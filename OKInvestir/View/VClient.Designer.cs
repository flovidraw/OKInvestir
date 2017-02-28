namespace OKInvestir.View
{
    partial class VClient
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
            this.lbIDClient = new System.Windows.Forms.Label();
            this.tbIDClient = new System.Windows.Forms.TextBox();
            this.tbTotalSum = new System.Windows.Forms.TextBox();
            this.lbTotalSum = new System.Windows.Forms.Label();
            this.lboxProductBought = new System.Windows.Forms.ListBox();
            this.lboxProductBoughtInfomation = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiGoToMainPage = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiHelpClient = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiSimulation = new System.Windows.Forms.ToolStripMenuItem();
            this.lbListProductBought = new System.Windows.Forms.Label();
            this.lbProductBoughtInformation = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbIDClient
            // 
            this.lbIDClient.AutoSize = true;
            this.lbIDClient.Location = new System.Drawing.Point(12, 37);
            this.lbIDClient.Name = "lbIDClient";
            this.lbIDClient.Size = new System.Drawing.Size(65, 12);
            this.lbIDClient.TabIndex = 1;
            this.lbIDClient.Text = "Client ID:";
            // 
            // tbIDClient
            // 
            this.tbIDClient.Location = new System.Drawing.Point(83, 34);
            this.tbIDClient.Name = "tbIDClient";
            this.tbIDClient.Size = new System.Drawing.Size(100, 21);
            this.tbIDClient.TabIndex = 2;
            // 
            // tbTotalSum
            // 
            this.tbTotalSum.Location = new System.Drawing.Point(83, 78);
            this.tbTotalSum.Name = "tbTotalSum";
            this.tbTotalSum.Size = new System.Drawing.Size(100, 21);
            this.tbTotalSum.TabIndex = 3;
            // 
            // lbTotalSum
            // 
            this.lbTotalSum.AutoSize = true;
            this.lbTotalSum.Location = new System.Drawing.Point(12, 81);
            this.lbTotalSum.Name = "lbTotalSum";
            this.lbTotalSum.Size = new System.Drawing.Size(65, 12);
            this.lbTotalSum.TabIndex = 4;
            this.lbTotalSum.Text = "Total Sum:";
            // 
            // lboxProductBought
            // 
            this.lboxProductBought.FormattingEnabled = true;
            this.lboxProductBought.ItemHeight = 12;
            this.lboxProductBought.Location = new System.Drawing.Point(241, 62);
            this.lboxProductBought.Name = "lboxProductBought";
            this.lboxProductBought.Size = new System.Drawing.Size(230, 268);
            this.lboxProductBought.TabIndex = 5;
            // 
            // lboxProductBoughtInfomation
            // 
            this.lboxProductBoughtInfomation.FormattingEnabled = true;
            this.lboxProductBoughtInfomation.ItemHeight = 12;
            this.lboxProductBoughtInfomation.Location = new System.Drawing.Point(504, 62);
            this.lboxProductBoughtInfomation.Name = "lboxProductBoughtInfomation";
            this.lboxProductBoughtInfomation.Size = new System.Drawing.Size(225, 268);
            this.lboxProductBoughtInfomation.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.tmsiHelpClient});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiSimulation,
            this.tmsiGoToMainPage,
            this.tmsiQuit});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // tmsiGoToMainPage
            // 
            this.tmsiGoToMainPage.Name = "tmsiGoToMainPage";
            this.tmsiGoToMainPage.Size = new System.Drawing.Size(169, 22);
            this.tmsiGoToMainPage.Text = "Go to MainPage";
            this.tmsiGoToMainPage.Click += new System.EventHandler(this.goToToolStripMenuItem_Click);
            // 
            // tmsiQuit
            // 
            this.tmsiQuit.Name = "tmsiQuit";
            this.tmsiQuit.Size = new System.Drawing.Size(169, 22);
            this.tmsiQuit.Text = "Quit";
            // 
            // tmsiHelpClient
            // 
            this.tmsiHelpClient.Name = "tmsiHelpClient";
            this.tmsiHelpClient.Size = new System.Drawing.Size(46, 20);
            this.tmsiHelpClient.Text = "Help";
            // 
            // tmsiSimulation
            // 
            this.tmsiSimulation.Name = "tmsiSimulation";
            this.tmsiSimulation.Size = new System.Drawing.Size(169, 22);
            this.tmsiSimulation.Text = "Simulation";
            // 
            // lbListProductBought
            // 
            this.lbListProductBought.AutoSize = true;
            this.lbListProductBought.Location = new System.Drawing.Point(239, 28);
            this.lbListProductBought.Name = "lbListProductBought";
            this.lbListProductBought.Size = new System.Drawing.Size(143, 12);
            this.lbListProductBought.TabIndex = 8;
            this.lbListProductBought.Text = "List of product bought;";
            // 
            // lbProductBoughtInformation
            // 
            this.lbProductBoughtInformation.AutoSize = true;
            this.lbProductBoughtInformation.Location = new System.Drawing.Point(502, 28);
            this.lbProductBoughtInformation.Name = "lbProductBoughtInformation";
            this.lbProductBoughtInformation.Size = new System.Drawing.Size(167, 12);
            this.lbProductBoughtInformation.TabIndex = 9;
            this.lbProductBoughtInformation.Text = "Product Bought Information:";
            // 
            // VClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 370);
            this.Controls.Add(this.lbProductBoughtInformation);
            this.Controls.Add(this.lbListProductBought);
            this.Controls.Add(this.lboxProductBoughtInfomation);
            this.Controls.Add(this.lboxProductBought);
            this.Controls.Add(this.lbTotalSum);
            this.Controls.Add(this.tbTotalSum);
            this.Controls.Add(this.tbIDClient);
            this.Controls.Add(this.lbIDClient);
            this.Controls.Add(this.menuStrip1);
            this.Name = "VClient";
            this.Text = " OKInvestir-Client";
            this.Load += new System.EventHandler(this.VClient_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbIDClient;
        private System.Windows.Forms.TextBox tbIDClient;
        private System.Windows.Forms.TextBox tbTotalSum;
        private System.Windows.Forms.Label lbTotalSum;
        private System.Windows.Forms.ListBox lboxProductBought;
        private System.Windows.Forms.ListBox lboxProductBoughtInfomation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tmsiGoToMainPage;
        private System.Windows.Forms.ToolStripMenuItem tmsiQuit;
        private System.Windows.Forms.ToolStripMenuItem tmsiHelpClient;
        private System.Windows.Forms.ToolStripMenuItem tmsiSimulation;
        private System.Windows.Forms.Label lbListProductBought;
        private System.Windows.Forms.Label lbProductBoughtInformation;
    }
}