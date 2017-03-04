namespace OKInvestir.UI
{
    partial class UISimulation
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
            this.simulation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // simulation
            // 
            this.simulation.AutoSize = true;
            this.simulation.Location = new System.Drawing.Point(250, 260);
            this.simulation.Name = "simulation";
            this.simulation.Size = new System.Drawing.Size(65, 12);
            this.simulation.TabIndex = 0;
            this.simulation.Text = "simulation";
            // 
            // UISimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simulation);
            this.Name = "UISimulation";
            this.Size = new System.Drawing.Size(824, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label simulation;
    }
}
