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
    public partial class DialogForm : Form
    {
        //private IView owner;
        public DialogForm()
        {
            InitializeComponent();
        }

        /*public void setOwner(IView owner)
        {
            this.owner = owner;
        }*/

        public void genMsgBox(string msg, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(msg, caption, buttons, icon);
        }
    }
}
