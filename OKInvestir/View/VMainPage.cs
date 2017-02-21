using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OKInvestir.View
{
    public partial class VMainPage : extendedForm, IView
    {
        private ViewModel.VMMainPage ViewModel;

        public VMainPage()
        {
            InitializeComponent();

            lbList.Hide();
        }

        public void setViewModel(ViewModel.IViewModel IViewModel)
        {
            this.ViewModel = (ViewModel.VMMainPage)IViewModel;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }


        // buttons onclick functions
        private void logOut_Click(object sender, EventArgs e)
        {
            ViewModel.VMMain.switchToLogin();
        }
        private void quit_Click(object sender, EventArgs e)
        {
            // Confirm user wants to close
            if (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void addClient_Click(object sender, EventArgs e)
        {
            genMsgBox("Add client", "Developping", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void searchClient_Click(object sender, EventArgs e)
        {
            lbList.Show();
            genMsgBox("search client", "Developping", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void addProduct_Click(object sender, EventArgs e)
        {
            genMsgBox("Add product", "Developping", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void searchProduct_Click(object sender, EventArgs e)
        {
            lbList.Show();
            genMsgBox("search product", "Developping", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void help_Click(object sender, EventArgs e)
        {
            genMsgBox("Help", "Developping", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public void enableProductManage()
        {

        }
    }
}
