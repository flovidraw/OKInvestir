using OKInvestir.Model;
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
    public partial class VDClientDetail : DialogForm
    {
        private Client client;

        public VDClientDetail(Client clt)
        {
            InitializeComponent();

            this.client = clt;

            //btOK.DialogResult = DialogResult.OK;    // Make btOK's dialog result Cancel.
            btCancel.DialogResult = DialogResult.Cancel;    // Make btCancel's dialog result Cancel.
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Define the border style of the form to a dialog box.
            this.AcceptButton = btOK;   // Set the accept button of the form to button1.
            this.CancelButton = btCancel;   // Set the cancel button of the form to button2.
            this.StartPosition = FormStartPosition.CenterScreen;    // Set the start position of the form to the center of the screen.

            if (clt == null)
            {
                this.btOK.Click += new System.EventHandler(this.btOK_Click_AddClient);
            } else
            {
                this.btOK.Click += new System.EventHandler(this.btOK_Click_ModifyClient);
                tbFirstName.Text = clt.FirstName;
                tbLastName.Text = clt.LastName;
                tbIdCardNumber.Text = clt.IdCardNumber;
            }

        }

        private void btOK_Click_AddClient(object sender, EventArgs e)
        {
            VMainPage owner = (VMainPage)Owner;
            if (owner.ViewModel.addClient(tbFirstName.Text, tbLastName.Text, tbIdCardNumber.Text))
            {
                DialogResult = DialogResult.OK;
                Dispose();
            }
        }

        private void btOK_Click_ModifyClient(object sender, EventArgs e)
        {
            VClient owner = (VClient)Owner;
            if (owner.ViewModel.modifyClient(client, tbFirstName.Text, tbLastName.Text, tbIdCardNumber.Text))
            {
                DialogResult = DialogResult.OK;
                Dispose();
            }
        }
    }
}
