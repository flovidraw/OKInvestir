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
            this.lbListClient = new System.Windows.Forms.Label();
            this.lbListProduct = new System.Windows.Forms.Label();
            this.lboxListProduct = new System.Windows.Forms.ListBox();
            this.tbSearchClient = new System.Windows.Forms.TextBox();
            this.btAddClient = new System.Windows.Forms.Button();
            this.btChooseClient = new System.Windows.Forms.Button();
            this.tbSearchProduct = new System.Windows.Forms.TextBox();
            this.btChooseProduct = new System.Windows.Forms.Button();
            this.btAddProduct = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lviewProductDetail = new System.Windows.Forms.ListView();
            this.lboxListClient = new System.Windows.Forms.ListBox();
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
            this.tsmiMenuMenu.Size = new System.Drawing.Size(53, 22);
            this.tsmiMenuMenu.Text = "Menu";
            // 
            // tsmiLogOut
            // 
            this.tsmiLogOut.Name = "tsmiLogOut";
            this.tsmiLogOut.Size = new System.Drawing.Size(121, 22);
            this.tsmiLogOut.Text = "Log out";
            this.tsmiLogOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // tsmiQuit
            // 
            this.tsmiQuit.Name = "tsmiQuit";
            this.tsmiQuit.Size = new System.Drawing.Size(121, 22);
            this.tsmiQuit.Text = "Quit";
            this.tsmiQuit.Click += new System.EventHandler(this.quit_Click);
            // 
            // tsmiHelpMenu
            // 
            this.tsmiHelpMenu.Name = "tsmiHelpMenu";
            this.tsmiHelpMenu.Size = new System.Drawing.Size(47, 22);
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
            // lbListClient
            // 
            this.lbListClient.AutoSize = true;
            this.lbListClient.Location = new System.Drawing.Point(9, 31);
            this.lbListClient.Name = "lbListClient";
            this.lbListClient.Size = new System.Drawing.Size(101, 12);
            this.lbListClient.TabIndex = 4;
            this.lbListClient.Text = "List of Clients:";
            // 
            // lbListProduct
            // 
            this.lbListProduct.AutoSize = true;
            this.lbListProduct.Location = new System.Drawing.Point(240, 31);
            this.lbListProduct.Name = "lbListProduct";
            this.lbListProduct.Size = new System.Drawing.Size(107, 12);
            this.lbListProduct.TabIndex = 5;
            this.lbListProduct.Text = "List of Products:";
            // 
            // lboxListProduct
            // 
            this.lboxListProduct.FormattingEnabled = true;
            this.lboxListProduct.ItemHeight = 12;
            this.lboxListProduct.Location = new System.Drawing.Point(243, 77);
            this.lboxListProduct.Margin = new System.Windows.Forms.Padding(2);
            this.lboxListProduct.Name = "lboxListProduct";
            this.lboxListProduct.Size = new System.Drawing.Size(195, 280);
            this.lboxListProduct.TabIndex = 6;
            this.lboxListProduct.SelectedIndexChanged += new System.EventHandler(this.lboxListProduct_SelectedIndexChanged);
            // 
            // tbSearchClient
            // 
            this.tbSearchClient.Location = new System.Drawing.Point(11, 46);
            this.tbSearchClient.Name = "tbSearchClient";
            this.tbSearchClient.Size = new System.Drawing.Size(195, 21);
            this.tbSearchClient.TabIndex = 7;
            this.tbSearchClient.TextChanged += new System.EventHandler(this.tbSearchClient_TextChanged);
            // 
            // btAddClient
            // 
            this.btAddClient.Location = new System.Drawing.Point(116, 369);
            this.btAddClient.Name = "btAddClient";
            this.btAddClient.Size = new System.Drawing.Size(90, 23);
            this.btAddClient.TabIndex = 9;
            this.btAddClient.Text = "Add client";
            this.btAddClient.UseVisualStyleBackColor = true;
            this.btAddClient.Click += new System.EventHandler(this.btAddClient_Click);
            // 
            // btChooseClient
            // 
            this.btChooseClient.Location = new System.Drawing.Point(10, 369);
            this.btChooseClient.Name = "btChooseClient";
            this.btChooseClient.Size = new System.Drawing.Size(90, 23);
            this.btChooseClient.TabIndex = 10;
            this.btChooseClient.Text = "Choose";
            this.btChooseClient.UseVisualStyleBackColor = true;
            // 
            // tbSearchProduct
            // 
            this.tbSearchProduct.Location = new System.Drawing.Point(242, 46);
            this.tbSearchProduct.Name = "tbSearchProduct";
            this.tbSearchProduct.Size = new System.Drawing.Size(195, 21);
            this.tbSearchProduct.TabIndex = 11;
            this.tbSearchProduct.TextChanged += new System.EventHandler(this.tbSearchProduct_TextChanged);
            // 
            // btChooseProduct
            // 
            this.btChooseProduct.Location = new System.Drawing.Point(243, 369);
            this.btChooseProduct.Name = "btChooseProduct";
            this.btChooseProduct.Size = new System.Drawing.Size(90, 23);
            this.btChooseProduct.TabIndex = 13;
            this.btChooseProduct.Text = "Choose";
            this.btChooseProduct.UseVisualStyleBackColor = true;
            // 
            // btAddProduct
            // 
            this.btAddProduct.Location = new System.Drawing.Point(348, 369);
            this.btAddProduct.Name = "btAddProduct";
            this.btAddProduct.Size = new System.Drawing.Size(90, 23);
            this.btAddProduct.TabIndex = 14;
            this.btAddProduct.Text = "Add product";
            this.btAddProduct.UseVisualStyleBackColor = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // lviewProductDetail
            // 
            this.lviewProductDetail.Location = new System.Drawing.Point(475, 77);
            this.lviewProductDetail.Name = "lviewProductDetail";
            this.lviewProductDetail.Size = new System.Drawing.Size(264, 280);
            this.lviewProductDetail.TabIndex = 16;
            this.lviewProductDetail.UseCompatibleStateImageBehavior = false;
            // 
            // lboxListClient
            // 
            this.lboxListClient.FormattingEnabled = true;
            this.lboxListClient.ItemHeight = 12;
            this.lboxListClient.Location = new System.Drawing.Point(13, 77);
            this.lboxListClient.Name = "lboxListClient";
            this.lboxListClient.Size = new System.Drawing.Size(193, 280);
            this.lboxListClient.TabIndex = 17;
            // 
            // VMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 417);
            this.Controls.Add(this.lboxListClient);
            this.Controls.Add(this.lviewProductDetail);
            this.Controls.Add(this.btAddProduct);
            this.Controls.Add(this.btChooseProduct);
            this.Controls.Add(this.tbSearchProduct);
            this.Controls.Add(this.btChooseClient);
            this.Controls.Add(this.btAddClient);
            this.Controls.Add(this.tbSearchClient);
            this.Controls.Add(this.lboxListProduct);
            this.Controls.Add(this.lbListProduct);
            this.Controls.Add(this.lbListClient);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VMainPage";
            this.Text = "OKInvestir-Main Page";
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
        private System.Windows.Forms.Label lbListClient;
        private System.Windows.Forms.Label lbListProduct;
        private System.Windows.Forms.TextBox tbSearchClient;
        private System.Windows.Forms.Button btAddClient;
        private System.Windows.Forms.Button btChooseClient;
        private System.Windows.Forms.TextBox tbSearchProduct;
        private System.Windows.Forms.Button btChooseProduct;
        private System.Windows.Forms.Button btAddProduct;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListView lviewProductDetail;
        private System.Windows.Forms.ListBox lboxListClient;
        private System.Windows.Forms.ListBox lboxListProduct;
    }
}

