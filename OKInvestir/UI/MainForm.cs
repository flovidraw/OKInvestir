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

namespace OKInvestir.View
{
    public partial class VMainForm : Form
    {
        List<Button> btnList;

        public VMainForm()
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


        // buttons onclick events
        private void btDashboard_Click(object sender, EventArgs e)
        {
            btnOnClickColorChanger(btDashboard);

            pnUserControl.Controls.Clear();
            pnUserControl.Controls.Add(new UI.UIDashboard());
        }

        private void btClient_Click(object sender, EventArgs e)
        {
            btnOnClickColorChanger(btClient);
        }

        private void btProduct_Click(object sender, EventArgs e)
        {
            btnOnClickColorChanger(btProduct);
        }

        private void btSimulation_Click(object sender, EventArgs e)
        {
            btnOnClickColorChanger(btSimulation);
        }


        // change buttons back color and title when a button onclick
        private void btnOnClickColorChanger(Button btn)
        {
            lbTitle.Text = btn.Text;

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


        // rounded corner
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


        // allow minimize form when click on taskbar icon
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
    }
}
