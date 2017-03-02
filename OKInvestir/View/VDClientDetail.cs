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
    public partial class VDClientIDetail : DialogForm
    {
        public VDClientIDetail()
        {
            InitializeComponent();

            //btOK.DialogResult = DialogResult.OK;    // Make btOK's dialog result Cancel.
            btCancel.DialogResult = DialogResult.Cancel;    // Make btCancel's dialog result Cancel.
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Define the border style of the form to a dialog box.
            this.AcceptButton = btOK;   // Set the accept button of the form to button1.
            this.CancelButton = btCancel;   // Set the cancel button of the form to button2.
            this.StartPosition = FormStartPosition.CenterScreen;    // Set the start position of the form to the center of the screen.
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            VMainPage owner = (VMainPage)Owner;
            owner.ViewModel.addClient(tbFirstName.Text, tbLastName.Text, tbIdCardNumber.Text);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
