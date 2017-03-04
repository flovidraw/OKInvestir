namespace OKInvestir.UI
{
    partial class UILogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbPw = new System.Windows.Forms.TextBox();
            this.btSubmit = new System.Windows.Forms.Button();
            this.pnTbId = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnTbId.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(287, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbId
            // 
            this.tbId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbId.Font = new System.Drawing.Font("Arial", 14F);
            this.tbId.Location = new System.Drawing.Point(0, 7);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(200, 22);
            this.tbId.TabIndex = 1;
            this.tbId.TextChanged += new System.EventHandler(this.tbId_TextChanged);
            this.tbId.Click += new System.EventHandler(this.tbId_Click);
            this.tbId.LostFocus += new System.EventHandler(this.tbId_LostFocus);
            //
            // tbPw
            // 
            this.tbPw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPw.Font = new System.Drawing.Font("Arial", 14F);
            this.tbPw.Location = new System.Drawing.Point(0, 7);
            this.tbPw.Name = "tbPw";
            this.tbPw.Size = new System.Drawing.Size(200, 22);
            this.tbPw.TabIndex = 2;
            this.tbPw.TextChanged += new System.EventHandler(this.tbPw_TextChanged);
            this.tbPw.Click += new System.EventHandler(this.tbPw_Click);
            this.tbPw.LostFocus += new System.EventHandler(this.tbPw_LostFocus);
            // 
            // btSubmit
            // 
            this.btSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSubmit.FlatAppearance.BorderSize = 0;
            this.btSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(180)))), ((int)(((byte)(237)))));
            this.btSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(249)))));
            this.btSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSubmit.Font = new System.Drawing.Font("Arial", 14F);
            this.btSubmit.Location = new System.Drawing.Point(312, 302);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(200, 35);
            this.btSubmit.TabIndex = 3;
            this.btSubmit.Text = "Sign in";
            this.btSubmit.UseVisualStyleBackColor = true;
            // 
            // pnTbId
            // 
            this.pnTbId.BackColor = System.Drawing.SystemColors.Window;
            this.pnTbId.Controls.Add(this.tbId);
            this.pnTbId.Location = new System.Drawing.Point(312, 163);
            this.pnTbId.Name = "pnTbId";
            this.pnTbId.Size = new System.Drawing.Size(200, 35);
            this.pnTbId.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.tbPw);
            this.panel1.Location = new System.Drawing.Point(312, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 35);
            this.panel1.TabIndex = 5;
            // 
            // UILogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnTbId);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UILogin";
            this.Size = new System.Drawing.Size(824, 500);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnTbId.ResumeLayout(false);
            this.pnTbId.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbPw;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Panel pnTbId;
        private System.Windows.Forms.Panel panel1;
    }
}
