using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OKInvestir.ViewModel;

namespace OKInvestir.UI
{
    public partial class UIMainForm : Form
    {
        public VMMain VMMain { get; set; }

        List<Button> btnList;

        public UIMainForm()
        {
            InitializeComponent();
            CenterToScreen();

            btnList = new List<Button>();
            btnList.Add(btDashboard);
            btnList.Add(btClient);

            // allow drag window by draging the head panel
            pnHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            pnLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            lbLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);

            // rounded corner
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        /**
         * Getters
         */
        public Panel getPnUserControl() { return this.pnUserControl; }

        public Button getBtDashboard() { return btDashboard; }

        public Label getLbUserName() { return lbUserName; }

        public Label getLbClientName() { return lbClientName; }


        /**
         * Buttons onclick functions
         */
        private void btDashboard_Click(object sender, EventArgs e)
        {
            btnOnClickColorChanger(btDashboard);

            if (VMMain.User != null)
            {
                VMMain.switchToDashboard();
            }
            else
            {
                VMMain.switchToLogin();
            }
        }

        private void btClient_Click(object sender, EventArgs e)
        {
            btnOnClickColorChanger(btClient);

            if (VMMain.User != null)
            {
                VMMain.switchToClient();
            }
            else
            {
                VMMain.switchToLogin();
            }
        }

        private void btProduct_Click(object sender, EventArgs e)
        {
            btnOnClickColorChanger(btProduct);

            if (VMMain.User != null)
            {
                VMMain.switchToProduct();
            }
            else
            {
                VMMain.switchToLogin();
            }
        }

        private void btSimulation_Click(object sender, EventArgs e)
        {
            btnOnClickColorChanger(btSimulation);

            if (VMMain.User != null)
            {
                VMMain.switchToSimulation();
            }
            else
            {
                VMMain.switchToLogin();
            }
        }


        /**
         * Functions for change buttons colors
         */
        // change buttons back color and title when a button onclick
        private void btnOnClickColorChanger(Button btn)
        {
            if(VMMain.User != null) // if not in the login page
            {
                lbTitle.Text = btn.Text;
            }

            switch (btn.Name)
            {
                case "btDashboard":
                    btDashboard.BackColor = Color.FromArgb(30, 43, 53);
                    btClient.BackColor = Color.FromArgb(43, 54, 65);
                    btProduct.BackColor = Color.FromArgb(43, 54, 65);
                    btSimulation.BackColor = Color.FromArgb(43, 54, 65);

                    btDashboard.ForeColor = Color.FromArgb(244, 197, 66);
                    btClient.ForeColor = Color.FromArgb(255, 255, 255);
                    btProduct.ForeColor = Color.FromArgb(255, 255, 255);
                    btSimulation.ForeColor = Color.FromArgb(255, 255, 255);
                        
                    break;

                case "btClient":
                    btDashboard.BackColor = Color.FromArgb(43, 54, 65);
                    btClient.BackColor = Color.FromArgb(30, 43, 53);
                    btProduct.BackColor = Color.FromArgb(43, 54, 65);
                    btSimulation.BackColor = Color.FromArgb(43, 54, 65);

                    btDashboard.ForeColor = Color.FromArgb(255, 255, 255);
                    btClient.ForeColor = Color.FromArgb(244, 197, 66);
                    btProduct.ForeColor = Color.FromArgb(255, 255, 255);
                    btSimulation.ForeColor = Color.FromArgb(255, 255, 255);
                    break;

                case "btProduct":
                    btDashboard.BackColor = Color.FromArgb(43, 54, 65);
                    btClient.BackColor = Color.FromArgb(43, 54, 65);
                    btProduct.BackColor = Color.FromArgb(30, 43, 53);
                    btSimulation.BackColor = Color.FromArgb(43, 54, 65);

                    btDashboard.ForeColor = Color.FromArgb(255, 255, 255);
                    btClient.ForeColor = Color.FromArgb(255, 255, 255);
                    btProduct.ForeColor = Color.FromArgb(244, 197, 66);
                    btSimulation.ForeColor = Color.FromArgb(255, 255, 255);
                    break;

                case "btSimulation":
                    btDashboard.BackColor = Color.FromArgb(43, 54, 65);
                    btClient.BackColor = Color.FromArgb(43, 54, 65);
                    btProduct.BackColor = Color.FromArgb(43, 54, 65);
                    btSimulation.BackColor = Color.FromArgb(30, 43, 53);

                    btDashboard.ForeColor = Color.FromArgb(255, 255, 255);
                    btClient.ForeColor = Color.FromArgb(255, 255, 255);
                    btProduct.ForeColor = Color.FromArgb(255, 255, 255);
                    btSimulation.ForeColor = Color.FromArgb(244, 197, 66);
                    break;
            }
        }


