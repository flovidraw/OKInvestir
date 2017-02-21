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
            this.tsmiClientMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddClient = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchClient = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProductMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearchProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbList = new System.Windows.Forms.ListBox();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMenuMenu,
            this.tsmiClientMenu,
            this.tsmiProductMenu,
            this.tsmiHelpMenu});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1126, 32);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "Main Menu Stript ";
            // 
            // tsmiMenuMenu
            // 
            this.tsmiMenuMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLogOut,
            this.tsmiQuit});
            this.tsmiMenuMenu.Name = "tsmiMenuMenu";
            this.tsmiMenuMenu.Size = new System.Drawing.Size(72, 28);
            this.tsmiMenuMenu.Text = "Menu";
            // 
            // tsmiLogOut
            // 
            this.tsmiLogOut.Name = "tsmiLogOut";
            this.tsmiLogOut.Size = new System.Drawing.Size(159, 30);
            this.tsmiLogOut.Text = "Log out";
            this.tsmiLogOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // tsmiQuit
            // 
            this.tsmiQuit.Name = "tsmiQuit";
            this.tsmiQuit.Size = new System.Drawing.Size(159, 30);
            this.tsmiQuit.Text = "Quit";
            this.tsmiQuit.Click += new System.EventHandler(this.quit_Click);
            // 
            // tsmiClientMenu
            // 
            this.tsmiClientMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddClient,
            this.tsmiSearchClient});
            this.tsmiClientMenu.Name = "tsmiClientMenu";
            this.tsmiClientMenu.Size = new System.Drawing.Size(72, 28);
            this.tsmiClientMenu.Text = "Client";
            // 
            // tsmiAddClient
            // 
            this.tsmiAddClient.Name = "tsmiAddClient";
            this.tsmiAddClient.Size = new System.Drawing.Size(150, 30);
            this.tsmiAddClient.Text = "Add";
            this.tsmiAddClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // tsmiSearchClient
            // 
            this.tsmiSearchClient.Name = "tsmiSearchClient";
            this.tsmiSearchClient.Size = new System.Drawing.Size(150, 30);
            this.tsmiSearchClient.Text = "Search";
            this.tsmiSearchClient.Click += new System.EventHandler(this.searchClient_Click);
            // 
            // tsmiProductMenu
            // 
            this.tsmiProductMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddProduct,
            this.tsmiSearchProduct});
            this.tsmiProductMenu.Name = "tsmiProductMenu";
            this.tsmiProductMenu.Size = new System.Drawing.Size(90, 28);
            this.tsmiProductMenu.Text = "Product";
            // 
            // tsmiAddProduct
            // 
            this.tsmiAddProduct.Name = "tsmiAddProduct";
            this.tsmiAddProduct.Size = new System.Drawing.Size(150, 30);
            this.tsmiAddProduct.Text = "Add";
            this.tsmiAddProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // tsmiSearchProduct
            // 
            this.tsmiSearchProduct.Name = "tsmiSearchProduct";
            this.tsmiSearchProduct.Size = new System.Drawing.Size(150, 30);
            this.tsmiSearchProduct.Text = "Search";
            this.tsmiSearchProduct.Click += new System.EventHandler(this.searchProduct_Click);
            // 
            // tsmiHelpMenu
            // 
            this.tsmiHelpMenu.Name = "tsmiHelpMenu";
            this.tsmiHelpMenu.Size = new System.Drawing.Size(63, 28);
            this.tsmiHelpMenu.Text = "Help";
            this.tsmiHelpMenu.Click += new System.EventHandler(this.help_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 603);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1126, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbList
            // 
            this.lbList.FormattingEnabled = true;
            this.lbList.ItemHeight = 18;
            this.lbList.Location = new System.Drawing.Point(12, 36);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(291, 562);
            this.lbList.TabIndex = 3;
            // 
            // VMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 625);
            this.Controls.Add(this.lbList);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "VMainPage";
            this.Text = "OKInvestir";
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
        private System.Windows.Forms.ToolStripMenuItem tsmiClientMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddClient;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchClient;
        private System.Windows.Forms.ToolStripMenuItem tsmiProductMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddProduct;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchProduct;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpMenu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListBox lbList;
    }
}

