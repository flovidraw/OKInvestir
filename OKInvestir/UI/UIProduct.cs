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
using OKInvestir.Model;

namespace OKInvestir.UI
{
    public partial class UIProduct : UserControl
    {
        public VMProduct ViewModel { get; set; }
        public UISubProduct sub { get; set; }

        public UIProduct()
        {
            InitializeComponent();
        }
        /**
         * Functions for button onclick
         */
        private void btChoose_Click(object sender, EventArgs e)
        {
            ViewModel.chooseProduct((Product)lboxProduct.SelectedValue);
        }

        private void btAddProduct_Click(object sender, EventArgs e)
        {
            sub = new UISubProduct(this);
            ViewModel.VMMain.switchToSubProduct(sub);
            ViewModel.VMMain.UIMainForm.disableButtons();
        }

        private void btModify_Click(object sender, EventArgs e)
        {
            sub = new UISubProduct(this, (Product)lboxProduct.SelectedValue);
            ViewModel.VMMain.switchToSubProduct(sub);
            ViewModel.VMMain.UIMainForm.disableButtons();
        }


        /**
         * Product list selected index changed
         */
        private void lboxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewModel.loadProductDetail((Product)lboxProduct.SelectedValue);
        }

        /**
         * Search text box text changed
         */
        private void tbSearchProduct_TextChanged(object sender, EventArgs e)
        {
            ViewModel.searchProduct(tbSearchProduct.Text);
        }



        /**
         * Getters
         */
        public ListBox getLboxProduct() { return lboxProduct; }
        public ListView getLviewSillInterest() { return lviewSillInterest; }
        public ListView getLviewTimeInterest() { return lviewTimeInterest; }
        public Label getLbName() { return lbName; }
        public Label getLbStatus() { return lbStatus; }
        public Label getLbId() { return lbId; }
        public TextBox getTbDescription() { return tbDescription; }
        public TextBox getTbSearchProduct() { return tbSearchProduct; }

    }
}
