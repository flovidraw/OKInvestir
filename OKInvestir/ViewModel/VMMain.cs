using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKInvestir.View;

namespace OKInvestir.ViewModel
{
    public class VMMain
    {
        public VMLogin VMLogin { get; set; }
        public VMMainPage VMMainPage { get; set; }


        public View.VLogin VLogin { get; set; }
        public View.VMainPage VMainPage { get; set; }

        public VMMain()
        {
            //switchToLogin(null); // App start page
            switchToMainPage(null, new Model.User(1));
        }


        public void switchToLogin(ExtendedForm Owner)
        {
            if (Owner != null)
            {
                Owner.Dispose();
            }

            VLogin = new View.VLogin();
            VMLogin = new VMLogin(this, VLogin);
            VLogin.Show();
        }


        public void switchToMainPage(ExtendedForm Owner, Model.User User)
        {
            if (Owner != null)
            {
                Owner.Dispose();
            }

            VMainPage = new View.VMainPage();
            VMMainPage = new VMMainPage(this, VMainPage, User);
            VMainPage.Show();
        }
    }
}
