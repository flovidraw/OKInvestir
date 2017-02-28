namespace OKInvestir.View
{
    partial class VMainPage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiMenuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lboxListClient = new System.Windows.Forms.ListBox();
            this.lbListClient = new System.Windows.Forms.Label();
            this.lbListProduct = new System.Windows.Forms.Label();
            this.lboxListProduct = new System.Windows.Forms.ListBox();
            this.tbSearchClient = new System.Windows.Forms.TextBox();
            this.btSearchClient = new System.Windows.Forms.Button();
            this.btAddClient = new System.Windows.Forms.Button();
            this.btChoseClient = new System.Windows.Forms.Button();
            this.tbSearchProduct = new System.Windows.Forms.TextBox();
            this.btSearchProduct = new System.Windows.Forms.Button();
            this.btChoseProduct = new System.Windows.Forms.Button();
            this.btAddProduct = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMenuMenu,
            this.tsmiHelpMenu});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.msMain.Size = new System.Drawing.Size(751, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "Main Menu Stript ";
            // 
            // tsmiMenuMenu
            // 
            this.tsmiMenuMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLogOut,
            this.tsmiQuit});
            this.tsmiMenuMenu.Name = "tsmiMenuMenu";
            this.tsmiMenuMenu.Size = new System.Drawing.Size(52, 22);
            this.tsmiMenuMenu.Text = "Menu";
            // 
            // tsmiLogOut
            // 
            this.tsmiLogOut.Name = "tsmiLogOut";
            this.tsmiLogOut.Size = new System.Drawing.Size(152, 22);
            this.tsmiLogOut.Text = "Log out";
            this.tsmiLogOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // tsmiQuit
            // 
            this.tsmiQuit.Name = "tsmiQuit";
            this.tsmiQuit.Size = new System.Drawing.Size(152, 22);
            this.tsmiQuit.Text = "Quit";
            this.tsmiQuit.Click += new System.EventHandler(this.quit_Click);
            // 
            // tsmiHelpMenu
            // 
            this.tsmiHelpMenu.Name = "tsmiHelpMenu";
            this.tsmiHelpMenu.Size = new System.Drawing.Size(46, 22);
            this.tsmiHelpMenu.Text = "Help";
            this.tsmiHelpMenu.Click += new System.EventHandler(this.help_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 395);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(751, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lboxListClient
            // 
            this.lboxListClient.FormattingEnabled = true;
            this.lboxListClient.ItemHeight = 12;
            this.lboxListClient.Location = new System.Drawing.Point(11, 67);
            this.lboxListClient.Margin = new System.Windows.Forms.Padding(2);
            this.lboxListClient.Name = "lboxListClient";
            this.lboxListClient.Size = new System.Drawing.Size(195, 292);
            this.lboxListClient.TabIndex = 3;
            this.lboxListClient.SelectedIndexChanged += new System.EventHandler(this.lbList_SelectedIndexChanged);
            // 
            // lbListClient
            // 
            this.lbListClient.AutoSize = true;
            this.lbListClient.Location = new System.Drawing.Point(12, 42);
            this.lbListClient.Name = "lbListClient";
            this.lbListClient.Size = new System.Drawing.Size(101, 12);
            this.lbListClient.TabIndex = 4;
            this.lbListClient.Text = "List of Clients:";
            this.lbListClient.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbListProduct
            // 
            this.lbListProduct.AutoSize = true;
            this.lbListProduct.Location = new System.Drawing.Point(381, 42);
            this.lbListProduct.Name = "lbListProduct";
            this.lbListProduct.Size = new System.Drawing.Size(107, 12);
            this.lbListProduct.TabIndex = 5;
            this.lbListProduct.Text = "List of Products:";
            this.lbListProduct.Click += new System.EventHandler(this.label2_Click);
            // 
            // lboxListProduct
            // 
            this.lboxListProduct.FormattingEnabled = true;
            this.lboxListProduct.ItemHeight = 12;
            this.lboxListProduct.Location = new System.Drawing.Point(383, 67);
            this.lboxListProduct.Margin = new System.Windows.Forms.Padding(2);
            this.lboxListProduct.Name = "lboxListProduct";
            this.lboxListProduct.Size = new System.Drawing.Size(195, 292);
            this.lboxListProduct.TabIndex = 6;
            // 
            // tbSearchClient
            // 
            this.tbSearchClient.Location = new System.Drawing.Point(247, 67);
            this.tbSearchClient.Name = "tbSearchClient";
            this.tbSearchClient.Size = new System.Drawing.Size(100, 21);
            this.tbSearchClient.TabIndex = 7;
            // 
            // btSearchClient
            // 
            this.btSearchClient.Location = new System.Drawing.Point(272, 94);
            this.btSearchClient.Name = "btSearchClient";
            this.btSearchClient.Size = new System.Drawing.Size(75, 23);
            this.btSearchClient.TabIndex = 8;
            this.btSearchClient.Text = "Search";
            this.btSearchClient.UseVisualStyleBackColor = true;
            // 
            // btAddClient
            // 
            this.btAddClient.Location = new System.Drawing.Point(247, 221);
            this.btAddClient.Name = "btAddClient";
            this.btAddClient.Size = new System.Drawing.Size(100, 23);
            this.btAddClient.TabIndex = 9;
            this.btAddClient.Text = "Add client";
            this.btAddClient.UseVisualStyleBackColor = true;
            // 
            // btChoseClient
            // 
            this.btChoseClient.Location = new System.Drawing.Point(247, 175);
            this.btChoseClient.Name = "btChoseClient";
            this.btChoseClient.Size = new System.Drawing.Size(100, 23);
            this.btChoseClient.TabIndex = 10;
            this.btChoseClient.Text = "Chose";
            this.btChoseClient.UseVisualStyleBackColor = true;
            // 
            // tbSearchProduct
            // 
            this.tbSearchProduct.Location = new System.Drawing.Point(617, 67);
            this.tbSearchProduct.Name = "tbSearchProduct";
            this.tbSearchProduct.Size = new System.Drawing.Size(100, 21);
            this.tbSearchProduct.TabIndex = 11;
            // 
            // btSearchProduct
            // 
            this.btSearchProduct.Location = new System.Drawing.Point(642, 94);
            this.btSearchProduct.Name = "btSearchProduct";
            this.btSearchProduct.Size = new System.Drawing.Size(75, 23);
            this.btSearchProduct.TabIndex = 12;
            this.btSearchProduct.Text = "Search";
            this.btSearchProduct.UseVisualStyleBackColor = true;
            // 
            // btChoseProduct
            // 
            this.btChoseProduct.Location = new System.Drawing.Point(617, 174);
            this.btChoseProduct.Name = "btChoseProduct";
            this.btChoseProduct.Size = new System.Drawing.Size(100, 23);
            this.btChoseProduct.TabIndex = 13;
            this.btChoseProduct.Text = "Chose";
            this.btChoseProduct.UseVisualStyleBackColor = true;
            // 
            // btAddProduct
            // 
            this.btAddProduct.Location = new System.Drawing.Point(617, 221);
            this.btAddProduct.Name = "btAddProduct";
            this.btAddProduct.Size = new System.Drawing.Size(100, 23);
            this.btAddProduct.TabIndex = 14;
            this.btAddProduct.Text = "Add product";
            this.btAddProduct.UseVisualStyleBackColor = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // VMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 417);
            this.Controls.Add(this.btAddProduct);
            this.Controls.Add(this.btChoseProduct);
            this.Controls.Add(this.btSearchProduct);
            this.Controls.Add(this.tbSearchProduct);
            this.Controls.Add(this.btChoseClient);
            this.Controls.Add(this.btAddClient);
            this.Controls.Add(this.btSearchClient);
            this.Controls.Add(this.tbSearchClient);
            this.Controls.Add(this.lboxListProduct);
            this.Controls.Add(this.lbListProduct);
            this.Controls.Add(this.lbListClient);
            this.Controls.Add(this.lboxListClient);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VMainPage";
            this.Text = "OKInvestir-Main Page";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenuMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogOut;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuit;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpMenu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListBox lboxListClient;
        private System.Windows.Forms.Label lbListClient;
        private System.Windows.Forms.Label lbListProduct;
        private System.Windows.Forms.ListBox lboxListProduct;
        private System.Windows.Forms.TextBox tbSearchClient;
        private System.Windows.Forms.Button btSearchClient;
        private System.Windows.Forms.Button btAddClient;
        private System.Windows.Forms.Button btChoseClient;
        private System.Windows.Forms.TextBox tbSearchProduct;
        private System.Windows.Forms.Button btSearchProduct;
        private System.Windows.Forms.Button btChoseProduct;
        private System.Windows.Forms.Button btAddProduct;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}

