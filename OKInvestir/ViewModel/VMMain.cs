using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKInvestir.View;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace OKInvestir.ViewModel
{
    public class VMMain
    {
        public VMLogin VMLogin { get; set; }
        public VClient VClient { get; set; }

        public VLogin VLogin { get; set; }
        public VMainPage VMainPage { get; set; }

        public VMMainPage VMMainPage { get; set; }
        public VMClient VMClient { get; set; }

        public VMMain()
        {
            //switchToLogin(null); // App start page
            switchToMainPage(null, new Model.User(1));
        }


        public void switchToLogin(ExtendedForm owner)
        {
            if (owner != null)
            {
                owner.Dispose();
            }

            VLogin = new View.VLogin();
            VMLogin = new VMLogin(this, VLogin);
            VLogin.Show();
        }


        public void switchToMainPage(ExtendedForm owner, Model.User user)
        {
            if (owner != null)
            {
                owner.Dispose();
            }

            VMainPage = new View.VMainPage();
            VMMainPage = new VMMainPage(this, VMainPage, user);
            VMainPage.Show();
        }

        public void switchToClient(ExtendedForm owner, Model.User user, Model.Client client)
        {
            if (owner != null)
            {
                owner.Dispose();
            }

            VClient = new View.VClient();
            VMClient = new VMClient(this, VClient, user, client);
            VClient.Show();
        }





        // http://stackoverflow.com/questions/31515776/how-can-i-catch-uniquekey-violation-exceptions-with-ef6-and-sql-server
        public virtual void HandleException(Exception exception, ExtendedForm form)
        {
            DbUpdateException dbUpdateEx = exception as DbUpdateException;
            if (dbUpdateEx != null)
            {
                if (dbUpdateEx != null
                        && dbUpdateEx.InnerException != null
                        && dbUpdateEx.InnerException.InnerException != null)
                {
                    MySqlException sqlException = dbUpdateEx.InnerException.InnerException as MySqlException;
                    if (sqlException != null)
                    {
                        DatabaseAccessException(form, dbUpdateEx.Message, sqlException.Message, sqlException.Number);
                    } else
                    {
                        DatabaseAccessException(form, dbUpdateEx.Message, dbUpdateEx.InnerException.Message);
                    }
                }
            }
        }

        public void DatabaseAccessException(ExtendedForm form, string dbUpdateExMessage, string dbUpdateExInnerException, int sqlExceptionNumber)
        {
            switch (sqlExceptionNumber)
            {
                case 1062:
                    form.genMsgBox("The number of ID card is already exist.", "DataBase Access Exception",
                        System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    break;

                default:
                    form.genMsgBox("Message = " + dbUpdateExMessage + "\nInnerException = " + dbUpdateExInnerException
                        + "\nsqlExceptionNumber = " + sqlExceptionNumber, "DataBase Access Exception",
                        System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    break;
            }
            
        }

        public void DatabaseAccessException(ExtendedForm form, string dbUpdateExMessage, string dbUpdateExInnerException)
        {
            form.genMsgBox("Message = " + dbUpdateExMessage + "\nInnerException = " + dbUpdateExInnerException,
                "DataBase Access Exception", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }
    }
}
