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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblEmpStat = new System.Windows.Forms.Label();
            this.dtDateStatistic = new System.Windows.Forms.DateTimePicker();
            this.tbcEmployeeStatistics = new System.Windows.Forms.TabControl();
            this.tbpAllEmployees = new System.Windows.Forms.TabPage();
            this.tbpSpecificEmployee = new System.Windows.Forms.TabPage();
            this.lbxEmployees = new System.Windows.Forms.ListBox();
            this.txbEmployees = new System.Windows.Forms.TextBox();
            this.dtpTimePeriod = new System.Windows.Forms.DateTimePicker();
            this.lblPeriodOfTime = new System.Windows.Forms.Label();
            this.btnShowStatistics = new System.Windows.Forms.Button();
            this.lblChooseAnEmployee = new System.Windows.Forms.Label();
            this.chartStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblSortEmployees = new System.Windows.Forms.Label();
            this.cbbSortEmployees = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbShowStats = new System.Windows.Forms.ComboBox();
            this.rbtnYear = new System.Windows.Forms.RadioButton();
            this.rbtnMonth = new System.Windows.Forms.RadioButton();
            this.rbtnWeek = new System.Windows.Forms.RadioButton();
            this.chbOrderBy = new System.Windows.Forms.CheckBox();
            this.tbcEmployeeStatistics.SuspendLayout();
            this.tbpAllEmployees.SuspendLayout();
            this.tbpSpecificEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpStat
            // 
            this.lblEmpStat.AutoSize = true;
            this.lblEmpStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmpStat.Location = new System.Drawing.Point(563, 17);
            this.lblEmpStat.Name = "lblEmpStat";
            this.lblEmpStat.Size = new System.Drawing.Size(205, 24);
            this.lblEmpStat.TabIndex = 2;
            this.lblEmpStat.Text = "Chosen period of time: ";
            // 
            // dtDateStatistic
            // 
            this.dtDateStatistic.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtDateStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtDateStatistic.Location = new System.Drawing.Point(567, 49);
            this.dtDateStatistic.Name = "dtDateStatistic";
            this.dtDateStatistic.Size = new System.Drawing.Size(256, 27);
            this.dtDateStatistic.TabIndex = 3;
            this.dtDateStatistic.Value = new System.DateTime(2021, 3, 22, 12, 44, 54, 0);
            this.dtDateStatistic.ValueChanged += new System.EventHandler(this.dtDateStatistic_ValueChanged);
            // 
            // tbcEmployeeStatistics
            // 
            this.tbcEmployeeStatistics.Controls.Add(this.tbpAllEmployees);
            this.tbcEmployeeStatistics.Controls.Add(this.tbpSpecificEmployee);
            this.tbcEmployeeStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbcEmployeeStatistics.Location = new System.Drawing.Point(3, 3);
            this.tbcEmployeeStatistics.Name = "tbcEmployeeStatistics";
            this.tbcEmployeeStatistics.SelectedIndex = 0;
            this.tbcEmployeeStatistics.Size = new System.Drawing.Size(920, 508);
            this.tbcEmployeeStatistics.TabIndex = 4;
            // 
            // tbpAllEmployees
            // 
            this.tbpAllEmployees.Controls.Add(this.chbOrderBy);
            this.tbpAllEmployees.Controls.Add(this.rbtnYear);
            this.tbpAllEmployees.Controls.Add(this.rbtnWeek);
            this.tbpAllEmployees.Controls.Add(this.rbtnMonth);
            this.tbpAllEmployees.Controls.Add(this.cbbShowStats);
            this.tbpAllEmployees.Controls.Add(this.label1);
            this.tbpAllEmployees.Controls.Add(this.cbbSortEmployees);
            this.tbpAllEmployees.Controls.Add(this.lblSortEmployees);
            this.tbpAllEmployees.Controls.Add(this.chartStatistics);
            this.tbpAllEmployees.Controls.Add(this.lblEmpStat);
            this.tbpAllEmployees.Controls.Add(this.dtDateStatistic);
            this.tbpAllEmployees.Location = new System.Drawing.Point(4, 27);
            this.tbpAllEmployees.Name = "tbpAllEmployees";
            this.tbpAllEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAllEmployees.Size = new System.Drawing.Size(912, 477);
            this.tbpAllEmployees.TabIndex = 0;
            this.tbpAllEmployees.Text = " Overall statistics";
            this.tbpAllEmployees.UseVisualStyleBackColor = true;
            this.tbpAllEmployees.Click += new System.EventHandler(this.tbpAllEmployees_Click);
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
            this.tbpSpecificEmployee.Size = new System.Drawing.Size(876, 477);
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
            this.btnShowStatistics.Location = new System.Drawing.Point(322, 388);
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
            // chartStatistics
            // 
            chartArea5.Name = "ChartArea1";
            this.chartStatistics.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartStatistics.Legends.Add(legend5);
            this.chartStatistics.Location = new System.Drawing.Point(6, 82);
            this.chartStatistics.Name = "chartStatistics";
            series17.ChartArea = "ChartArea1";
            series17.Legend = "Legend1";
            series17.Name = "Total salary";
            series18.ChartArea = "ChartArea1";
            series18.Legend = "Legend1";
            series18.Name = "Average salary";
            series19.ChartArea = "ChartArea1";
            series19.Legend = "Legend1";
            series19.Name = "Total hours worked";
            series20.ChartArea = "ChartArea1";
            series20.Legend = "Legend1";
            series20.Name = "Average hours worked";
            this.chartStatistics.Series.Add(series17);
            this.chartStatistics.Series.Add(series18);
            this.chartStatistics.Series.Add(series19);
            this.chartStatistics.Series.Add(series20);
            this.chartStatistics.Size = new System.Drawing.Size(903, 348);
            this.chartStatistics.TabIndex = 4;
            this.chartStatistics.Text = "chart1";
            // 
            // lblSortEmployees
            // 
            this.lblSortEmployees.AutoSize = true;
            this.lblSortEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSortEmployees.Location = new System.Drawing.Point(6, 17);
            this.lblSortEmployees.Name = "lblSortEmployees";
            this.lblSortEmployees.Size = new System.Drawing.Size(173, 24);
            this.lblSortEmployees.TabIndex = 5;
            this.lblSortEmployees.Text = "Sort employees on:";
            // 
            // cbbSortEmployees
            // 
            this.cbbSortEmployees.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbbSortEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbbSortEmployees.Items.AddRange(new object[] {
            "Position",
            "Contract",
            "All employees"});
            this.cbbSortEmployees.Location = new System.Drawing.Point(10, 47);
            this.cbbSortEmployees.Name = "cbbSortEmployees";
            this.cbbSortEmployees.Size = new System.Drawing.Size(215, 28);
            this.cbbSortEmployees.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(275, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Show statistics of: ";
            // 
            // cbbShowStats
            // 
            this.cbbShowStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbbShowStats.Items.AddRange(new object[] {
            "Total salary",
            "Average salary",
            "Total hours worked",
            "Average hours worked"});
            this.cbbShowStats.Location = new System.Drawing.Point(279, 47);
            this.cbbShowStats.Name = "cbbShowStats";
            this.cbbShowStats.Size = new System.Drawing.Size(228, 28);
            this.cbbShowStats.TabIndex = 9;
            this.cbbShowStats.SelectedIndexChanged += new System.EventHandler(this.cbbShowStats_SelectedIndexChanged);
            // 
            // rbtnYear
            // 
            this.rbtnYear.AutoSize = true;
            this.rbtnYear.Checked = true;
            this.rbtnYear.Location = new System.Drawing.Point(709, 240);
            this.rbtnYear.Name = "rbtnYear";
            this.rbtnYear.Size = new System.Drawing.Size(59, 22);
            this.rbtnYear.TabIndex = 10;
            this.rbtnYear.TabStop = true;
            this.rbtnYear.Text = "Year";
            this.rbtnYear.UseVisualStyleBackColor = true;
            this.rbtnYear.CheckedChanged += new System.EventHandler(this.rbtnYear_CheckedChanged);
            // 
            // rbtnMonth
            // 
            this.rbtnMonth.AutoSize = true;
            this.rbtnMonth.Location = new System.Drawing.Point(709, 287);
            this.rbtnMonth.Name = "rbtnMonth";
            this.rbtnMonth.Size = new System.Drawing.Size(71, 22);
            this.rbtnMonth.TabIndex = 11;
            this.rbtnMonth.Text = "Month";
            this.rbtnMonth.UseVisualStyleBackColor = true;
            this.rbtnMonth.CheckedChanged += new System.EventHandler(this.rbtnMonth_CheckedChanged);
            // 
            // rbtnWeek
            // 
            this.rbtnWeek.AutoSize = true;
            this.rbtnWeek.Location = new System.Drawing.Point(709, 339);
            this.rbtnWeek.Name = "rbtnWeek";
            this.rbtnWeek.Size = new System.Drawing.Size(68, 22);
            this.rbtnWeek.TabIndex = 12;
            this.rbtnWeek.Text = "Week";
            this.rbtnWeek.UseVisualStyleBackColor = true;
            this.rbtnWeek.CheckedChanged += new System.EventHandler(this.rbtnWeek_CheckedChanged);
            // 
            // chbOrderBy
            // 
            this.chbOrderBy.AutoSize = true;
            this.chbOrderBy.Location = new System.Drawing.Point(709, 390);
            this.chbOrderBy.Name = "chbOrderBy";
            this.chbOrderBy.Size = new System.Drawing.Size(141, 40);
            this.chbOrderBy.TabIndex = 13;
            this.chbOrderBy.Text = "Order by \r\nhighest to lowest";
            this.chbOrderBy.UseVisualStyleBackColor = true;
            this.chbOrderBy.CheckedChanged += new System.EventHandler(this.chbOrderBy_CheckedChanged);
            // 
            // EmployeeStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tbcEmployeeStatistics);
            this.Name = "EmployeeStatistics";
            this.Size = new System.Drawing.Size(934, 530);
            this.Load += new System.EventHandler(this.EmployeeStatistics_Load);
            this.tbcEmployeeStatistics.ResumeLayout(false);
            this.tbpAllEmployees.ResumeLayout(false);
            this.tbpAllEmployees.PerformLayout();
            this.tbpSpecificEmployee.ResumeLayout(false);
            this.tbpSpecificEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblEmpStat;
        private System.Windows.Forms.DateTimePicker dtDateStatistic;
        private System.Windows.Forms.TabControl tbcEmployeeStatistics;
        private System.Windows.Forms.TabPage tbpAllEmployees;
        private System.Windows.Forms.TabPage tbpSpecificEmployee;
        private System.Windows.Forms.Button btnShowStatistics;
        private System.Windows.Forms.Label lblChooseAnEmployee;
        private System.Windows.Forms.Label lblPeriodOfTime;
        private System.Windows.Forms.DateTimePicker dtpTimePeriod;
        private System.Windows.Forms.TextBox txbEmployees;
        private System.Windows.Forms.ListBox lbxEmployees;
        private System.Windows.Forms.RadioButton rbtnWeek;
        private System.Windows.Forms.RadioButton rbtnMonth;
        private System.Windows.Forms.RadioButton rbtnYear;
        private System.Windows.Forms.ComboBox cbbShowStats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbSortEmployees;
        private System.Windows.Forms.Label lblSortEmployees;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistics;
        private System.Windows.Forms.CheckBox chbOrderBy;
    }
}
