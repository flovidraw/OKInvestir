using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OKInvestir.UI;
using OKInvestir.Model;

namespace OKInvestir.ViewModel
{
    public class VMProduct
    {
        private UIProduct View;
        public VMMain VMMain { get; set; }

        public VMProduct(VMMain VMMain, UIProduct View)
        {
            this.View = View;
            this.View.ViewModel = this;
            this.VMMain = VMMain;
        }











        public void loadProductDetail(Product pdt)
        {
            /*var listView = View.getListViewProductDetail();
            listView.View = System.Windows.Forms.View.Details;  // set view to details mode sothat it show added item

            // clear the list and readd headers
            listView.Clear();
            listView.Columns.Add("Proprety");
            listView.Columns.Add("Value");

            // add data in listView
            listView.Items.Add(new ListViewItem(new string[] { "Name", pdt.Product.Name }));
            listView.Items.Add(new ListViewItem(new string[] { "Description", pdt.Product.Description }));
            listView.Items.Add(new ListViewItem(new string[] { "Status", pdt.Product.ProductStatus.ToString() }));

            List<SillInterest> siList = pdt.Product.SillInterests;
            listView.Items.Add(new ListViewItem(new string[] { "", "" }));
            listView.Items.Add(new ListViewItem(new string[] { "Sill", "Interest" }));
            foreach (SillInterest si in siList)
            {
                listView.Items.Add(new ListViewItem(new string[] { si.Sill.ToString(), si.Interest.ToString() }));
            }

            List<TimeInterest> tiList = pdt.Product.TimeInterests;
            listView.Items.Add(new ListViewItem(new string[] { "", "" }));
            listView.Items.Add(new ListViewItem(new string[] { "Time", "Interest" }));
            foreach (TimeInterest ti in tiList)
            {
                listView.Items.Add(new ListViewItem(new string[] { ti.Time.ToString(), ti.Interest.ToString() }));
            }

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); // resize columns width*/
        }

    }
}
