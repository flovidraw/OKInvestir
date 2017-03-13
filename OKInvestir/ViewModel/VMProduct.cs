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

namespace OKInvestir.ViewModel
{
    public class VMProduct
    {
        private UIProduct View;
        public VMMain VMMain { get; set; }

        public List<Product> Products { get; set; }
        public List<Product> ProductsForBinding { get; set; }
        public BindingList<Product> blProducts { get; set; }

        public VMProduct(VMMain VMMain, UIProduct View)
        {
            this.View = View;
            this.View.ViewModel = this;
            this.VMMain = VMMain;


            // load products in lists
            getDataFromDb();

            // load selected client detail to listView and textboxes
            loadProductDetail((Product)View.getLboxProduct().SelectedValue);

        }



        /**
         * Choose product and go to simulation
         */
        public void chooseProduct(Product pdt)
        {
            VMMain.Product = pdt;
            if (VMMain.Client != null)
            {
                VMMain.UIMainForm.getBtSimulation().PerformClick();
            }
            else
            {
                VMMain.UIMainForm.genMsgBox("Please choose a client first.", "No client chose", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /**
         * Search product on text change
         */
        public void searchProduct(string text)
        {
            blProducts.Clear();
            foreach (Product pdt in Products)
            {
                if (pdt.Name.Contains(text))
                    blProducts.Add(pdt);
            }

            // select automatically the first item after searching
            if (blProducts.Count > 0)
            {
                //View.getLBoxClient().SelectedIndex = 0;
                View.getLboxProduct().SetSelected(0, true);
            }
        }


        /**
         * Connect database and get Client list
         */
        public void getDataFromDb()
        {
            Cursor.Current = Cursors.WaitCursor;        // waiting animation cursor
            using (var context = new Model.Context())
            {
                context.Database.Initialize(force: false);  // connect to db, it takes time
                Products = context.Products
                    .Include(p => p.TimeInterests)            // get related entities
                    .Include(p => p.SillInterests)            // get related entities
                    .ToList();
            }
            Cursor.Current = Cursors.Arrow;             // get back to normal cursor

            ProductsForBinding = new List<Product>(Products);   // clone for binding list

            // bind list to listBoxes
            blProducts = new BindingList<Product>(ProductsForBinding);
            View.getLboxProduct().DataSource = blProducts;
            View.getLboxProduct().DisplayMember = "Name";
        }


        /**
         * Load product's infomation in listviews and labels
         */
        public void loadProductDetail(Product pdt)
        {
            var lviewSillInterest = View.getLviewSillInterest();
            var lviewTimeInterest = View.getLviewTimeInterest();

            // clear the list and readd headers
            lviewSillInterest.Clear();
            lviewTimeInterest.Clear();

            lviewSillInterest.Columns.Add("Sill");
            lviewSillInterest.Columns.Add("Interest");
            lviewTimeInterest.Columns.Add("Months");
            lviewTimeInterest.Columns.Add("Interest");

            // change labels and textbox of product info
            View.getLbName().Text = pdt.Name;
            View.getTbDescription().Text = pdt.Description;
            View.getLbId().Text = "ID: " + pdt.Id.ToString();
            // TODO: change int to text of status
            View.getLbStatus().Text = "Status: " + pdt.ProductStatus.ToString();

            // add data in listviews
            foreach (SillInterest si in pdt.SillInterests)
            {
                lviewSillInterest.Items.Add(new ListViewItem(new string[] { si.Sill.ToString(), si.Interest.ToString() }));
            }
            foreach (TimeInterest ti in pdt.TimeInterests)
            {
                lviewTimeInterest.Items.Add(new ListViewItem(new string[] { ti.Time.ToString(), ti.Interest.ToString() }));
            }

            // resize columns width
            lviewSillInterest.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            lviewTimeInterest.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }



        /**
         * Save product in database. Call by UISunProduct
         */
        public bool saveProduct()
        {
            Product pdt = new Product();
            if (View.sub.pdtId != 0)
            {
                pdt.Id = View.sub.pdtId;
            }
            
            pdt.Name = View.sub.getTbName().Text;
            pdt.Description = View.sub.getTbDescription().Text;

            int sillInterestCount = View.sub.sillInterestCount;
            int timeInterestCount = View.sub.timeInterestCount;

            Dictionary<decimal, decimal> siDict = new Dictionary<decimal, decimal>();
            Dictionary<int, decimal> tiDict = new Dictionary<int, decimal>();

            decimal tempSill = 0;

            int tempTime = 0;
            decimal tempInterest = 0;
            bool isTwoTbFilled = true;

            // extract all filled sill-interest
            for (int i = 1; i <= sillInterestCount; i++)
            {
                isTwoTbFilled = true;

                string sill = View.sub.getFlpSI().Controls.Find
                    ("sill" + sillInterestCount.ToString(), false)[0].Text;
                if (!string.IsNullOrEmpty(sill))
                {
                    tempSill = decimal.Parse(sill);
                }
                else
                {
                    isTwoTbFilled = false;
                }

                string interest = View.sub.getFlpSI().Controls.Find
                    ("interest" + sillInterestCount.ToString(), false)[0].Text;
                if (!string.IsNullOrEmpty(interest))
                {
                    tempInterest = decimal.Parse(interest);
                }
                else
                {
                    isTwoTbFilled = false;
                }

                if (isTwoTbFilled)
                {
                    SillInterest si = new SillInterest();
                    si.Sill = tempSill;
                    si.Interest = tempInterest;
                    si.Product = pdt;
                    pdt.SillInterests.Add(si);
                }
            }

            // find all filled pair of time-interest textboxes             for (int i = 1; i <= timeInterestCount; i++)
            {
                isTwoTbFilled = true;

                string sill = View.sub.getFlpTI().Controls.Find
                    ("sill" + timeInterestCount.ToString(), false)[0].Text;
                if (!string.IsNullOrEmpty(sill))
                {
                    tempTime = int.Parse(sill);
                }
                else
                {
                    isTwoTbFilled = false;
                }

                string interest = View.sub.getFlpTI().Controls.Find
                    ("interest" + timeInterestCount.ToString(), false)[0].Text;
                if (!string.IsNullOrEmpty(interest))
                {
                    tempInterest = decimal.Parse(interest);
                }
                else
                {
                    isTwoTbFilled = false;
                }

                // convert to SillInterest, and add to list
                if (isTwoTbFilled)
                {
                    TimeInterest ti = new TimeInterest();
                    ti.Time = tempTime;
                    ti.Interest = tempInterest;
                    ti.Product = pdt;
                    pdt.TimeInterests.Add(ti);
                }
            }

            // connect to db
            bool isSuccess = true;
            using (var context = new Model.Context())
            {
                Cursor.Current = Cursors.WaitCursor;        // waiting animation cursor
                context.Database.Initialize(force: false);   // connect to db, it takes time

                if (View.sub.pdtId != 0) // if modified a product
                {
                    var pdtOld = context.Products.Where(p => p.Id == pdt.Id);
                    // there should be only one product in the list
                    // modify product
                    pdtOld.First().Name = pdt.Name;
                    pdtOld.First().Description = pdt.Description;
                    pdtOld.First().SillInterests = new List<SillInterest>(pdt.SillInterests);
                    pdtOld.First().TimeInterests = new List<TimeInterest>(pdt.TimeInterests);
                }
                else // if add a new product
                {
                    // add product
                    context.Products.Add(pdt);
                }

                // save change
                try
                {
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    VMMain.HandleException(e, VMMain.UIMainForm);
                    isSuccess = false;
                }

                Cursor.Current = Cursors.Arrow;             // get back to normal cursor
            }

            return isSuccess;
        }

    }
}
