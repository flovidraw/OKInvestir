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
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.lbBalance = new System.Windows.Forms.Label();
            this.lboxProductBought = new System.Windows.Forms.ListBox();
            this.lboxProductBoughtInfomation = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiSimulation = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiGoToMainPage = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiHelpClient = new System.Windows.Forms.ToolStripMenuItem();
            this.lbListProductBought = new System.Windows.Forms.Label();
            this.lbProductBoughtInformation = new System.Windows.Forms.Label();
            this.tbIdCardNumber = new System.Windows.Forms.TextBox();
            this.lbIdCartNumber = new System.Windows.Forms.Label();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.btModify = new System.Windows.Forms.Button();
            this.btReturn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbIDClient
            // 
            this.lbIDClient.AutoSize = true;
            this.lbIDClient.Location = new System.Drawing.Point(13, 68);
            this.lbIDClient.Name = "lbIDClient";
            this.lbIDClient.Size = new System.Drawing.Size(65, 12);
            this.lbIDClient.TabIndex = 1;
            this.lbIDClient.Text = "Client ID:";
            // 
            // tbIDClient
            // 
            this.tbIDClient.BackColor = System.Drawing.SystemColors.Control;
            this.tbIDClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIDClient.Location = new System.Drawing.Point(15, 108);
            this.tbIDClient.Name = "tbIDClient";
            this.tbIDClient.ReadOnly = true;
            this.tbIDClient.Size = new System.Drawing.Size(159, 14);
            this.tbIDClient.TabIndex = 2;
            this.tbIDClient.TabStop = false;
            this.tbIDClient.Text = "id";
            // 
            // tbBalance
            // 
            this.tbBalance.BackColor = System.Drawing.SystemColors.Control;
            this.tbBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBalance.Location = new System.Drawing.Point(15, 268);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.ReadOnly = true;
            this.tbBalance.Size = new System.Drawing.Size(158, 14);
            this.tbBalance.TabIndex = 3;
            this.tbBalance.TabStop = false;
            this.tbBalance.Text = "balance";
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Location = new System.Drawing.Point(13, 228);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(53, 12);
            this.lbBalance.TabIndex = 4;
            this.lbBalance.Text = "Balance:";
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
            this.menuStrip1.Size = new System.Drawing.Size(761, 25);
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
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // tmsiSimulation
            // 
            this.tmsiSimulation.Name = "tmsiSimulation";
            this.tmsiSimulation.Size = new System.Drawing.Size(171, 22);
            this.tmsiSimulation.Text = "Simulation";
            // 
            // tmsiGoToMainPage
            // 
            this.tmsiGoToMainPage.Name = "tmsiGoToMainPage";
            this.tmsiGoToMainPage.Size = new System.Drawing.Size(171, 22);
            this.tmsiGoToMainPage.Text = "Go to MainPage";
            // 
            // tmsiQuit
            // 
            this.tmsiQuit.Name = "tmsiQuit";
            this.tmsiQuit.Size = new System.Drawing.Size(171, 22);
            this.tmsiQuit.Text = "Quit";
            // 
            // tmsiHelpClient
            // 
            this.tmsiHelpClient.Name = "tmsiHelpClient";
            this.tmsiHelpClient.Size = new System.Drawing.Size(47, 21);
            this.tmsiHelpClient.Text = "Help";
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
            // tbIdCardNumber
            // 
            this.tbIdCardNumber.BackColor = System.Drawing.SystemColors.Control;
            this.tbIdCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIdCardNumber.Location = new System.Drawing.Point(12, 188);
            this.tbIdCardNumber.Name = "tbIdCardNumber";
            this.tbIdCardNumber.ReadOnly = true;
            this.tbIdCardNumber.Size = new System.Drawing.Size(158, 14);
            this.tbIdCardNumber.TabIndex = 15;
            this.tbIdCardNumber.TabStop = false;
            this.tbIdCardNumber.Text = "id card number";
            // 
            // lbIdCartNumber
            // 
            this.lbIdCartNumber.AutoSize = true;
            this.lbIdCartNumber.Location = new System.Drawing.Point(13, 148);
            this.lbIdCartNumber.Name = "lbIdCartNumber";
            this.lbIdCartNumber.Size = new System.Drawing.Size(95, 12);
            this.lbIdCartNumber.TabIndex = 12;
            this.lbIdCartNumber.Text = "ID card number:";
            // 
            // tbClientName
            // 
            this.tbClientName.BackColor = System.Drawing.SystemColors.Control;
            this.tbClientName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbClientName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbClientName.Location = new System.Drawing.Point(15, 28);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.ReadOnly = true;
            this.tbClientName.Size = new System.Drawing.Size(218, 22);
            this.tbClientName.TabIndex = 16;
            this.tbClientName.TabStop = false;
            this.tbClientName.Text = "client name";
            // 
            // btModify
            // 
            this.btModify.Location = new System.Drawing.Point(15, 306);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(75, 23);
            this.btModify.TabIndex = 17;
            this.btModify.Text = "Modify";
            this.btModify.UseVisualStyleBackColor = true;
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
            // 
            // btReturn
            // 
            this.btReturn.Location = new System.Drawing.Point(99, 307);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(75, 23);
            this.btReturn.TabIndex = 18;
            this.btReturn.Text = "Return";
            this.btReturn.UseVisualStyleBackColor = true;
            //this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // VClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 370);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.btModify);
            this.Controls.Add(this.tbClientName);
            this.Controls.Add(this.tbIdCardNumber);
            this.Controls.Add(this.lbIdCartNumber);
            this.Controls.Add(this.lbProductBoughtInformation);
            this.Controls.Add(this.lbListProductBought);
            this.Controls.Add(this.lboxProductBoughtInfomation);
            this.Controls.Add(this.lboxProductBought);
            this.Controls.Add(this.lbBalance);
            this.Controls.Add(this.tbBalance);
            this.Controls.Add(this.tbIDClient);
            this.Controls.Add(this.lbIDClient);
            this.Controls.Add(this.menuStrip1);
            this.Name = "VClient";
            this.Text = " OKInvestir-Client";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbIDClient;
        private System.Windows.Forms.TextBox tbIDClient;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.Label lbBalance;
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
        private System.Windows.Forms.TextBox tbIdCardNumber;
        private System.Windows.Forms.Label lbIdCartNumber;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.Button btModify;
        private System.Windows.Forms.Button btReturn;
    }
}