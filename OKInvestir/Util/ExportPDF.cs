using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using OKInvestir.Model;
using OKInvestir.UI;

namespace OKInvestir.Util
{
    class ExportPDF
    {
        // Function to exoprt the given client's simulation list in to format pdf
        public static void writePdf(Client clt, UIMainForm form)
        {
            // Print PDF table
            string pdfname = string.Empty;
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "Okinvestir Simulation liste";
            dlg.DefaultExt = ".pdf";
            dlg.Filter = "Text documents (.pdf)|*.pdf";
            
            var logo = System.Drawing.Image.FromHbitmap(Properties.Resources.logo.GetHbitmap());
            Image imageHeader = Image.GetInstance(logo, System.Drawing.Imaging.ImageFormat.Png);

            if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pdfname = dlg.FileName;
                    List<Simulation> simus = clt.getSimulationList();
                try
                {
                FileStream fs = new FileStream(pdfname, FileMode.Create);   // Create file stream
                 
                Document document = new Document(PageSize.A4.Rotate());     // Create file PageSize.A7.Rotate() 
                    PdfWriter pdfWriter = PdfWriter.GetInstance(document, fs);  // Create objet
                    
                    MyPageEventHandler e = new MyPageEventHandler()
                    {
                        ImageHeader = imageHeader

                    };
                    pdfWriter.PageEvent = e;

                    document.Open();   // Open file
                    
                    document.Add(PDFTable1(clt));               //add table

                    document.SetPageSize(PageSize.A4);       // A4 print in lanscape orientation
                    document.NewPage();                      // Open a new page
                    document.Close();                        // Close file
                    fs.Close();
                }
                catch
                {
                    form.genMsgBox("Fail to export pdf file, maybe de file is already openned", "error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                           
            }    
        }

        public static PdfPTable PDFTable1(Client client)
        {
            List<Simulation> listSim = new List<Simulation>();

            var table1 = new PdfPTable(9);     // Create table for 9 columns
            table1.DefaultCell.Border = Rectangle.NO_BORDER;

            var Calibri1 = FontFactory.GetFont("TimesNewRoman", 14, Font.BOLD);
            PdfPCell cell = new PdfPCell(new Phrase("Simulation list of " + client.FullName, Calibri1));
            cell.Colspan = 9;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cell.Border = Rectangle.NO_BORDER;
            table1.AddCell(cell);
            table1.DefaultCell.BackgroundColor = BaseColor.LIGHT_GRAY;
            var Calibri9 = FontFactory.GetFont("TimesNewRoman", 12, Font.BOLD);
            int[] a = { 1, 3, 3, 3, 3, 3, 3, 3, 3 };
            table1.NormalizeHeadersFooters();// Set columns' width
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


            listSim = client.getSimulationList();

            if (listSim.Count != 0)
            {
                
                int i = 0;
                var FontColour = new BaseColor(35, 31, 32);
                var Calibri8 = FontFactory.GetFont("TimesNewRoman", 11, FontColour);
                foreach (Simulation Sim in listSim)
                {
                    if (i % 2 == 0)
                    {
                        table1.DefaultCell.BackgroundColor = BaseColor.WHITE;
                    }
                    else
                    {
                        table1.DefaultCell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    }
                    table1.AddCell(new Paragraph((i + 1).ToString(), Calibri8)); // Add cell
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
