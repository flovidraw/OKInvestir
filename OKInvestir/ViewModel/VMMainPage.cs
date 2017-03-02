using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OKInvestir.Model;
using System.ComponentModel;

namespace OKInvestir.ViewModel
{
    public class VMMainPage : IViewModel
    {
        private View.VMainPage View;
        public VMMain VMMain { get; set; }
    
        public string tbSearchClientText { get; set; }
        public string tbSearchProductText { get; set; }
        public List<Client> Clients { get; set; }
        public List<Product> Products { get; set; }
        public List<Client> ClientsForBinding { get; set; }
        public List<Product> ProductsForBinding { get; set; }
        public BindingList<Client> blClients { get; set; }
        public BindingList<Product> blProducts { get; set; }

        public VMMainPage(VMMain VMMain, View.VMainPage View, Model.User User)
        {
            this.View = View;
            this.View.setViewModel(this);
            this.VMMain = VMMain;

            // user level control
            if(User.UserLevel == 2)
            {
                View.enableProductManage();
            }

            // load clients and products in lists
            using (var context = new Model.Context())
            {
                Cursor.Current = Cursors.WaitCursor;        // waiting animation cursor
                context.Database.Initialize(force: false);   // connect to db, it takes time
                Clients = context.Clients.ToList();
                Products = context.Products.ToList();
                ClientsForBinding = context.Clients.ToList();
                ProductsForBinding = context.Products.ToList();
                Cursor.Current = Cursors.Arrow;             // get back to normal cursor
            }

            // bind list to listBoxes
            ClientsForBinding = new List<Client>(Clients);      // clone for binding list
            ProductsForBinding = new List<Product>(Products);
            blClients = new BindingList<Client>(ClientsForBinding);
            blProducts = new BindingList<Product>(ProductsForBinding);

            View.getListBoxClient().DataSource = blClients;
            View.getListBoxClient().DisplayMember = "FullName";
            View.getListBoxProduct().DataSource = blProducts;
            View.getListBoxProduct().DisplayMember = "Name";
            
            // load selected product detail to listView
            loadProductDetail((Product)View.getListBoxProduct().SelectedValue);
        }

        public void serachClient(string text)
        {
            blClients.Clear();
            foreach (Client clt in Clients)
            {
                if (clt.FullName.Contains(text))
                    blClients.Add(clt);
            }

            // select automatically the first item after searching
            if (blClients.Count > 0)
                View.getListBoxClient().SetSelected(0, true);
        }

        public void serachProduct(string text)
        {
            blProducts.Clear();
            foreach (Product pdt in Products)
            {
                if (pdt.Name.Contains(text))
                    blProducts.Add(pdt);
            }

            // select automatically the first item after searching
            if (blProducts.Count > 0)
                View.getListBoxProduct().SetSelected(0, true);
        }

        public void loadProductDetail(Product pdt)
        {
            var listView = View.getListViewProductDetail();
            listView.View = System.Windows.Forms.View.Details;  // set view to details mode sothat it show added item

            // clear the list and readd headers
            listView.Clear();
            listView.Columns.Add("Proprety");
            listView.Columns.Add("Value");
            
            // add data in listView
            listView.Items.Add(new ListViewItem(new string[] { "Name", pdt.Name }));
            listView.Items.Add(new ListViewItem(new string[] { "Description", pdt.Description }));
            listView.Items.Add(new ListViewItem(new string[] { "Status", pdt.ProductStatus.ToString() }));

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); // resize columns width
        }

    }
}
