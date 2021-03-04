
namespace MediaBazaar
{
    partial class DepartmentManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentManager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnDManagerEmployeeStatistic = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDManagerLogOut = new System.Windows.Forms.Button();
            this.btnDManagerAccount = new System.Windows.Forms.Button();
            this.lblDManagerAddress = new System.Windows.Forms.Label();
            this.lblDManagerEmail = new System.Windows.Forms.Label();
            this.lblDManagerPhoneNum = new System.Windows.Forms.Label();
            this.lblDManagerPosition = new System.Windows.Forms.Label();
            this.lblDManagerLName = new System.Windows.Forms.Label();
            this.lblDManagerFName = new System.Windows.Forms.Label();
            this.pbxDManager = new System.Windows.Forms.PictureBox();
            this.btnDManagerEdit = new System.Windows.Forms.Button();
            this.btnDManagerSchedule = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDManager)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDManagerSchedule);
            this.panel1.Controls.Add(this.pbxLogo);
            this.panel1.Controls.Add(this.btnDManagerEmployeeStatistic);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 530);
            this.panel1.TabIndex = 33;
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(32, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(146, 134);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 2;
            this.pbxLogo.TabStop = false;
            // 
            // btnDManagerEmployeeStatistic
            // 
            this.btnDManagerEmployeeStatistic.BackColor = System.Drawing.Color.SlateGray;
            this.btnDManagerEmployeeStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDManagerEmployeeStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDManagerEmployeeStatistic.Location = new System.Drawing.Point(32, 152);
            this.btnDManagerEmployeeStatistic.Name = "btnDManagerEmployeeStatistic";
            this.btnDManagerEmployeeStatistic.Size = new System.Drawing.Size(146, 64);
            this.btnDManagerEmployeeStatistic.TabIndex = 1;
            this.btnDManagerEmployeeStatistic.Text = "Employee Statistic";
            this.btnDManagerEmployeeStatistic.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDManagerLogOut);
            this.panel2.Controls.Add(this.btnDManagerAccount);
            this.panel2.Location = new System.Drawing.Point(-1, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 217);
            this.panel2.TabIndex = 0;
            // 
            // btnDManagerLogOut
            // 
            this.btnDManagerLogOut.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDManagerLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDManagerLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDManagerLogOut.Location = new System.Drawing.Point(32, 142);
            this.btnDManagerLogOut.Name = "btnDManagerLogOut";
            this.btnDManagerLogOut.Size = new System.Drawing.Size(146, 43);
            this.btnDManagerLogOut.TabIndex = 3;
            this.btnDManagerLogOut.Text = "Log out";
            this.btnDManagerLogOut.UseVisualStyleBackColor = false;
            // 
            // btnDManagerAccount
            // 
            this.btnDManagerAccount.BackColor = System.Drawing.Color.White;
            this.btnDManagerAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDManagerAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDManagerAccount.Location = new System.Drawing.Point(32, 47);
            this.btnDManagerAccount.Name = "btnDManagerAccount";
            this.btnDManagerAccount.Size = new System.Drawing.Size(146, 43);
            this.btnDManagerAccount.TabIndex = 2;
            this.btnDManagerAccount.Text = "My account";
            this.btnDManagerAccount.UseVisualStyleBackColor = false;
            // 
            // lblDManagerAddress
            // 
            this.lblDManagerAddress.AutoSize = true;
            this.lblDManagerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDManagerAddress.Location = new System.Drawing.Point(558, 255);
            this.lblDManagerAddress.Name = "lblDManagerAddress";
            this.lblDManagerAddress.Size = new System.Drawing.Size(171, 20);
            this.lblDManagerAddress.TabIndex = 41;
            this.lblDManagerAddress.Text = "Address: Street 1, NL";
            // 
            // lblDManagerEmail
            // 
            this.lblDManagerEmail.AutoSize = true;
            this.lblDManagerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDManagerEmail.Location = new System.Drawing.Point(558, 221);
            this.lblDManagerEmail.Name = "lblDManagerEmail";
            this.lblDManagerEmail.Size = new System.Drawing.Size(224, 20);
            this.lblDManagerEmail.TabIndex = 40;
            this.lblDManagerEmail.Text = "Email: paula.l@example.com";
            // 
            // lblDManagerPhoneNum
            // 
            this.lblDManagerPhoneNum.AutoSize = true;
            this.lblDManagerPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDManagerPhoneNum.Location = new System.Drawing.Point(558, 187);
            this.lblDManagerPhoneNum.Name = "lblDManagerPhoneNum";
            this.lblDManagerPhoneNum.Size = new System.Drawing.Size(205, 20);
            this.lblDManagerPhoneNum.TabIndex = 39;
            this.lblDManagerPhoneNum.Text = "Phone number: 06-****-****";
            // 
            // lblDManagerPosition
            // 
            this.lblDManagerPosition.AutoSize = true;
            this.lblDManagerPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDManagerPosition.Location = new System.Drawing.Point(558, 153);
            this.lblDManagerPosition.Name = "lblDManagerPosition";
            this.lblDManagerPosition.Size = new System.Drawing.Size(237, 20);
            this.lblDManagerPosition.TabIndex = 38;
            this.lblDManagerPosition.Text = "Position: Department Manager";
            // 
            // lblDManagerLName
            // 
            this.lblDManagerLName.AutoSize = true;
            this.lblDManagerLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDManagerLName.Location = new System.Drawing.Point(558, 119);
            this.lblDManagerLName.Name = "lblDManagerLName";
            this.lblDManagerLName.Size = new System.Drawing.Size(144, 20);
            this.lblDManagerLName.TabIndex = 37;
            this.lblDManagerLName.Text = "Last name: Lopez";
            // 
            // lblDManagerFName
            // 
            this.lblDManagerFName.AutoSize = true;
            this.lblDManagerFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDManagerFName.Location = new System.Drawing.Point(558, 85);
            this.lblDManagerFName.Name = "lblDManagerFName";
            this.lblDManagerFName.Size = new System.Drawing.Size(141, 20);
            this.lblDManagerFName.TabIndex = 36;
            this.lblDManagerFName.Text = "First name: Paula";
            // 
            // pbxDManager
            // 
            this.pbxDManager.Image = ((System.Drawing.Image)(resources.GetObject("pbxDManager.Image")));
            this.pbxDManager.Location = new System.Drawing.Point(333, 85);
            this.pbxDManager.Name = "pbxDManager";
            this.pbxDManager.Size = new System.Drawing.Size(160, 171);
            this.pbxDManager.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDManager.TabIndex = 35;
            this.pbxDManager.TabStop = false;
            // 
            // btnDManagerEdit
            // 
            this.btnDManagerEdit.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDManagerEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDManagerEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDManagerEdit.Location = new System.Drawing.Point(768, 455);
            this.btnDManagerEdit.Name = "btnDManagerEdit";
            this.btnDManagerEdit.Size = new System.Drawing.Size(125, 43);
            this.btnDManagerEdit.TabIndex = 34;
            this.btnDManagerEdit.Text = "Edit";
            this.btnDManagerEdit.UseVisualStyleBackColor = false;
            // 
            // btnDManagerSchedule
            // 
            this.btnDManagerSchedule.BackColor = System.Drawing.Color.SlateGray;
            this.btnDManagerSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDManagerSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDManagerSchedule.Location = new System.Drawing.Point(32, 242);
            this.btnDManagerSchedule.Name = "btnDManagerSchedule";
            this.btnDManagerSchedule.Size = new System.Drawing.Size(146, 42);
            this.btnDManagerSchedule.TabIndex = 3;
            this.btnDManagerSchedule.Text = "Schedule";
            this.btnDManagerSchedule.UseVisualStyleBackColor = false;
            // 
            // DepartmentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDManagerAddress);
            this.Controls.Add(this.lblDManagerEmail);
            this.Controls.Add(this.lblDManagerPhoneNum);
            this.Controls.Add(this.lblDManagerPosition);
            this.Controls.Add(this.lblDManagerLName);
            this.Controls.Add(this.lblDManagerFName);
            this.Controls.Add(this.pbxDManager);
            this.Controls.Add(this.btnDManagerEdit);
            this.Controls.Add(this.panel1);
            this.Name = "DepartmentManager";
            this.Size = new System.Drawing.Size(924, 530);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnDManagerEmployeeStatistic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDManagerLogOut;
        private System.Windows.Forms.Button btnDManagerAccount;
        private System.Windows.Forms.Label lblDManagerAddress;
        private System.Windows.Forms.Label lblDManagerEmail;
        private System.Windows.Forms.Label lblDManagerPhoneNum;
        private System.Windows.Forms.Label lblDManagerPosition;
        private System.Windows.Forms.Label lblDManagerLName;
        private System.Windows.Forms.Label lblDManagerFName;
        private System.Windows.Forms.PictureBox pbxDManager;
        private System.Windows.Forms.Button btnDManagerEdit;
        private System.Windows.Forms.Button btnDManagerSchedule;
    }
}
