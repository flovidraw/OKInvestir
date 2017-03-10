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
            View.getLbName().Text =  pdt.Name;
            View.getTbDescription().Text = pdt.Description;
            View.getLbId().Text = pdt.Id.ToString();
            // TODO: change int to text of status
            View.getLbStatus().Text = pdt.ProductStatus.ToString();

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
            lviewSillInterest.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lviewTimeInterest.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

    }
}
