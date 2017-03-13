using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OKInvestir.Model;

namespace OKInvestir.UI
{
    public partial class UISubProduct : UserControl
    {
        private UIProduct owner;
        public int pdtId { get; private set; }

        public int sillInterestCount { get; private set; }
        public int timeInterestCount { get; private set; }

        public UISubProduct(UIProduct owner)
        {
            InitializeComponent();
            // auto add scrol bar for 2 flowlayout panels
            flpSI.AutoScroll = true;
            flpTI.AutoScroll = true;

            pdtId = 0;
            this.owner = owner;
            sillInterestCount = 0;
            timeInterestCount = 0;
        }

        public UISubProduct(UIProduct owner, Product pdt)
        {
            InitializeComponent();

            pdtId = pdt.Id;
            this.owner = owner;
            sillInterestCount = 0;
            timeInterestCount = 0;

            // auto add scrol bar for 2 flowlayout panels
            flpSI.AutoScroll = true;
            flpTI.AutoScroll = true;


            // load product's data in textboxes
            tbName.Text = pdt.Name.ToString();
            tbDescription.Text = pdt.Description.ToString();

            // load product's sill/time interest data in flow layout panels
            foreach (SillInterest si in pdt.SillInterests)
            {
                // counter ++
                sillInterestCount++;

                // new text boxes to add in panels dynamically
                TextBox tbSill = new TextBox();
                TextBox tbInterest = new TextBox();

                // set name, color, styles ...
                tbSill.BackColor = Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
                tbSill.BorderStyle = BorderStyle.None;
                tbSill.Font = new Font("Arial", 11F);
                tbSill.Size = new Size(168, 17);
                tbSill.Name = "sill" + sillInterestCount.ToString();

                tbInterest.BackColor = Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
                tbInterest.BorderStyle = BorderStyle.None;
                tbInterest.Font = new Font("Arial", 11F);
                tbInterest.Size = new Size(168, 17);
                tbInterest.Name = "interest" + sillInterestCount.ToString();

                // set text
                tbSill.Text = si.Sill.ToString();
                tbInterest.Text = si.Interest.ToString();

                // add them in panel
                flpSI.Controls.Add(tbSill);
                flpSI.Controls.Add(tbInterest);
            }

            foreach (TimeInterest ti in pdt.TimeInterests)
            {
                // counter ++
                timeInterestCount++;

                // new text boxes to add in panels dynamically
                TextBox tbSill = new TextBox();
                TextBox tbInterest = new TextBox();

                // set name, color, styles ...
                tbSill.BackColor = Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
                tbSill.BorderStyle = BorderStyle.None;
                tbSill.Font = new Font("Arial", 11F);
                tbSill.Size = new Size(168, 17);
                tbSill.Name = "sill" + sillInterestCount.ToString();

                tbInterest.BackColor = Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
                tbInterest.BorderStyle = BorderStyle.None;
                tbInterest.Font = new Font("Arial", 11F);
                tbInterest.Size = new Size(168, 17);
                tbInterest.Name = "interest" + sillInterestCount.ToString();

                // set text
                tbSill.Text = ti.Time.ToString();
                tbInterest.Text = ti.Interest.ToString();

                // add them in panel
                flpTI.Controls.Add(tbSill);
                flpTI.Controls.Add(tbInterest);
            }
        }

        /**
         * getters
         */
        public TextBox getTbName() { return tbName; }
        public TextBox getTbDescription() { return tbDescription; }
        public FlowLayoutPanel getFlpSI() { return flpSI; }
        public FlowLayoutPanel getFlpTI() { return flpTI; }

        private void btAddSI_Click(object sender, EventArgs e)
        {
            // counter ++
            sillInterestCount++;

            // new text boxes to add in panels dynamically
            TextBox tbSill = new TextBox();
            TextBox tbInterest = new TextBox();

            // set name, color, styles ...
            tbSill.BackColor = Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            tbSill.BorderStyle = BorderStyle.None;
            tbSill.Font = new Font("Arial", 11F);
            tbSill.Size = new Size(168, 17);
            tbSill.Name = "sill" + sillInterestCount.ToString();

            tbInterest.BackColor = Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            tbInterest.BorderStyle = BorderStyle.None;
            tbInterest.Font = new Font("Arial", 11F);
            tbInterest.Size = new Size(168, 17);
            tbInterest.Name = "interest" + sillInterestCount.ToString();

            // add them in panel
            flpSI.Controls.Add(tbSill);
            flpSI.Controls.Add(tbInterest);
        }

        private void btAddTI_Click(object sender, EventArgs e)
        {
            timeInterestCount++;
            TextBox tbSill = new TextBox();
            TextBox tbInterest = new TextBox();

            tbSill.BackColor = Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            tbSill.BorderStyle = BorderStyle.None;
            tbSill.Font = new Font("Arial", 11F);
            tbSill.Size = new Size(168, 17);
            tbSill.Name = "sill" + timeInterestCount.ToString();

            tbInterest.BackColor = Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            tbInterest.BorderStyle = BorderStyle.None;
            tbInterest.Font = new Font("Arial", 11F);
            tbInterest.Size = new Size(168, 17);
            tbInterest.Name = "interest" + timeInterestCount.ToString();

            flpTI.Controls.Add(tbSill);
            flpTI.Controls.Add(tbInterest);
            flpTI.SetFlowBreak(tbInterest, true);
        }

        private void btRemoveSI_Click(object sender, EventArgs e)
        {
            // if have added textboxes 
            if (sillInterestCount > 0)
            {
                // should not remove controls in the foreach loop!
                // so create new textbox firstly
                TextBox tb1 = new TextBox();
                TextBox tb2 = new TextBox();

                // iterate over Control list
                foreach (Control ctrl in flpSI.Controls)
                {
                    // if find latest textboxes, copy into tb1 or tb2
                    if (ctrl.Name == "sill" + sillInterestCount.ToString())
                    {
                        tb1 = (TextBox)ctrl;
                    }
                    else if (ctrl.Name == "interest" + sillInterestCount.ToString())
                    {
                        tb2 = (TextBox)ctrl;
                    }
                }

                // remove them from the panel AFTER the loop
                flpSI.Controls.Remove(tb1);
                flpSI.Controls.Remove(tb2);

                sillInterestCount--;
            }
        }

        private void btRemoveTI_Click(object sender, EventArgs e)
        {
            if (timeInterestCount > 0)
            {
                TextBox tb1 = new TextBox();
                TextBox tb2 = new TextBox();
                foreach (Control ctrl in flpTI.Controls)
                {
                    if (ctrl.Name == "sill" + timeInterestCount.ToString())
                    {
                        tb1 = (TextBox)ctrl;
                    }
                    else if (ctrl.Name == "interest" + timeInterestCount.ToString())
                    {
                        tb2 = (TextBox)ctrl;
                    }
                }
                // should not remove controls in the foreach loop!
                flpTI.Controls.Remove(tb1);
                flpTI.Controls.Remove(tb2);
                
                timeInterestCount--;
            }
        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            owner.ViewModel.VMMain.switchToProduct();
            owner.ViewModel.VMMain.UIMainForm.enableButtons();
        }

        private void pbSave_Click(object sender, EventArgs e)
        {
            if (owner.ViewModel.saveProduct())
            {
                owner.ViewModel.VMMain.UIMainForm.genMsgBox("OK", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                owner.ViewModel.VMMain.UIMainForm.genMsgBox("Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
