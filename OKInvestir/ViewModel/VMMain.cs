using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //switchToLogin(); // App start page
            switchToMainPage(new Model.User(1));
        }


        public void switchToLogin()
        {
            if(VMainPage != null)
            {
                VMainPage.Dispose();
                VMMainPage = null;
            }
            
            VLogin = new View.VLogin();
            VMLogin = new VMLogin(this, VLogin);
            VLogin.Show();
        }


        public void switchToMainPage(Model.User User)
        {
            if (VLogin != null) {
                VLogin.Dispose();
                VMLogin = null;
            }
            VMainPage = new View.VMainPage();
            VMMainPage = new VMMainPage(this, VMainPage, User);
            VMainPage.Show();
        }
    }
}
