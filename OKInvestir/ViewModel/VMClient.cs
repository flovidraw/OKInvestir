using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKInvestir.ViewModel
{
    public class VMClient : IViewModel
    {
        private View.VClient View;
        public VMMain VMMain { get; set; }

        public VMClient(VMMain VMMain, View.VClient View)
        {
            this.View = View;
            this.View.setViewModel(this);
            this.VMMain = VMMain;
        }
    }
}
