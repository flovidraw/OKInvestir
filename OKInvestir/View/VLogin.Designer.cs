using System.Windows.Forms;
namespace OKInvestir.View
{
    partial class VLogin
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
            this.lbId = new System.Windows.Forms.Label();
            this.lbPw = new System.Windows.Forms.Label();
            this.tbPw = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(46, 164);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(35, 18);
            this.lbId.TabIndex = 4;
            this.lbId.Text = "ID:";
            // 
            // lbPw
            // 
            this.lbPw.AutoSize = true;
            this.lbPw.Location = new System.Drawing.Point(46, 258);
            this.lbPw.Name = "lbPw";
            this.lbPw.Size = new System.Drawing.Size(89, 18);
            this.lbPw.TabIndex = 5;
            this.lbPw.Text = "Password:";
            // 
            // tbPw
            // 
            this.tbPw.Location = new System.Drawing.Point(158, 255);
            this.tbPw.Name = "tbPw";
            this.tbPw.Size = new System.Drawing.Size(174, 28);
            this.tbPw.TabIndex = 1;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(158, 161);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(174, 28);
            this.tbId.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(256, 346);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 34);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Login";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitle.Location = new System.Drawing.Point(39, 58);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(298, 30);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "OKInvestir - Login:";
            // 
            // VLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 457);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbPw);
            this.Controls.Add(this.lbPw);
            this.Controls.Add(this.lbId);
            this.Name = "VLogin";
            this.Text = "OKInvestir - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbPw;
        private System.Windows.Forms.TextBox tbPw;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lbTitle;

    }
}