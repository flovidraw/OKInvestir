using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKInvestir.ViewModel
{
    public class VMSimulation : IViewModel
    {
        private View.VSimulation View;
        public VMMain VMMain { get; set; }

        public VMSimulation(VMMain VMMain, View.VSimulation View)
        {
            this.View = View;
            this.View.setViewModel(this);
            this.VMMain = VMMain;
        }
    }
}
