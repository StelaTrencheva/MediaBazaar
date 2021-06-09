
namespace MediaBazaar.UserControls
{
    partial class HolidayRequestsUC
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
            this.pnlHolidaysBackground = new System.Windows.Forms.Panel();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.gbRequestedHolidays = new System.Windows.Forms.GroupBox();
            this.rbSortByEmployee = new System.Windows.Forms.RadioButton();
            this.btnDenyHolidayRequest = new System.Windows.Forms.Button();
            this.rbSortByRequestedTime = new System.Windows.Forms.RadioButton();
            this.lbRequestedHolidays = new System.Windows.Forms.ListBox();
            this.gbRegisterNewHoliday = new System.Windows.Forms.GroupBox();
            this.btnRegisterNewHoliday = new System.Windows.Forms.Button();
            this.lblEmployeeBsn = new System.Windows.Forms.Label();
            this.tbEmployeeBSN = new System.Windows.Forms.TextBox();
            this.pnlHolidaysBackground.SuspendLayout();
            this.gbRequestedHolidays.SuspendLayout();
            this.gbRegisterNewHoliday.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHolidaysBackground
            // 
            this.pnlHolidaysBackground.BackColor = System.Drawing.Color.Azure;
            this.pnlHolidaysBackground.Controls.Add(this.dtpEndDate);
            this.pnlHolidaysBackground.Controls.Add(this.dtpStartDate);
            this.pnlHolidaysBackground.Controls.Add(this.lblEndDate);
            this.pnlHolidaysBackground.Controls.Add(this.lblStartDate);
            this.pnlHolidaysBackground.Controls.Add(this.gbRequestedHolidays);
            this.pnlHolidaysBackground.Controls.Add(this.gbRegisterNewHoliday);
            this.pnlHolidaysBackground.Location = new System.Drawing.Point(7, 7);
            this.pnlHolidaysBackground.Name = "pnlHolidaysBackground";
            this.pnlHolidaysBackground.Size = new System.Drawing.Size(1115, 771);
            this.pnlHolidaysBackground.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpEndDate.Location = new System.Drawing.Point(306, 627);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(290, 30);
            this.dtpEndDate.TabIndex = 94;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpStartDate.Location = new System.Drawing.Point(306, 543);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(290, 30);
            this.dtpStartDate.TabIndex = 93;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEndDate.Location = new System.Drawing.Point(63, 632);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(164, 25);
            this.lblEndDate.TabIndex = 90;
            this.lblEndDate.Text = "Holiday end date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStartDate.Location = new System.Drawing.Point(63, 548);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(168, 25);
            this.lblStartDate.TabIndex = 89;
            this.lblStartDate.Text = "Holiday start date:";
            // 
            // gbRequestedHolidays
            // 
            this.gbRequestedHolidays.Controls.Add(this.rbSortByEmployee);
            this.gbRequestedHolidays.Controls.Add(this.btnDenyHolidayRequest);
            this.gbRequestedHolidays.Controls.Add(this.rbSortByRequestedTime);
            this.gbRequestedHolidays.Controls.Add(this.lbRequestedHolidays);
            this.gbRequestedHolidays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbRequestedHolidays.Location = new System.Drawing.Point(41, 23);
            this.gbRequestedHolidays.Name = "gbRequestedHolidays";
            this.gbRequestedHolidays.Size = new System.Drawing.Size(1028, 334);
            this.gbRequestedHolidays.TabIndex = 104;
            this.gbRequestedHolidays.TabStop = false;
            this.gbRequestedHolidays.Text = "Requested Holidays";
            // 
            // rbSortByEmployee
            // 
            this.rbSortByEmployee.AutoSize = true;
            this.rbSortByEmployee.Location = new System.Drawing.Point(265, 37);
            this.rbSortByEmployee.Name = "rbSortByEmployee";
            this.rbSortByEmployee.Size = new System.Drawing.Size(159, 24);
            this.rbSortByEmployee.TabIndex = 98;
            this.rbSortByEmployee.TabStop = true;
            this.rbSortByEmployee.Text = "Sort by employee";
            this.rbSortByEmployee.UseVisualStyleBackColor = true;
            this.rbSortByEmployee.CheckedChanged += new System.EventHandler(this.rbSortByEmployee_CheckedChanged);
            // 
            // btnDenyHolidayRequest
            // 
            this.btnDenyHolidayRequest.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDenyHolidayRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDenyHolidayRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDenyHolidayRequest.Location = new System.Drawing.Point(809, 143);
            this.btnDenyHolidayRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDenyHolidayRequest.Name = "btnDenyHolidayRequest";
            this.btnDenyHolidayRequest.Size = new System.Drawing.Size(183, 80);
            this.btnDenyHolidayRequest.TabIndex = 99;
            this.btnDenyHolidayRequest.Text = "Deny holiday request";
            this.btnDenyHolidayRequest.UseVisualStyleBackColor = false;
            this.btnDenyHolidayRequest.Visible = false;
            this.btnDenyHolidayRequest.Click += new System.EventHandler(this.btnDenyHolidayRequest_Click);
            // 
            // rbSortByRequestedTime
            // 
            this.rbSortByRequestedTime.AutoSize = true;
            this.rbSortByRequestedTime.Location = new System.Drawing.Point(27, 37);
            this.rbSortByRequestedTime.Name = "rbSortByRequestedTime";
            this.rbSortByRequestedTime.Size = new System.Drawing.Size(199, 24);
            this.rbSortByRequestedTime.TabIndex = 96;
            this.rbSortByRequestedTime.TabStop = true;
            this.rbSortByRequestedTime.Text = "Sort by requested time";
            this.rbSortByRequestedTime.UseVisualStyleBackColor = true;
            this.rbSortByRequestedTime.CheckedChanged += new System.EventHandler(this.rbSortByRequestedTime_CheckedChanged);
            // 
            // lbRequestedHolidays
            // 
            this.lbRequestedHolidays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRequestedHolidays.FormattingEnabled = true;
            this.lbRequestedHolidays.ItemHeight = 20;
            this.lbRequestedHolidays.Location = new System.Drawing.Point(27, 78);
            this.lbRequestedHolidays.Name = "lbRequestedHolidays";
            this.lbRequestedHolidays.Size = new System.Drawing.Size(746, 224);
            this.lbRequestedHolidays.TabIndex = 97;
            this.lbRequestedHolidays.DoubleClick += new System.EventHandler(this.lbRequestedHolidays_DoubleClick);
            // 
            // gbRegisterNewHoliday
            // 
            this.gbRegisterNewHoliday.Controls.Add(this.btnRegisterNewHoliday);
            this.gbRegisterNewHoliday.Controls.Add(this.lblEmployeeBsn);
            this.gbRegisterNewHoliday.Controls.Add(this.tbEmployeeBSN);
            this.gbRegisterNewHoliday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbRegisterNewHoliday.Location = new System.Drawing.Point(41, 391);
            this.gbRegisterNewHoliday.Name = "gbRegisterNewHoliday";
            this.gbRegisterNewHoliday.Size = new System.Drawing.Size(1028, 320);
            this.gbRegisterNewHoliday.TabIndex = 103;
            this.gbRegisterNewHoliday.TabStop = false;
            this.gbRegisterNewHoliday.Text = "Register new holiday";
            // 
            // btnRegisterNewHoliday
            // 
            this.btnRegisterNewHoliday.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRegisterNewHoliday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterNewHoliday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegisterNewHoliday.Location = new System.Drawing.Point(809, 131);
            this.btnRegisterNewHoliday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegisterNewHoliday.Name = "btnRegisterNewHoliday";
            this.btnRegisterNewHoliday.Size = new System.Drawing.Size(183, 80);
            this.btnRegisterNewHoliday.TabIndex = 100;
            this.btnRegisterNewHoliday.Text = "Register new holiday";
            this.btnRegisterNewHoliday.UseVisualStyleBackColor = false;
            this.btnRegisterNewHoliday.Click += new System.EventHandler(this.btnRegisterNewHoliday_Click);
            // 
            // lblEmployeeBsn
            // 
            this.lblEmployeeBsn.AutoSize = true;
            this.lblEmployeeBsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmployeeBsn.Location = new System.Drawing.Point(22, 71);
            this.lblEmployeeBsn.Name = "lblEmployeeBsn";
            this.lblEmployeeBsn.Size = new System.Drawing.Size(151, 25);
            this.lblEmployeeBsn.TabIndex = 87;
            this.lblEmployeeBsn.Text = "Employee BSN:";
            // 
            // tbEmployeeBSN
            // 
            this.tbEmployeeBSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEmployeeBSN.Location = new System.Drawing.Point(265, 68);
            this.tbEmployeeBSN.Name = "tbEmployeeBSN";
            this.tbEmployeeBSN.Size = new System.Drawing.Size(290, 30);
            this.tbEmployeeBSN.TabIndex = 91;
            // 
            // HolidayRequestsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlHolidaysBackground);
            this.Name = "HolidayRequestsUC";
            this.Size = new System.Drawing.Size(1128, 785);
            this.pnlHolidaysBackground.ResumeLayout(false);
            this.pnlHolidaysBackground.PerformLayout();
            this.gbRequestedHolidays.ResumeLayout(false);
            this.gbRequestedHolidays.PerformLayout();
            this.gbRegisterNewHoliday.ResumeLayout(false);
            this.gbRegisterNewHoliday.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHolidaysBackground;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox tbEmployeeBSN;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEmployeeBsn;
        private System.Windows.Forms.RadioButton rbSortByRequestedTime;
        private System.Windows.Forms.ListBox lbRequestedHolidays;
        private System.Windows.Forms.RadioButton rbSortByEmployee;
        private System.Windows.Forms.Button btnDenyHolidayRequest;
        private System.Windows.Forms.GroupBox gbRequestedHolidays;
        private System.Windows.Forms.GroupBox gbRegisterNewHoliday;
        private System.Windows.Forms.Button btnRegisterNewHoliday;
    }
}
