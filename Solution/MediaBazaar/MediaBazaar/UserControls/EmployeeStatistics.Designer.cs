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
            this.dtgvEmployeeStatistics = new System.Windows.Forms.DataGridView();
            this.C_EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Contract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_HourlyWage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_TotalSalaryPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_TotalSalaryPerWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_TotalSalaryPerMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_TotalSalaryPerYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ActualHoursPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ActualHoursPerWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ActualHoursPerMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ActualHoursPerYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ContractuaHoursPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ContractualHoursPerWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ContractulaHoursPerMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ContractualHoursPerYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ZeroHourContractAvgPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ZeroHourContractAvgPerWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ZeroHourContractAvgPerMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ZeroHourContractAvgPerYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEmpStat = new System.Windows.Forms.Label();
            this.dtDateStatistic = new System.Windows.Forms.DateTimePicker();
            this.tbcEmployeeStatistics = new System.Windows.Forms.TabControl();
            this.tbpAllEmployees = new System.Windows.Forms.TabPage();
            this.tbpSpecificEmployee = new System.Windows.Forms.TabPage();
            this.lblChooseAnEmployee = new System.Windows.Forms.Label();
            this.btnShowStatistics = new System.Windows.Forms.Button();
            this.lblPeriodOfTime = new System.Windows.Forms.Label();
            this.dtpTimePeriod = new System.Windows.Forms.DateTimePicker();
            this.txbEmployees = new System.Windows.Forms.TextBox();
            this.lbxEmployees = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployeeStatistics)).BeginInit();
            this.tbcEmployeeStatistics.SuspendLayout();
            this.tbpAllEmployees.SuspendLayout();
            this.tbpSpecificEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvEmployeeStatistics
            // 
            this.dtgvEmployeeStatistics.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtgvEmployeeStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmployeeStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_EmployeeID,
            this.C_EmployeeName,
            this.C_Position,
            this.C_Contract,
            this.C_Email,
            this.C_HourlyWage,
            this.C_TotalSalaryPerDay,
            this.C_TotalSalaryPerWeek,
            this.C_TotalSalaryPerMonth,
            this.C_TotalSalaryPerYear,
            this.C_ActualHoursPerDay,
            this.C_ActualHoursPerWeek,
            this.C_ActualHoursPerMonth,
            this.C_ActualHoursPerYear,
            this.C_ContractuaHoursPerDay,
            this.C_ContractualHoursPerWeek,
            this.C_ContractulaHoursPerMonth,
            this.C_ContractualHoursPerYear,
            this.C_ZeroHourContractAvgPerDay,
            this.C_ZeroHourContractAvgPerWeek,
            this.C_ZeroHourContractAvgPerMonth,
            this.C_ZeroHourContractAvgPerYear});
            this.dtgvEmployeeStatistics.GridColor = System.Drawing.SystemColors.InfoText;
            this.dtgvEmployeeStatistics.Location = new System.Drawing.Point(11, 58);
            this.dtgvEmployeeStatistics.Name = "dtgvEmployeeStatistics";
            this.dtgvEmployeeStatistics.ReadOnly = true;
            this.dtgvEmployeeStatistics.RowHeadersWidth = 51;
            this.dtgvEmployeeStatistics.RowTemplate.Height = 24;
            this.dtgvEmployeeStatistics.Size = new System.Drawing.Size(859, 420);
            this.dtgvEmployeeStatistics.StandardTab = true;
            this.dtgvEmployeeStatistics.TabIndex = 0;
            // 
            // C_EmployeeID
            // 
            this.C_EmployeeID.HeaderText = "Employee id";
            this.C_EmployeeID.MinimumWidth = 6;
            this.C_EmployeeID.Name = "C_EmployeeID";
            this.C_EmployeeID.ReadOnly = true;
            this.C_EmployeeID.Width = 125;
            // 
            // C_EmployeeName
            // 
            this.C_EmployeeName.HeaderText = "Employee name";
            this.C_EmployeeName.MinimumWidth = 6;
            this.C_EmployeeName.Name = "C_EmployeeName";
            this.C_EmployeeName.ReadOnly = true;
            this.C_EmployeeName.Width = 125;
            // 
            // C_Position
            // 
            this.C_Position.HeaderText = "Position";
            this.C_Position.MinimumWidth = 6;
            this.C_Position.Name = "C_Position";
            this.C_Position.ReadOnly = true;
            this.C_Position.Width = 125;
            // 
            // C_Contract
            // 
            this.C_Contract.HeaderText = "Contract";
            this.C_Contract.MinimumWidth = 6;
            this.C_Contract.Name = "C_Contract";
            this.C_Contract.ReadOnly = true;
            this.C_Contract.Width = 125;
            // 
            // C_Email
            // 
            this.C_Email.HeaderText = "E-mail";
            this.C_Email.MinimumWidth = 6;
            this.C_Email.Name = "C_Email";
            this.C_Email.ReadOnly = true;
            this.C_Email.Width = 125;
            // 
            // C_HourlyWage
            // 
            this.C_HourlyWage.HeaderText = "Hourly wage";
            this.C_HourlyWage.MinimumWidth = 6;
            this.C_HourlyWage.Name = "C_HourlyWage";
            this.C_HourlyWage.ReadOnly = true;
            this.C_HourlyWage.Width = 125;
            // 
            // C_TotalSalaryPerDay
            // 
            this.C_TotalSalaryPerDay.HeaderText = "Total salary per day";
            this.C_TotalSalaryPerDay.MinimumWidth = 6;
            this.C_TotalSalaryPerDay.Name = "C_TotalSalaryPerDay";
            this.C_TotalSalaryPerDay.ReadOnly = true;
            this.C_TotalSalaryPerDay.Width = 125;
            // 
            // C_TotalSalaryPerWeek
            // 
            this.C_TotalSalaryPerWeek.HeaderText = "Total salary per week";
            this.C_TotalSalaryPerWeek.MinimumWidth = 6;
            this.C_TotalSalaryPerWeek.Name = "C_TotalSalaryPerWeek";
            this.C_TotalSalaryPerWeek.ReadOnly = true;
            this.C_TotalSalaryPerWeek.Width = 125;
            // 
            // C_TotalSalaryPerMonth
            // 
            this.C_TotalSalaryPerMonth.HeaderText = "Total salary per month";
            this.C_TotalSalaryPerMonth.MinimumWidth = 6;
            this.C_TotalSalaryPerMonth.Name = "C_TotalSalaryPerMonth";
            this.C_TotalSalaryPerMonth.ReadOnly = true;
            this.C_TotalSalaryPerMonth.Width = 125;
            // 
            // C_TotalSalaryPerYear
            // 
            this.C_TotalSalaryPerYear.HeaderText = "Total salary per year";
            this.C_TotalSalaryPerYear.MinimumWidth = 6;
            this.C_TotalSalaryPerYear.Name = "C_TotalSalaryPerYear";
            this.C_TotalSalaryPerYear.ReadOnly = true;
            this.C_TotalSalaryPerYear.Width = 125;
            // 
            // C_ActualHoursPerDay
            // 
            this.C_ActualHoursPerDay.HeaderText = "Actual hours worked per day";
            this.C_ActualHoursPerDay.MinimumWidth = 6;
            this.C_ActualHoursPerDay.Name = "C_ActualHoursPerDay";
            this.C_ActualHoursPerDay.ReadOnly = true;
            this.C_ActualHoursPerDay.Width = 125;
            // 
            // C_ActualHoursPerWeek
            // 
            this.C_ActualHoursPerWeek.HeaderText = "Actual hours worked per week";
            this.C_ActualHoursPerWeek.MinimumWidth = 6;
            this.C_ActualHoursPerWeek.Name = "C_ActualHoursPerWeek";
            this.C_ActualHoursPerWeek.ReadOnly = true;
            this.C_ActualHoursPerWeek.Width = 125;
            // 
            // C_ActualHoursPerMonth
            // 
            this.C_ActualHoursPerMonth.HeaderText = "Actual hours worked per month";
            this.C_ActualHoursPerMonth.MinimumWidth = 6;
            this.C_ActualHoursPerMonth.Name = "C_ActualHoursPerMonth";
            this.C_ActualHoursPerMonth.ReadOnly = true;
            this.C_ActualHoursPerMonth.Width = 125;
            // 
            // C_ActualHoursPerYear
            // 
            this.C_ActualHoursPerYear.HeaderText = "Actual hours worked per year";
            this.C_ActualHoursPerYear.MinimumWidth = 6;
            this.C_ActualHoursPerYear.Name = "C_ActualHoursPerYear";
            this.C_ActualHoursPerYear.ReadOnly = true;
            this.C_ActualHoursPerYear.Width = 125;
            // 
            // C_ContractuaHoursPerDay
            // 
            this.C_ContractuaHoursPerDay.HeaderText = "Contractual hours per day (avg)";
            this.C_ContractuaHoursPerDay.MinimumWidth = 6;
            this.C_ContractuaHoursPerDay.Name = "C_ContractuaHoursPerDay";
            this.C_ContractuaHoursPerDay.ReadOnly = true;
            this.C_ContractuaHoursPerDay.Width = 125;
            // 
            // C_ContractualHoursPerWeek
            // 
            this.C_ContractualHoursPerWeek.HeaderText = "Contractual hours per week";
            this.C_ContractualHoursPerWeek.MinimumWidth = 6;
            this.C_ContractualHoursPerWeek.Name = "C_ContractualHoursPerWeek";
            this.C_ContractualHoursPerWeek.ReadOnly = true;
            this.C_ContractualHoursPerWeek.Width = 125;
            // 
            // C_ContractulaHoursPerMonth
            // 
            this.C_ContractulaHoursPerMonth.HeaderText = "Contractual hours per month";
            this.C_ContractulaHoursPerMonth.MinimumWidth = 6;
            this.C_ContractulaHoursPerMonth.Name = "C_ContractulaHoursPerMonth";
            this.C_ContractulaHoursPerMonth.ReadOnly = true;
            this.C_ContractulaHoursPerMonth.Width = 125;
            // 
            // C_ContractualHoursPerYear
            // 
            this.C_ContractualHoursPerYear.HeaderText = "Contractual hours per year";
            this.C_ContractualHoursPerYear.MinimumWidth = 6;
            this.C_ContractualHoursPerYear.Name = "C_ContractualHoursPerYear";
            this.C_ContractualHoursPerYear.ReadOnly = true;
            this.C_ContractualHoursPerYear.Width = 125;
            // 
            // C_ZeroHourContractAvgPerDay
            // 
            this.C_ZeroHourContractAvgPerDay.HeaderText = "Zero-hour contract avg per day";
            this.C_ZeroHourContractAvgPerDay.MinimumWidth = 6;
            this.C_ZeroHourContractAvgPerDay.Name = "C_ZeroHourContractAvgPerDay";
            this.C_ZeroHourContractAvgPerDay.ReadOnly = true;
            this.C_ZeroHourContractAvgPerDay.Width = 125;
            // 
            // C_ZeroHourContractAvgPerWeek
            // 
            this.C_ZeroHourContractAvgPerWeek.HeaderText = "Zero-hour contract avg per week";
            this.C_ZeroHourContractAvgPerWeek.MinimumWidth = 6;
            this.C_ZeroHourContractAvgPerWeek.Name = "C_ZeroHourContractAvgPerWeek";
            this.C_ZeroHourContractAvgPerWeek.ReadOnly = true;
            this.C_ZeroHourContractAvgPerWeek.Width = 125;
            // 
            // C_ZeroHourContractAvgPerMonth
            // 
            this.C_ZeroHourContractAvgPerMonth.HeaderText = "Zero-hour contract avg per month";
            this.C_ZeroHourContractAvgPerMonth.MinimumWidth = 6;
            this.C_ZeroHourContractAvgPerMonth.Name = "C_ZeroHourContractAvgPerMonth";
            this.C_ZeroHourContractAvgPerMonth.ReadOnly = true;
            this.C_ZeroHourContractAvgPerMonth.Width = 125;
            // 
            // C_ZeroHourContractAvgPerYear
            // 
            this.C_ZeroHourContractAvgPerYear.HeaderText = "Zero-hour contract avg per year";
            this.C_ZeroHourContractAvgPerYear.MinimumWidth = 6;
            this.C_ZeroHourContractAvgPerYear.Name = "C_ZeroHourContractAvgPerYear";
            this.C_ZeroHourContractAvgPerYear.ReadOnly = true;
            this.C_ZeroHourContractAvgPerYear.Width = 125;
            // 
            // lblEmpStat
            // 
            this.lblEmpStat.AutoSize = true;
            this.lblEmpStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmpStat.Location = new System.Drawing.Point(6, 18);
            this.lblEmpStat.Name = "lblEmpStat";
            this.lblEmpStat.Size = new System.Drawing.Size(213, 25);
            this.lblEmpStat.TabIndex = 2;
            this.lblEmpStat.Text = "Chosen period of time: ";
            // 
            // dtDateStatistic
            // 
            this.dtDateStatistic.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtDateStatistic.Location = new System.Drawing.Point(249, 20);
            this.dtDateStatistic.Name = "dtDateStatistic";
            this.dtDateStatistic.Size = new System.Drawing.Size(256, 24);
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
            this.tbcEmployeeStatistics.Size = new System.Drawing.Size(884, 508);
            this.tbcEmployeeStatistics.TabIndex = 4;
            // 
            // tbpAllEmployees
            // 
            this.tbpAllEmployees.Controls.Add(this.lblEmpStat);
            this.tbpAllEmployees.Controls.Add(this.dtgvEmployeeStatistics);
            this.tbpAllEmployees.Controls.Add(this.dtDateStatistic);
            this.tbpAllEmployees.Location = new System.Drawing.Point(4, 27);
            this.tbpAllEmployees.Name = "tbpAllEmployees";
            this.tbpAllEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAllEmployees.Size = new System.Drawing.Size(876, 477);
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
            // txbEmployees
            // 
            this.txbEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbEmployees.Location = new System.Drawing.Point(249, 87);
            this.txbEmployees.Name = "txbEmployees";
            this.txbEmployees.Size = new System.Drawing.Size(440, 27);
            this.txbEmployees.TabIndex = 12;
            this.txbEmployees.TextChanged += new System.EventHandler(this.txbEmployees_TextChanged);
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
            // EmployeeStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tbcEmployeeStatistics);
            this.Name = "EmployeeStatistics";
            this.Size = new System.Drawing.Size(890, 530);
            this.Load += new System.EventHandler(this.EmployeeStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployeeStatistics)).EndInit();
            this.tbcEmployeeStatistics.ResumeLayout(false);
            this.tbpAllEmployees.ResumeLayout(false);
            this.tbpAllEmployees.PerformLayout();
            this.tbpSpecificEmployee.ResumeLayout(false);
            this.tbpSpecificEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvEmployeeStatistics;
        private System.Windows.Forms.Label lblEmpStat;
        private System.Windows.Forms.DateTimePicker dtDateStatistic;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Contract;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_HourlyWage;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_TotalSalaryPerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_TotalSalaryPerWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_TotalSalaryPerMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_TotalSalaryPerYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ActualHoursPerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ActualHoursPerWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ActualHoursPerMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ActualHoursPerYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ContractuaHoursPerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ContractualHoursPerWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ContractulaHoursPerMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ContractualHoursPerYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ZeroHourContractAvgPerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ZeroHourContractAvgPerWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ZeroHourContractAvgPerMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ZeroHourContractAvgPerYear;
        private System.Windows.Forms.TabControl tbcEmployeeStatistics;
        private System.Windows.Forms.TabPage tbpAllEmployees;
        private System.Windows.Forms.TabPage tbpSpecificEmployee;
        private System.Windows.Forms.Button btnShowStatistics;
        private System.Windows.Forms.Label lblChooseAnEmployee;
        private System.Windows.Forms.Label lblPeriodOfTime;
        private System.Windows.Forms.DateTimePicker dtpTimePeriod;
        private System.Windows.Forms.TextBox txbEmployees;
        private System.Windows.Forms.ListBox lbxEmployees;
    }
}
