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
            this.lbBalance = new System.Windows.Forms.Label();
            this.lbValueBalance = new System.Windows.Forms.Label();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lbAmout = new System.Windows.Forms.Label();
            this.tbAmout = new System.Windows.Forms.TextBox();
            this.btSimulate = new System.Windows.Forms.Button();
            this.lbProductSelected = new System.Windows.Forms.Label();
            this.lbValueProductSelected = new System.Windows.Forms.Label();
            this.lbResultAmount = new System.Windows.Forms.Label();
            this.lbValueAmount = new System.Windows.Forms.Label();
            this.lbInterestRate = new System.Windows.Forms.Label();
            this.lbValueInterestRate = new System.Windows.Forms.Label();
            this.lbSettlementPrice = new System.Windows.Forms.Label();
            this.lbValueSettlementPrice = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btExecute = new System.Windows.Forms.Button();
            this.lbValuePeriode = new System.Windows.Forms.Label();
            this.lbPeriode = new System.Windows.Forms.Label();
            this.lboxSimulation = new System.Windows.Forms.ListBox();
            this.btSimulationChosen = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.exportPdf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exportXlsx = new System.Windows.Forms.Button();
            this.exportCsv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalance.Location = new System.Drawing.Point(48, 88);
            this.lbBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(120, 31);
            this.lbBalance.TabIndex = 19;
            this.lbBalance.Text = "Balance :";
            // 
            // lbValueBalance
            // 
            this.lbValueBalance.AutoSize = true;
            this.lbValueBalance.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValueBalance.Location = new System.Drawing.Point(180, 88);
            this.lbValueBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbValueBalance.Name = "lbValueBalance";
            this.lbValueBalance.Size = new System.Drawing.Size(0, 31);
            this.lbValueBalance.TabIndex = 20;
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartDate.Location = new System.Drawing.Point(46, 156);
            this.lbStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(139, 31);
            this.lbStartDate.TabIndex = 27;
            this.lbStartDate.Text = "Start date :";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dtpStartDate.Location = new System.Drawing.Point(196, 156);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(298, 28);
            this.dtpStartDate.TabIndex = 28;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndDate.Location = new System.Drawing.Point(46, 228);
            this.lbEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(131, 31);
            this.lbEndDate.TabIndex = 29;
            this.lbEndDate.Text = "End date :";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(196, 228);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(298, 28);
            this.dtpEndDate.TabIndex = 30;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // lbAmout
            // 
            this.lbAmout.AutoSize = true;
            this.lbAmout.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmout.Location = new System.Drawing.Point(46, 296);
            this.lbAmout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAmout.Name = "lbAmout";
            this.lbAmout.Size = new System.Drawing.Size(116, 31);
            this.lbAmout.TabIndex = 31;
            this.lbAmout.Text = "Amount :";
            this.lbAmout.Click += new System.EventHandler(this.lbAmout_Click);
            // 
            // tbAmout
            // 
            this.tbAmout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAmout.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmout.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tbAmout.Location = new System.Drawing.Point(195, 294);
            this.tbAmout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAmout.Name = "tbAmout";
            this.tbAmout.Size = new System.Drawing.Size(300, 30);
            this.tbAmout.TabIndex = 32;
            this.tbAmout.TextChanged += new System.EventHandler(this.tbAmout_TextChanged);
            // 
            // btSimulate
            // 
            this.btSimulate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btSimulate.FlatAppearance.BorderSize = 0;
            this.btSimulate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(180)))), ((int)(((byte)(237)))));
            this.btSimulate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(249)))));
            this.btSimulate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSimulate.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSimulate.ForeColor = System.Drawing.Color.Black;
            this.btSimulate.Location = new System.Drawing.Point(54, 357);
            this.btSimulate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSimulate.Name = "btSimulate";
            this.btSimulate.Size = new System.Drawing.Size(441, 45);
            this.btSimulate.TabIndex = 33;
            this.btSimulate.TabStop = false;
            this.btSimulate.Text = "Simulate";
            this.btSimulate.UseVisualStyleBackColor = false;
            this.btSimulate.Click += new System.EventHandler(this.btSimulate_Click);
            // 
            // lbProductSelected
            // 
            this.lbProductSelected.AutoSize = true;
            this.lbProductSelected.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductSelected.Location = new System.Drawing.Point(624, 156);
            this.lbProductSelected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProductSelected.Name = "lbProductSelected";
            this.lbProductSelected.Size = new System.Drawing.Size(220, 31);
            this.lbProductSelected.TabIndex = 34;
            this.lbProductSelected.Text = "Product selected :";
            // 
            // lbValueProductSelected
            // 
            this.lbValueProductSelected.AutoSize = true;
            this.lbValueProductSelected.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValueProductSelected.Location = new System.Drawing.Point(861, 156);
            this.lbValueProductSelected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbValueProductSelected.Name = "lbValueProductSelected";
            this.lbValueProductSelected.Size = new System.Drawing.Size(0, 31);
            this.lbValueProductSelected.TabIndex = 35;
            // 
            // lbResultAmount
            // 
            this.lbResultAmount.AutoSize = true;
            this.lbResultAmount.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultAmount.Location = new System.Drawing.Point(626, 228);
            this.lbResultAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbResultAmount.Name = "lbResultAmount";
            this.lbResultAmount.Size = new System.Drawing.Size(116, 31);
            this.lbResultAmount.TabIndex = 36;
            this.lbResultAmount.Text = "Amount :";
            // 
            // lbValueAmount
            // 
            this.lbValueAmount.AutoSize = true;
            this.lbValueAmount.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValueAmount.Location = new System.Drawing.Point(762, 228);
            this.lbValueAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbValueAmount.Name = "lbValueAmount";
            this.lbValueAmount.Size = new System.Drawing.Size(0, 31);
            this.lbValueAmount.TabIndex = 37;
            // 
            // lbInterestRate
            // 
            this.lbInterestRate.AutoSize = true;
            this.lbInterestRate.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInterestRate.Location = new System.Drawing.Point(626, 357);
            this.lbInterestRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInterestRate.Name = "lbInterestRate";
            this.lbInterestRate.Size = new System.Drawing.Size(163, 31);
            this.lbInterestRate.TabIndex = 42;
            this.lbInterestRate.Text = "Interest rate :";
            // 
            // lbValueInterestRate
            // 
            this.lbValueInterestRate.AutoSize = true;
            this.lbValueInterestRate.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValueInterestRate.Location = new System.Drawing.Point(812, 357);
            this.lbValueInterestRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbValueInterestRate.Name = "lbValueInterestRate";
            this.lbValueInterestRate.Size = new System.Drawing.Size(0, 31);
            this.lbValueInterestRate.TabIndex = 43;
            // 
            // lbSettlementPrice
            // 
            this.lbSettlementPrice.AutoSize = true;
            this.lbSettlementPrice.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSettlementPrice.Location = new System.Drawing.Point(624, 429);
            this.lbSettlementPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSettlementPrice.Name = "lbSettlementPrice";
            this.lbSettlementPrice.Size = new System.Drawing.Size(214, 31);
            this.lbSettlementPrice.TabIndex = 44;
            this.lbSettlementPrice.Text = "Settlement price :";
            // 
            // lbValueSettlementPrice
            // 
            this.lbValueSettlementPrice.AutoSize = true;
            this.lbValueSettlementPrice.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValueSettlementPrice.Location = new System.Drawing.Point(862, 429);
            this.lbValueSettlementPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbValueSettlementPrice.Name = "lbValueSettlementPrice";
            this.lbValueSettlementPrice.Size = new System.Drawing.Size(0, 31);
            this.lbValueSettlementPrice.TabIndex = 45;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btSave.FlatAppearance.BorderSize = 0;
            this.btSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(180)))), ((int)(((byte)(237)))));
            this.btSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(249)))));
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.Color.Black;
            this.btSave.Location = new System.Drawing.Point(630, 500);
            this.btSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(477, 45);
            this.btSave.TabIndex = 46;
            this.btSave.TabStop = false;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btExecute
            // 
            this.btExecute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btExecute.FlatAppearance.BorderSize = 0;
            this.btExecute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(180)))), ((int)(((byte)(237)))));
            this.btExecute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(249)))));
            this.btExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExecute.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExecute.ForeColor = System.Drawing.Color.Black;
            this.btExecute.Location = new System.Drawing.Point(297, 642);
            this.btExecute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btExecute.Name = "btExecute";
            this.btExecute.Size = new System.Drawing.Size(200, 45);
            this.btExecute.TabIndex = 47;
            this.btExecute.TabStop = false;
            this.btExecute.Text = "Execute";
            this.btExecute.UseVisualStyleBackColor = false;
            this.btExecute.Click += new System.EventHandler(this.btExecute_Click);
            // 
            // lbValuePeriode
            // 
            this.lbValuePeriode.AutoSize = true;
            this.lbValuePeriode.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValuePeriode.Location = new System.Drawing.Point(764, 296);
            this.lbValuePeriode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbValuePeriode.Name = "lbValuePeriode";
            this.lbValuePeriode.Size = new System.Drawing.Size(0, 31);
            this.lbValuePeriode.TabIndex = 49;
            // 
            // lbPeriode
            // 
            this.lbPeriode.AutoSize = true;
            this.lbPeriode.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeriode.Location = new System.Drawing.Point(626, 296);
            this.lbPeriode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPeriode.Name = "lbPeriode";
            this.lbPeriode.Size = new System.Drawing.Size(117, 31);
            this.lbPeriode.TabIndex = 48;
            this.lbPeriode.Text = "Periode :";
            // 
            // lboxSimulation
            // 
            this.lboxSimulation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lboxSimulation.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lboxSimulation.FormattingEnabled = true;
            this.lboxSimulation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lboxSimulation.ItemHeight = 18;
            this.lboxSimulation.Location = new System.Drawing.Point(54, 520);
            this.lboxSimulation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lboxSimulation.Name = "lboxSimulation";
            this.lboxSimulation.Size = new System.Drawing.Size(442, 90);
            this.lboxSimulation.TabIndex = 50;
            this.lboxSimulation.SelectedIndexChanged += new System.EventHandler(this.lboxBoughtProduct_SelectedIndexChanged);
            // 
            // btSimulationChosen
            // 
            this.btSimulationChosen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btSimulationChosen.FlatAppearance.BorderSize = 0;
            this.btSimulationChosen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(180)))), ((int)(((byte)(237)))));
            this.btSimulationChosen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(249)))));
            this.btSimulationChosen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSimulationChosen.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSimulationChosen.ForeColor = System.Drawing.Color.Black;
            this.btSimulationChosen.Location = new System.Drawing.Point(296, 450);
            this.btSimulationChosen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSimulationChosen.Name = "btSimulationChosen";
            this.btSimulationChosen.Size = new System.Drawing.Size(200, 48);
            this.btSimulationChosen.TabIndex = 51;
            this.btSimulationChosen.TabStop = false;
            this.btSimulationChosen.Text = "Select";
            this.btSimulationChosen.UseVisualStyleBackColor = false;
            this.btSimulationChosen.Click += new System.EventHandler(this.btSimulationChosen_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btDelete.FlatAppearance.BorderSize = 0;
            this.btDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(180)))), ((int)(((byte)(237)))));
            this.btDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(249)))));
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.Color.Black;
            this.btDelete.Location = new System.Drawing.Point(54, 642);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(196, 45);
            this.btDelete.TabIndex = 52;
            this.btDelete.TabStop = false;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // exportPdf
            // 
            this.exportPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.exportPdf.FlatAppearance.BorderSize = 0;
            this.exportPdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(180)))), ((int)(((byte)(237)))));
            this.exportPdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(249)))));
            this.exportPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportPdf.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportPdf.ForeColor = System.Drawing.Color.Black;
            this.exportPdf.Location = new System.Drawing.Point(632, 642);
            this.exportPdf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exportPdf.Name = "exportPdf";
            this.exportPdf.Size = new System.Drawing.Size(149, 45);
            this.exportPdf.TabIndex = 53;
            this.exportPdf.TabStop = false;
            this.exportPdf.Text = "pdf";
            this.exportPdf.UseVisualStyleBackColor = false;
            this.exportPdf.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.75F);
            this.label1.Location = new System.Drawing.Point(626, 590);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 31);
            this.label1.TabIndex = 54;
            this.label1.Text = "Export all simulation as:";
            // 
            // exportXlsx
            // 
            this.exportXlsx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.exportXlsx.FlatAppearance.BorderSize = 0;
            this.exportXlsx.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(180)))), ((int)(((byte)(237)))));
            this.exportXlsx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(249)))));
            this.exportXlsx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportXlsx.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportXlsx.ForeColor = System.Drawing.Color.Black;
            this.exportXlsx.Location = new System.Drawing.Point(796, 642);
            this.exportXlsx.Margin = new System.Windows.Forms.Padding(4);
            this.exportXlsx.Name = "exportXlsx";
            this.exportXlsx.Size = new System.Drawing.Size(149, 45);
            this.exportXlsx.TabIndex = 55;
            this.exportXlsx.TabStop = false;
            this.exportXlsx.Text = "xlsx";
            this.exportXlsx.UseVisualStyleBackColor = false;
            // 
            // exportCsv
            // 
            this.exportCsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.exportCsv.FlatAppearance.BorderSize = 0;
            this.exportCsv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(180)))), ((int)(((byte)(237)))));
            this.exportCsv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(216)))), ((int)(((byte)(249)))));
            this.exportCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportCsv.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportCsv.ForeColor = System.Drawing.Color.Black;
            this.exportCsv.Location = new System.Drawing.Point(958, 642);
            this.exportCsv.Margin = new System.Windows.Forms.Padding(4);
            this.exportCsv.Name = "exportCsv";
            this.exportCsv.Size = new System.Drawing.Size(149, 45);
            this.exportCsv.TabIndex = 56;
            this.exportCsv.TabStop = false;
            this.exportCsv.Text = "csv";
            this.exportCsv.UseVisualStyleBackColor = false;
            this.exportCsv.Click += new System.EventHandler(this.exportCsv_Click);
            // 
            // UISimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.exportCsv);
            this.Controls.Add(this.exportXlsx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exportPdf);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btSimulationChosen);
            this.Controls.Add(this.lboxSimulation);
            this.Controls.Add(this.lbValuePeriode);
            this.Controls.Add(this.lbPeriode);
            this.Controls.Add(this.btExecute);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbValueSettlementPrice);
            this.Controls.Add(this.lbSettlementPrice);
            this.Controls.Add(this.lbValueInterestRate);
            this.Controls.Add(this.lbInterestRate);
            this.Controls.Add(this.lbValueAmount);
            this.Controls.Add(this.lbResultAmount);
            this.Controls.Add(this.lbValueProductSelected);
            this.Controls.Add(this.lbProductSelected);
            this.Controls.Add(this.btSimulate);
            this.Controls.Add(this.tbAmout);
            this.Controls.Add(this.lbAmout);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lbEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lbStartDate);
            this.Controls.Add(this.lbValueBalance);
            this.Controls.Add(this.lbBalance);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UISimulation";
            this.Size = new System.Drawing.Size(1236, 882);
            this.Load += new System.EventHandler(this.UISimulation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label lbValueBalance;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lbAmout;
        private System.Windows.Forms.TextBox tbAmout;
        private System.Windows.Forms.Button btSimulate;
        private System.Windows.Forms.Label lbProductSelected;
        private System.Windows.Forms.Label lbValueProductSelected;
        private System.Windows.Forms.Label lbResultAmount;
        private System.Windows.Forms.Label lbValueAmount;
        private System.Windows.Forms.Label lbInterestRate;
        private System.Windows.Forms.Label lbValueInterestRate;
        private System.Windows.Forms.Label lbSettlementPrice;
        private System.Windows.Forms.Label lbValueSettlementPrice;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btExecute;
        private System.Windows.Forms.Label lbValuePeriode;
        private System.Windows.Forms.Label lbPeriode;
        private System.Windows.Forms.ListBox lboxSimulation;
        private System.Windows.Forms.Button btSimulationChosen;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button exportPdf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exportXlsx;
        private System.Windows.Forms.Button exportCsv;
    }
}
