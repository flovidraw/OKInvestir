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
    public partial class UIClient : UserControl
    {
        public VMClient ViewModel { get; set; }

        public bool isEditing { get; set; }

        public UIClient()
        {
            InitializeComponent();

            isEditing = false;
            lbEscIndicator.Text = "";
        }

        /**
         * Functions for button onclick
         */
        private void btAddClient_Click(object sender, EventArgs e)
        {
            ViewModel.addClientOnClick();
        }

        private void btChooseClient_Click(object sender, EventArgs e)
        {
            ViewModel.chooseClient();
        }

        private void btModify_Click(object sender, EventArgs e)
        {
            ViewModel.modifyOnClick();
        }







        /**
         * Getters
         */
        public ListView getListViewProductDetail() { return lviewProductDetail; }
        public ListBox getLBoxClient() { return lboxListClient; }
        public ListBox getLBoxProduct() { return lboxProductBought; }
        public TextBox getTbSearchClient() { return tbSearchClient; }
        public TextBox getTbIDClient() { return tbIDClient; }
        public TextBox getTbBalance() { return tbBalance; }
        public TextBox getTbFirstName() { return tbFirstName; }
        public TextBox getTbLastName() { return tbLastName; }
        public TextBox getTbIdCardNumber() { return tbIdCardNumber; }
        public Button getBtChoose() { return btChooseClient; }
        public Button getBtModify() { return btModify; }
        public Button getBtAddClient() { return btAddClient; }
        public Label getLbFirstName() { return lbFirstName; }
        public Label getLbLastName() { return lbLastName; }
        public Label getlbEscIndicator() { return lbEscIndicator; }


        /**
         * Search client
         */
        private void tbSearchClient_TextChanged(object sender, EventArgs e)
        {
            ViewModel.searchClient(tbSearchClient.Text);
        }

        private void lboxListClient_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!this.getLBoxClient().SelectedValue.Equals(null))
            {
                ViewModel.loadClientDetail((Model.Client)lboxListClient.SelectedValue);
            }
            else
            {
                ViewModel.VMMain.UIMainForm.genMsgBox("You haven't chosen a client yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lboxProductBought_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewModel.loadProductDetail((Model.BoughtProduct)lboxProductBought.SelectedValue);
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            if (isEditing)
            {
                Size size = TextRenderer.MeasureText(tbFirstName.Text, tbFirstName.Font);
                if (size.Width < 140)
                {
                    if (size.Width > 30)
                    {
                        tbFirstName.Width = size.Width;
                    }
                    else
                    {
                        tbFirstName.Width = 30;
                    }

                }
                else
                {
                    tbFirstName.Width = 140;
                }
            }
            else
            {
                if (tbFirstName.Width < 260)
                {
                    Size size = TextRenderer.MeasureText(tbFirstName.Text, tbFirstName.Font);
                    tbFirstName.Width = size.Width;
                }
            }

        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            if (isEditing)
            {
                Size size = TextRenderer.MeasureText(tbLastName.Text, tbLastName.Font);
                if (size.Width < 140)
                {
                    if (size.Width > 30)
                    {
                        tbLastName.Width = size.Width;
                    }
                    else
                    {
                        tbLastName.Width = 30;
                    }
                }
                else
                {
                    tbLastName.Width = 140;
                }
            }
            else
            {
                if (tbLastName.Width < 260)
                {
                    Size size = TextRenderer.MeasureText(tbLastName.Text, tbLastName.Font);
                    tbLastName.Width = size.Width;
                }
            }


        }

        private void UIClient_Load(object sender, EventArgs e)
        {

        }

        private void btDelect_Click(object sender, EventArgs e)
        {
            this.ViewModel.SellProduct();
        }
    }
}
