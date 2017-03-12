namespace OKInvestir.UI
{
    partial class UIProduct
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
            this.lviewSillInterest = new System.Windows.Forms.ListView();
            this.lboxProduct = new System.Windows.Forms.ListBox();
            this.btModify = new System.Windows.Forms.Button();
            this.btChoose = new System.Windows.Forms.Button();
            this.btAddProduct = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSearchProduct = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lviewTimeInterest = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lviewSillInterest
            // 
            this.lviewSillInterest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lviewSillInterest.Font = new System.Drawing.Font("Arial", 11F);
            this.lviewSillInterest.Location = new System.Drawing.Point(261, 61);
            this.lviewSillInterest.Name = "lviewSillInterest";
            this.lviewSillInterest.Size = new System.Drawing.Size(249, 285);
            this.lviewSillInterest.TabIndex = 38;
            this.lviewSillInterest.UseCompatibleStateImageBehavior = false;
            this.lviewSillInterest.View = System.Windows.Forms.View.Details;
            // 
            // lboxProduct
            // 
            this.lboxProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lboxProduct.Font = new System.Drawing.Font("Arial", 11F);
            this.lboxProduct.FormattingEnabled = true;
            this.lboxProduct.ItemHeight = 17;
            this.lboxProduct.Location = new System.Drawing.Point(37, 97);
            this.lboxProduct.Name = "lboxProduct";
            this.lboxProduct.Size = new System.Drawing.Size(193, 238);
            this.lboxProduct.TabIndex = 37;
            this.lboxProduct.SelectedIndexChanged += new System.EventHandler(this.lboxProduct_SelectedIndexChanged);
            // 
            // btModify
            // 
            this.btModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btModify.FlatAppearance.BorderSize = 0;
            this.btModify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(180)))), ((int)(((byte)(237)))));
            this.btModify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(249)))));
            this.btModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModify.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModify.ForeColor = System.Drawing.Color.Black;
            this.btModify.Location = new System.Drawing.Point(37, 439);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(193, 30);
            this.btModify.TabIndex = 41;
            this.btModify.TabStop = false;
            this.btModify.Text = "Modify";
            this.btModify.UseVisualStyleBackColor = false;
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
            // 
            // btChoose
            // 
            this.btChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btChoose.FlatAppearance.BorderSize = 0;
            this.btChoose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(180)))), ((int)(((byte)(237)))));
            this.btChoose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(249)))));
            this.btChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChoose.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChoose.ForeColor = System.Drawing.Color.Black;
            this.btChoose.Location = new System.Drawing.Point(37, 368);
            this.btChoose.Name = "btChoose";
            this.btChoose.Size = new System.Drawing.Size(193, 30);
            this.btChoose.TabIndex = 40;
            this.btChoose.TabStop = false;
            this.btChoose.Text = "Simulate";
            this.btChoose.UseVisualStyleBackColor = false;
            this.btChoose.Click += new System.EventHandler(this.btChoose_Click);
            // 
            // btAddProduct
            // 
            this.btAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btAddProduct.FlatAppearance.BorderSize = 0;
            this.btAddProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(180)))), ((int)(((byte)(237)))));
            this.btAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(249)))));
            this.btAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddProduct.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddProduct.ForeColor = System.Drawing.Color.Black;
            this.btAddProduct.Location = new System.Drawing.Point(37, 403);
            this.btAddProduct.Name = "btAddProduct";
            this.btAddProduct.Size = new System.Drawing.Size(193, 30);
            this.btAddProduct.TabIndex = 39;
            this.btAddProduct.TabStop = false;
            this.btAddProduct.Text = "Add product";
            this.btAddProduct.UseVisualStyleBackColor = false;
            this.btAddProduct.Click += new System.EventHandler(this.btAddProduct_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tbSearchProduct);
            this.panel1.Location = new System.Drawing.Point(37, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 30);
            this.panel1.TabIndex = 42;
            // 
            // tbSearchProduct
            // 
            this.tbSearchProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearchProduct.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchProduct.Location = new System.Drawing.Point(0, 5);
            this.tbSearchProduct.Name = "tbSearchProduct";
            this.tbSearchProduct.Size = new System.Drawing.Size(193, 20);
            this.tbSearchProduct.TabIndex = 19;
            this.tbSearchProduct.TextChanged += new System.EventHandler(this.tbSearchProduct_TextChanged);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Bold);
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.Location = new System.Drawing.Point(2, 0);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(87, 26);
            this.lbName.TabIndex = 43;
            this.lbName.Text = "lbName";
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescription.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(261, 403);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(525, 84);
            this.tbDescription.TabIndex = 44;
            this.tbDescription.Text = "description, tbDescription, tbDescription, tbDescription, tbDescription, tbDescri" +
    "ption, tbDescription, tbDescription, tbDescription, tbDescription";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Bold);
            this.lbId.ForeColor = System.Drawing.Color.Black;
            this.lbId.Location = new System.Drawing.Point(93, 0);
            this.lbId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(96, 26);
            this.lbId.TabIndex = 45;
            this.lbId.Text = "id : 2233";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Bold);
            this.lbStatus.ForeColor = System.Drawing.Color.Black;
            this.lbStatus.Location = new System.Drawing.Point(193, 0);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(94, 26);
            this.lbStatus.TabIndex = 46;
            this.lbStatus.Text = "lbStatus";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbName);
            this.flowLayoutPanel1.Controls.Add(this.lbId);
            this.flowLayoutPanel1.Controls.Add(this.lbStatus);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(261, 368);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(527, 30);
            this.flowLayoutPanel1.TabIndex = 47;
            // 
            // lviewTimeInterest
            // 
            this.lviewTimeInterest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lviewTimeInterest.Font = new System.Drawing.Font("Arial", 11F);
            this.lviewTimeInterest.Location = new System.Drawing.Point(538, 61);
            this.lviewTimeInterest.Name = "lviewTimeInterest";
            this.lviewTimeInterest.Size = new System.Drawing.Size(249, 285);
            this.lviewTimeInterest.TabIndex = 48;
            this.lviewTimeInterest.UseCompatibleStateImageBehavior = false;
            this.lviewTimeInterest.View = System.Windows.Forms.View.Details;
            // 
            // UIProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.lviewTimeInterest);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btModify);
            this.Controls.Add(this.btChoose);
            this.Controls.Add(this.btAddProduct);
            this.Controls.Add(this.lviewSillInterest);
            this.Controls.Add(this.lboxProduct);
            this.Name = "UIProduct";
            this.Size = new System.Drawing.Size(824, 500);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lviewSillInterest;
        private System.Windows.Forms.ListBox lboxProduct;
        private System.Windows.Forms.Button btModify;
        private System.Windows.Forms.Button btChoose;
        private System.Windows.Forms.Button btAddProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbSearchProduct;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListView lviewTimeInterest;
    }
}
