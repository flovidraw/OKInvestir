using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OKInvestir.UI;
using OKInvestir.Model;
using System.ComponentModel;
using System.Data.Entity;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;

namespace OKInvestir.ViewModel
{
    public class VMSimulation
    {
        private UISimulation View;
        public VMMain VMMain { get; set; }
        public List<Simulation> Simulations { get; set; }
        public List<Simulation> SimulationForBinding { get; set; }
        public BindingList<Simulation> blSimulation { get; set; }
        public List<Simulation> SimulationList { get; set; }


        public VMSimulation(VMMain VMMain, UISimulation View)
        {
            this.View = View;
            this.View.ViewModel = this;
            this.VMMain = VMMain;



        }

        public Model.TimeInterest FindTimeInterestSection()
        {
            DateTime StartDate = View.getValueStartDate();
            DateTime EndDate = View.getValueEndDate();
            int periode = (int)(EndDate - StartDate).TotalDays / 30;
            Model.TimeInterest time = new Model.TimeInterest();
            time.Time = 0;
            foreach (Model.TimeInterest timeI in VMMain.Product.TimeInterests)
            {
                if ((timeI.Time <= periode) && (timeI.Time >= time.Time))
                {
                    time.Time = timeI.Time;
                    time.Interest = timeI.Interest;
                    time.Id = timeI.Id;
                    time.ProductID = timeI.ProductID;
                    //time.Product = timeI.Product;
                }
            }
            return time;
        }

        public Model.SillInterest FindSillInterestSection(decimal Amount)
        {
            decimal amount = Amount;
            Model.SillInterest sill = new Model.SillInterest();
            sill.Sill = 0;
            foreach (Model.SillInterest sillI in VMMain.Product.SillInterests)
            {
                if ((sillI.Sill <= amount) && (sillI.Sill >= sill.Sill))
                {
                    sill.Sill = sillI.Sill;
                    sill.Id = sillI.Id;
                    sill.Interest = sillI.Interest;
                    //sill.Product = sillI.Product;
                    sill.ProductID = sillI.ProductID;
                }
            }
            return sill;
        }

        public int MinimumTimeSimulation()
        {
            Model.TimeInterest time = new Model.TimeInterest();
            time.Time = 0;
            int i = 0;
            foreach (Model.TimeInterest timeI in VMMain.Product.TimeInterests)
            {
                if (i == 0)
                {
                    time.Time = timeI.Time;
                }
                else
                {
                    if (timeI.Time < time.Time)
                    {
                        time.Time = timeI.Time;
                    }
                }
                i++;
            }
            return time.Time;
        }

        public void printBalance()
        {
            if (VMMain.Client.AccountList.Count > 0)
            {
                this.View.getLbValueBalance().Text = this.VMMain.Client.AccountList[0].Balance.ToString();
            }
            else
            {
                this.View.getLbValueBalance().Text = "No account";
            }
        }






