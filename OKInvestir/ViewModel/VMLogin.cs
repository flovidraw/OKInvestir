using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OKInvestir.Model;

namespace OKInvestir.ViewModel
{
    public class VMLogin: IViewModel
    {
        private View.VLogin View;
        private VMMain VMMain;

        public VMLogin(VMMain VMMain, View.VLogin View)
        {
            this.View = View;
            this.View.setViewModel(this);
            this.VMMain = VMMain;
        }

        public void login()
        {
            string Id = View.getTbIdText();
            string Pw = View.getTbPwText();

            if (Id == "")           // username void
            {
                View.genMsgBox("Please enter your ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (Pw == "")    // password void
            {
                View.genMsgBox("Please enter your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                Boolean isUsrFound = false;
                User UsrFound = null;
                using (var context = new Model.Context())
                {
                    Cursor.Current = Cursors.WaitCursor;        // waiting animation cursor
                    //context.Database.Initialize(force: true);   // connect to db, it takes time
                    context.Database.Initialize(force: false);   // connect to db, it takes time
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
                        VMMain.switchToMainPage(this.View , UsrFound);
                        //View.genMsgBox("Login succeed.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else {        // login failed
                        View.genMsgBox("ID or password incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
            }

            
        }
    }
}
