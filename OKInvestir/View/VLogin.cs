using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OKInvestir.ViewModel;

namespace OKInvestir.View
{
    public partial class VLogin : ExtendedForm, IView
    {
        private ViewModel.VMLogin ViewModel;
        
        public VLogin()
        {
            InitializeComponent();
            this.ActiveControl = this.tbId;     // focus on id textbox
            this.AcceptButton = this.btnSubmit; // set enter key call submit button
        }

        public void setViewModel(IViewModel IViewModel)
        {
            this.ViewModel = (VMLogin)IViewModel;
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.ViewModel.login();
        }

        public string getTbIdText()
        {
            return tbId.Text;
        }

        public string getTbPwText()
        {
            return tbPw.Text;
        }

    }
}
