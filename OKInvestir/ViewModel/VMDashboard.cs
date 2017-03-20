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
    public class VMDashboard
    {
        private UIDashboard View;
        private VMMain VMMain;

        public VMDashboard(VMMain VMMain, UIDashboard View)
        {
            this.View = View;
            this.View.ViewModel = this;
            this.VMMain = VMMain;

            loadDataInDashboard();
        }


        /**
         * Load data from db and change labels
         */
        public void loadDataInDashboard()
        {
            using (var context = new Model.Context())
            {
                Cursor.Current = Cursors.WaitCursor;        // waiting animation cursor
                context.Database.Initialize(force: false);   // connect to db

                View.getLbNbClient().Text = context.Clients.Count().ToString();
                View.getLbNbPdt().Text = context.Products.Where(p => p.ProductStatus == 1).Count().ToString();
                View.getLbNbPdtSold().Text = context.BoughtProducts.Count().ToString();

                
                decimal turnover = 0;
                foreach (BoughtProduct bp in context.BoughtProducts.ToList())
                {
                    turnover += bp.Price;
                }
                View.getLbTurnover().Text = turnover.ToString();

                Cursor.Current = Cursors.Arrow;             // get back to normal cursor
            }
        }
    }
}
