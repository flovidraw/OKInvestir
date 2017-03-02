using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKInvestir.Model;

namespace OKInvestir.ViewModel
{
    public class VMClient : IViewModel
    {
        private View.VClient View;
        public VMMain VMMain { get; set; }
        public User User;
        public Client Client;

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
    }
}