        public Model.Simulation resultSimulation()
        {
            Model.Simulation simulation = new Model.Simulation();

            simulation.ClientId = VMMain.Client.Id;
            simulation.ProductId = VMMain.Product.Id;
            simulation.Price = View.getTbAmount();
            simulation.StartDate = View.getValueStartDate();
            simulation.EndDate = View.getValueEndDate();
            int periodeSimulation = (int)(simulation.EndDate - simulation.StartDate).TotalDays / 30;
            decimal InterestRateTime = FindTimeInterestSection().Interest;
            decimal InterestRateSill = FindSillInterestSection(simulation.Price).Interest;
            simulation.InterestRate = ((InterestRateSill + 100) * (InterestRateTime + 100)) / 100 - 100;
            simulation.SettlementPrice = simulation.Price * (100 + simulation.InterestRate) / 100;
            if (InterestRateTime == 0)
            {
                VMMain.UIMainForm.genMsgBox("For this product selected, the minimum holding periode have to be more than " + MinimumTimeSimulation() + " months.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                simulation.Price = 0;
            }

            if (simulation.Price != 0)
            {
                View.getLbValueAmount().Text = simulation.Price.ToString();
                View.getValuePeriode().Text = periodeSimulation.ToString() + " Months";

                View.getLbValueProductSelected().Text = VMMain.Product.Name;
                View.getLbValueInterestRate().Text = (simulation.InterestRate).ToString() + " %";
                View.GetLbValueSettlementPrice().Text = simulation.SettlementPrice.ToString();
            }
            return simulation;
        }

        public void saveSimulation(Model.Simulation simulation)
        {
            using (var context = new Model.Context())
            {
                Cursor.Current = Cursors.WaitCursor;        // waiting animation cursor
                context.Database.Initialize(force: false);  // connect to db
                context.Simulations.Add(simulation);
                try
                {
                    context.SaveChanges();  // save change
                    VMMain.UIMainForm.genMsgBox("Simulation saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception e)
                {
                    VMMain.HandleException(e, this.VMMain.UIMainForm);
                    VMMain.UIMainForm.genMsgBox("Fail to save the simulation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Cursor.Current = Cursors.Arrow;             // get back to normal cursor
                }
            }
        }

        public void getSimulation()
        {

            if (!VMMain.Client.Equals(null))
            {

                using (var context = new Model.Context())
                {
                    int ClientId = VMMain.Client.Id;
                    bool isSimulationFound = false;
                    Cursor.Current = Cursors.WaitCursor;        // waiting animation cursor
                                                                //context.Database.Initialize(force: true);   // connect to db, it takes time
                    context.Database.Initialize(force: true);   // connect to db, it takes time
                    Simulations = context.Simulations.Where(u => u.ClientId == ClientId).ToList();
                    Cursor.Current = Cursors.Arrow;             // get back to normal cursor

                    SimulationForBinding = new List<Simulation>(Simulations);
                    blSimulation = new BindingList<Simulation>(SimulationForBinding);
                    this.View.getLboxSim().DataSource = blSimulation;
                    this.View.getLboxSim().DisplayMember = "LbInformation";


                }
            }
        }

        public void chooseSimulation(Simulation sim)
        {
            this.View.getValuePeriode().Text = ((int)(sim.EndDate - sim.StartDate).TotalDays / 30).ToString();
            this.View.getLbValueProductSelected().Text = sim.Product.Name;
            this.View.getLbValueAmount().Text = sim.Price.ToString();
            this.View.getLbValueInterestRate().Text = sim.InterestRate.ToString();
            this.View.GetLbValueSettlementPrice().Text = sim.SettlementPrice.ToString();

        }

        public void delectSimulaion(Simulation Sim)
        {
            using (var context = new Model.Context())
            {
                int SimId = Sim.Id;


                Cursor.Current = Cursors.WaitCursor;        // waiting animation cursor
                                                            //context.Database.Initialize(force: true);   // connect to db, it takes time
                context.Database.Initialize(force: true);   // connect to db, it takes time
                Model.Simulation SimToRemove = context.Simulations.Where(u => u.Id == SimId).First();
                if (SimToRemove != null)
                {
                    context.Simulations.Attach(SimToRemove);
                    context.Simulations.Remove(SimToRemove);
                    context.SaveChanges();
                    VMMain.UIMainForm.genMsgBox("Simulation deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                Cursor.Current = Cursors.Arrow;             // get back to normal cursor

                SimulationForBinding = new List<Simulation>(Simulations);
                blSimulation = new BindingList<Simulation>(SimulationForBinding);
                this.View.getLboxSim().DataSource = blSimulation;
                this.View.getLboxSim().DisplayMember = "LbInformation";


            }
        }

        public void ExecuteSimulation(Model.Simulation Sim)
        {
            if (this.VMMain.Client.AccountList[0].Balance >= Sim.Price)
            {

                Model.BoughtProduct boughtP = new Model.BoughtProduct();
                //Enter infomations of simulation
                boughtP.BoughtStatus = 1;
                boughtP.Price = Sim.Price;

                //boughtP.Product = Sim.Product;
                boughtP.ProductId = Sim.ProductId;

                boughtP.SettlementPrice = Sim.SettlementPrice;

                boughtP.StartDate = Sim.StartDate;
                boughtP.EndDate = Sim.EndDate;
                boughtP.BuyingDate = DateTime.Today.Date;

                //boughtP.Client = this.VMMain.Client;
                boughtP.ClientId = this.VMMain.Client.Id;

                boughtP.FinalInterest = Sim.SettlementPrice - Sim.Price;

                //Save bought product
                using (var context = new Model.Context())
                {
                    Cursor.Current = Cursors.WaitCursor;        // waiting animation cursor
                    context.Database.Initialize(force: false);  // connect to db
                    List<Client> clients = context.Clients
                    .Include(c => c.AccountList)            // get related entities
                    .Include(bpl => bpl.BoughtProductList)
                    .Include("BoughtProductList.Product")
                    .Include("BoughtProductList.Product.TimeInterests")
                    .Include("BoughtProductList.Product.SillInterests")
                    .ToList();
                    Client clientSim = clients.Where(c => c.Id == VMMain.Client.Id).SingleOrDefault();
                    context.BoughtProducts.Add(boughtP);
                    clientSim.BoughtProductList.Add(boughtP);
                    clientSim.AccountList[0].Balance = clientSim.AccountList[0].Balance - Sim.Price;
                    //Console.Write(context.Clients.Find(VMMain.Client.Id).FirstName);

                    VMMain.Client.BoughtProductList.Add(boughtP);

                    try
                    {
                        context.SaveChanges();  // save change
                        VMMain.UIMainForm.genMsgBox("Simulation executed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.VMMain.Client.AccountList[0].Balance = this.VMMain.Client.AccountList[0].Balance - Sim.Price;

                    }
                    catch (Exception e)
                    {
                        VMMain.HandleException(e, this.VMMain.UIMainForm);
                        VMMain.UIMainForm.genMsgBox("Fail to execute the simulation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Cursor.Current = Cursors.Arrow;             // get back to normal cursor
                    }
                    //context.SaveChanges();
                }

            }
            else
            {
                VMMain.UIMainForm.genMsgBox("Balance not enough!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //======================================================= PDF ==============================================================================





        public void CreatPDFTable()
        {

            //打印PDF表格
            string pdfname = string.Empty;
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "Okinvestir Simulation liste";
            dlg.DefaultExt = ".pdf";
            dlg.Filter = "Text documents (.pdf)|*.pdf";
            Image imageHeader = Image.GetInstance("business_banking.jpg");


            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pdfname = dlg.FileName;
                FileStream fs = new FileStream(pdfname, FileMode.Create);   //创建文件流
                Document document = new Document(PageSize.A4.Rotate());     //创建文件 PageSize.A7.Rotate()表示A7纸横向输出  
                PdfWriter pdfWriter = PdfWriter.GetInstance(document, fs);  //实例化

                MyPageEventHandler e = new MyPageEventHandler()
                {
                    ImageHeader = imageHeader

                };
                pdfWriter.PageEvent = e;

                document.Open();   //打开文件


                document.Add(new Paragraph("1"));
                //document.Add(header1);
                document.Add(PDFTable1());               //添加表格

                document.SetPageSize(PageSize.A4);       //A4纸纵向输出
                document.NewPage();                      //新起一页
                document.Close();                        //关闭文件
                fs.Close();
            }
        }



        public PdfPTable PDFTable1()
        {
            List<Simulation> listSim = new List<Simulation>();

            var table1 = new PdfPTable(9);     //创建表格实例4列
            table1.DefaultCell.Border = Rectangle.NO_BORDER;

            var Calibri1 = FontFactory.GetFont("TimesNewRoman", 14, Font.BOLD);
            PdfPCell cell = new PdfPCell(new Phrase("Simulation list of " + VMMain.Client.FullName, Calibri1));
            cell.Colspan = 9;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cell.Border = Rectangle.NO_BORDER;
            table1.AddCell(cell);
            table1.DefaultCell.BackgroundColor = BaseColor.LIGHT_GRAY;
            var Calibri9 = FontFactory.GetFont("TimesNewRoman", 12, Font.BOLD);
            int[] a = { 1, 3, 3, 3, 3, 3, 3, 3, 3 };
            table1.NormalizeHeadersFooters();//设置列宽比例
            table1.SetWidths(a);
            table1.AddCell(" ");
            table1.AddCell(new Paragraph("Simulation Id", Calibri9));
            table1.AddCell(new Paragraph("Product name", Calibri9));
            table1.AddCell(new Paragraph("Price", Calibri9));
            table1.AddCell(new Paragraph("Start date", Calibri9));
            table1.AddCell(new Paragraph("End date", Calibri9));
            table1.AddCell(new Paragraph("Interest rate", Calibri9));
            table1.AddCell(new Paragraph("Settlement price", Calibri9));
            table1.AddCell(new Paragraph("Tatal months", Calibri9));


            SimulationList = VMMain.Client.getSimulationList();

            if (SimulationList.Count != 0)
            {
                /* for (int i = 0; i < SimulationList.Count; i++)
                 {
                     table1.AddCell((i + 1).ToString());     //添加单元格
                     table1.AddCell(SimulationList.Find(Index);
                 }
                 return table1;
                 */
                int i = 0;
                var FontColour = new BaseColor(35, 31, 32);
                var Calibri8 = FontFactory.GetFont("TimesNewRoman", 11, FontColour);
                foreach (Simulation Sim in SimulationList)
                {
                    if (i % 2 == 0)
                    {
                        table1.DefaultCell.BackgroundColor = BaseColor.WHITE;
                    }
                    else
                    {
                        table1.DefaultCell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    }
                    table1.AddCell(new Paragraph((i + 1).ToString(), Calibri8));
                    table1.AddCell(new Paragraph(Sim.Id.ToString(), Calibri8));
                    table1.AddCell(new Paragraph(Sim.Product.Name.ToString(), Calibri8));
                    table1.AddCell(new Paragraph(Sim.Price.ToString(), Calibri8));
                    table1.AddCell(new Paragraph(Sim.StartDate.Day.ToString() + "-" + Sim.StartDate.Month + "-" + Sim.StartDate.Year.ToString(), Calibri8));
                    table1.AddCell(new Paragraph(Sim.EndDate.Day.ToString() + "-" + Sim.EndDate.Month.ToString() + "-" + Sim.EndDate.Year.ToString(), Calibri8));
                    table1.AddCell(new Paragraph(Sim.InterestRate.ToString(), Calibri8));
                    table1.AddCell(new Paragraph(Sim.SettlementPrice.ToString(), Calibri8));
                    table1.AddCell(new Paragraph(((int)((Sim.EndDate - Sim.StartDate).TotalDays) / 30).ToString(), Calibri8));
                    i++;
                }


            }
            return table1;
        }

        private class MyPageEventHandler : PdfPageEventHelper
        {
            /*
             * We use a __single__ Image instance that's assigned __once__;
             * the image bytes added **ONCE** to the PDF file. If you create 
             * separate Image instances in OnEndPage()/OnEndPage(), for example,
             * you'll end up with a much bigger file size.
             */
            public Image ImageHeader { get; set; }
            public Image ImageFooter { get; set; }

            public override void OnEndPage(PdfWriter writer, Document document)
            {
                // cell height 
                float cellHeight = document.TopMargin;
                // PDF document size      
                Rectangle page = document.PageSize;

                // create two column table
                PdfPTable head = new PdfPTable(2);
                head.TotalWidth = page.Width;


                // add image; PdfPCell() overload sizes image to fit cell
                PdfPCell c = new PdfPCell(ImageHeader, true);
                c.HorizontalAlignment = Element.ALIGN_CENTER;
                c.FixedHeight = cellHeight;
                c.Border = PdfPCell.NO_BORDER;
                head.AddCell(c);

                //add the header text
                PdfPCell e = new PdfPCell(new Phrase("OkInvestir - Bank application", new Font(Font.FontFamily.TIMES_ROMAN, 20, Font.BOLD)));
                e.HorizontalAlignment = Element.ALIGN_LEFT;
                e.FixedHeight = cellHeight;
                e.Border = PdfPCell.NO_BORDER;
                head.AddCell(e);






                // since the table header is implemented using a PdfPTable, we call
                // WriteSelectedRows(), which requires absolute positions!
                head.WriteSelectedRows(
                  0, -1,  // first/last row; -1 flags all write all rows
                  0,      // left offset
                          // ** bottom** yPos of the table
                  page.Height - cellHeight + head.TotalHeight,
                  writer.DirectContent
                );



                PdfPTable foot = new PdfPTable(2);
                foot.TotalWidth = page.Width;
                PdfPCell d = new PdfPCell(new Phrase("PDF exported at " +
               DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss") + " GMT",
               new Font(Font.FontFamily.COURIER, 8)
             ));
                d.Border = PdfPCell.NO_BORDER;
                d.VerticalAlignment = Element.ALIGN_CENTER;
                d.FixedHeight = cellHeight;
                foot.AddCell(d);

                PdfPCell a = new PdfPCell(new Phrase("Page " + writer.CurrentPageNumber));
                a.Border = PdfPCell.NO_BORDER;
                a.HorizontalAlignment = Element.ALIGN_LEFT;
                foot.AddCell(a);

                foot.WriteSelectedRows(
               0, -1,
               300,

               30,
               writer.DirectContent
               );


            }





        }




    }
}
