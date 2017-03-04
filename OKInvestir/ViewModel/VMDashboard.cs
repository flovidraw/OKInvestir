using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OKInvestir.UI;

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

        }



    }
}
