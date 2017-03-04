using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OKInvestir.Model;
using OKInvestir.UI;

namespace OKInvestir.ViewModel
{
    public class VMLogin: IViewModel
    {
        private UILogin View;
        private VMMain VMMain;

        public VMLogin(VMMain VMMain, UILogin View)
        {
            this.View = View;
            this.View.ViewModel = this;
            this.VMMain = VMMain;
        }

        public void login()
        {
            string Id = View.getTbIdText();
            string Pw = View.getTbPwText();

            if (Id == "User name                   ")           // username void
            {
                VMMain.UIMainForm.genMsgBox("Please enter your ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (Pw == "Password                   ")    // password void
            {
                VMMain.UIMainForm.genMsgBox("Please enter your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                Boolean isUsrFound = false;
                User UsrFound = null;
                using (var context = new Model.Context())
                {
                    Cursor.Current = Cursors.WaitCursor;        // waiting animation cursor
                    //context.Database.Initialize(force: true);   // connect to db, it takes time
                    context.Database.Initialize(force: true);   // connect to db, it takes time
                    Cursor.Current = Cursors.Arrow;             // get back to normal cursor
                    var Usr = context.Users.Where(u => u.Username == Id && u.Password == Pw);
                    if (Usr.Any())
                    {
                        isUsrFound = true;
                        UsrFound = Usr.First();
                    }
                    
                }
                if (isUsrFound)   // login successful
                {
                    VMMain.User = UsrFound;
                    VMMain.switchToDashboard();
                    VMMain.UIMainForm.getLbUserName().Text = UsrFound.Username;
                    VMMain.UIMainForm.getBtDashboard().PerformClick();
                        //View.genMsgBox("Login succeed.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else {        // login failed
                    VMMain.UIMainForm.genMsgBox("ID or password incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

            
        }
    }
}
