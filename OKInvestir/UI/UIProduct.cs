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
    public partial class UIProduct : UserControl
    {
        public VMProduct ViewModel { get; set; }

        public UIProduct()
        {
            InitializeComponent();
        }

        private void lboxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewModel.loadProductDetail((Model.Product)lboxProduct.SelectedValue);
        }

        /**
         * Functions for button onclick
         */






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
