
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
            this.tcStoreWorkerSchedule = new System.Windows.Forms.TabControl();
            this.tpStoreWAssign = new System.Windows.Forms.TabPage();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblAvailableStoreW = new System.Windows.Forms.Label();
            this.lblAssignStoreW = new System.Windows.Forms.Label();
            this.lbxDisplayAvailableStoreW = new System.Windows.Forms.ListBox();
            this.lbxDisplayAssignStoreW = new System.Windows.Forms.ListBox();
            this.cbxShiftType = new System.Windows.Forms.ComboBox();
            this.cbxDay = new System.Windows.Forms.ComboBox();
            this.lblShiftType = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.tpStoreWView = new System.Windows.Forms.TabPage();
            this.tcStoreWorkerSchedule.SuspendLayout();
            this.tpStoreWAssign.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcStoreWorkerSchedule
            // 
            this.tcStoreWorkerSchedule.Controls.Add(this.tpStoreWAssign);
            this.tcStoreWorkerSchedule.Controls.Add(this.tpStoreWView);
            this.tcStoreWorkerSchedule.Location = new System.Drawing.Point(29, 17);
            this.tcStoreWorkerSchedule.Name = "tcStoreWorkerSchedule";
            this.tcStoreWorkerSchedule.SelectedIndex = 0;
            this.tcStoreWorkerSchedule.Size = new System.Drawing.Size(659, 497);
            this.tcStoreWorkerSchedule.TabIndex = 1;
            // 
            // tpStoreWAssign
            // 
            this.tpStoreWAssign.BackColor = System.Drawing.Color.Lavender;
            this.tpStoreWAssign.Controls.Add(this.btnAssign);
            this.tpStoreWAssign.Controls.Add(this.btnRemove);
            this.tpStoreWAssign.Controls.Add(this.lblAvailableStoreW);
            this.tpStoreWAssign.Controls.Add(this.lblAssignStoreW);
            this.tpStoreWAssign.Controls.Add(this.lbxDisplayAvailableStoreW);
            this.tpStoreWAssign.Controls.Add(this.lbxDisplayAssignStoreW);
            this.tpStoreWAssign.Controls.Add(this.cbxShiftType);
            this.tpStoreWAssign.Controls.Add(this.cbxDay);
            this.tpStoreWAssign.Controls.Add(this.lblShiftType);
            this.tpStoreWAssign.Controls.Add(this.lblDay);
            this.tpStoreWAssign.Location = new System.Drawing.Point(4, 25);
            this.tpStoreWAssign.Name = "tpStoreWAssign";
            this.tpStoreWAssign.Padding = new System.Windows.Forms.Padding(3);
            this.tpStoreWAssign.Size = new System.Drawing.Size(651, 468);
            this.tpStoreWAssign.TabIndex = 0;
            this.tpStoreWAssign.Text = "Assign";
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.Location = new System.Drawing.Point(414, 412);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(148, 43);
            this.btnAssign.TabIndex = 80;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(84, 412);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(148, 43);
            this.btnRemove.TabIndex = 79;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // lblAvailableStoreW
            // 
            this.lblAvailableStoreW.AutoSize = true;
            this.lblAvailableStoreW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableStoreW.Location = new System.Drawing.Point(325, 203);
            this.lblAvailableStoreW.Name = "lblAvailableStoreW";
            this.lblAvailableStoreW.Size = new System.Drawing.Size(179, 20);
            this.lblAvailableStoreW.TabIndex = 7;
            this.lblAvailableStoreW.Text = "Available store worker:";
            // 
            // lblAssignStoreW
            // 
            this.lblAssignStoreW.AutoSize = true;
            this.lblAssignStoreW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignStoreW.Location = new System.Drawing.Point(6, 203);
            this.lblAssignStoreW.Name = "lblAssignStoreW";
            this.lblAssignStoreW.Size = new System.Drawing.Size(187, 20);
            this.lblAssignStoreW.TabIndex = 6;
            this.lblAssignStoreW.Text = "Assigned Store Worker:";
            // 
            // lbxDisplayAvailableStoreW
            // 
            this.lbxDisplayAvailableStoreW.FormattingEnabled = true;
            this.lbxDisplayAvailableStoreW.ItemHeight = 16;
            this.lbxDisplayAvailableStoreW.Location = new System.Drawing.Point(329, 226);
            this.lbxDisplayAvailableStoreW.Name = "lbxDisplayAvailableStoreW";
            this.lbxDisplayAvailableStoreW.Size = new System.Drawing.Size(317, 180);
            this.lbxDisplayAvailableStoreW.TabIndex = 5;
            // 
            // lbxDisplayAssignStoreW
            // 
            this.lbxDisplayAssignStoreW.FormattingEnabled = true;
            this.lbxDisplayAssignStoreW.ItemHeight = 16;
            this.lbxDisplayAssignStoreW.Location = new System.Drawing.Point(6, 226);
            this.lbxDisplayAssignStoreW.Name = "lbxDisplayAssignStoreW";
            this.lbxDisplayAssignStoreW.Size = new System.Drawing.Size(317, 180);
            this.lbxDisplayAssignStoreW.TabIndex = 4;
            // 
            // cbxShiftType
            // 
            this.cbxShiftType.FormattingEnabled = true;
            this.cbxShiftType.Location = new System.Drawing.Point(199, 80);
            this.cbxShiftType.Name = "cbxShiftType";
            this.cbxShiftType.Size = new System.Drawing.Size(374, 24);
            this.cbxShiftType.TabIndex = 3;
            // 
            // cbxDay
            // 
            this.cbxDay.FormattingEnabled = true;
            this.cbxDay.Location = new System.Drawing.Point(199, 30);
            this.cbxDay.Name = "cbxDay";
            this.cbxDay.Size = new System.Drawing.Size(374, 24);
            this.cbxDay.TabIndex = 2;
            // 
            // lblShiftType
            // 
            this.lblShiftType.AutoSize = true;
            this.lblShiftType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShiftType.Location = new System.Drawing.Point(32, 84);
            this.lblShiftType.Name = "lblShiftType";
            this.lblShiftType.Size = new System.Drawing.Size(84, 20);
            this.lblShiftType.TabIndex = 1;
            this.lblShiftType.Text = "Shift type:";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(32, 36);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(44, 20);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "Day:";
            // 
            // tpStoreWView
            // 
            this.tpStoreWView.BackColor = System.Drawing.Color.Lavender;
            this.tpStoreWView.Location = new System.Drawing.Point(4, 25);
            this.tpStoreWView.Name = "tpStoreWView";
            this.tpStoreWView.Padding = new System.Windows.Forms.Padding(3);
            this.tpStoreWView.Size = new System.Drawing.Size(651, 468);
            this.tpStoreWView.TabIndex = 1;
            this.tpStoreWView.Text = "View";
            // 
            // StoreWorkerScheduleInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcStoreWorkerSchedule);
            this.Name = "StoreWorkerScheduleInterface";
            this.Size = new System.Drawing.Size(717, 530);
            this.tcStoreWorkerSchedule.ResumeLayout(false);
            this.tpStoreWAssign.ResumeLayout(false);
            this.tpStoreWAssign.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcStoreWorkerSchedule;
        private System.Windows.Forms.TabPage tpStoreWAssign;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblAvailableStoreW;
        private System.Windows.Forms.Label lblAssignStoreW;
        private System.Windows.Forms.ListBox lbxDisplayAvailableStoreW;
        private System.Windows.Forms.ListBox lbxDisplayAssignStoreW;
        private System.Windows.Forms.ComboBox cbxShiftType;
        private System.Windows.Forms.ComboBox cbxDay;
        private System.Windows.Forms.Label lblShiftType;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.TabPage tpStoreWView;
    }
}
