
namespace MediaBazaar
{
    partial class StoreWorkerScheduleInterface
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbxAvailableStoreWorkers = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTodayDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLeftEmployeesNight = new System.Windows.Forms.Label();
            this.lbLeftEmployeesEvening = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.lbLeftEmployeesAfternoon = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbLeftEmployeesMorning = new System.Windows.Forms.Label();
            this.lbxAssignedEmployeesEvening = new System.Windows.Forms.ListBox();
            this.rbNightShift = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tpStoreWView = new System.Windows.Forms.TabPage();
            this.pnlDisplayEmployees = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbDisplayEmployees = new System.Windows.Forms.ListBox();
            this.lblAssignedEmployees = new System.Windows.Forms.Label();
            this.dgvViewShifts = new System.Windows.Forms.DataGridView();
            this.clMorning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAfternoon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEvening = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbWeek = new System.Windows.Forms.Label();
            this.calendarDate = new System.Windows.Forms.MonthCalendar();
            this.lblViewInstructions = new System.Windows.Forms.Label();
            this.btnShowShifts = new System.Windows.Forms.Button();
            this.pnlDisplayDate = new System.Windows.Forms.Panel();
            this.lblDisplayedDates = new System.Windows.Forms.Label();
            this.pnlChangeWeek = new System.Windows.Forms.Panel();
            this.btnChangeSelectedWeek = new System.Windows.Forms.Button();
            this.lbxAssignedEmployeesNight = new System.Windows.Forms.ListBox();
            this.lbxAssignedEmployeesMorning = new System.Windows.Forms.ListBox();
            this.tpStoreWAssign = new System.Windows.Forms.TabPage();
            this.gbAvailableEmployees = new System.Windows.Forms.GroupBox();
            this.gbChangeAssignableEmployees = new System.Windows.Forms.GroupBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.tbMaxEmployees = new System.Windows.Forms.TextBox();
            this.lbMaxEmplPerShift = new System.Windows.Forms.Label();
            this.cbxDay = new System.Windows.Forms.ComboBox();
            this.gbOverview = new System.Windows.Forms.GroupBox();
            this.rbAfternoonShift = new System.Windows.Forms.RadioButton();
            this.rbEveningShift = new System.Windows.Forms.RadioButton();
            this.rbMorningShift = new System.Windows.Forms.RadioButton();
            this.lbxAssignedEmployeesAfternoon = new System.Windows.Forms.ListBox();
            this.tcStoreWorkerSchedule = new System.Windows.Forms.TabControl();
            this.tpStoreWView.SuspendLayout();
            this.pnlDisplayEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewShifts)).BeginInit();
            this.pnlDisplayDate.SuspendLayout();
            this.pnlChangeWeek.SuspendLayout();
            this.tpStoreWAssign.SuspendLayout();
            this.gbAvailableEmployees.SuspendLayout();
            this.gbChangeAssignableEmployees.SuspendLayout();
            this.gbOverview.SuspendLayout();
            this.tcStoreWorkerSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxAvailableStoreWorkers
            // 
            this.lbxAvailableStoreWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxAvailableStoreWorkers.FormattingEnabled = true;
            this.lbxAvailableStoreWorkers.HorizontalScrollbar = true;
            this.lbxAvailableStoreWorkers.ItemHeight = 20;
            this.lbxAvailableStoreWorkers.Location = new System.Drawing.Point(11, 28);
            this.lbxAvailableStoreWorkers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxAvailableStoreWorkers.Name = "lbxAvailableStoreWorkers";
            this.lbxAvailableStoreWorkers.Size = new System.Drawing.Size(719, 124);
            this.lbxAvailableStoreWorkers.TabIndex = 5;
            this.lbxAvailableStoreWorkers.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbxAvailableStoreWorkers_DrawItem);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemove.Location = new System.Drawing.Point(877, 116);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(115, 54);
            this.btnRemove.TabIndex = 79;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cbMonth
            // 
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(101, 55);
            this.cbMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(375, 28);
            this.cbMonth.TabIndex = 84;
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 83;
            this.label2.Text = "Month:";
            // 
            // lbTodayDate
            // 
            this.lbTodayDate.AutoSize = true;
            this.lbTodayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTodayDate.Location = new System.Drawing.Point(161, 18);
            this.lbTodayDate.Name = "lbTodayDate";
            this.lbTodayDate.Size = new System.Drawing.Size(0, 20);
            this.lbTodayDate.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 81;
            this.label1.Text = "Today\'s date:";
            // 
            // lbLeftEmployeesNight
            // 
            this.lbLeftEmployeesNight.AutoSize = true;
            this.lbLeftEmployeesNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLeftEmployeesNight.Location = new System.Drawing.Point(445, 270);
            this.lbLeftEmployeesNight.Name = "lbLeftEmployeesNight";
            this.lbLeftEmployeesNight.Size = new System.Drawing.Size(0, 20);
            this.lbLeftEmployeesNight.TabIndex = 95;
            // 
            // lbLeftEmployeesEvening
            // 
            this.lbLeftEmployeesEvening.AutoSize = true;
            this.lbLeftEmployeesEvening.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLeftEmployeesEvening.Location = new System.Drawing.Point(445, 62);
            this.lbLeftEmployeesEvening.Name = "lbLeftEmployeesEvening";
            this.lbLeftEmployeesEvening.Size = new System.Drawing.Size(0, 20);
            this.lbLeftEmployeesEvening.TabIndex = 93;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(492, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(265, 20);
            this.label11.TabIndex = 94;
            this.label11.Text = "employees left to be assigned.";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(555, 58);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(44, 20);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "Day:";
            this.lblDay.Visible = false;
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAssign.Location = new System.Drawing.Point(877, 337);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(115, 54);
            this.btnAssign.TabIndex = 80;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // lbLeftEmployeesAfternoon
            // 
            this.lbLeftEmployeesAfternoon.AutoSize = true;
            this.lbLeftEmployeesAfternoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLeftEmployeesAfternoon.Location = new System.Drawing.Point(5, 270);
            this.lbLeftEmployeesAfternoon.Name = "lbLeftEmployeesAfternoon";
            this.lbLeftEmployeesAfternoon.Size = new System.Drawing.Size(0, 20);
            this.lbLeftEmployeesAfternoon.TabIndex = 90;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(509, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(265, 20);
            this.label9.TabIndex = 92;
            this.label9.Text = "employees left to be assigned.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(52, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(265, 20);
            this.label7.TabIndex = 89;
            this.label7.Text = "employees left to be assigned.";
            // 
            // lbLeftEmployeesMorning
            // 
            this.lbLeftEmployeesMorning.AutoSize = true;
            this.lbLeftEmployeesMorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLeftEmployeesMorning.Location = new System.Drawing.Point(5, 60);
            this.lbLeftEmployeesMorning.Name = "lbLeftEmployeesMorning";
            this.lbLeftEmployeesMorning.Size = new System.Drawing.Size(0, 20);
            this.lbLeftEmployeesMorning.TabIndex = 88;
            // 
            // lbxAssignedEmployeesEvening
            // 
            this.lbxAssignedEmployeesEvening.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxAssignedEmployeesEvening.FormattingEnabled = true;
            this.lbxAssignedEmployeesEvening.ItemHeight = 20;
            this.lbxAssignedEmployeesEvening.Location = new System.Drawing.Point(451, 92);
            this.lbxAssignedEmployeesEvening.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxAssignedEmployeesEvening.Name = "lbxAssignedEmployeesEvening";
            this.lbxAssignedEmployeesEvening.Size = new System.Drawing.Size(356, 104);
            this.lbxAssignedEmployeesEvening.TabIndex = 91;
            // 
            // rbNightShift
            // 
            this.rbNightShift.AutoSize = true;
            this.rbNightShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbNightShift.Location = new System.Drawing.Point(451, 238);
            this.rbNightShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNightShift.Name = "rbNightShift";
            this.rbNightShift.Size = new System.Drawing.Size(108, 24);
            this.rbNightShift.TabIndex = 89;
            this.rbNightShift.TabStop = true;
            this.rbNightShift.Text = "Night Shift";
            this.rbNightShift.UseVisualStyleBackColor = true;
            this.rbNightShift.CheckedChanged += new System.EventHandler(this.rbNightShift_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(52, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 20);
            this.label4.TabIndex = 87;
            this.label4.Text = "employees left to be assigned.";
            // 
            // tpStoreWView
            // 
            this.tpStoreWView.BackColor = System.Drawing.Color.Azure;
            this.tpStoreWView.Controls.Add(this.pnlDisplayEmployees);
            this.tpStoreWView.Controls.Add(this.dgvViewShifts);
            this.tpStoreWView.Controls.Add(this.lbWeek);
            this.tpStoreWView.Controls.Add(this.calendarDate);
            this.tpStoreWView.Controls.Add(this.lblViewInstructions);
            this.tpStoreWView.Controls.Add(this.btnShowShifts);
            this.tpStoreWView.Controls.Add(this.pnlDisplayDate);
            this.tpStoreWView.Location = new System.Drawing.Point(4, 34);
            this.tpStoreWView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpStoreWView.Name = "tpStoreWView";
            this.tpStoreWView.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpStoreWView.Size = new System.Drawing.Size(1115, 771);
            this.tpStoreWView.TabIndex = 1;
            this.tpStoreWView.Text = "View";
            // 
            // pnlDisplayEmployees
            // 
            this.pnlDisplayEmployees.Controls.Add(this.btnClose);
            this.pnlDisplayEmployees.Controls.Add(this.lbDisplayEmployees);
            this.pnlDisplayEmployees.Controls.Add(this.lblAssignedEmployees);
            this.pnlDisplayEmployees.Location = new System.Drawing.Point(305, 184);
            this.pnlDisplayEmployees.Name = "pnlDisplayEmployees";
            this.pnlDisplayEmployees.Size = new System.Drawing.Size(558, 404);
            this.pnlDisplayEmployees.TabIndex = 98;
            this.pnlDisplayEmployees.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnClose.Location = new System.Drawing.Point(466, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 46);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbDisplayEmployees
            // 
            this.lbDisplayEmployees.FormattingEnabled = true;
            this.lbDisplayEmployees.ItemHeight = 25;
            this.lbDisplayEmployees.Location = new System.Drawing.Point(20, 78);
            this.lbDisplayEmployees.Name = "lbDisplayEmployees";
            this.lbDisplayEmployees.Size = new System.Drawing.Size(521, 304);
            this.lbDisplayEmployees.TabIndex = 1;
            // 
            // lblAssignedEmployees
            // 
            this.lblAssignedEmployees.AutoSize = true;
            this.lblAssignedEmployees.Location = new System.Drawing.Point(180, 26);
            this.lblAssignedEmployees.Name = "lblAssignedEmployees";
            this.lblAssignedEmployees.Size = new System.Drawing.Size(196, 25);
            this.lblAssignedEmployees.TabIndex = 0;
            this.lblAssignedEmployees.Text = "Assigned Employees";
            // 
            // dgvViewShifts
            // 
            this.dgvViewShifts.AllowUserToAddRows = false;
            this.dgvViewShifts.AllowUserToDeleteRows = false;
            this.dgvViewShifts.AllowUserToResizeColumns = false;
            this.dgvViewShifts.AllowUserToResizeRows = false;
            this.dgvViewShifts.BackgroundColor = System.Drawing.Color.White;
            this.dgvViewShifts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewShifts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvViewShifts.ColumnHeadersHeight = 50;
            this.dgvViewShifts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMorning,
            this.clAfternoon,
            this.clEvening,
            this.clNight});
            this.dgvViewShifts.GridColor = System.Drawing.Color.White;
            this.dgvViewShifts.Location = new System.Drawing.Point(6, 98);
            this.dgvViewShifts.Name = "dgvViewShifts";
            this.dgvViewShifts.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewShifts.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvViewShifts.RowHeadersWidth = 150;
            this.dgvViewShifts.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvViewShifts.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvViewShifts.RowTemplate.DefaultCellStyle.NullValue = "0 emp. assigned";
            this.dgvViewShifts.RowTemplate.Height = 60;
            this.dgvViewShifts.RowTemplate.ReadOnly = true;
            this.dgvViewShifts.Size = new System.Drawing.Size(1103, 668);
            this.dgvViewShifts.TabIndex = 11;
            this.dgvViewShifts.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // clMorning
            // 
            this.clMorning.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMorning.HeaderText = "Morning";
            this.clMorning.MinimumWidth = 6;
            this.clMorning.Name = "clMorning";
            this.clMorning.ReadOnly = true;
            // 
            // clAfternoon
            // 
            this.clAfternoon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clAfternoon.HeaderText = "Afternoon";
            this.clAfternoon.MinimumWidth = 6;
            this.clAfternoon.Name = "clAfternoon";
            this.clAfternoon.ReadOnly = true;
            // 
            // clEvening
            // 
            this.clEvening.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clEvening.HeaderText = "Evening";
            this.clEvening.MinimumWidth = 6;
            this.clEvening.Name = "clEvening";
            this.clEvening.ReadOnly = true;
            // 
            // clNight
            // 
            this.clNight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clNight.HeaderText = "Night";
            this.clNight.MinimumWidth = 6;
            this.clNight.Name = "clNight";
            this.clNight.ReadOnly = true;
            // 
            // lbWeek
            // 
            this.lbWeek.AutoSize = true;
            this.lbWeek.Location = new System.Drawing.Point(285, 46);
            this.lbWeek.Name = "lbWeek";
            this.lbWeek.Size = new System.Drawing.Size(0, 25);
            this.lbWeek.TabIndex = 96;
            // 
            // calendarDate
            // 
            this.calendarDate.Location = new System.Drawing.Point(360, 135);
            this.calendarDate.Name = "calendarDate";
            this.calendarDate.TabIndex = 95;
            // 
            // lblViewInstructions
            // 
            this.lblViewInstructions.AutoSize = true;
            this.lblViewInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewInstructions.Location = new System.Drawing.Point(249, 402);
            this.lblViewInstructions.Name = "lblViewInstructions";
            this.lblViewInstructions.Size = new System.Drawing.Size(513, 20);
            this.lblViewInstructions.TabIndex = 92;
            this.lblViewInstructions.Text = "Select a date and the shifts assigned for the week will be displayed:";
            // 
            // btnShowShifts
            // 
            this.btnShowShifts.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnShowShifts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowShifts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowShifts.Location = new System.Drawing.Point(441, 470);
            this.btnShowShifts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowShifts.Name = "btnShowShifts";
            this.btnShowShifts.Size = new System.Drawing.Size(115, 43);
            this.btnShowShifts.TabIndex = 91;
            this.btnShowShifts.Text = "Show";
            this.btnShowShifts.UseVisualStyleBackColor = false;
            this.btnShowShifts.Click += new System.EventHandler(this.btnShowShifts_Click);
            // 
            // pnlDisplayDate
            // 
            this.pnlDisplayDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDisplayDate.Controls.Add(this.lblDisplayedDates);
            this.pnlDisplayDate.Controls.Add(this.pnlChangeWeek);
            this.pnlDisplayDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDisplayDate.Location = new System.Drawing.Point(3, 2);
            this.pnlDisplayDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDisplayDate.Name = "pnlDisplayDate";
            this.pnlDisplayDate.Size = new System.Drawing.Size(1109, 91);
            this.pnlDisplayDate.TabIndex = 97;
            // 
            // lblDisplayedDates
            // 
            this.lblDisplayedDates.AutoSize = true;
            this.lblDisplayedDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDisplayedDates.Location = new System.Drawing.Point(33, 25);
            this.lblDisplayedDates.Name = "lblDisplayedDates";
            this.lblDisplayedDates.Size = new System.Drawing.Size(103, 38);
            this.lblDisplayedDates.TabIndex = 1;
            this.lblDisplayedDates.Text = "label3";
            // 
            // pnlChangeWeek
            // 
            this.pnlChangeWeek.Controls.Add(this.btnChangeSelectedWeek);
            this.pnlChangeWeek.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlChangeWeek.Location = new System.Drawing.Point(830, 0);
            this.pnlChangeWeek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlChangeWeek.Name = "pnlChangeWeek";
            this.pnlChangeWeek.Size = new System.Drawing.Size(277, 89);
            this.pnlChangeWeek.TabIndex = 0;
            // 
            // btnChangeSelectedWeek
            // 
            this.btnChangeSelectedWeek.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnChangeSelectedWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeSelectedWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeSelectedWeek.Location = new System.Drawing.Point(17, 25);
            this.btnChangeSelectedWeek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangeSelectedWeek.Name = "btnChangeSelectedWeek";
            this.btnChangeSelectedWeek.Size = new System.Drawing.Size(240, 43);
            this.btnChangeSelectedWeek.TabIndex = 94;
            this.btnChangeSelectedWeek.Text = "Change week";
            this.btnChangeSelectedWeek.UseVisualStyleBackColor = false;
            this.btnChangeSelectedWeek.Click += new System.EventHandler(this.btnChangeSelectedWeek_Click);
            // 
            // lbxAssignedEmployeesNight
            // 
            this.lbxAssignedEmployeesNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxAssignedEmployeesNight.FormattingEnabled = true;
            this.lbxAssignedEmployeesNight.ItemHeight = 20;
            this.lbxAssignedEmployeesNight.Location = new System.Drawing.Point(451, 300);
            this.lbxAssignedEmployeesNight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxAssignedEmployeesNight.Name = "lbxAssignedEmployeesNight";
            this.lbxAssignedEmployeesNight.Size = new System.Drawing.Size(356, 104);
            this.lbxAssignedEmployeesNight.TabIndex = 92;
            // 
            // lbxAssignedEmployeesMorning
            // 
            this.lbxAssignedEmployeesMorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxAssignedEmployeesMorning.FormattingEnabled = true;
            this.lbxAssignedEmployeesMorning.ItemHeight = 20;
            this.lbxAssignedEmployeesMorning.Location = new System.Drawing.Point(12, 92);
            this.lbxAssignedEmployeesMorning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxAssignedEmployeesMorning.Name = "lbxAssignedEmployeesMorning";
            this.lbxAssignedEmployeesMorning.Size = new System.Drawing.Size(356, 104);
            this.lbxAssignedEmployeesMorning.TabIndex = 85;
            // 
            // tpStoreWAssign
            // 
            this.tpStoreWAssign.BackColor = System.Drawing.Color.Azure;
            this.tpStoreWAssign.Controls.Add(this.gbAvailableEmployees);
            this.tpStoreWAssign.Controls.Add(this.gbChangeAssignableEmployees);
            this.tpStoreWAssign.Controls.Add(this.cbMonth);
            this.tpStoreWAssign.Controls.Add(this.label2);
            this.tpStoreWAssign.Controls.Add(this.lbTodayDate);
            this.tpStoreWAssign.Controls.Add(this.label1);
            this.tpStoreWAssign.Controls.Add(this.cbxDay);
            this.tpStoreWAssign.Controls.Add(this.lblDay);
            this.tpStoreWAssign.Controls.Add(this.gbOverview);
            this.tpStoreWAssign.Location = new System.Drawing.Point(4, 34);
            this.tpStoreWAssign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpStoreWAssign.Name = "tpStoreWAssign";
            this.tpStoreWAssign.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpStoreWAssign.Size = new System.Drawing.Size(1115, 771);
            this.tpStoreWAssign.TabIndex = 0;
            this.tpStoreWAssign.Text = "Assign";
            // 
            // gbAvailableEmployees
            // 
            this.gbAvailableEmployees.Controls.Add(this.lbxAvailableStoreWorkers);
            this.gbAvailableEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbAvailableEmployees.Location = new System.Drawing.Point(21, 534);
            this.gbAvailableEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAvailableEmployees.Name = "gbAvailableEmployees";
            this.gbAvailableEmployees.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAvailableEmployees.Size = new System.Drawing.Size(739, 207);
            this.gbAvailableEmployees.TabIndex = 95;
            this.gbAvailableEmployees.TabStop = false;
            this.gbAvailableEmployees.Text = "Available Employees:";
            this.gbAvailableEmployees.Visible = false;
            // 
            // gbChangeAssignableEmployees
            // 
            this.gbChangeAssignableEmployees.Controls.Add(this.btnChange);
            this.gbChangeAssignableEmployees.Controls.Add(this.tbMaxEmployees);
            this.gbChangeAssignableEmployees.Controls.Add(this.lbMaxEmplPerShift);
            this.gbChangeAssignableEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbChangeAssignableEmployees.Location = new System.Drawing.Point(763, 534);
            this.gbChangeAssignableEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbChangeAssignableEmployees.Name = "gbChangeAssignableEmployees";
            this.gbChangeAssignableEmployees.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbChangeAssignableEmployees.Size = new System.Drawing.Size(339, 207);
            this.gbChangeAssignableEmployees.TabIndex = 94;
            this.gbChangeAssignableEmployees.TabStop = false;
            this.gbChangeAssignableEmployees.Visible = false;
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChange.Location = new System.Drawing.Point(84, 132);
            this.btnChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(175, 50);
            this.btnChange.TabIndex = 95;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click_1);
            // 
            // tbMaxEmployees
            // 
            this.tbMaxEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMaxEmployees.Location = new System.Drawing.Point(97, 84);
            this.tbMaxEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMaxEmployees.Name = "tbMaxEmployees";
            this.tbMaxEmployees.Size = new System.Drawing.Size(145, 27);
            this.tbMaxEmployees.TabIndex = 94;
            // 
            // lbMaxEmplPerShift
            // 
            this.lbMaxEmplPerShift.AutoSize = true;
            this.lbMaxEmplPerShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMaxEmplPerShift.Location = new System.Drawing.Point(52, 41);
            this.lbMaxEmplPerShift.Name = "lbMaxEmplPerShift";
            this.lbMaxEmplPerShift.Size = new System.Drawing.Size(237, 20);
            this.lbMaxEmplPerShift.TabIndex = 93;
            this.lbMaxEmplPerShift.Text = "Maximum employees per shift:";
            // 
            // cbxDay
            // 
            this.cbxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxDay.FormattingEnabled = true;
            this.cbxDay.Location = new System.Drawing.Point(653, 55);
            this.cbxDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxDay.Name = "cbxDay";
            this.cbxDay.Size = new System.Drawing.Size(375, 28);
            this.cbxDay.TabIndex = 2;
            this.cbxDay.Visible = false;
            this.cbxDay.SelectedIndexChanged += new System.EventHandler(this.cbxDay_SelectedIndexChanged);
            // 
            // gbOverview
            // 
            this.gbOverview.Controls.Add(this.lbLeftEmployeesNight);
            this.gbOverview.Controls.Add(this.btnAssign);
            this.gbOverview.Controls.Add(this.lbLeftEmployeesEvening);
            this.gbOverview.Controls.Add(this.btnRemove);
            this.gbOverview.Controls.Add(this.label11);
            this.gbOverview.Controls.Add(this.lbLeftEmployeesAfternoon);
            this.gbOverview.Controls.Add(this.label9);
            this.gbOverview.Controls.Add(this.label7);
            this.gbOverview.Controls.Add(this.lbLeftEmployeesMorning);
            this.gbOverview.Controls.Add(this.lbxAssignedEmployeesEvening);
            this.gbOverview.Controls.Add(this.rbNightShift);
            this.gbOverview.Controls.Add(this.label4);
            this.gbOverview.Controls.Add(this.lbxAssignedEmployeesNight);
            this.gbOverview.Controls.Add(this.lbxAssignedEmployeesMorning);
            this.gbOverview.Controls.Add(this.rbAfternoonShift);
            this.gbOverview.Controls.Add(this.rbEveningShift);
            this.gbOverview.Controls.Add(this.rbMorningShift);
            this.gbOverview.Controls.Add(this.lbxAssignedEmployeesAfternoon);
            this.gbOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbOverview.Location = new System.Drawing.Point(21, 89);
            this.gbOverview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOverview.Name = "gbOverview";
            this.gbOverview.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOverview.Size = new System.Drawing.Size(1077, 452);
            this.gbOverview.TabIndex = 96;
            this.gbOverview.TabStop = false;
            this.gbOverview.Text = "Overview:";
            this.gbOverview.Visible = false;
            // 
            // rbAfternoonShift
            // 
            this.rbAfternoonShift.AutoSize = true;
            this.rbAfternoonShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbAfternoonShift.Location = new System.Drawing.Point(16, 242);
            this.rbAfternoonShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAfternoonShift.Name = "rbAfternoonShift";
            this.rbAfternoonShift.Size = new System.Drawing.Size(141, 24);
            this.rbAfternoonShift.TabIndex = 87;
            this.rbAfternoonShift.TabStop = true;
            this.rbAfternoonShift.Text = "Afternoon Shift";
            this.rbAfternoonShift.UseVisualStyleBackColor = true;
            this.rbAfternoonShift.CheckedChanged += new System.EventHandler(this.rbAfternoonShift_CheckedChanged);
            // 
            // rbEveningShift
            // 
            this.rbEveningShift.AutoSize = true;
            this.rbEveningShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbEveningShift.Location = new System.Drawing.Point(453, 30);
            this.rbEveningShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbEveningShift.Name = "rbEveningShift";
            this.rbEveningShift.Size = new System.Drawing.Size(128, 24);
            this.rbEveningShift.TabIndex = 88;
            this.rbEveningShift.TabStop = true;
            this.rbEveningShift.Text = "Evening Shift";
            this.rbEveningShift.UseVisualStyleBackColor = true;
            this.rbEveningShift.CheckedChanged += new System.EventHandler(this.rbEveningShift_CheckedChanged);
            // 
            // rbMorningShift
            // 
            this.rbMorningShift.AutoSize = true;
            this.rbMorningShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbMorningShift.Location = new System.Drawing.Point(16, 30);
            this.rbMorningShift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMorningShift.Name = "rbMorningShift";
            this.rbMorningShift.Size = new System.Drawing.Size(129, 24);
            this.rbMorningShift.TabIndex = 86;
            this.rbMorningShift.TabStop = true;
            this.rbMorningShift.Text = "Morning Shift";
            this.rbMorningShift.UseVisualStyleBackColor = true;
            this.rbMorningShift.CheckedChanged += new System.EventHandler(this.rbMorningShift_CheckedChanged);
            // 
            // lbxAssignedEmployeesAfternoon
            // 
            this.lbxAssignedEmployeesAfternoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxAssignedEmployeesAfternoon.FormattingEnabled = true;
            this.lbxAssignedEmployeesAfternoon.ItemHeight = 20;
            this.lbxAssignedEmployeesAfternoon.Location = new System.Drawing.Point(12, 300);
            this.lbxAssignedEmployeesAfternoon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxAssignedEmployeesAfternoon.Name = "lbxAssignedEmployeesAfternoon";
            this.lbxAssignedEmployeesAfternoon.Size = new System.Drawing.Size(356, 104);
            this.lbxAssignedEmployeesAfternoon.TabIndex = 90;
            // 
            // tcStoreWorkerSchedule
            // 
            this.tcStoreWorkerSchedule.Controls.Add(this.tpStoreWAssign);
            this.tcStoreWorkerSchedule.Controls.Add(this.tpStoreWView);
            this.tcStoreWorkerSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tcStoreWorkerSchedule.Location = new System.Drawing.Point(5, 2);
            this.tcStoreWorkerSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcStoreWorkerSchedule.Name = "tcStoreWorkerSchedule";
            this.tcStoreWorkerSchedule.SelectedIndex = 0;
            this.tcStoreWorkerSchedule.Size = new System.Drawing.Size(1123, 809);
            this.tcStoreWorkerSchedule.TabIndex = 4;
            this.tcStoreWorkerSchedule.SelectedIndexChanged += new System.EventHandler(this.tcStoreWorkerSchedule_SelectedIndexChanged);
            // 
            // StoreWorkerScheduleInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcStoreWorkerSchedule);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StoreWorkerScheduleInterface";
            this.Size = new System.Drawing.Size(1129, 812);
            this.tpStoreWView.ResumeLayout(false);
            this.tpStoreWView.PerformLayout();
            this.pnlDisplayEmployees.ResumeLayout(false);
            this.pnlDisplayEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewShifts)).EndInit();
            this.pnlDisplayDate.ResumeLayout(false);
            this.pnlDisplayDate.PerformLayout();
            this.pnlChangeWeek.ResumeLayout(false);
            this.tpStoreWAssign.ResumeLayout(false);
            this.tpStoreWAssign.PerformLayout();
            this.gbAvailableEmployees.ResumeLayout(false);
            this.gbChangeAssignableEmployees.ResumeLayout(false);
            this.gbChangeAssignableEmployees.PerformLayout();
            this.gbOverview.ResumeLayout(false);
            this.gbOverview.PerformLayout();
            this.tcStoreWorkerSchedule.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxAvailableStoreWorkers;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTodayDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLeftEmployeesNight;
        private System.Windows.Forms.Label lbLeftEmployeesEvening;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label lbLeftEmployeesAfternoon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbLeftEmployeesMorning;
        private System.Windows.Forms.ListBox lbxAssignedEmployeesEvening;
        private System.Windows.Forms.RadioButton rbNightShift;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tpStoreWView;
        private System.Windows.Forms.ListBox lbxAssignedEmployeesNight;
        private System.Windows.Forms.ListBox lbxAssignedEmployeesMorning;
        private System.Windows.Forms.TabPage tpStoreWAssign;
        private System.Windows.Forms.GroupBox gbAvailableEmployees;
        private System.Windows.Forms.GroupBox gbChangeAssignableEmployees;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox tbMaxEmployees;
        private System.Windows.Forms.Label lbMaxEmplPerShift;
        private System.Windows.Forms.ComboBox cbxDay;
        private System.Windows.Forms.GroupBox gbOverview;
        private System.Windows.Forms.RadioButton rbAfternoonShift;
        private System.Windows.Forms.RadioButton rbEveningShift;
        private System.Windows.Forms.RadioButton rbMorningShift;
        private System.Windows.Forms.ListBox lbxAssignedEmployeesAfternoon;
        private System.Windows.Forms.TabControl tcStoreWorkerSchedule;
        private System.Windows.Forms.Label lbWeek;
        private System.Windows.Forms.MonthCalendar calendarDate;
        private System.Windows.Forms.Label lblViewInstructions;
        private System.Windows.Forms.Button btnShowShifts;
        private System.Windows.Forms.Panel pnlDisplayDate;
        private System.Windows.Forms.Label lblDisplayedDates;
        private System.Windows.Forms.Panel pnlChangeWeek;
        private System.Windows.Forms.Button btnChangeSelectedWeek;
        private System.Windows.Forms.DataGridView dgvViewShifts;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMorning;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAfternoon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEvening;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNight;
        private System.Windows.Forms.Panel pnlDisplayEmployees;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbDisplayEmployees;
        private System.Windows.Forms.Label lblAssignedEmployees;
    }
}
