using System;
using System.Windows.Forms;

namespace OKInvestir.View
{
    partial class VMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMin = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.Label();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.lbLogo = new System.Windows.Forms.Label();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btSimulation = new System.Windows.Forms.Button();
            this.btProduct = new System.Windows.Forms.Button();
            this.btClient = new System.Windows.Forms.Button();
            this.btDashboard = new System.Windows.Forms.Button();
            this.pnHead = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnUserControl = new System.Windows.Forms.Panel();
            this.pnLogo.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.pnHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbMin.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbMin.Location = new System.Drawing.Point(768, 4);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(22, 24);
            this.lbMin.TabIndex = 0;
            this.lbMin.Text = "-";
            this.lbMin.Click += new System.EventHandler(this.lbMin_Click);
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbX.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbX.Location = new System.Drawing.Point(796, 4);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(22, 24);
            this.lbX.TabIndex = 1;
            this.lbX.Text = "x";
            this.lbX.Click += new System.EventHandler(this.lbX_Click);
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(183)))), ((int)(((byte)(181)))));
            this.pnLogo.Controls.Add(this.lbLogo);
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(200, 76);
            this.pnLogo.TabIndex = 2;
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.lbLogo.Font = new System.Drawing.Font("mononoki", 20F, System.Drawing.FontStyle.Bold);
            this.lbLogo.ForeColor = System.Drawing.Color.White;
            this.lbLogo.Location = new System.Drawing.Point(30, 23);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(164, 31);
            this.lbLogo.TabIndex = 0;
            this.lbLogo.Text = "OKInvestir";
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(65)))));
            this.pnMenu.Controls.Add(this.btSimulation);
            this.pnMenu.Controls.Add(this.btProduct);
            this.pnMenu.Controls.Add(this.btClient);
            this.pnMenu.Controls.Add(this.btDashboard);
            this.pnMenu.Location = new System.Drawing.Point(0, 76);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(200, 500);
            this.pnMenu.TabIndex = 3;
            // 
            // btSimulation
            // 
            this.btSimulation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(65)))));
            this.btSimulation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSimulation.FlatAppearance.BorderSize = 0;
            this.btSimulation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.btSimulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSimulation.Font = new System.Drawing.Font("mononoki", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSimulation.ForeColor = System.Drawing.Color.White;
            this.btSimulation.Location = new System.Drawing.Point(0, 216);
            this.btSimulation.Name = "btSimulation";
            this.btSimulation.Size = new System.Drawing.Size(200, 72);
            this.btSimulation.TabIndex = 3;
            this.btSimulation.TabStop = false;
            this.btSimulation.Text = "Simulation";
            this.btSimulation.UseVisualStyleBackColor = false;
            this.btSimulation.Click += new System.EventHandler(this.btSimulation_Click);
            this.btSimulation.MouseEnter += new System.EventHandler(this.btSimulation_MouseEnter);
            this.btSimulation.MouseLeave += new System.EventHandler(this.btSimulation_MouseLeave);
            // 
            // btProduct
            // 
            this.btProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(65)))));
            this.btProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btProduct.FlatAppearance.BorderSize = 0;
            this.btProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.btProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProduct.Font = new System.Drawing.Font("mononoki", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProduct.ForeColor = System.Drawing.Color.White;
            this.btProduct.Location = new System.Drawing.Point(0, 144);
            this.btProduct.Name = "btProduct";
            this.btProduct.Size = new System.Drawing.Size(200, 72);
            this.btProduct.TabIndex = 2;
            this.btProduct.TabStop = false;
            this.btProduct.Text = "Product";
            this.btProduct.UseVisualStyleBackColor = false;
            this.btProduct.Click += new System.EventHandler(this.btProduct_Click);
            this.btProduct.MouseEnter += new System.EventHandler(this.btProduct_MouseEnter);
            this.btProduct.MouseLeave += new System.EventHandler(this.btProduct_MouseLeave);
            // 
            // btClient
            // 
            this.btClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(65)))));
            this.btClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btClient.FlatAppearance.BorderSize = 0;
            this.btClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.btClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClient.Font = new System.Drawing.Font("mononoki", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClient.ForeColor = System.Drawing.Color.White;
            this.btClient.Location = new System.Drawing.Point(0, 72);
            this.btClient.Name = "btClient";
            this.btClient.Size = new System.Drawing.Size(200, 72);
            this.btClient.TabIndex = 1;
            this.btClient.TabStop = false;
            this.btClient.Text = "Client";
            this.btClient.UseVisualStyleBackColor = false;
            this.btClient.Click += new System.EventHandler(this.btClient_Click);
            this.btClient.MouseEnter += new System.EventHandler(this.btClient_MouseEnter);
            this.btClient.MouseLeave += new System.EventHandler(this.btClient_MouseLeave);
            // 
            // btDashboard
            // 
            this.btDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(65)))));
            this.btDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btDashboard.FlatAppearance.BorderSize = 0;
            this.btDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.btDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDashboard.Font = new System.Drawing.Font("mononoki", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDashboard.ForeColor = System.Drawing.Color.White;
            this.btDashboard.Location = new System.Drawing.Point(0, 0);
            this.btDashboard.Name = "btDashboard";
            this.btDashboard.Size = new System.Drawing.Size(200, 72);
            this.btDashboard.TabIndex = 0;
            this.btDashboard.TabStop = false;
            this.btDashboard.Text = "Dashboard";
            this.btDashboard.UseVisualStyleBackColor = false;
            this.btDashboard.Click += new System.EventHandler(this.btDashboard_Click);
            this.btDashboard.MouseEnter += new System.EventHandler(this.btDashboard_MouseEnter);
            this.btDashboard.MouseLeave += new System.EventHandler(this.btDashboard_MouseLeave);
            // 
            // pnHead
            // 
            this.pnHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(169)))), ((int)(((byte)(168)))));
            this.pnHead.Controls.Add(this.lbTitle);
            this.pnHead.Controls.Add(this.lbX);
            this.pnHead.Controls.Add(this.lbMin);
            this.pnHead.Location = new System.Drawing.Point(200, 0);
            this.pnHead.Name = "pnHead";
            this.pnHead.Size = new System.Drawing.Size(824, 76);
            this.pnHead.TabIndex = 4;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("mononoki", 20F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(126, 23);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(149, 31);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Dashboard";
            // 
            // pnUserControl
            // 
            this.pnUserControl.Location = new System.Drawing.Point(200, 76);
            this.pnUserControl.Name = "pnUserControl";
            this.pnUserControl.Size = new System.Drawing.Size(824, 500);
            this.pnUserControl.TabIndex = 5;
            // 
            // VMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.pnUserControl);
            this.Controls.Add(this.pnHead);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnLogo);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VMainForm";
            this.Text = "VMainForm";
            this.pnLogo.ResumeLayout(false);
            this.pnLogo.PerformLayout();
            this.pnMenu.ResumeLayout(false);
            this.pnHead.ResumeLayout(false);
            this.pnHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btDashboard;
        private System.Windows.Forms.Panel pnHead;
        private Button btClient;
        private Button btSimulation;
        private Button btProduct;
        private Label lbLogo;
        private Label lbTitle;
        private Panel pnUserControl;
    }
}