﻿namespace MediaBazaar
{
    partial class DepartmentManagerEmployeeStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series31 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series32 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series33 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series34 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series35 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series36 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbcEmployeeStatistics = new System.Windows.Forms.TabControl();
            this.tbpAllEmployees = new System.Windows.Forms.TabPage();
            this.lblChartTitle = new System.Windows.Forms.Label();
            this.btnRemoveStats = new System.Windows.Forms.Button();
            this.btnShowStats = new System.Windows.Forms.Button();
            this.rbtnWeek = new System.Windows.Forms.RadioButton();
            this.rbtnMonth = new System.Windows.Forms.RadioButton();
            this.rbtnYear = new System.Windows.Forms.RadioButton();
            this.chartDepStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbbAllKindsOfStatistics = new System.Windows.Forms.ComboBox();
            this.dtDateStatistic = new System.Windows.Forms.DateTimePicker();
            this.lblEmpStat = new System.Windows.Forms.Label();
            this.lblShowFilteredStats = new System.Windows.Forms.Label();
            this.tbpSpecificEmployee = new System.Windows.Forms.TabPage();
            this.gbxDeptChart = new System.Windows.Forms.GroupBox();
            this.rdbtnDay = new System.Windows.Forms.RadioButton();
            this.rdbtnYear = new System.Windows.Forms.RadioButton();
            this.rdbtnWeek = new System.Windows.Forms.RadioButton();
            this.rdbtnMonth = new System.Windows.Forms.RadioButton();
            this.chartutilizationOfDeptEmployee = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbxDeptEmpInformation = new System.Windows.Forms.GroupBox();
            this.lblTotalSalaryPerYear = new System.Windows.Forms.Label();
            this.lblTotalSalaryPerDay = new System.Windows.Forms.Label();
            this.lblTotalSalaryPerWeek = new System.Windows.Forms.Label();
            this.lblTotalSalaryPerMonth = new System.Windows.Forms.Label();
            this.lblTotalSalary = new System.Windows.Forms.Label();
            this.lblEmpNames = new System.Windows.Forms.Label();
            this.lblNames = new System.Windows.Forms.Label();
            this.lblEmpHourlyWage = new System.Windows.Forms.Label();
            this.lblEmpContract = new System.Windows.Forms.Label();
            this.lblEmpPosition = new System.Windows.Forms.Label();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.lblHourlyWage = new System.Windows.Forms.Label();
            this.lblContract = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lbxDeptEmployees = new System.Windows.Forms.ListBox();
            this.txbDeptEmployees = new System.Windows.Forms.TextBox();
            this.dtpTimePeriod = new System.Windows.Forms.DateTimePicker();
            this.lblPeriodOfTime = new System.Windows.Forms.Label();
            this.btnShowStatistics = new System.Windows.Forms.Button();
            this.lblChooseAnEmployee = new System.Windows.Forms.Label();
            this.tbcEmployeeStatistics.SuspendLayout();
            this.tbpAllEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDepStatistics)).BeginInit();
            this.tbpSpecificEmployee.SuspendLayout();
            this.gbxDeptChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartutilizationOfDeptEmployee)).BeginInit();
            this.gbxDeptEmpInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcEmployeeStatistics
            // 
            this.tbcEmployeeStatistics.Controls.Add(this.tbpAllEmployees);
            this.tbcEmployeeStatistics.Controls.Add(this.tbpSpecificEmployee);
            this.tbcEmployeeStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbcEmployeeStatistics.Location = new System.Drawing.Point(3, 16);
            this.tbcEmployeeStatistics.Name = "tbcEmployeeStatistics";
            this.tbcEmployeeStatistics.SelectedIndex = 0;
            this.tbcEmployeeStatistics.Size = new System.Drawing.Size(1124, 767);
            this.tbcEmployeeStatistics.TabIndex = 5;
            // 
            // tbpAllEmployees
            // 
            this.tbpAllEmployees.Controls.Add(this.lblChartTitle);
            this.tbpAllEmployees.Controls.Add(this.btnRemoveStats);
            this.tbpAllEmployees.Controls.Add(this.btnShowStats);
            this.tbpAllEmployees.Controls.Add(this.rbtnWeek);
            this.tbpAllEmployees.Controls.Add(this.rbtnMonth);
            this.tbpAllEmployees.Controls.Add(this.rbtnYear);
            this.tbpAllEmployees.Controls.Add(this.chartDepStatistics);
            this.tbpAllEmployees.Controls.Add(this.cbbAllKindsOfStatistics);
            this.tbpAllEmployees.Controls.Add(this.dtDateStatistic);
            this.tbpAllEmployees.Controls.Add(this.lblEmpStat);
            this.tbpAllEmployees.Controls.Add(this.lblShowFilteredStats);
            this.tbpAllEmployees.Location = new System.Drawing.Point(4, 27);
            this.tbpAllEmployees.Name = "tbpAllEmployees";
            this.tbpAllEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAllEmployees.Size = new System.Drawing.Size(1116, 736);
            this.tbpAllEmployees.TabIndex = 0;
            this.tbpAllEmployees.Text = " Overall statistics";
            this.tbpAllEmployees.UseVisualStyleBackColor = true;
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
            // rbtnWeek
            // 
            this.rbtnWeek.AutoSize = true;
            this.rbtnWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnWeek.Location = new System.Drawing.Point(928, 31);
            this.rbtnWeek.Name = "rbtnWeek";
            this.rbtnWeek.Size = new System.Drawing.Size(72, 24);
            this.rbtnWeek.TabIndex = 25;
            this.rbtnWeek.TabStop = true;
            this.rbtnWeek.Text = "Week";
            this.rbtnWeek.UseVisualStyleBackColor = true;
            this.rbtnWeek.CheckedChanged += new System.EventHandler(this.rbtnWeek_CheckedChanged);
            // 
            // rbtnMonth
            // 
            this.rbtnMonth.AutoSize = true;
            this.rbtnMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnMonth.Location = new System.Drawing.Point(802, 31);
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
            this.rbtnYear.Location = new System.Drawing.Point(691, 31);
            this.rbtnYear.Name = "rbtnYear";
            this.rbtnYear.Size = new System.Drawing.Size(64, 24);
            this.rbtnYear.TabIndex = 21;
            this.rbtnYear.TabStop = true;
            this.rbtnYear.Text = "Year";
            this.rbtnYear.UseVisualStyleBackColor = true;
            this.rbtnYear.CheckedChanged += new System.EventHandler(this.rbtnYear_CheckedChanged);
            // 
            // chartDepStatistics
            // 
            chartArea11.IsSameFontSizeForAllAxes = true;
            chartArea11.Name = "ChartArea1";
            this.chartDepStatistics.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chartDepStatistics.Legends.Add(legend11);
            this.chartDepStatistics.Location = new System.Drawing.Point(2, 247);
            this.chartDepStatistics.Name = "chartDepStatistics";
            series31.ChartArea = "ChartArea1";
            series31.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series31.IsVisibleInLegend = false;
            series31.Legend = "Legend1";
            series31.Name = "Total salary";
            series32.ChartArea = "ChartArea1";
            series32.IsVisibleInLegend = false;
            series32.Legend = "Legend1";
            series32.Name = "Average salary";
            series33.ChartArea = "ChartArea1";
            series33.IsVisibleInLegend = false;
            series33.Legend = "Legend1";
            series33.Name = "Total hours worked";
            series34.ChartArea = "ChartArea1";
            series34.IsVisibleInLegend = false;
            series34.Legend = "Legend1";
            series34.Name = "Average hours worked";
            this.chartDepStatistics.Series.Add(series31);
            this.chartDepStatistics.Series.Add(series32);
            this.chartDepStatistics.Series.Add(series33);
            this.chartDepStatistics.Series.Add(series34);
            this.chartDepStatistics.Size = new System.Drawing.Size(1111, 406);
            this.chartDepStatistics.TabIndex = 20;
            this.chartDepStatistics.Text = "chart1";
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
            this.dtDateStatistic.Value = new System.DateTime(2021, 4, 15, 0, 0, 0, 0);
            this.dtDateStatistic.ValueChanged += new System.EventHandler(this.dtDateStatistic_ValueChanged);
            // 
            // lblEmpStat
            // 
            this.lblEmpStat.AutoSize = true;
            this.lblEmpStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmpStat.Location = new System.Drawing.Point(34, 34);
            this.lblEmpStat.Name = "lblEmpStat";
            this.lblEmpStat.Size = new System.Drawing.Size(122, 24);
            this.lblEmpStat.TabIndex = 16;
            this.lblEmpStat.Text = "Choose date:";
            // 
            // lblShowFilteredStats
            // 
            this.lblShowFilteredStats.AutoSize = true;
            this.lblShowFilteredStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblShowFilteredStats.Location = new System.Drawing.Point(34, 87);
            this.lblShowFilteredStats.Name = "lblShowFilteredStats";
            this.lblShowFilteredStats.Size = new System.Drawing.Size(160, 24);
            this.lblShowFilteredStats.TabIndex = 8;
            this.lblShowFilteredStats.Text = "Show statistics of: ";
            // 
            // tbpSpecificEmployee
            // 
            this.tbpSpecificEmployee.Controls.Add(this.gbxDeptChart);
            this.tbpSpecificEmployee.Controls.Add(this.gbxDeptEmpInformation);
            this.tbpSpecificEmployee.Controls.Add(this.lbxDeptEmployees);
            this.tbpSpecificEmployee.Controls.Add(this.txbDeptEmployees);
            this.tbpSpecificEmployee.Controls.Add(this.dtpTimePeriod);
            this.tbpSpecificEmployee.Controls.Add(this.lblPeriodOfTime);
            this.tbpSpecificEmployee.Controls.Add(this.btnShowStatistics);
            this.tbpSpecificEmployee.Controls.Add(this.lblChooseAnEmployee);
            this.tbpSpecificEmployee.Location = new System.Drawing.Point(4, 27);
            this.tbpSpecificEmployee.Name = "tbpSpecificEmployee";
            this.tbpSpecificEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSpecificEmployee.Size = new System.Drawing.Size(1116, 736);
            this.tbpSpecificEmployee.TabIndex = 1;
            this.tbpSpecificEmployee.Text = "Employee statistics";
            this.tbpSpecificEmployee.UseVisualStyleBackColor = true;
            // 
            // gbxDeptChart
            // 
            this.gbxDeptChart.BackColor = System.Drawing.Color.LightBlue;
            this.gbxDeptChart.Controls.Add(this.rdbtnDay);
            this.gbxDeptChart.Controls.Add(this.rdbtnYear);
            this.gbxDeptChart.Controls.Add(this.rdbtnWeek);
            this.gbxDeptChart.Controls.Add(this.rdbtnMonth);
            this.gbxDeptChart.Controls.Add(this.chartutilizationOfDeptEmployee);
            this.gbxDeptChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxDeptChart.Location = new System.Drawing.Point(400, 228);
            this.gbxDeptChart.Name = "gbxDeptChart";
            this.gbxDeptChart.Size = new System.Drawing.Size(688, 502);
            this.gbxDeptChart.TabIndex = 21;
            this.gbxDeptChart.TabStop = false;
            this.gbxDeptChart.Text = "Actual hours worked (in blue) vs. Contractual hours (in green)";
            // 
            // rdbtnDay
            // 
            this.rdbtnDay.AutoSize = true;
            this.rdbtnDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbtnDay.Location = new System.Drawing.Point(552, 309);
            this.rdbtnDay.Name = "rdbtnDay";
            this.rdbtnDay.Size = new System.Drawing.Size(60, 24);
            this.rdbtnDay.TabIndex = 19;
            this.rdbtnDay.Text = "Day";
            this.rdbtnDay.UseVisualStyleBackColor = true;
            this.rdbtnDay.CheckedChanged += new System.EventHandler(this.rdbtnDay_CheckedChanged);
            // 
            // rdbtnYear
            // 
            this.rdbtnYear.AutoSize = true;
            this.rdbtnYear.Checked = true;
            this.rdbtnYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbtnYear.Location = new System.Drawing.Point(552, 148);
            this.rdbtnYear.Name = "rdbtnYear";
            this.rdbtnYear.Size = new System.Drawing.Size(64, 24);
            this.rdbtnYear.TabIndex = 16;
            this.rdbtnYear.TabStop = true;
            this.rdbtnYear.Text = "Year";
            this.rdbtnYear.UseVisualStyleBackColor = true;
            this.rdbtnYear.CheckedChanged += new System.EventHandler(this.rdbtnYear_CheckedChanged);
            // 
            // rdbtnWeek
            // 
            this.rdbtnWeek.AutoSize = true;
            this.rdbtnWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbtnWeek.Location = new System.Drawing.Point(552, 253);
            this.rdbtnWeek.Name = "rdbtnWeek";
            this.rdbtnWeek.Size = new System.Drawing.Size(72, 24);
            this.rdbtnWeek.TabIndex = 18;
            this.rdbtnWeek.Text = "Week";
            this.rdbtnWeek.UseVisualStyleBackColor = true;
            this.rdbtnWeek.CheckedChanged += new System.EventHandler(this.rdbtnWeek_CheckedChanged);
            // 
            // rdbtnMonth
            // 
            this.rdbtnMonth.AutoSize = true;
            this.rdbtnMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbtnMonth.Location = new System.Drawing.Point(552, 200);
            this.rdbtnMonth.Name = "rdbtnMonth";
            this.rdbtnMonth.Size = new System.Drawing.Size(76, 24);
            this.rdbtnMonth.TabIndex = 17;
            this.rdbtnMonth.Text = "Month";
            this.rdbtnMonth.UseVisualStyleBackColor = true;
            this.rdbtnMonth.CheckedChanged += new System.EventHandler(this.rdbtnMonth_CheckedChanged);
            // 
            // chartutilizationOfDeptEmployee
            // 
            this.chartutilizationOfDeptEmployee.BackColor = System.Drawing.Color.Transparent;
            chartArea12.Name = "ChartArea1";
            this.chartutilizationOfDeptEmployee.ChartAreas.Add(chartArea12);
            legend12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend12.IsTextAutoFit = false;
            legend12.Name = "Legend1";
            this.chartutilizationOfDeptEmployee.Legends.Add(legend12);
            this.chartutilizationOfDeptEmployee.Location = new System.Drawing.Point(13, 40);
            this.chartutilizationOfDeptEmployee.Name = "chartutilizationOfDeptEmployee";
            this.chartutilizationOfDeptEmployee.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series35.ChartArea = "ChartArea1";
            series35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series35.Legend = "Legend1";
            series35.LegendText = "Actual hours worked";
            series35.Name = "Actual hours worked";
            series36.ChartArea = "ChartArea1";
            series36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series36.Legend = "Legend1";
            series36.LegendText = "Contractual hours";
            series36.Name = "Contractual hours";
            this.chartutilizationOfDeptEmployee.Series.Add(series35);
            this.chartutilizationOfDeptEmployee.Series.Add(series36);
            this.chartutilizationOfDeptEmployee.Size = new System.Drawing.Size(669, 462);
            this.chartutilizationOfDeptEmployee.TabIndex = 15;
            this.chartutilizationOfDeptEmployee.Text = "chart1";
            // 
            // gbxDeptEmpInformation
            // 
            this.gbxDeptEmpInformation.BackColor = System.Drawing.Color.LightBlue;
            this.gbxDeptEmpInformation.Controls.Add(this.lblTotalSalaryPerYear);
            this.gbxDeptEmpInformation.Controls.Add(this.lblTotalSalaryPerDay);
            this.gbxDeptEmpInformation.Controls.Add(this.lblTotalSalaryPerWeek);
            this.gbxDeptEmpInformation.Controls.Add(this.lblTotalSalaryPerMonth);
            this.gbxDeptEmpInformation.Controls.Add(this.lblTotalSalary);
            this.gbxDeptEmpInformation.Controls.Add(this.lblEmpNames);
            this.gbxDeptEmpInformation.Controls.Add(this.lblNames);
            this.gbxDeptEmpInformation.Controls.Add(this.lblEmpHourlyWage);
            this.gbxDeptEmpInformation.Controls.Add(this.lblEmpContract);
            this.gbxDeptEmpInformation.Controls.Add(this.lblEmpPosition);
            this.gbxDeptEmpInformation.Controls.Add(this.lblEmpId);
            this.gbxDeptEmpInformation.Controls.Add(this.lblHourlyWage);
            this.gbxDeptEmpInformation.Controls.Add(this.lblContract);
            this.gbxDeptEmpInformation.Controls.Add(this.lblPosition);
            this.gbxDeptEmpInformation.Controls.Add(this.lblid);
            this.gbxDeptEmpInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxDeptEmpInformation.Location = new System.Drawing.Point(28, 228);
            this.gbxDeptEmpInformation.Name = "gbxDeptEmpInformation";
            this.gbxDeptEmpInformation.Size = new System.Drawing.Size(366, 502);
            this.gbxDeptEmpInformation.TabIndex = 14;
            this.gbxDeptEmpInformation.TabStop = false;
            this.gbxDeptEmpInformation.Text = "Employee information";
            // 
            // lblTotalSalaryPerYear
            // 
            this.lblTotalSalaryPerYear.AutoSize = true;
            this.lblTotalSalaryPerYear.Location = new System.Drawing.Point(161, 393);
            this.lblTotalSalaryPerYear.Name = "lblTotalSalaryPerYear";
            this.lblTotalSalaryPerYear.Size = new System.Drawing.Size(99, 25);
            this.lblTotalSalaryPerYear.TabIndex = 14;
            this.lblTotalSalaryPerYear.Text = "0.00 /year";
            // 
            // lblTotalSalaryPerDay
            // 
            this.lblTotalSalaryPerDay.AutoSize = true;
            this.lblTotalSalaryPerDay.Location = new System.Drawing.Point(161, 269);
            this.lblTotalSalaryPerDay.Name = "lblTotalSalaryPerDay";
            this.lblTotalSalaryPerDay.Size = new System.Drawing.Size(93, 25);
            this.lblTotalSalaryPerDay.TabIndex = 13;
            this.lblTotalSalaryPerDay.Text = "0.00 /day";
            // 
            // lblTotalSalaryPerWeek
            // 
            this.lblTotalSalaryPerWeek.AutoSize = true;
            this.lblTotalSalaryPerWeek.Location = new System.Drawing.Point(161, 309);
            this.lblTotalSalaryPerWeek.Name = "lblTotalSalaryPerWeek";
            this.lblTotalSalaryPerWeek.Size = new System.Drawing.Size(107, 25);
            this.lblTotalSalaryPerWeek.TabIndex = 12;
            this.lblTotalSalaryPerWeek.Text = "0.00 /week";
            // 
            // lblTotalSalaryPerMonth
            // 
            this.lblTotalSalaryPerMonth.AutoSize = true;
            this.lblTotalSalaryPerMonth.Location = new System.Drawing.Point(161, 351);
            this.lblTotalSalaryPerMonth.Name = "lblTotalSalaryPerMonth";
            this.lblTotalSalaryPerMonth.Size = new System.Drawing.Size(115, 25);
            this.lblTotalSalaryPerMonth.TabIndex = 11;
            this.lblTotalSalaryPerMonth.Text = "0.00 /month";
            // 
            // lblTotalSalary
            // 
            this.lblTotalSalary.AutoSize = true;
            this.lblTotalSalary.Location = new System.Drawing.Point(16, 269);
            this.lblTotalSalary.Name = "lblTotalSalary";
            this.lblTotalSalary.Size = new System.Drawing.Size(119, 25);
            this.lblTotalSalary.TabIndex = 10;
            this.lblTotalSalary.Text = "Total salary:";
            // 
            // lblEmpNames
            // 
            this.lblEmpNames.AutoSize = true;
            this.lblEmpNames.Location = new System.Drawing.Point(161, 40);
            this.lblEmpNames.Name = "lblEmpNames";
            this.lblEmpNames.Size = new System.Drawing.Size(19, 25);
            this.lblEmpNames.TabIndex = 9;
            this.lblEmpNames.Text = "-";
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Location = new System.Drawing.Point(16, 40);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(94, 25);
            this.lblNames.TabIndex = 8;
            this.lblNames.Text = "Name(s):";
            // 
            // lblEmpHourlyWage
            // 
            this.lblEmpHourlyWage.AutoSize = true;
            this.lblEmpHourlyWage.Location = new System.Drawing.Point(161, 185);
            this.lblEmpHourlyWage.Name = "lblEmpHourlyWage";
            this.lblEmpHourlyWage.Size = new System.Drawing.Size(50, 25);
            this.lblEmpHourlyWage.TabIndex = 7;
            this.lblEmpHourlyWage.Text = "0.00";
            // 
            // lblEmpContract
            // 
            this.lblEmpContract.AutoSize = true;
            this.lblEmpContract.Location = new System.Drawing.Point(161, 148);
            this.lblEmpContract.Name = "lblEmpContract";
            this.lblEmpContract.Size = new System.Drawing.Size(19, 25);
            this.lblEmpContract.TabIndex = 6;
            this.lblEmpContract.Text = "-";
            // 
            // lblEmpPosition
            // 
            this.lblEmpPosition.AutoSize = true;
            this.lblEmpPosition.Location = new System.Drawing.Point(161, 113);
            this.lblEmpPosition.Name = "lblEmpPosition";
            this.lblEmpPosition.Size = new System.Drawing.Size(19, 25);
            this.lblEmpPosition.TabIndex = 5;
            this.lblEmpPosition.Text = "-";
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Location = new System.Drawing.Point(161, 77);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(19, 25);
            this.lblEmpId.TabIndex = 4;
            this.lblEmpId.Text = "-";
            // 
            // lblHourlyWage
            // 
            this.lblHourlyWage.AutoSize = true;
            this.lblHourlyWage.Location = new System.Drawing.Point(16, 185);
            this.lblHourlyWage.Name = "lblHourlyWage";
            this.lblHourlyWage.Size = new System.Drawing.Size(126, 25);
            this.lblHourlyWage.TabIndex = 3;
            this.lblHourlyWage.Text = "Hourly wage:";
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Location = new System.Drawing.Point(16, 148);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(92, 25);
            this.lblContract.TabIndex = 2;
            this.lblContract.Text = "Contract:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(16, 113);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(87, 25);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "Position:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(16, 77);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(34, 25);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "Id:";
            // 
            // lbxDeptEmployees
            // 
            this.lbxDeptEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxDeptEmployees.FormattingEnabled = true;
            this.lbxDeptEmployees.ItemHeight = 22;
            this.lbxDeptEmployees.Location = new System.Drawing.Point(764, 39);
            this.lbxDeptEmployees.Name = "lbxDeptEmployees";
            this.lbxDeptEmployees.Size = new System.Drawing.Size(318, 158);
            this.lbxDeptEmployees.TabIndex = 13;
            // 
            // txbDeptEmployees
            // 
            this.txbDeptEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbDeptEmployees.Location = new System.Drawing.Point(400, 53);
            this.txbDeptEmployees.Name = "txbDeptEmployees";
            this.txbDeptEmployees.Size = new System.Drawing.Size(299, 28);
            this.txbDeptEmployees.TabIndex = 12;
            this.txbDeptEmployees.TextChanged += new System.EventHandler(this.txbDeptEmployees_TextChanged);
            // 
            // dtpTimePeriod
            // 
            this.dtpTimePeriod.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpTimePeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpTimePeriod.Location = new System.Drawing.Point(40, 53);
            this.dtpTimePeriod.Name = "dtpTimePeriod";
            this.dtpTimePeriod.Size = new System.Drawing.Size(299, 28);
            this.dtpTimePeriod.TabIndex = 9;
            this.dtpTimePeriod.Value = new System.DateTime(2021, 3, 22, 12, 44, 54, 0);
            this.dtpTimePeriod.ValueChanged += new System.EventHandler(this.dtpTimePeriod_ValueChanged);
            // 
            // lblPeriodOfTime
            // 
            this.lblPeriodOfTime.AutoSize = true;
            this.lblPeriodOfTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPeriodOfTime.Location = new System.Drawing.Point(119, 26);
            this.lblPeriodOfTime.Name = "lblPeriodOfTime";
            this.lblPeriodOfTime.Size = new System.Drawing.Size(122, 24);
            this.lblPeriodOfTime.TabIndex = 8;
            this.lblPeriodOfTime.Text = "Choose date:";
            // 
            // btnShowStatistics
            // 
            this.btnShowStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowStatistics.Location = new System.Drawing.Point(447, 122);
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
            this.lblChooseAnEmployee.Location = new System.Drawing.Point(452, 26);
            this.lblChooseAnEmployee.Name = "lblChooseAnEmployee";
            this.lblChooseAnEmployee.Size = new System.Drawing.Size(196, 24);
            this.lblChooseAnEmployee.TabIndex = 0;
            this.lblChooseAnEmployee.Text = "Choose an employee:";
            // 
            // DepartmentManagerEmployeeStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbcEmployeeStatistics);
            this.Name = "DepartmentManagerEmployeeStatistics";
            this.Size = new System.Drawing.Size(1130, 785);
            this.Load += new System.EventHandler(this.DepartmentManagerEmployeeStatistics_Load);
            this.tbcEmployeeStatistics.ResumeLayout(false);
            this.tbpAllEmployees.ResumeLayout(false);
            this.tbpAllEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDepStatistics)).EndInit();
            this.tbpSpecificEmployee.ResumeLayout(false);
            this.tbpSpecificEmployee.PerformLayout();
            this.gbxDeptChart.ResumeLayout(false);
            this.gbxDeptChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartutilizationOfDeptEmployee)).EndInit();
            this.gbxDeptEmpInformation.ResumeLayout(false);
            this.gbxDeptEmpInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcEmployeeStatistics;
        private System.Windows.Forms.TabPage tbpAllEmployees;
        private System.Windows.Forms.Label lblChartTitle;
        private System.Windows.Forms.Button btnRemoveStats;
        private System.Windows.Forms.Button btnShowStats;
        private System.Windows.Forms.RadioButton rbtnWeek;
        private System.Windows.Forms.RadioButton rbtnMonth;
        private System.Windows.Forms.RadioButton rbtnYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDepStatistics;
        private System.Windows.Forms.ComboBox cbbAllKindsOfStatistics;
        private System.Windows.Forms.DateTimePicker dtDateStatistic;
        private System.Windows.Forms.Label lblEmpStat;
        private System.Windows.Forms.Label lblShowFilteredStats;
        private System.Windows.Forms.TabPage tbpSpecificEmployee;
        private System.Windows.Forms.GroupBox gbxDeptChart;
        private System.Windows.Forms.RadioButton rdbtnDay;
        private System.Windows.Forms.RadioButton rdbtnYear;
        private System.Windows.Forms.RadioButton rdbtnWeek;
        private System.Windows.Forms.RadioButton rdbtnMonth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartutilizationOfDeptEmployee;
        private System.Windows.Forms.GroupBox gbxDeptEmpInformation;
        private System.Windows.Forms.Label lblTotalSalaryPerYear;
        private System.Windows.Forms.Label lblTotalSalaryPerDay;
        private System.Windows.Forms.Label lblTotalSalaryPerWeek;
        private System.Windows.Forms.Label lblTotalSalaryPerMonth;
        private System.Windows.Forms.Label lblTotalSalary;
        private System.Windows.Forms.Label lblEmpNames;
        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.Label lblEmpHourlyWage;
        private System.Windows.Forms.Label lblEmpContract;
        private System.Windows.Forms.Label lblEmpPosition;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.Label lblHourlyWage;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.ListBox lbxDeptEmployees;
        private System.Windows.Forms.TextBox txbDeptEmployees;
        private System.Windows.Forms.DateTimePicker dtpTimePeriod;
        private System.Windows.Forms.Label lblPeriodOfTime;
        private System.Windows.Forms.Button btnShowStatistics;
        private System.Windows.Forms.Label lblChooseAnEmployee;
    }
}
