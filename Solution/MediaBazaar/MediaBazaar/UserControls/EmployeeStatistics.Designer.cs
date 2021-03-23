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
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployeeStatistics)).BeginInit();
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
            this.dtgvEmployeeStatistics.Location = new System.Drawing.Point(0, 71);
            this.dtgvEmployeeStatistics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvEmployeeStatistics.Name = "dtgvEmployeeStatistics";
            this.dtgvEmployeeStatistics.ReadOnly = true;
            this.dtgvEmployeeStatistics.RowHeadersWidth = 51;
            this.dtgvEmployeeStatistics.RowTemplate.Height = 24;
            this.dtgvEmployeeStatistics.Size = new System.Drawing.Size(1001, 588);
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
            this.lblEmpStat.Location = new System.Drawing.Point(3, 15);
            this.lblEmpStat.Name = "lblEmpStat";
            this.lblEmpStat.Size = new System.Drawing.Size(262, 29);
            this.lblEmpStat.TabIndex = 2;
            this.lblEmpStat.Text = "Chosen period of time: ";
            // 
            // dtDateStatistic
            // 
            this.dtDateStatistic.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtDateStatistic.Location = new System.Drawing.Point(273, 18);
            this.dtDateStatistic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtDateStatistic.Name = "dtDateStatistic";
            this.dtDateStatistic.Size = new System.Drawing.Size(288, 26);
            this.dtDateStatistic.TabIndex = 3;
            this.dtDateStatistic.Value = new System.DateTime(2021, 3, 22, 12, 44, 54, 0);
            this.dtDateStatistic.ValueChanged += new System.EventHandler(this.dtDateStatistic_ValueChanged);
            // 
            // EmployeeStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dtDateStatistic);
            this.Controls.Add(this.lblEmpStat);
            this.Controls.Add(this.dtgvEmployeeStatistics);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmployeeStatistics";
            this.Size = new System.Drawing.Size(1001, 662);
            this.Load += new System.EventHandler(this.EmployeeStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployeeStatistics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