        // change buttons text color when mouse on hover or leave
        private void btDashboard_MouseLeave(object sender, EventArgs e)
        {
            if (btDashboard.BackColor != Color.FromArgb(30, 43, 53))
                btDashboard.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btDashboard_MouseEnter(object sender, EventArgs e)
        {
            btDashboard.ForeColor = Color.FromArgb(244, 197, 66);
        }

        private void btClient_MouseLeave(object sender, EventArgs e)
        {
            if (btClient.BackColor != Color.FromArgb(30, 43, 53))
                btClient.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btClient_MouseEnter(object sender, EventArgs e)
        {
            btClient.ForeColor = Color.FromArgb(244, 197, 66);
        }

        private void btProduct_MouseLeave(object sender, EventArgs e)
        {
            if (btProduct.BackColor != Color.FromArgb(30, 43, 53))
                btProduct.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btProduct_MouseEnter(object sender, EventArgs e)
        {
            btProduct.ForeColor = Color.FromArgb(244, 197, 66);
        }

        private void btSimulation_MouseLeave(object sender, EventArgs e)
        {
            if (btSimulation.BackColor != Color.FromArgb(30, 43, 53))
                btSimulation.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btSimulation_MouseEnter(object sender, EventArgs e)
        {
            btSimulation.ForeColor = Color.FromArgb(244, 197, 66);
        }



        /**
         * Functions allow minimize and close form
         */
        // close window when x label onclick
        private void lbX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // minimize window when - label onclick
        private void lbMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /**
         * Functions allow drag windows
         */
        // allow drag window by draging the head panel
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /**
         * Functions allow rounded corner
         */
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        /**
         * Functions allow minimize form when click on taskbar icon
         */
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_MINIMIZEBOX = 0x00020000;  // Winuser.h中定义         
                CreateParams cp = base.CreateParams;
                cp.Style = cp.Style | WS_MINIMIZEBOX;   // 允许最小化操作        
                return cp;
            }
        }


        /**
         * Function to generate a message box
         */
        public void genMsgBox(string msg, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(msg, caption, buttons, icon);
        }


        /**
         * Function to disable and enable menu buttons
         */
        public void disableButtons()
        {
            btClient.Enabled = false;
            btDashboard.Enabled = false;
            btProduct.Enabled = false;
            btSimulation.Enabled = false;
            pbLogout.Enabled = false;
            pbClearClient.Enabled = false;
        }

        public void enableButtons()
        {
            btClient.Enabled = true;
            btDashboard.Enabled = true;
            btProduct.Enabled = true;
            btSimulation.Enabled = true;
            pbLogout.Enabled = true;
            pbClearClient.Enabled = true;
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            VMMain.logout();
            lbUserName.Text = "";
        }

        private void pbClearClient_Click(object sender, EventArgs e)
        {
            VMMain.Client = null;
            lbClientName.Text = "";
        }



        /**
         * Fonction that define key press event.
         * 
         * 1. Allow pressing esc to end add/modify client
         */
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                if(VMMain.UIClient != null)
                {
                    if (VMMain.UIClient.isEditing == true)
                    {
                        VMMain.VMClient.escEdit();
                    }
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
