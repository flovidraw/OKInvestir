namespace OKInvestir.UI
{
    partial class UIClient
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lboxListClient = new System.Windows.Forms.ListBox();
            this.btChooseClient = new System.Windows.Forms.Button();
            this.btAddClient = new System.Windows.Forms.Button();
            this.tbSearchClient = new System.Windows.Forms.TextBox();
            this.lbListClient = new System.Windows.Forms.Label();
            this.btModify = new System.Windows.Forms.Button();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbIdCardNumber = new System.Windows.Forms.TextBox();
            this.lbIdCartNumber = new System.Windows.Forms.Label();
            this.lbProductBoughtInformation = new System.Windows.Forms.Label();
            this.lbListProductBought = new System.Windows.Forms.Label();
            this.lboxProductBought = new System.Windows.Forms.ListBox();
            this.lbBalance = new System.Windows.Forms.Label();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.tbIDClient = new System.Windows.Forms.TextBox();
            this.lbIDClient = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lviewProductDetail = new System.Windows.Forms.ListView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbEscIndicator = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lboxListClient
            // 
            this.lboxListClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lboxListClient.Font = new System.Drawing.Font("Arial", 11F);
            this.lboxListClient.FormattingEnabled = true;
            this.lboxListClient.ItemHeight = 17;
            this.lboxListClient.Location = new System.Drawing.Point(20, 89);
            this.lboxListClient.Name = "lboxListClient";
            this.lboxListClient.Size = new System.Drawing.Size(193, 255);
            this.lboxListClient.TabIndex = 22;
            this.lboxListClient.SelectedIndexChanged += new System.EventHandler(this.lboxListClient_SelectedIndexChanged);
            // 
            // btChooseClient
            // 
            this.btChooseClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btChooseClient.FlatAppearance.BorderSize = 0;
            this.btChooseClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(180)))), ((int)(((byte)(237)))));
            this.btChooseClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(249)))));
            this.btChooseClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChooseClient.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChooseClient.Location = new System.Drawing.Point(20, 371);
            this.btChooseClient.Name = "btChooseClient";
            this.btChooseClient.Size = new System.Drawing.Size(193, 30);
            this.btChooseClient.TabIndex = 21;
            this.btChooseClient.TabStop = false;
            this.btChooseClient.Text = "Choose";
            this.btChooseClient.UseVisualStyleBackColor = false;
            this.btChooseClient.Click += new System.EventHandler(this.btChooseClient_Click);
            // 
            // btAddClient
            // 
            this.btAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btAddClient.FlatAppearance.BorderSize = 0;
            this.btAddClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(180)))), ((int)(((byte)(237)))));
            this.btAddClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(249)))));
            this.btAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddClient.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddClient.Location = new System.Drawing.Point(20, 406);
            this.btAddClient.Name = "btAddClient";
            this.btAddClient.Size = new System.Drawing.Size(193, 30);
            this.btAddClient.TabIndex = 20;
            this.btAddClient.TabStop = false;
            this.btAddClient.Text = "Add client";
            this.btAddClient.UseVisualStyleBackColor = false;
            this.btAddClient.Click += new System.EventHandler(this.btAddClient_Click);
            // 
            // tbSearchClient
            // 
            this.tbSearchClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearchClient.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchClient.Location = new System.Drawing.Point(0, 5);
            this.tbSearchClient.Name = "tbSearchClient";
            this.tbSearchClient.Size = new System.Drawing.Size(193, 20);
            this.tbSearchClient.TabIndex = 19;
            this.tbSearchClient.TextChanged += new System.EventHandler(this.tbSearchClient_TextChanged);
            // 
            // lbListClient
            // 
            this.lbListClient.AutoSize = true;
            this.lbListClient.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListClient.Location = new System.Drawing.Point(16, 25);
            this.lbListClient.Name = "lbListClient";
            this.lbListClient.Size = new System.Drawing.Size(58, 19);
            this.lbListClient.TabIndex = 18;
            this.lbListClient.Text = "Clients";
            // 
            // btModify
            // 
            this.btModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btModify.FlatAppearance.BorderSize = 0;
            this.btModify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(180)))), ((int)(((byte)(237)))));
            this.btModify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(249)))));
            this.btModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModify.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModify.Location = new System.Drawing.Point(20, 442);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(193, 30);
            this.btModify.TabIndex = 34;
            this.btModify.TabStop = false;
            this.btModify.Text = "Modify";
            this.btModify.UseVisualStyleBackColor = false;
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.tbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFirstName.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Bold);
            this.tbFirstName.Location = new System.Drawing.Point(9, 3);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.ReadOnly = true;
            this.tbFirstName.Size = new System.Drawing.Size(114, 25);
            this.tbFirstName.TabIndex = 33;
            this.tbFirstName.TabStop = false;
            this.tbFirstName.Text = "fname";
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // tbIdCardNumber
            // 
            this.tbIdCardNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.tbIdCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIdCardNumber.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdCardNumber.Location = new System.Drawing.Point(7, 42);
            this.tbIdCardNumber.Name = "tbIdCardNumber";
            this.tbIdCardNumber.ReadOnly = true;
            this.tbIdCardNumber.Size = new System.Drawing.Size(195, 20);
            this.tbIdCardNumber.TabIndex = 32;
            this.tbIdCardNumber.TabStop = false;
            this.tbIdCardNumber.Text = "id card number";
            // 
            // lbIdCartNumber
            // 
            this.lbIdCartNumber.AutoSize = true;
            this.lbIdCartNumber.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdCartNumber.Location = new System.Drawing.Point(3, 6);
            this.lbIdCartNumber.Name = "lbIdCartNumber";
            this.lbIdCartNumber.Size = new System.Drawing.Size(124, 19);
            this.lbIdCartNumber.TabIndex = 31;
            this.lbIdCartNumber.Text = "ID card number";
            // 
            // lbProductBoughtInformation
            // 
            this.lbProductBoughtInformation.AutoSize = true;
            this.lbProductBoughtInformation.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductBoughtInformation.Location = new System.Drawing.Point(551, 25);
            this.lbProductBoughtInformation.Name = "lbProductBoughtInformation";
            this.lbProductBoughtInformation.Size = new System.Drawing.Size(109, 19);
            this.lbProductBoughtInformation.TabIndex = 30;
            this.lbProductBoughtInformation.Text = "Product detail";
            // 
            // lbListProductBought
            // 
            this.lbListProductBought.AutoSize = true;
            this.lbListProductBought.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListProductBought.Location = new System.Drawing.Point(253, 25);
            this.lbListProductBought.Name = "lbListProductBought";
            this.lbListProductBought.Size = new System.Drawing.Size(128, 19);
            this.lbListProductBought.TabIndex = 29;
            this.lbListProductBought.Text = "Bought products";
            // 
            // lboxProductBought
            // 
            this.lboxProductBought.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lboxProductBought.Font = new System.Drawing.Font("Arial", 11F);
            this.lboxProductBought.FormattingEnabled = true;
            this.lboxProductBought.ItemHeight = 17;
            this.lboxProductBought.Location = new System.Drawing.Point(255, 53);
            this.lboxProductBought.Name = "lboxProductBought";
            this.lboxProductBought.Size = new System.Drawing.Size(230, 289);
            this.lboxProductBought.TabIndex = 27;
            this.lboxProductBought.SelectedIndexChanged += new System.EventHandler(this.lboxProductBought_SelectedIndexChanged);
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalance.Location = new System.Drawing.Point(3, 6);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(68, 19);
            this.lbBalance.TabIndex = 26;
            this.lbBalance.Text = "Balance";
            // 
            // tbBalance
            // 
            this.tbBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.tbBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBalance.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBalance.Location = new System.Drawing.Point(7, 42);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.ReadOnly = true;
            this.tbBalance.Size = new System.Drawing.Size(158, 20);
            this.tbBalance.TabIndex = 25;
            this.tbBalance.TabStop = false;
            this.tbBalance.Text = "balance";
            // 
            // tbIDClient
            // 
            this.tbIDClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.tbIDClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIDClient.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDClient.Location = new System.Drawing.Point(7, 42);
            this.tbIDClient.Name = "tbIDClient";
            this.tbIDClient.ReadOnly = true;
            this.tbIDClient.Size = new System.Drawing.Size(105, 20);
            this.tbIDClient.TabIndex = 24;
            this.tbIDClient.TabStop = false;
            this.tbIDClient.Text = "id";
            // 
            // lbIDClient
            // 
            this.lbIDClient.AutoSize = true;
            this.lbIDClient.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDClient.Location = new System.Drawing.Point(3, 6);
            this.lbIDClient.Name = "lbIDClient";
            this.lbIDClient.Size = new System.Drawing.Size(72, 19);
            this.lbIDClient.TabIndex = 23;
            this.lbIDClient.Text = "Client ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tbSearchClient);
            this.panel1.Location = new System.Drawing.Point(20, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 30);
            this.panel1.TabIndex = 35;
            // 
            // lviewProductDetail
            // 
            this.lviewProductDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lviewProductDetail.Font = new System.Drawing.Font("Arial", 11F);
            this.lviewProductDetail.Location = new System.Drawing.Point(527, 53);
            this.lviewProductDetail.Name = "lviewProductDetail";
            this.lviewProductDetail.Size = new System.Drawing.Size(267, 291);
            this.lviewProductDetail.TabIndex = 36;
            this.lviewProductDetail.UseCompatibleStateImageBehavior = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbFirstName);
            this.flowLayoutPanel1.Controls.Add(this.tbFirstName);
            this.flowLayoutPanel1.Controls.Add(this.lbLastName);
            this.flowLayoutPanel1.Controls.Add(this.tbLastName);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(243, 371);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(578, 30);
            this.flowLayoutPanel1.TabIndex = 38;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Arial Black", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.Location = new System.Drawing.Point(3, 0);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(0, 24);
            this.lbFirstName.TabIndex = 35;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Arial Black", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastName.Location = new System.Drawing.Point(129, 0);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(0, 24);
            this.lbLastName.TabIndex = 36;
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.tbLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLastName.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Bold);
            this.tbLastName.Location = new System.Drawing.Point(135, 3);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.ReadOnly = true;
            this.tbLastName.Size = new System.Drawing.Size(114, 25);
            this.tbLastName.TabIndex = 34;
            this.tbLastName.TabStop = false;
            this.tbLastName.Text = "lname";
            this.tbLastName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.panel2.Controls.Add(this.lbIDClient);
            this.panel2.Controls.Add(this.tbIDClient);
            this.panel2.Location = new System.Drawing.Point(250, 406);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 66);
            this.panel2.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.panel3.Controls.Add(this.lbIdCartNumber);
            this.panel3.Controls.Add(this.tbIdCardNumber);
            this.panel3.Location = new System.Drawing.Point(388, 406);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 66);
            this.panel3.TabIndex = 40;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.panel4.Controls.Add(this.lbBalance);
            this.panel4.Controls.Add(this.tbBalance);
            this.panel4.Location = new System.Drawing.Point(613, 406);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(181, 66);
            this.panel4.TabIndex = 41;
            // 
            // lbEscIndicator
            // 
            this.lbEscIndicator.AutoSize = true;
            this.lbEscIndicator.ForeColor = System.Drawing.Color.Red;
            this.lbEscIndicator.Location = new System.Drawing.Point(250, 356);
            this.lbEscIndicator.Name = "lbEscIndicator";
            this.lbEscIndicator.Size = new System.Drawing.Size(0, 12);
            this.lbEscIndicator.TabIndex = 42;
            // 
            // UIClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.lbEscIndicator);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lviewProductDetail);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btModify);
            this.Controls.Add(this.lbProductBoughtInformation);
            this.Controls.Add(this.lbListProductBought);
            this.Controls.Add(this.lboxProductBought);
            this.Controls.Add(this.lboxListClient);
            this.Controls.Add(this.btChooseClient);
            this.Controls.Add(this.btAddClient);
            this.Controls.Add(this.lbListClient);
            this.Name = "UIClient";
            this.Size = new System.Drawing.Size(824, 500);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxListClient;
        private System.Windows.Forms.Button btChooseClient;
        private System.Windows.Forms.Button btAddClient;
        private System.Windows.Forms.TextBox tbSearchClient;
        private System.Windows.Forms.Label lbListClient;
        private System.Windows.Forms.Button btModify;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbIdCardNumber;
        private System.Windows.Forms.Label lbIdCartNumber;
        private System.Windows.Forms.Label lbProductBoughtInformation;
        private System.Windows.Forms.Label lbListProductBought;
        private System.Windows.Forms.ListBox lboxProductBought;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.TextBox tbIDClient;
        private System.Windows.Forms.Label lbIDClient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lviewProductDetail;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbEscIndicator;
    }
}
