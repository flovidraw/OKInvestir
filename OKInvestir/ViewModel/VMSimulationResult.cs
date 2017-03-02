using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKInvestir.ViewModel
{
    public class VMSimulationResult : IViewModel
    {
        private View.VSimulationResult View;
        public VMMain VMMain { get; set; }

        public VMSimulationResult(VMMain VMMain, View.VSimulationResult View)
        {
            this.View = View;
            this.View.setViewModel(this);
            this.VMMain = VMMain;
        }
    }
}
