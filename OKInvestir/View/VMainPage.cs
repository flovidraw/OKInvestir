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
    public partial class VMainPage : ExtendedForm, IView
    {
        private ViewModel.VMMainPage ViewModel;

        public VMainPage()
        {
            InitializeComponent();
        }

        public void setViewModel(ViewModel.IViewModel IViewModel)
        {
            this.ViewModel = (ViewModel.VMMainPage)IViewModel;
        }

        // buttons onclick functions
        private void logOut_Click(object sender, EventArgs e)
        {
            ViewModel.VMMain.switchToLogin(this);
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
        private void help_Click(object sender, EventArgs e)
        {
            genMsgBox("Help", "Developping", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void enableProductManage()
        {

        }
        public ListView getListViewProductDetail() { return lviewProductDetail; }
        public ListBox getListBoxClient() { return lboxListClient; }
        public ListBox getListBoxProduct() { return lboxListProduct; }
        public TextBox getTextBoxSearchClient() { return tbSearchClient; }
        public TextBox getTextBoxSearchProduct() { return tbSearchProduct; }

        private void tbSearchClient_TextChanged(object sender, EventArgs e)
        {
            ViewModel.serachClient(tbSearchClient.Text);
        }

        private void tbSearchProduct_TextChanged(object sender, EventArgs e)
        {
            ViewModel.serachProduct(tbSearchProduct.Text);
        }

        private void lboxListProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewModel.loadProductDetail((Model.Product)lboxListProduct.SelectedValue);
        }
    }
}
