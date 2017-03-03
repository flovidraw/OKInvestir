using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKInvestir.Model;
using System.Windows.Forms;

namespace OKInvestir.ViewModel
{
    public class VMClient : IViewModel
    {
        private View.VClient View { get; set; }
        public VMMain VMMain { get; set; }
        public User User { get; set; }
        public Client Client { get; set; }

        public VMClient(VMMain VMMain, View.VClient View, User user, Client client)
        {
            this.View = View;
            this.View.setViewModel(this);
            this.VMMain = VMMain;
            this.User = user;
            this.Client = client;

            // show client detail
            View.getTbIDClient().Text = Client.Id.ToString();
            View.getTbBalance().Text = Client.AccountList[0].Balance.ToString();
            View.getTbIdCardNumber().Text = Client.IdCardNumber;
            View.getTbClientName().Text = Client.FullName;
        }

        public bool modifyClient(Client clt, string firstName, string lastName, string idCardNumber)
        {
            bool isSuccess = true;

            using (var context = new Model.Context())
            {
                Cursor.Current = Cursors.WaitCursor;        // waiting animation cursor
                context.Database.Initialize(force: false);  // connect to db
                Client oldClt = context.Clients.Find(clt.Id);
                oldClt.FirstName = firstName;
                oldClt.LastName = lastName;
                oldClt.IdCardNumber = idCardNumber;
                try
                {
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    VMMain.HandleException(e, this.View);
                    isSuccess = false;
                }
                Cursor.Current = Cursors.Arrow;             // get back to normal cursor
            }

            return isSuccess;
        }
    }
}
