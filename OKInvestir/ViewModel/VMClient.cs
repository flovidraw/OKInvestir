using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKInvestir.Model;
using System.Windows.Forms;
using OKInvestir.UI;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;

namespace OKInvestir.ViewModel
{
    public class VMClient : IViewModel
    {
        private UIClient View { get; set; }
        public VMMain VMMain { get; set; }
        
        public string tbSearchClientText { get; set; }
        public string tbSearchProductText { get; set; }
        public List<Client> Clients { get; set; }
        public List<Client> ClientsForBinding { get; set; }
        public List<BoughtProduct> ProductsForBinding { get; set; }
        public BindingList<Client> blClients { get; set; }
        public BindingList<BoughtProduct> blProducts { get; set; }


        public VMClient(VMMain VMMain, UIClient View)
        {
            this.View = View;
            this.View.ViewModel = this;
            this.VMMain = VMMain;

            // load clients and products in lists
            getDataFromDb();

            // load selected client detail to listView and textboxes
            loadClientDetail((Client)View.getLBoxClient().SelectedValue);
        }



        /**
         * Functions for 3 buttons, add, modify and choose client
         */
        public bool addClient(string firstName, string lastName, string idCardNumber)
        {
            bool isSuccess = true;

            if (firstName == "" || lastName == "" || idCardNumber == "")
            {
                VMMain.UIMainForm.genMsgBox("Please enter all 3 textboxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isSuccess = false;
            }
            else if (firstName.Length > 20 || lastName.Length > 20)
            {
                VMMain.UIMainForm.genMsgBox("First name and last name should less than 20 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isSuccess = false;
            }
            else if (idCardNumber.Length > 20)
            {
                VMMain.UIMainForm.genMsgBox("ID card number should less than 20 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isSuccess = false;
            }
            else
            {
                // creaete a client by input
                Client clt = new Client(firstName, lastName, idCardNumber);

                // create a default account
                Account acc = new Account();
                acc.Client = clt;
                acc.Number = DateTime.Now.ToString("yyyyMMddHHmmssf"); // use time of now , a unique number
                acc.status = 1;
                acc.Balance = 0M;
                clt.AccountList = new List<Account>();
                clt.AccountList.Add(acc);


                using (var context = new Model.Context())
                {
                    Cursor.Current = Cursors.WaitCursor;        // waiting animation cursor
                    context.Database.Initialize(force: false);  // connect to db
                    context.Clients.Add(clt);
                    try
                    {
                        context.SaveChanges();  // save change
                        getDataFromDb();        // refresh the list
                    }
                    catch (Exception e)
                    {
                        VMMain.HandleException(e, this.VMMain.UIMainForm);
                        isSuccess = false;
                    }
                    Cursor.Current = Cursors.Arrow;             // get back to normal cursor
                }
            }
            return isSuccess;
        }

        public bool modifyClient(Client clt, string firstName, string lastName, string idCardNumber)
        {
            bool isSuccess = true;

            if (firstName == "" || lastName == "" || idCardNumber == "")
            {
                VMMain.UIMainForm.genMsgBox("Please enter all 3 textboxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isSuccess = false;
            }
            else if (firstName.Length > 20 || lastName.Length > 20)
            {
                VMMain.UIMainForm.genMsgBox("First name and last name should less than 20 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isSuccess = false;
            }
            else if (idCardNumber.Length > 20)
            {
                VMMain.UIMainForm.genMsgBox("ID card number should less than 20 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isSuccess = false;
            }
            else
            {
                using (var context = new Model.Context())
                {
                    Cursor.Current = Cursors.WaitCursor;        // waiting animation cursor
                    context.Database.Initialize(force: false);  // connect to db
                    Client oldClt = context.Clients.Find(clt.Id);
                    oldClt.FirstName = firstName;
                    oldClt.LastName = lastName;
                    oldClt.IdCardNumber = idCardNumber;
                    try
                    {
                        context.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        VMMain.HandleException(e, this.VMMain.UIMainForm);
                        isSuccess = false;
                    }
                    Cursor.Current = Cursors.Arrow;             // get back to normal cursor
                }
            }

            return isSuccess;
        }

        public void chooseClient()
        {
            if (View.getLBoxClient().SelectedValue != null)
            {
                Client selectedClt = (Client)View.getLBoxClient().SelectedValue;
                VMMain.Client = selectedClt;
                VMMain.UIMainForm.getLbClientName().Text = selectedClt.FullName;
            }
            else
            {
                VMMain.UIMainForm.genMsgBox("Please choose a client.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







        /**
         * Search client on text change
         */
        public void searchClient(string text)
        {
            blClients.Clear();
            foreach (Client clt in Clients)
            {
                if (clt.FullName.Contains(text))
                    blClients.Add(clt);
            }
            
            // select automatically the first item after searching
            if (blClients.Count > 0)
                //View.getLBoxClient().SelectedIndex = 0;
                View.getLBoxClient().SetSelected(0, true);
            else
            {
                blProducts.Clear();
                View.getListViewProductDetail().Clear();
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
                Clients = context.Clients
                    .Include(c => c.AccountList)            // get related entities
                    .Include(bpl => bpl.BoughtProductList)
                    .Include("BoughtProductList.Product")
                    .Include("BoughtProductList.Product.TimeInterests")
                    .Include("BoughtProductList.Product.SillInterests")
                    .ToList();
            }
            Cursor.Current = Cursors.Arrow;             // get back to normal cursor

            ClientsForBinding = new List<Client>(Clients);   // clone for binding list
            ProductsForBinding = new List<BoughtProduct>();

            // bind list to listBoxes
            blClients = new BindingList<Client>(ClientsForBinding);
            blProducts = new BindingList<BoughtProduct>(ProductsForBinding);

            View.getLBoxClient().DataSource = blClients;
            View.getLBoxClient().DisplayMember = "FullName";
            View.getLBoxProduct().DataSource = blProducts;
            View.getLBoxProduct().DisplayMember = "Name";
        }

        public void loadClientDetail(Client clt)
        {
            // load client info
            View.getTbIDClient().Text = clt.Id.ToString();
            View.getTbFirstName().Text = clt.FirstName;
            View.getTbLastName().Text = clt.LastName;
            View.getTbIdCardNumber().Text = clt.IdCardNumber;
            if(clt.AccountList.Count > 0)
            {
                View.getTbBalance().Text = clt.AccountList[0].Balance.ToString();
            } else
            {
                View.getTbBalance().Text = "No Account";
            }
            

            // load bought product
            if(clt.BoughtProductList != null)
            {
                ListBox lb = View.getLBoxProduct();
                ProductsForBinding.Clear();
                foreach (BoughtProduct bp in clt.BoughtProductList)
                {
                    blProducts.Add(bp);
                }

                // load first bought product detail
                loadProductDetail(blProducts[0]);
            } else
            {
                blProducts.Clear();
            }



        }

        public void loadProductDetail(BoughtProduct pdt)
        {
            var listView = View.getListViewProductDetail();
            listView.View = System.Windows.Forms.View.Details;  // set view to details mode sothat it show added item

            // clear the list and readd headers
            listView.Clear();
            listView.Columns.Add("Proprety");
            listView.Columns.Add("Value");

            // add data in listView
            listView.Items.Add(new ListViewItem(new string[] { "Name", pdt.Product.Name }));
            listView.Items.Add(new ListViewItem(new string[] { "Description", pdt.Product.Description }));
            listView.Items.Add(new ListViewItem(new string[] { "Final interest", pdt.FinalInterest.ToString() }));
            listView.Items.Add(new ListViewItem(new string[] { "Start date", pdt.StartDate.ToString("dd/MM/yyyy") }));
            listView.Items.Add(new ListViewItem(new string[] { "End date", pdt.EndDate.ToString("dd/MM/yyyy") }));
            listView.Items.Add(new ListViewItem(new string[] { "Buying date", pdt.BuyingDate.ToString("dd/MM/yyyy") }));
            listView.Items.Add(new ListViewItem(new string[] { "Status", pdt.Product.ProductStatus.ToString() }));

            List<SillInterest> siList = pdt.Product.SillInterests;
            listView.Items.Add(new ListViewItem(new string[] { "", "" }));
            listView.Items.Add(new ListViewItem(new string[] { "Sill(Euro)", "Interest" }));
            foreach (SillInterest si in siList)
            {
                listView.Items.Add(new ListViewItem(new string[] { si.Sill.ToString(), si.Interest.ToString() }));
            }

            List<TimeInterest> tiList = pdt.Product.TimeInterests;
            listView.Items.Add(new ListViewItem(new string[] { "", "" }));
            listView.Items.Add(new ListViewItem(new string[] { "Time(Month)", "Interest" }));
            foreach (TimeInterest ti in tiList)
            {
                listView.Items.Add(new ListViewItem(new string[] { ti.Time.ToString(), ti.Interest.ToString() }));
            }

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); // resize columns width
        }


        /**
         * Logic fo modify button onclick
         */
        public void modifyOnClick()
        {
            if (View.isEditing)
            {
                if (modifyClient((Model.Client)View.getLBoxClient().SelectedValue,
                View.getTbFirstName().Text, View.getTbLastName().Text, View.getTbIdCardNumber().Text))
                {
                    View.isEditing = false;

                    // edit finish, enable all buttons
                    VMMain.UIMainForm.enableButtons();
                    View.getBtAddClient().Enabled = true;
                    View.getBtChoose().Enabled = true;
                    View.getBtModify().Text = "Modify";

                    // enable lists
                    View.getLBoxClient().Enabled = true;
                    View.getLBoxProduct().Enabled = true;
                    View.getListViewProductDetail().Enabled = true;

                    // change back to origin color
                    View.getTbFirstName().BackColor = System.Drawing.Color.FromArgb(196, 232, 250);
                    View.getTbLastName().BackColor = System.Drawing.Color.FromArgb(196, 232, 250);
                    View.getTbIdCardNumber().BackColor = System.Drawing.Color.FromArgb(166, 202, 240);

                    // set read only
                    View.getTbFirstName().ReadOnly = true;
                    View.getTbLastName().ReadOnly = true;
                    View.getTbIdCardNumber().ReadOnly = true;

                    // set indicate labels text to void
                    View.getLbFirstName().Text = "";
                    View.getLbLastName().Text = "";
                    View.getlbEscIndicator().Text = "";

                    // reload data
                    getDataFromDb();
                }
            }
            else
            {
                View.isEditing = true;

                // disable all buttons
                VMMain.UIMainForm.disableButtons();
                View.getBtAddClient().Enabled = false;
                View.getBtChoose().Enabled = false;
                View.getBtModify().Text = "Confirm";

                // disable lists
                View.getLBoxClient().Enabled = false;
                View.getLBoxProduct().Enabled = false;
                View.getListViewProductDetail().Enabled = false;

                // change textboxes color to show which textbox can modify
                View.getTbFirstName().BackColor = System.Drawing.Color.FromArgb(252, 138, 197);
                View.getTbLastName().BackColor = System.Drawing.Color.FromArgb(252, 138, 197);
                View.getTbIdCardNumber().BackColor = System.Drawing.Color.FromArgb(252, 138, 197);

                // disable read only to let user input data
                View.getTbFirstName().ReadOnly = false;
                View.getTbLastName().ReadOnly = false;
                View.getTbIdCardNumber().ReadOnly = false;

                // show indicate labels text
                View.getLbFirstName().Text = "First name:";
                View.getLbLastName().Text = "Last name:";
                View.getlbEscIndicator().Text = "Press Esc to exit.";

                // Limite textbox width because there will be 2 indicate label show up
                if (View.getTbLastName().Width > 140)
                {
                    View.getTbLastName().Width = 140;
                }
                if (View.getTbFirstName().Width > 140)
                {
                    View.getTbFirstName().Width = 140;
                }
            }
        }

        public void addClientOnClick()
        {
            if (View.isEditing)
            {
                if (addClient(View.getTbFirstName().Text, View.getTbLastName().Text, View.getTbIdCardNumber().Text))
                {
                    View.isEditing = false;

                    // enable all buttons
                    VMMain.UIMainForm.enableButtons();
                    View.getBtChoose().Enabled = true;
                    View.getBtModify().Enabled = true;

                    // enable lists
                    View.getLBoxClient().Enabled = true;
                    View.getLBoxProduct().Enabled = true;
                    View.getListViewProductDetail().Enabled = true;

                    // change back the text
                    View.getBtAddClient().Text = "Add client"; 

                    // change back to origin color
                    View.getTbFirstName().BackColor = System.Drawing.Color.FromArgb(196, 232, 250);
                    View.getTbLastName().BackColor = System.Drawing.Color.FromArgb(196, 232, 250);
                    View.getTbIdCardNumber().BackColor = System.Drawing.Color.FromArgb(166, 202, 240);

                    // set read only
                    View.getTbFirstName().ReadOnly = true;
                    View.getTbLastName().ReadOnly = true;
                    View.getTbIdCardNumber().ReadOnly = true;

                    // set indicate labels text to void
                    View.getLbFirstName().Text = "";
                    View.getLbLastName().Text = "";
                    View.getlbEscIndicator().Text = "";

                    // reload data
                    getDataFromDb();
                }
            }
            else
            {
                View.isEditing = true;

                // disable all buttons
                VMMain.UIMainForm.disableButtons();
                View.getBtChoose().Enabled = false;
                View.getBtModify().Enabled = false;

                // disable lists
                View.getLBoxClient().Enabled = false;
                View.getLBoxProduct().Enabled = false;
                View.getListViewProductDetail().Enabled = false;

                // change button to confirm button
                View.getBtAddClient().Text = "Confirm"; 

                // change textboxes color to show which textbox can modify
                View.getTbFirstName().BackColor = System.Drawing.Color.FromArgb(252, 138, 197);
                View.getTbLastName().BackColor = System.Drawing.Color.FromArgb(252, 138, 197);
                View.getTbIdCardNumber().BackColor = System.Drawing.Color.FromArgb(252, 138, 197);

                // disable read only to allow input
                View.getTbFirstName().ReadOnly = false;
                View.getTbLastName().ReadOnly = false;
                View.getTbIdCardNumber().ReadOnly = false;

                // clear text to allow input new data
                View.getTbFirstName().Text = "";
                View.getTbLastName().Text = "";
                View.getTbIdCardNumber().Text = "";
                View.getTbBalance().Text = "";
                View.getTbIDClient().Text = "";

                // show indicate labels text
                View.getLbFirstName().Text = "First name:";
                View.getLbLastName().Text = "Last name:";
                View.getlbEscIndicator().Text = "Press Esc to exit.";
            }
        }

        public void escEdit()
        {
            View.isEditing = false;

            // enable all buttons
            VMMain.UIMainForm.enableButtons();
            View.getBtAddClient().Enabled = true;
            View.getBtChoose().Enabled = true;
            View.getBtModify().Enabled = true;

            // enable lists
            View.getLBoxClient().Enabled = true;
            View.getLBoxProduct().Enabled = true;
            View.getListViewProductDetail().Enabled = true;

            // change back the text
            if(View.getBtAddClient().Text == "Confirm")
            {
                View.getBtAddClient().Text = "Add client";
            } else
            {
                View.getBtModify().Text = "Modify";
            }
            

            // change back to origin color
            View.getTbFirstName().BackColor = System.Drawing.Color.FromArgb(196, 232, 250);
            View.getTbLastName().BackColor = System.Drawing.Color.FromArgb(196, 232, 250);
            View.getTbIdCardNumber().BackColor = System.Drawing.Color.FromArgb(166, 202, 240);

            // set read only
            View.getTbFirstName().ReadOnly = true;
            View.getTbLastName().ReadOnly = true;
            View.getTbIdCardNumber().ReadOnly = true;

            // set indicate labels text to void
            View.getLbFirstName().Text = "";
            View.getLbLastName().Text = "";
            View.getlbEscIndicator().Text = "";

            // reload data
            getDataFromDb();
        }

        
    }
}
