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
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.lbxListOfEmployees = new System.Windows.Forms.ListBox();
            this.lblEmpStat = new System.Windows.Forms.Label();
            this.tbcViewStatistics = new System.Windows.Forms.TabControl();
            this.tbcStatEmp = new System.Windows.Forms.TabPage();
            this.tbcAllEmpStat = new System.Windows.Forms.TabPage();
            this.tbcViewStatistics.SuspendLayout();
            this.tbcStatEmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewDetails.Location = new System.Drawing.Point(298, 375);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(231, 44);
            this.btnViewDetails.TabIndex = 0;
            this.btnViewDetails.Text = "View detials";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // lbxListOfEmployees
            // 
            this.lbxListOfEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxListOfEmployees.FormattingEnabled = true;
            this.lbxListOfEmployees.ItemHeight = 29;
            this.lbxListOfEmployees.Location = new System.Drawing.Point(22, 64);
            this.lbxListOfEmployees.Name = "lbxListOfEmployees";
            this.lbxListOfEmployees.Size = new System.Drawing.Size(784, 294);
            this.lbxListOfEmployees.TabIndex = 1;
            // 
            // lblEmpStat
            // 
            this.lblEmpStat.AutoSize = true;
            this.lblEmpStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmpStat.Location = new System.Drawing.Point(17, 20);
            this.lblEmpStat.Name = "lblEmpStat";
            this.lblEmpStat.Size = new System.Drawing.Size(219, 29);
            this.lblEmpStat.TabIndex = 2;
            this.lblEmpStat.Text = "Employee statistics";
            // 
            // tbcViewStatistics
            // 
            this.tbcViewStatistics.Controls.Add(this.tbcStatEmp);
            this.tbcViewStatistics.Controls.Add(this.tbcAllEmpStat);
            this.tbcViewStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbcViewStatistics.Location = new System.Drawing.Point(21, 22);
            this.tbcViewStatistics.Name = "tbcViewStatistics";
            this.tbcViewStatistics.SelectedIndex = 0;
            this.tbcViewStatistics.Size = new System.Drawing.Size(841, 478);
            this.tbcViewStatistics.TabIndex = 3;
            // 
            // tbcStatEmp
            // 
            this.tbcStatEmp.Controls.Add(this.lbxListOfEmployees);
            this.tbcStatEmp.Controls.Add(this.btnViewDetails);
            this.tbcStatEmp.Controls.Add(this.lblEmpStat);
            this.tbcStatEmp.Location = new System.Drawing.Point(4, 38);
            this.tbcStatEmp.Name = "tbcStatEmp";
            this.tbcStatEmp.Padding = new System.Windows.Forms.Padding(3);
            this.tbcStatEmp.Size = new System.Drawing.Size(833, 436);
            this.tbcStatEmp.TabIndex = 0;
            this.tbcStatEmp.Text = "View statistics about en employee";
            this.tbcStatEmp.UseVisualStyleBackColor = true;
            // 
            // tbcAllEmpStat
            // 
            this.tbcAllEmpStat.Location = new System.Drawing.Point(4, 38);
            this.tbcAllEmpStat.Name = "tbcAllEmpStat";
            this.tbcAllEmpStat.Padding = new System.Windows.Forms.Padding(3);
            this.tbcAllEmpStat.Size = new System.Drawing.Size(833, 436);
            this.tbcAllEmpStat.TabIndex = 1;
            this.tbcAllEmpStat.Text = "View statistic about all employees";
            this.tbcAllEmpStat.UseVisualStyleBackColor = true;
            // 
            // EmployeeStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.tbcViewStatistics);
            this.Name = "EmployeeStatistics";
            this.Size = new System.Drawing.Size(890, 530);
            this.Load += new System.EventHandler(this.EmployeeStatistics_Load);
            this.tbcViewStatistics.ResumeLayout(false);
            this.tbcStatEmp.ResumeLayout(false);
            this.tbcStatEmp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.ListBox lbxListOfEmployees;
        private System.Windows.Forms.Label lblEmpStat;
        private System.Windows.Forms.TabControl tbcViewStatistics;
        private System.Windows.Forms.TabPage tbcStatEmp;
        private System.Windows.Forms.TabPage tbcAllEmpStat;
    }
}
