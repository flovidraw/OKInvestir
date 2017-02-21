using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKInvestir.ViewModel
{
    public class VMMainPage : IViewModel
    {
        private View.VMainPage View;
        public VMMain VMMain { get; set; }

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
        }
       
    }
}
