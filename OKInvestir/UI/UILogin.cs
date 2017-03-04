using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OKInvestir.ViewModel;

namespace OKInvestir.UI
{
    public partial class UILogin : UserControl
    {
        public VMLogin ViewModel { get; set; }

        private bool hasTbIdTextBeenTyped = false;
        private bool hasTbPwTextBeenTyped = false;

        public UILogin()
        {
            InitializeComponent();

            this.ActiveControl = this.tbId;     // focus on id textbox

            // for showing hint
            tbId.ForeColor = Color.LightGray;
            tbId.Text = "User name                   ";
            tbPw.ForeColor = Color.LightGray;
            tbPw.Text = "Password                   ";
        }
        
        /**
         * Functions for button onclick
         */
        private void btSubmit_Click(object sender, EventArgs e)
        {
            this.ViewModel.login();
        }


        /**
         * Getters
         */
        public string getTbIdText()
        {
            return tbId.Text;
        }

        public string getTbPwText()
        {
            return tbPw.Text;
        }


        /**
         * Function allow pressing enter call btSubmit
         */
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btSubmit.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        /**
         * Functions for showing hint
         */
        // change text color to show hint
        private void tbId_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbId.Text) || tbId.Text == "User name                   ")
                hasTbIdTextBeenTyped = false;
            else
                hasTbIdTextBeenTyped = true;
            // add some space at the end to avoid user has a password which is "Password"
            if (tbId.Text == "User name                   ") 
            {
                tbId.ForeColor = Color.LightGray;
            } else
            {
                tbId.ForeColor = Color.Black;
            }
        }
        // show hint
        private void tbId_LostFocus(object sender, EventArgs e)
        {
            if (tbId.Text == "")
            {
                tbId.Text = "User name                   ";
            }
        }
        // clear hint text
        private void tbId_Click(object sender, EventArgs e)
        {
            if (!hasTbIdTextBeenTyped)
            {
                tbId.Text = "";
            }
        }

        // change text color to show hint
        private void tbPw_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbPw.Text) || tbPw.Text == "Password                   ")
                hasTbPwTextBeenTyped = false;
            else
                hasTbPwTextBeenTyped = true;

            if (tbPw.Text == "Password                   ")
            {
                tbPw.ForeColor = Color.LightGray;
            }
            else
            {
                tbPw.ForeColor = Color.Black;
            }
        }
        // show hint
        private void tbPw_LostFocus(object sender, EventArgs e)
        {
            if (tbPw.Text == "")
            {
                tbPw.Text = "Password                   ";
            }
        }
        // clear hint text
        private void tbPw_Click(object sender, EventArgs e)
        {
            if (!hasTbPwTextBeenTyped)
            {
                tbPw.Text = "";
            }
        }
    }
}
