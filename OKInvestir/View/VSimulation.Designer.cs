namespace OKInvestir.View
{
    partial class VSimulation
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsniMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGoToMainPage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGoToPageClient = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.lbClientID = new System.Windows.Forms.Label();
            this.tbClientID = new System.Windows.Forms.TextBox();
            this.lbTotalSum = new System.Windows.Forms.Label();
            this.tbTotalSum = new System.Windows.Forms.TextBox();
            this.lboxListProduct = new System.Windows.Forms.ListBox();
            this.lboxProductInformation = new System.Windows.Forms.ListBox();
            this.lbListProduct = new System.Windows.Forms.Label();
            this.lbProductInformations = new System.Windows.Forms.Label();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lbAmount = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.btSelectProduct = new System.Windows.Forms.Button();
            this.btSimulate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsniMenu,
            this.tsmiHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsniMenu
            // 
            this.tsniMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGoToMainPage,
            this.tsmiGoToPageClient,
            this.tsmiQuit});
            this.tsniMenu.Name = "tsniMenu";
            this.tsniMenu.Size = new System.Drawing.Size(52, 20);
            this.tsniMenu.Text = "Menu";
            // 
            // tsmiGoToMainPage
            // 
            this.tsmiGoToMainPage.Name = "tsmiGoToMainPage";
            this.tsmiGoToMainPage.Size = new System.Drawing.Size(175, 22);
            this.tsmiGoToMainPage.Text = "Go To MainPage";
            // 
            // tsmiGoToPageClient
            // 
            this.tsmiGoToPageClient.Name = "tsmiGoToPageClient";
            this.tsmiGoToPageClient.Size = new System.Drawing.Size(175, 22);
            this.tsmiGoToPageClient.Text = "Go To PageClient";
            // 
            // tsmiQuit
            // 
            this.tsmiQuit.Name = "tsmiQuit";
            this.tsmiQuit.Size = new System.Drawing.Size(175, 22);
            this.tsmiQuit.Text = "Quit";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(46, 20);
            this.tsmiHelp.Text = "Help";
            // 
            // lbClientID
            // 
            this.lbClientID.AutoSize = true;
            this.lbClientID.Location = new System.Drawing.Point(12, 48);
            this.lbClientID.Name = "lbClientID";
            this.lbClientID.Size = new System.Drawing.Size(65, 12);
            this.lbClientID.TabIndex = 1;
            this.lbClientID.Text = "Client ID:";
            // 
            // tbClientID
            // 
            this.tbClientID.Location = new System.Drawing.Point(100, 45);
            this.tbClientID.Name = "tbClientID";
            this.tbClientID.Size = new System.Drawing.Size(100, 21);
            this.tbClientID.TabIndex = 2;
            // 
            // lbTotalSum
            // 
            this.lbTotalSum.AutoSize = true;
            this.lbTotalSum.Location = new System.Drawing.Point(12, 89);
            this.lbTotalSum.Name = "lbTotalSum";
            this.lbTotalSum.Size = new System.Drawing.Size(65, 12);
            this.lbTotalSum.TabIndex = 3;
            this.lbTotalSum.Text = "Total Sum:";
            // 
            // tbTotalSum
            // 
            this.tbTotalSum.Location = new System.Drawing.Point(100, 86);
            this.tbTotalSum.Name = "tbTotalSum";
            this.tbTotalSum.Size = new System.Drawing.Size(100, 21);
            this.tbTotalSum.TabIndex = 4;
            // 
            // lboxListProduct
            // 
            this.lboxListProduct.FormattingEnabled = true;
            this.lboxListProduct.ItemHeight = 12;
            this.lboxListProduct.Location = new System.Drawing.Point(14, 161);
            this.lboxListProduct.Name = "lboxListProduct";
            this.lboxListProduct.Size = new System.Drawing.Size(186, 232);
            this.lboxListProduct.TabIndex = 5;
            // 
            // lboxProductInformation
            // 
            this.lboxProductInformation.FormattingEnabled = true;
            this.lboxProductInformation.ItemHeight = 12;
            this.lboxProductInformation.Location = new System.Drawing.Point(247, 161);
            this.lboxProductInformation.Name = "lboxProductInformation";
            this.lboxProductInformation.Size = new System.Drawing.Size(189, 232);
            this.lboxProductInformation.TabIndex = 6;
            // 
            // lbListProduct
            // 
            this.lbListProduct.AutoSize = true;
            this.lbListProduct.Location = new System.Drawing.Point(14, 136);
            this.lbListProduct.Name = "lbListProduct";
            this.lbListProduct.Size = new System.Drawing.Size(107, 12);
            this.lbListProduct.TabIndex = 7;
            this.lbListProduct.Text = "List of Products:";
            // 
            // lbProductInformations
            // 
            this.lbProductInformations.AutoSize = true;
            this.lbProductInformations.Location = new System.Drawing.Point(245, 135);
            this.lbProductInformations.Name = "lbProductInformations";
            this.lbProductInformations.Size = new System.Drawing.Size(131, 12);
            this.lbProductInformations.TabIndex = 8;
            this.lbProductInformations.Text = "Product Informations:";
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Location = new System.Drawing.Point(489, 214);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(71, 12);
            this.lbStartDate.TabIndex = 9;
            this.lbStartDate.Text = "Start Date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(566, 208);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 21);
            this.dtpStartDate.TabIndex = 11;
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Location = new System.Drawing.Point(489, 264);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(59, 12);
            this.lbEndDate.TabIndex = 12;
            this.lbEndDate.Text = "End Date:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(566, 258);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 21);
            this.dtpEndDate.TabIndex = 13;
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(489, 310);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(47, 12);
            this.lbAmount.TabIndex = 14;
            this.lbAmount.Text = "Amount:";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(566, 307);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(100, 21);
            this.tbAmount.TabIndex = 15;
            // 
            // btSelectProduct
            // 
            this.btSelectProduct.Location = new System.Drawing.Point(491, 161);
            this.btSelectProduct.Name = "btSelectProduct";
            this.btSelectProduct.Size = new System.Drawing.Size(146, 23);
            this.btSelectProduct.TabIndex = 16;
            this.btSelectProduct.Text = "Select Product";
            this.btSelectProduct.UseVisualStyleBackColor = true;
            // 
            // btSimulate
            // 
            this.btSimulate.Location = new System.Drawing.Point(491, 360);
            this.btSimulate.Name = "btSimulate";
            this.btSimulate.Size = new System.Drawing.Size(275, 23);
            this.btSimulate.TabIndex = 17;
            this.btSimulate.Text = "Simulate";
            this.btSimulate.UseVisualStyleBackColor = true;
            // 
            // VSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 435);
            this.Controls.Add(this.btSimulate);
            this.Controls.Add(this.btSelectProduct);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lbEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lbStartDate);
            this.Controls.Add(this.lbProductInformations);
            this.Controls.Add(this.lbListProduct);
            this.Controls.Add(this.lboxProductInformation);
            this.Controls.Add(this.lboxListProduct);
            this.Controls.Add(this.tbTotalSum);
            this.Controls.Add(this.lbTotalSum);
            this.Controls.Add(this.tbClientID);
            this.Controls.Add(this.lbClientID);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VSimulation";
            this.Text = "Simulation";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsniMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiGoToMainPage;
        private System.Windows.Forms.ToolStripMenuItem tsmiGoToPageClient;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuit;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.Label lbClientID;
        private System.Windows.Forms.TextBox tbClientID;
        private System.Windows.Forms.Label lbTotalSum;
        private System.Windows.Forms.TextBox tbTotalSum;
        private System.Windows.Forms.ListBox lboxListProduct;
        private System.Windows.Forms.ListBox lboxProductInformation;
        private System.Windows.Forms.Label lbListProduct;
        private System.Windows.Forms.Label lbProductInformations;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Button btSelectProduct;
        private System.Windows.Forms.Button btSimulate;
    }
}