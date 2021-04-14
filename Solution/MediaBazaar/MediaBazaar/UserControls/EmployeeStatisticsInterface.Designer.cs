namespace MediaBazaar
{
    partial class EmployeeStatistics
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbcEmployeeStatistics = new System.Windows.Forms.TabControl();
            this.tbpAllEmployees = new System.Windows.Forms.TabPage();
            this.rbtnWeek = new System.Windows.Forms.RadioButton();
            this.cbbSortEmployees = new System.Windows.Forms.ComboBox();
            this.lblSortEmployees = new System.Windows.Forms.Label();
            this.rbtnMonth = new System.Windows.Forms.RadioButton();
            this.rbtnYear = new System.Windows.Forms.RadioButton();
            this.chartStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbbAllKindsOfStatistics = new System.Windows.Forms.ComboBox();
            this.dtDateStatistic = new System.Windows.Forms.DateTimePicker();
            this.lblEmpStat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpSpecificEmployee = new System.Windows.Forms.TabPage();
            this.lbxEmployees = new System.Windows.Forms.ListBox();
            this.txbEmployees = new System.Windows.Forms.TextBox();
            this.dtpTimePeriod = new System.Windows.Forms.DateTimePicker();
            this.lblPeriodOfTime = new System.Windows.Forms.Label();
            this.btnShowStatistics = new System.Windows.Forms.Button();
            this.lblChooseAnEmployee = new System.Windows.Forms.Label();
            this.btnShowStats = new System.Windows.Forms.Button();
            this.btnRemoveStats = new System.Windows.Forms.Button();
            this.lblChartTitle = new System.Windows.Forms.Label();
            this.tbcEmployeeStatistics.SuspendLayout();
            this.tbpAllEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics)).BeginInit();
            this.tbpSpecificEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcEmployeeStatistics
            // 
            this.tbcEmployeeStatistics.Controls.Add(this.tbpAllEmployees);
            this.tbcEmployeeStatistics.Controls.Add(this.tbpSpecificEmployee);
            this.tbcEmployeeStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbcEmployeeStatistics.Location = new System.Drawing.Point(3, 0);
            this.tbcEmployeeStatistics.Name = "tbcEmployeeStatistics";
            this.tbcEmployeeStatistics.SelectedIndex = 0;
            this.tbcEmployeeStatistics.Size = new System.Drawing.Size(1124, 782);
            this.tbcEmployeeStatistics.TabIndex = 4;
            // 
            // tbpAllEmployees
            // 
            this.tbpAllEmployees.Controls.Add(this.lblChartTitle);
            this.tbpAllEmployees.Controls.Add(this.btnRemoveStats);
            this.tbpAllEmployees.Controls.Add(this.btnShowStats);
            this.tbpAllEmployees.Controls.Add(this.rbtnWeek);
            this.tbpAllEmployees.Controls.Add(this.cbbSortEmployees);
            this.tbpAllEmployees.Controls.Add(this.lblSortEmployees);
            this.tbpAllEmployees.Controls.Add(this.rbtnMonth);
            this.tbpAllEmployees.Controls.Add(this.rbtnYear);
            this.tbpAllEmployees.Controls.Add(this.chartStatistics);
            this.tbpAllEmployees.Controls.Add(this.cbbAllKindsOfStatistics);
            this.tbpAllEmployees.Controls.Add(this.dtDateStatistic);
            this.tbpAllEmployees.Controls.Add(this.lblEmpStat);
            this.tbpAllEmployees.Controls.Add(this.label1);
            this.tbpAllEmployees.Location = new System.Drawing.Point(4, 27);
            this.tbpAllEmployees.Name = "tbpAllEmployees";
            this.tbpAllEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAllEmployees.Size = new System.Drawing.Size(1116, 751);
            this.tbpAllEmployees.TabIndex = 0;
            this.tbpAllEmployees.Text = " Overall statistics";
            this.tbpAllEmployees.UseVisualStyleBackColor = true;
            this.tbpAllEmployees.Click += new System.EventHandler(this.tbpAllEmployees_Click);
            // 
            // rbtnWeek
            // 
            this.rbtnWeek.AutoSize = true;
            this.rbtnWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnWeek.Location = new System.Drawing.Point(967, 34);
            this.rbtnWeek.Name = "rbtnWeek";
            this.rbtnWeek.Size = new System.Drawing.Size(72, 24);
            this.rbtnWeek.TabIndex = 25;
            this.rbtnWeek.TabStop = true;
            this.rbtnWeek.Text = "Week";
            this.rbtnWeek.UseVisualStyleBackColor = true;
            this.rbtnWeek.CheckedChanged += new System.EventHandler(this.rbtnWeek_CheckedChanged);
            // 
            // cbbSortEmployees
            // 
            this.cbbSortEmployees.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbbSortEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbbSortEmployees.Items.AddRange(new object[] {
            "Position",
            "Contract",
            "All employees"});
            this.cbbSortEmployees.Location = new System.Drawing.Point(271, 144);
            this.cbbSortEmployees.Name = "cbbSortEmployees";
            this.cbbSortEmployees.Size = new System.Drawing.Size(340, 28);
            this.cbbSortEmployees.TabIndex = 24;
            // 
            // lblSortEmployees
            // 
            this.lblSortEmployees.AutoSize = true;
            this.lblSortEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSortEmployees.Location = new System.Drawing.Point(34, 144);
            this.lblSortEmployees.Name = "lblSortEmployees";
            this.lblSortEmployees.Size = new System.Drawing.Size(181, 24);
            this.lblSortEmployees.TabIndex = 23;
            this.lblSortEmployees.Text = "Filter employees on:";
            // 
            // rbtnMonth
            // 
            this.rbtnMonth.AutoSize = true;
            this.rbtnMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnMonth.Location = new System.Drawing.Point(835, 34);
            this.rbtnMonth.Name = "rbtnMonth";
            this.rbtnMonth.Size = new System.Drawing.Size(76, 24);
            this.rbtnMonth.TabIndex = 22;
            this.rbtnMonth.Text = "Month";
            this.rbtnMonth.UseVisualStyleBackColor = true;
            this.rbtnMonth.CheckedChanged += new System.EventHandler(this.rbtnMonth_CheckedChanged);
            // 
            // rbtnYear
            // 
            this.rbtnYear.AutoSize = true;
            this.rbtnYear.Checked = true;
            this.rbtnYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnYear.Location = new System.Drawing.Point(712, 34);
            this.rbtnYear.Name = "rbtnYear";
            this.rbtnYear.Size = new System.Drawing.Size(64, 24);
            this.rbtnYear.TabIndex = 21;
            this.rbtnYear.TabStop = true;
            this.rbtnYear.Text = "Year";
            this.rbtnYear.UseVisualStyleBackColor = true;
            this.rbtnYear.CheckedChanged += new System.EventHandler(this.rbtnYear_CheckedChanged);
            // 
            // chartStatistics
            // 
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "ChartArea1";
            this.chartStatistics.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStatistics.Legends.Add(legend1);
            this.chartStatistics.Location = new System.Drawing.Point(2, 247);
            this.chartStatistics.Name = "chartStatistics";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Total salary";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Average salary";
            series3.ChartArea = "ChartArea1";
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Total hours worked";
            series4.ChartArea = "ChartArea1";
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Average hours worked";
            this.chartStatistics.Series.Add(series1);
            this.chartStatistics.Series.Add(series2);
            this.chartStatistics.Series.Add(series3);
            this.chartStatistics.Series.Add(series4);
            this.chartStatistics.Size = new System.Drawing.Size(1111, 406);
            this.chartStatistics.TabIndex = 20;
            this.chartStatistics.Text = "chart1";
            // 
            // cbbAllKindsOfStatistics
            // 
            this.cbbAllKindsOfStatistics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAllKindsOfStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbbAllKindsOfStatistics.FormattingEnabled = true;
            this.cbbAllKindsOfStatistics.Items.AddRange(new object[] {
            "Total salary",
            "Average salary",
            "Total hours worked",
            "Average hours worked"});
            this.cbbAllKindsOfStatistics.Location = new System.Drawing.Point(271, 87);
            this.cbbAllKindsOfStatistics.Name = "cbbAllKindsOfStatistics";
            this.cbbAllKindsOfStatistics.Size = new System.Drawing.Size(340, 28);
            this.cbbAllKindsOfStatistics.TabIndex = 19;
            this.cbbAllKindsOfStatistics.SelectedIndexChanged += new System.EventHandler(this.cbbAllKindsOfStatistics_SelectedIndexChanged);
            // 
            // dtDateStatistic
            // 
            this.dtDateStatistic.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtDateStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtDateStatistic.Location = new System.Drawing.Point(271, 31);
            this.dtDateStatistic.Name = "dtDateStatistic";
            this.dtDateStatistic.Size = new System.Drawing.Size(340, 27);
            this.dtDateStatistic.TabIndex = 17;
            this.dtDateStatistic.Value = new System.DateTime(2021, 3, 22, 12, 44, 54, 0);
            this.dtDateStatistic.ValueChanged += new System.EventHandler(this.dtDateStatistic_ValueChanged);
            // 
            // lblEmpStat
            // 
            this.lblEmpStat.AutoSize = true;
            this.lblEmpStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmpStat.Location = new System.Drawing.Point(34, 34);
            this.lblEmpStat.Name = "lblEmpStat";
            this.lblEmpStat.Size = new System.Drawing.Size(205, 24);
            this.lblEmpStat.TabIndex = 16;
            this.lblEmpStat.Text = "Chosen period of time: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Show statistics of: ";
            // 
            // tbpSpecificEmployee
            // 
            this.tbpSpecificEmployee.Controls.Add(this.lbxEmployees);
            this.tbpSpecificEmployee.Controls.Add(this.txbEmployees);
            this.tbpSpecificEmployee.Controls.Add(this.dtpTimePeriod);
            this.tbpSpecificEmployee.Controls.Add(this.lblPeriodOfTime);
            this.tbpSpecificEmployee.Controls.Add(this.btnShowStatistics);
            this.tbpSpecificEmployee.Controls.Add(this.lblChooseAnEmployee);
            this.tbpSpecificEmployee.Location = new System.Drawing.Point(4, 27);
            this.tbpSpecificEmployee.Name = "tbpSpecificEmployee";
            this.tbpSpecificEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSpecificEmployee.Size = new System.Drawing.Size(1116, 748);
            this.tbpSpecificEmployee.TabIndex = 1;
            this.tbpSpecificEmployee.Text = "Employee statistics";
            this.tbpSpecificEmployee.UseVisualStyleBackColor = true;
            // 
            // lbxEmployees
            // 
            this.lbxEmployees.FormattingEnabled = true;
            this.lbxEmployees.ItemHeight = 18;
            this.lbxEmployees.Location = new System.Drawing.Point(249, 138);
            this.lbxEmployees.Name = "lbxEmployees";
            this.lbxEmployees.Size = new System.Drawing.Size(440, 184);
            this.lbxEmployees.TabIndex = 13;
            // 
            // txbEmployees
            // 
            this.txbEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbEmployees.Location = new System.Drawing.Point(249, 87);
            this.txbEmployees.Name = "txbEmployees";
            this.txbEmployees.Size = new System.Drawing.Size(440, 27);
            this.txbEmployees.TabIndex = 12;
            this.txbEmployees.TextChanged += new System.EventHandler(this.txbEmployees_TextChanged);
            // 
            // dtpTimePeriod
            // 
            this.dtpTimePeriod.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpTimePeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpTimePeriod.Location = new System.Drawing.Point(249, 30);
            this.dtpTimePeriod.Name = "dtpTimePeriod";
            this.dtpTimePeriod.Size = new System.Drawing.Size(440, 27);
            this.dtpTimePeriod.TabIndex = 9;
            this.dtpTimePeriod.Value = new System.DateTime(2021, 3, 22, 12, 44, 54, 0);
            // 
            // lblPeriodOfTime
            // 
            this.lblPeriodOfTime.AutoSize = true;
            this.lblPeriodOfTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPeriodOfTime.Location = new System.Drawing.Point(26, 33);
            this.lblPeriodOfTime.Name = "lblPeriodOfTime";
            this.lblPeriodOfTime.Size = new System.Drawing.Size(205, 24);
            this.lblPeriodOfTime.TabIndex = 8;
            this.lblPeriodOfTime.Text = "Chosen period of time: ";
            // 
            // btnShowStatistics
            // 
            this.btnShowStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowStatistics.Location = new System.Drawing.Point(365, 385);
            this.btnShowStatistics.Name = "btnShowStatistics";
            this.btnShowStatistics.Size = new System.Drawing.Size(211, 35);
            this.btnShowStatistics.TabIndex = 2;
            this.btnShowStatistics.Text = "Show statistics";
            this.btnShowStatistics.UseVisualStyleBackColor = true;
            this.btnShowStatistics.Click += new System.EventHandler(this.btnShowStatistics_Click);
            // 
            // lblChooseAnEmployee
            // 
            this.lblChooseAnEmployee.AutoSize = true;
            this.lblChooseAnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChooseAnEmployee.Location = new System.Drawing.Point(26, 87);
            this.lblChooseAnEmployee.Name = "lblChooseAnEmployee";
            this.lblChooseAnEmployee.Size = new System.Drawing.Size(196, 24);
            this.lblChooseAnEmployee.TabIndex = 0;
            this.lblChooseAnEmployee.Text = "Choose an employee:";
            // 
            // btnShowStats
            // 
            this.btnShowStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowStats.Location = new System.Drawing.Point(100, 669);
            this.btnShowStats.Name = "btnShowStats";
            this.btnShowStats.Size = new System.Drawing.Size(340, 46);
            this.btnShowStats.TabIndex = 26;
            this.btnShowStats.Text = "Show statistics";
            this.btnShowStats.UseVisualStyleBackColor = true;
            this.btnShowStats.Click += new System.EventHandler(this.btnShowStats_Click);
            // 
            // btnRemoveStats
            // 
            this.btnRemoveStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveStats.Location = new System.Drawing.Point(571, 669);
            this.btnRemoveStats.Name = "btnRemoveStats";
            this.btnRemoveStats.Size = new System.Drawing.Size(340, 46);
            this.btnRemoveStats.TabIndex = 27;
            this.btnRemoveStats.Text = "Remove statistics";
            this.btnRemoveStats.UseVisualStyleBackColor = true;
            this.btnRemoveStats.Click += new System.EventHandler(this.btnRemoveStats_Click);
            // 
            // lblChartTitle
            // 
            this.lblChartTitle.AutoSize = true;
            this.lblChartTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChartTitle.Location = new System.Drawing.Point(96, 220);
            this.lblChartTitle.Name = "lblChartTitle";
            this.lblChartTitle.Size = new System.Drawing.Size(0, 24);
            this.lblChartTitle.TabIndex = 28;
            // 
            // EmployeeStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tbcEmployeeStatistics);
            this.Name = "EmployeeStatistics";
            this.Size = new System.Drawing.Size(1130, 785);
            this.Load += new System.EventHandler(this.EmployeeStatistics_Load);
            this.tbcEmployeeStatistics.ResumeLayout(false);
            this.tbpAllEmployees.ResumeLayout(false);
            this.tbpAllEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics)).EndInit();
            this.tbpSpecificEmployee.ResumeLayout(false);
            this.tbpSpecificEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbcEmployeeStatistics;
        private System.Windows.Forms.TabPage tbpAllEmployees;
        private System.Windows.Forms.TabPage tbpSpecificEmployee;
        private System.Windows.Forms.Button btnShowStatistics;
        private System.Windows.Forms.Label lblChooseAnEmployee;
        private System.Windows.Forms.Label lblPeriodOfTime;
        private System.Windows.Forms.DateTimePicker dtpTimePeriod;
        private System.Windows.Forms.TextBox txbEmployees;
        private System.Windows.Forms.ListBox lbxEmployees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmpStat;
        private System.Windows.Forms.DateTimePicker dtDateStatistic;
        private System.Windows.Forms.ComboBox cbbAllKindsOfStatistics;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistics;
        private System.Windows.Forms.RadioButton rbtnYear;
        private System.Windows.Forms.RadioButton rbtnMonth;
        private System.Windows.Forms.Label lblSortEmployees;
        private System.Windows.Forms.RadioButton rbtnWeek;
        private System.Windows.Forms.ComboBox cbbSortEmployees;
        private System.Windows.Forms.Button btnRemoveStats;
        private System.Windows.Forms.Button btnShowStats;
        private System.Windows.Forms.Label lblChartTitle;
    }
}
