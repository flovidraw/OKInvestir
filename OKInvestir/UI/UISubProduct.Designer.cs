namespace OKInvestir.UI
{
    partial class UISubProduct
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.flpSI = new System.Windows.Forms.FlowLayoutPanel();
            this.btAddSI = new System.Windows.Forms.Button();
            this.flpTI = new System.Windows.Forms.FlowLayoutPanel();
            this.btRemoveSI = new System.Windows.Forms.Button();
            this.btRemoveTI = new System.Windows.Forms.Button();
            this.btAddTI = new System.Windows.Forms.Button();
            this.lbSill = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbInterestSI = new System.Windows.Forms.Label();
            this.lbInterestTI = new System.Windows.Forms.Label();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.pbReturn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(60, 86);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(54, 18);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name:";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Location = new System.Drawing.Point(60, 123);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(92, 18);
            this.lbDescription.TabIndex = 1;
            this.lbDescription.Text = "Description:";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(158, 87);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(609, 18);
            this.tbName.TabIndex = 2;
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescription.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(158, 124);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(609, 82);
            this.tbDescription.TabIndex = 3;
            // 
            // flpSI
            // 
            this.flpSI.Location = new System.Drawing.Point(60, 286);
            this.flpSI.Name = "flpSI";
            this.flpSI.Size = new System.Drawing.Size(351, 178);
            this.flpSI.TabIndex = 5;
            // 
            // btAddSI
            // 
            this.btAddSI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btAddSI.FlatAppearance.BorderSize = 0;
            this.btAddSI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(180)))), ((int)(((byte)(237)))));
            this.btAddSI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(249)))));
            this.btAddSI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddSI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddSI.Location = new System.Drawing.Point(63, 227);
            this.btAddSI.Name = "btAddSI";
            this.btAddSI.Size = new System.Drawing.Size(168, 30);
            this.btAddSI.TabIndex = 7;
            this.btAddSI.Text = "Add Sill-Interest";
            this.btAddSI.UseVisualStyleBackColor = false;
            this.btAddSI.Click += new System.EventHandler(this.btAddSI_Click);
            // 
            // flpTI
            // 
            this.flpTI.Location = new System.Drawing.Point(419, 286);
            this.flpTI.Name = "flpTI";
            this.flpTI.Size = new System.Drawing.Size(351, 178);
            this.flpTI.TabIndex = 6;
            // 
            // btRemoveSI
            // 
            this.btRemoveSI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(98)))), ((int)(((byte)(146)))));
            this.btRemoveSI.FlatAppearance.BorderSize = 0;
            this.btRemoveSI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.btRemoveSI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(143)))), ((int)(((byte)(177)))));
            this.btRemoveSI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemoveSI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoveSI.Location = new System.Drawing.Point(237, 227);
            this.btRemoveSI.Name = "btRemoveSI";
            this.btRemoveSI.Size = new System.Drawing.Size(168, 30);
            this.btRemoveSI.TabIndex = 8;
            this.btRemoveSI.Text = "Remove";
            this.btRemoveSI.UseVisualStyleBackColor = false;
            this.btRemoveSI.Click += new System.EventHandler(this.btRemoveSI_Click);
            // 
            // btRemoveTI
            // 
            this.btRemoveTI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(98)))), ((int)(((byte)(146)))));
            this.btRemoveTI.FlatAppearance.BorderSize = 0;
            this.btRemoveTI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.btRemoveTI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(143)))), ((int)(((byte)(177)))));
            this.btRemoveTI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemoveTI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoveTI.Location = new System.Drawing.Point(599, 227);
            this.btRemoveTI.Name = "btRemoveTI";
            this.btRemoveTI.Size = new System.Drawing.Size(168, 30);
            this.btRemoveTI.TabIndex = 10;
            this.btRemoveTI.Text = "Remove";
            this.btRemoveTI.UseVisualStyleBackColor = false;
            this.btRemoveTI.Click += new System.EventHandler(this.btRemoveTI_Click);
            // 
            // btAddTI
            // 
            this.btAddTI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btAddTI.FlatAppearance.BorderSize = 0;
            this.btAddTI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(180)))), ((int)(((byte)(237)))));
            this.btAddTI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(249)))));
            this.btAddTI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddTI.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddTI.Location = new System.Drawing.Point(425, 227);
            this.btAddTI.Name = "btAddTI";
            this.btAddTI.Size = new System.Drawing.Size(168, 30);
            this.btAddTI.TabIndex = 9;
            this.btAddTI.Text = "Add Time-Interest";
            this.btAddTI.UseVisualStyleBackColor = false;
            this.btAddTI.Click += new System.EventHandler(this.btAddTI_Click);
            // 
            // lbSill
            // 
            this.lbSill.AutoSize = true;
            this.lbSill.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSill.Location = new System.Drawing.Point(128, 264);
            this.lbSill.Name = "lbSill";
            this.lbSill.Size = new System.Drawing.Size(27, 17);
            this.lbSill.TabIndex = 11;
            this.lbSill.Text = "Sill";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(457, 264);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(108, 17);
            this.lbTime.TabIndex = 12;
            this.lbTime.Text = "Time in months";
            // 
            // lbInterestSI
            // 
            this.lbInterestSI.AutoSize = true;
            this.lbInterestSI.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInterestSI.Location = new System.Drawing.Point(282, 264);
            this.lbInterestSI.Name = "lbInterestSI";
            this.lbInterestSI.Size = new System.Drawing.Size(79, 17);
            this.lbInterestSI.TabIndex = 13;
            this.lbInterestSI.Text = "Interest(%)";
            // 
            // lbInterestTI
            // 
            this.lbInterestTI.AutoSize = true;
            this.lbInterestTI.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInterestTI.Location = new System.Drawing.Point(646, 264);
            this.lbInterestTI.Name = "lbInterestTI";
            this.lbInterestTI.Size = new System.Drawing.Size(79, 17);
            this.lbInterestTI.TabIndex = 14;
            this.lbInterestTI.Text = "Interest(%)";
            // 
            // pbSave
            // 
            this.pbSave.Image = global::OKInvestir.Properties.Resources.save;
            this.pbSave.Location = new System.Drawing.Point(754, 20);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(50, 50);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSave.TabIndex = 16;
            this.pbSave.TabStop = false;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            // 
            // pbReturn
            // 
            this.pbReturn.Image = global::OKInvestir.Properties.Resources._return;
            this.pbReturn.Location = new System.Drawing.Point(20, 20);
            this.pbReturn.Name = "pbReturn";
            this.pbReturn.Size = new System.Drawing.Size(50, 50);
            this.pbReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReturn.TabIndex = 15;
            this.pbReturn.TabStop = false;
            this.pbReturn.Click += new System.EventHandler(this.pbReturn_Click);
            // 
            // UISubProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.pbSave);
            this.Controls.Add(this.pbReturn);
            this.Controls.Add(this.lbInterestTI);
            this.Controls.Add(this.lbInterestSI);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbSill);
            this.Controls.Add(this.btRemoveTI);
            this.Controls.Add(this.btAddTI);
            this.Controls.Add(this.btRemoveSI);
            this.Controls.Add(this.flpTI);
            this.Controls.Add(this.btAddSI);
            this.Controls.Add(this.flpSI);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbName);
            this.Name = "UISubProduct";
            this.Size = new System.Drawing.Size(824, 500);
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.FlowLayoutPanel flpSI;
        private System.Windows.Forms.Button btAddSI;
        private System.Windows.Forms.FlowLayoutPanel flpTI;
        private System.Windows.Forms.Button btRemoveSI;
        private System.Windows.Forms.Button btRemoveTI;
        private System.Windows.Forms.Button btAddTI;
        private System.Windows.Forms.Label lbSill;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbInterestSI;
        private System.Windows.Forms.Label lbInterestTI;
        private System.Windows.Forms.PictureBox pbReturn;
        private System.Windows.Forms.PictureBox pbSave;
    }
}
