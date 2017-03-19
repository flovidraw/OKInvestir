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
using System.Data.Entity.Validation;
using System.Diagnostics;

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
            bool isSuccess = true;              // if false, will not save modification
            bool isAnyFieldNotFilled = false;   // if true, will show a message
            bool isAnyFieldNotCorrect = false;  // if true, will show a message

            Product pdt = new Product();
            if (View.sub.pdtId != 0)
            {
                pdt.Id = View.sub.pdtId;
            }

            pdt.Name = View.sub.getTbName().Text;
            pdt.Description = View.sub.getTbDescription().Text;
            pdt.ProductStatus = 1;   // set 1 as default

            int sillInterestCount = View.sub.sillInterestCount;
            int timeInterestCount = View.sub.timeInterestCount;
            


            // extract all filled pairs of sill-interest
            for (int i = 1; i <= sillInterestCount; i++)
            {
                bool isTwoTbFilled = true;
                decimal tempSill = 0;
                decimal tempInterest = 0;

                // find all tb of sill, validate the text and copy it to tempSill
                TextBox tbSill = (TextBox)View.sub.getFlpSI().Controls.Find("sill" + i.ToString(), false).First();
                string sill = tbSill.Text;
                // if field is not filled, allow but show a message
                if (string.IsNullOrEmpty(sill))
                {
                    isTwoTbFilled = false;      // if false, will not save this pair of Sill-Interest
                    isAnyFieldNotFilled = true; // if true, will show a message
                }
                // if is not numeric, not allow, change text color to red and show a message
                else if(!decimal.TryParse(sill, out tempSill))
                {
                    isTwoTbFilled = false;
                    isAnyFieldNotCorrect = true;    // if true, will show a message
                    isSuccess = false;              // if false, will not save modification
                    tbSill.ForeColor = System.Drawing.Color.Red;
                }
                // if is numeric, change back to black color
                else
                {
                    tbSill.ForeColor = System.Drawing.Color.Black;
                }

                // find all tb of interest, validate the text and copy it to tempSill
                TextBox tbInterest = (TextBox)View.sub.getFlpSI().Controls.Find("interest" + i.ToString(), false).First();
                string interest = tbInterest.Text;
                if (string.IsNullOrEmpty(interest))
                {
                    isTwoTbFilled = false;
                    isAnyFieldNotFilled = true;
                }
                else if (!decimal.TryParse(interest, out tempInterest))
                {
                    isTwoTbFilled = false;
                    isAnyFieldNotCorrect = true;
                    isSuccess = false;
                    tbInterest.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    tbInterest.ForeColor = System.Drawing.Color.Black;
                }

                // if two tb are filled and the text inside is numeric, save them in the list
                if (isTwoTbFilled)
                {
                    SillInterest si = new SillInterest();
                    si.Sill = tempSill;
                    si.Interest = tempInterest;
                    pdt.SillInterests.Add(si);
                }
            }


            // find all filled pairs of time-interest textboxes 
            for (int i = 1; i <= timeInterestCount; i++)
            {
                bool isTwoTbFilled = true;
                int tempTime = 0;
                decimal tempInterest = 0;

                TextBox tbSill = (TextBox)View.sub.getFlpTI().Controls.Find("sill" + i.ToString(), false).First();
                string sill = tbSill.Text;
                if (string.IsNullOrEmpty(sill))
                {
                    isTwoTbFilled = false;
                    isAnyFieldNotFilled = true;
                }
                else if (!int.TryParse(sill, out tempTime))
                {
                    isTwoTbFilled = false;
                    isAnyFieldNotCorrect = true;
                    isSuccess = false;
                    tbSill.ForeColor = System.Drawing.Color.Red;
                } else
                {
                    tbSill.ForeColor = System.Drawing.Color.Black;
                }

                TextBox tbInterest = (TextBox)View.sub.getFlpTI().Controls.Find("interest" + i.ToString(), false).First();
                string interest = tbInterest.Text;
                if (string.IsNullOrEmpty(interest))
                {
                    isTwoTbFilled = false;
                    isAnyFieldNotFilled = true;
                }
                else if (!decimal.TryParse(interest, out tempInterest))
                {
                    isTwoTbFilled = false;
                    isAnyFieldNotCorrect = true;
                    isSuccess = false;
                    tbInterest.ForeColor = System.Drawing.Color.Red;
                } else
                {
                    tbInterest.ForeColor = System.Drawing.Color.Black;
                }

                // convert to SillInterest, and add to list
                if (isTwoTbFilled)
                {
                    TimeInterest ti = new TimeInterest();
                    ti.Time = tempTime;
                    ti.Interest = tempInterest;
                    pdt.TimeInterests.Add(ti);
                }
            }


            // sort list by sill/time
            pdt.SillInterests = pdt.SillInterests.OrderBy(si => si.Sill).ToList();
            pdt.TimeInterests = pdt.TimeInterests.OrderBy(ti => ti.Time).ToList();


            // show messages
            if (isAnyFieldNotCorrect)
            {
                VMMain.UIMainForm.genMsgBox("Input incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (isAnyFieldNotFilled)
            {
                VMMain.UIMainForm.genMsgBox("All not filled fields will be ignore", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

            // connect to db
            using (var context = new Model.Context())
            {
                Cursor.Current = Cursors.WaitCursor;        // waiting animation cursor
                context.Database.Initialize(force: false);   // connect to db

                if (View.sub.pdtId != 0) // if modified a product
                {
                    var pdts = context.Products.Where(p => p.Id == pdt.Id);
                    // there should be only one product in the list
                    Product pdtOld = pdts.First();
                    // modify product
                    pdtOld.Name = pdt.Name;
                    pdtOld.Description = pdt.Description;
                    // clear old SI and TI list, then copy new SI and TI
                    pdtOld.SillInterests.Clear();
                    pdtOld.SillInterests = new List<SillInterest>(pdt.SillInterests);
                    pdtOld.TimeInterests.Clear();
                    pdtOld.TimeInterests = new List<TimeInterest>(pdt.TimeInterests);
                    // set productID for SI and TI
                    foreach (SillInterest si in pdtOld.SillInterests)
                    {
                        si.ProductID = pdtOld.Id;
                    }
                    foreach (TimeInterest ti in pdtOld.TimeInterests)
                    {
                        ti.ProductID = pdtOld.Id;
                    }
                }
                else // if add a new product
                {
                    // add product
                    context.Products.Add(pdt);
                }
                try
                {
                    context.SaveChanges();
                    // modify product will set product's SI and TI rows's productID to null, 
                    // and insert new rows of SI and TI, so delete all rows with null productID
                    context.SillInterests.RemoveRange(context.SillInterests.Where(si => si.ProductID == null));
                    context.TimeInterests.RemoveRange(context.TimeInterests.Where(ti => ti.ProductID == null));
                    context.SaveChanges();
                }
                catch (DbEntityValidationException dbEx)    // catch DbEntityValidationException and print it out
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1}",
                                                    validationError.PropertyName,
                                                    validationError.ErrorMessage);
                        }
                    }
                    isSuccess = false;
                    
                }
                catch (Exception e)     // get other exception
                {
                    VMMain.UIMainForm.genMsgBox(e.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Cursor.Current = Cursors.Arrow;             // get back to normal cursor
            }

            return isSuccess;
        }

    }
}
