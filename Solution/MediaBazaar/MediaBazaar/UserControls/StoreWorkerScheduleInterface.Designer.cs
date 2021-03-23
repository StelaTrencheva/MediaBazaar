
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
            this.lbxDisplayAssignedEmployees = new System.Windows.Forms.ListBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTodayDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblAvailableStoreW = new System.Windows.Forms.Label();
            this.lblAssignStoreW = new System.Windows.Forms.Label();
            this.lbxDisplayAvailableStoreW = new System.Windows.Forms.ListBox();
            this.cbxDay = new System.Windows.Forms.ComboBox();
            this.cbxShiftType = new System.Windows.Forms.ComboBox();
            this.lblShiftType = new System.Windows.Forms.Label();
            this.tpStoreWView = new System.Windows.Forms.TabPage();
            this.btnChangeSelectedWeek = new System.Windows.Forms.Button();
            this.lbViewSchedule = new System.Windows.Forms.ListBox();
            this.lblViewInstructions = new System.Windows.Forms.Label();
            this.btnShowShifts = new System.Windows.Forms.Button();
            this.calendarDate = new System.Windows.Forms.MonthCalendar();
            this.lblDay = new System.Windows.Forms.Label();
            this.tpStoreWAssign = new System.Windows.Forms.TabPage();
            this.tcStoreWorkerSchedule = new System.Windows.Forms.TabControl();
            this.tpStoreWView.SuspendLayout();
            this.tpStoreWAssign.SuspendLayout();
            this.tcStoreWorkerSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxDisplayAssignedEmployees
            // 
            this.lbxDisplayAssignedEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxDisplayAssignedEmployees.FormattingEnabled = true;
            this.lbxDisplayAssignedEmployees.ItemHeight = 25;
            this.lbxDisplayAssignedEmployees.Location = new System.Drawing.Point(498, 251);
            this.lbxDisplayAssignedEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxDisplayAssignedEmployees.Name = "lbxDisplayAssignedEmployees";
            this.lbxDisplayAssignedEmployees.Size = new System.Drawing.Size(487, 279);
            this.lbxDisplayAssignedEmployees.TabIndex = 85;
            this.lbxDisplayAssignedEmployees.Visible = false;
            // 
            // cbMonth
            // 
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(363, 62);
            this.cbMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(420, 33);
            this.cbMonth.TabIndex = 84;
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 83;
            this.label2.Text = "Month:";
            // 
            // lbTodayDate
            // 
            this.lbTodayDate.AutoSize = true;
            this.lbTodayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTodayDate.Location = new System.Drawing.Point(359, 22);
            this.lbTodayDate.Name = "lbTodayDate";
            this.lbTodayDate.Size = new System.Drawing.Size(0, 25);
            this.lbTodayDate.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 81;
            this.label1.Text = "Today\'s date:";
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAssign.Location = new System.Drawing.Point(197, 539);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(129, 54);
            this.btnAssign.TabIndex = 80;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Visible = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemove.Location = new System.Drawing.Point(683, 539);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(129, 54);
            this.btnRemove.TabIndex = 79;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Visible = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblAvailableStoreW
            // 
            this.lblAvailableStoreW.AutoSize = true;
            this.lblAvailableStoreW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableStoreW.Location = new System.Drawing.Point(17, 211);
            this.lblAvailableStoreW.Name = "lblAvailableStoreW";
            this.lblAvailableStoreW.Size = new System.Drawing.Size(241, 25);
            this.lblAvailableStoreW.TabIndex = 7;
            this.lblAvailableStoreW.Text = "Available store workers:";
            this.lblAvailableStoreW.Visible = false;
            // 
            // lblAssignStoreW
            // 
            this.lblAssignStoreW.AutoSize = true;
            this.lblAssignStoreW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignStoreW.Location = new System.Drawing.Point(511, 211);
            this.lblAssignStoreW.Name = "lblAssignStoreW";
            this.lblAssignStoreW.Size = new System.Drawing.Size(250, 25);
            this.lblAssignStoreW.TabIndex = 6;
            this.lblAssignStoreW.Text = "Assigned Store Workers:";
            this.lblAssignStoreW.Visible = false;
            // 
            // lbxDisplayAvailableStoreW
            // 
            this.lbxDisplayAvailableStoreW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxDisplayAvailableStoreW.FormattingEnabled = true;
            this.lbxDisplayAvailableStoreW.HorizontalScrollbar = true;
            this.lbxDisplayAvailableStoreW.ItemHeight = 25;
            this.lbxDisplayAvailableStoreW.Location = new System.Drawing.Point(7, 251);
            this.lbxDisplayAvailableStoreW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxDisplayAvailableStoreW.Name = "lbxDisplayAvailableStoreW";
            this.lbxDisplayAvailableStoreW.Size = new System.Drawing.Size(487, 279);
            this.lbxDisplayAvailableStoreW.TabIndex = 5;
            this.lbxDisplayAvailableStoreW.Visible = false;
            // 
            // cbxDay
            // 
            this.cbxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxDay.FormattingEnabled = true;
            this.cbxDay.Location = new System.Drawing.Point(363, 109);
            this.cbxDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxDay.Name = "cbxDay";
            this.cbxDay.Size = new System.Drawing.Size(420, 33);
            this.cbxDay.TabIndex = 2;
            this.cbxDay.Visible = false;
            this.cbxDay.SelectedIndexChanged += new System.EventHandler(this.cbxDay_SelectedIndexChanged);
            // 
            // cbxShiftType
            // 
            this.cbxShiftType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxShiftType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxShiftType.FormattingEnabled = true;
            this.cbxShiftType.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening",
            "Night"});
            this.cbxShiftType.Location = new System.Drawing.Point(363, 156);
            this.cbxShiftType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxShiftType.Name = "cbxShiftType";
            this.cbxShiftType.Size = new System.Drawing.Size(420, 33);
            this.cbxShiftType.TabIndex = 3;
            this.cbxShiftType.Visible = false;
            this.cbxShiftType.SelectedIndexChanged += new System.EventHandler(this.cbxShiftType_SelectedIndexChanged);
            // 
            // lblShiftType
            // 
            this.lblShiftType.AutoSize = true;
            this.lblShiftType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShiftType.Location = new System.Drawing.Point(204, 156);
            this.lblShiftType.Name = "lblShiftType";
            this.lblShiftType.Size = new System.Drawing.Size(108, 25);
            this.lblShiftType.TabIndex = 1;
            this.lblShiftType.Text = "Shift type:";
            this.lblShiftType.Visible = false;
            // 
            // tpStoreWView
            // 
            this.tpStoreWView.BackColor = System.Drawing.Color.Azure;
            this.tpStoreWView.Controls.Add(this.btnChangeSelectedWeek);
            this.tpStoreWView.Controls.Add(this.lbViewSchedule);
            this.tpStoreWView.Controls.Add(this.lblViewInstructions);
            this.tpStoreWView.Controls.Add(this.btnShowShifts);
            this.tpStoreWView.Controls.Add(this.calendarDate);
            this.tpStoreWView.Location = new System.Drawing.Point(4, 34);
            this.tpStoreWView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpStoreWView.Name = "tpStoreWView";
            this.tpStoreWView.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpStoreWView.Size = new System.Drawing.Size(993, 624);
            this.tpStoreWView.TabIndex = 1;
            this.tpStoreWView.Text = "View";
            // 
            // btnChangeSelectedWeek
            // 
            this.btnChangeSelectedWeek.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnChangeSelectedWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeSelectedWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeSelectedWeek.Location = new System.Drawing.Point(637, 8);
            this.btnChangeSelectedWeek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangeSelectedWeek.Name = "btnChangeSelectedWeek";
            this.btnChangeSelectedWeek.Size = new System.Drawing.Size(270, 54);
            this.btnChangeSelectedWeek.TabIndex = 94;
            this.btnChangeSelectedWeek.Text = "Change week";
            this.btnChangeSelectedWeek.UseVisualStyleBackColor = false;
            this.btnChangeSelectedWeek.Visible = false;
            this.btnChangeSelectedWeek.Click += new System.EventHandler(this.btnChangeSelectedWeek_Click);
            // 
            // lbViewSchedule
            // 
            this.lbViewSchedule.FormattingEnabled = true;
            this.lbViewSchedule.ItemHeight = 25;
            this.lbViewSchedule.Location = new System.Drawing.Point(63, 66);
            this.lbViewSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbViewSchedule.Name = "lbViewSchedule";
            this.lbViewSchedule.Size = new System.Drawing.Size(843, 479);
            this.lbViewSchedule.TabIndex = 93;
            this.lbViewSchedule.Visible = false;
            // 
            // lblViewInstructions
            // 
            this.lblViewInstructions.AutoSize = true;
            this.lblViewInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewInstructions.Location = new System.Drawing.Point(201, 382);
            this.lblViewInstructions.Name = "lblViewInstructions";
            this.lblViewInstructions.Size = new System.Drawing.Size(659, 25);
            this.lblViewInstructions.TabIndex = 92;
            this.lblViewInstructions.Text = "Select a date and the shifts assigned for the week will be displayed:";
            // 
            // btnShowShifts
            // 
            this.btnShowShifts.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnShowShifts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowShifts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowShifts.Location = new System.Drawing.Point(405, 468);
            this.btnShowShifts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowShifts.Name = "btnShowShifts";
            this.btnShowShifts.Size = new System.Drawing.Size(129, 54);
            this.btnShowShifts.TabIndex = 91;
            this.btnShowShifts.Text = "Show";
            this.btnShowShifts.UseVisualStyleBackColor = false;
            this.btnShowShifts.Click += new System.EventHandler(this.btnShowShifts_Click);
            // 
            // calendarDate
            // 
            this.calendarDate.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.calendarDate.Location = new System.Drawing.Point(330, 66);
            this.calendarDate.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.calendarDate.MaxSelectionCount = 1;
            this.calendarDate.MinDate = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            this.calendarDate.Name = "calendarDate";
            this.calendarDate.TabIndex = 90;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(204, 112);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(56, 25);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "Day:";
            this.lblDay.Visible = false;
            // 
            // tpStoreWAssign
            // 
            this.tpStoreWAssign.BackColor = System.Drawing.Color.Azure;
            this.tpStoreWAssign.Controls.Add(this.lbxDisplayAssignedEmployees);
            this.tpStoreWAssign.Controls.Add(this.cbMonth);
            this.tpStoreWAssign.Controls.Add(this.label2);
            this.tpStoreWAssign.Controls.Add(this.lbTodayDate);
            this.tpStoreWAssign.Controls.Add(this.label1);
            this.tpStoreWAssign.Controls.Add(this.btnAssign);
            this.tpStoreWAssign.Controls.Add(this.btnRemove);
            this.tpStoreWAssign.Controls.Add(this.lblAvailableStoreW);
            this.tpStoreWAssign.Controls.Add(this.lblAssignStoreW);
            this.tpStoreWAssign.Controls.Add(this.lbxDisplayAvailableStoreW);
            this.tpStoreWAssign.Controls.Add(this.cbxShiftType);
            this.tpStoreWAssign.Controls.Add(this.cbxDay);
            this.tpStoreWAssign.Controls.Add(this.lblShiftType);
            this.tpStoreWAssign.Controls.Add(this.lblDay);
            this.tpStoreWAssign.Location = new System.Drawing.Point(4, 34);
            this.tpStoreWAssign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpStoreWAssign.Name = "tpStoreWAssign";
            this.tpStoreWAssign.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpStoreWAssign.Size = new System.Drawing.Size(993, 624);
            this.tpStoreWAssign.TabIndex = 0;
            this.tpStoreWAssign.Text = "Assign";
            // 
            // tcStoreWorkerSchedule
            // 
            this.tcStoreWorkerSchedule.Controls.Add(this.tpStoreWAssign);
            this.tcStoreWorkerSchedule.Controls.Add(this.tpStoreWView);
            this.tcStoreWorkerSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tcStoreWorkerSchedule.Location = new System.Drawing.Point(0, 0);
            this.tcStoreWorkerSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tcStoreWorkerSchedule.Name = "tcStoreWorkerSchedule";
            this.tcStoreWorkerSchedule.SelectedIndex = 0;
            this.tcStoreWorkerSchedule.Size = new System.Drawing.Size(1001, 662);
            this.tcStoreWorkerSchedule.TabIndex = 2;
            this.tcStoreWorkerSchedule.SelectedIndexChanged += new System.EventHandler(this.tcStoreWorkerSchedule_SelectedIndexChanged);
            // 
            // StoreWorkerScheduleInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcStoreWorkerSchedule);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StoreWorkerScheduleInterface";
            this.Size = new System.Drawing.Size(1001, 662);
            this.tpStoreWView.ResumeLayout(false);
            this.tpStoreWView.PerformLayout();
            this.tpStoreWAssign.ResumeLayout(false);
            this.tpStoreWAssign.PerformLayout();
            this.tcStoreWorkerSchedule.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbxDisplayAssignedEmployees;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTodayDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblAvailableStoreW;
        private System.Windows.Forms.Label lblAssignStoreW;
        private System.Windows.Forms.ListBox lbxDisplayAvailableStoreW;
        private System.Windows.Forms.ComboBox cbxDay;
        private System.Windows.Forms.ComboBox cbxShiftType;
        private System.Windows.Forms.Label lblShiftType;
        private System.Windows.Forms.TabPage tpStoreWView;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.TabPage tpStoreWAssign;
        private System.Windows.Forms.TabControl tcStoreWorkerSchedule;
        private System.Windows.Forms.MonthCalendar calendarDate;
        private System.Windows.Forms.Label lblViewInstructions;
        private System.Windows.Forms.Button btnShowShifts;
        private System.Windows.Forms.ListBox lbViewSchedule;
        private System.Windows.Forms.Button btnChangeSelectedWeek;
    }
}
