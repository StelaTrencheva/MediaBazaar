
namespace MediaBazaar
{
    partial class HRAdminForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HRAdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnHRAdminManageEmployee = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHRAdminLogOut = new System.Windows.Forms.Button();
            this.btnHRAdminAccount = new System.Windows.Forms.Button();
            this.manageEmployeeInterface1 = new MediaBazaar.ManageEmployeeInterface();
            this.hrAdminInterface1 = new MediaBazaar.HRAdminInterface();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbxLogo);
            this.panel1.Controls.Add(this.btnHRAdminManageEmployee);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 528);
            this.panel1.TabIndex = 26;
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
            // btnHRAdminManageEmployee
            // 
            this.btnHRAdminManageEmployee.BackColor = System.Drawing.Color.SlateGray;
            this.btnHRAdminManageEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHRAdminManageEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHRAdminManageEmployee.Location = new System.Drawing.Point(32, 187);
            this.btnHRAdminManageEmployee.Name = "btnHRAdminManageEmployee";
            this.btnHRAdminManageEmployee.Size = new System.Drawing.Size(146, 87);
            this.btnHRAdminManageEmployee.TabIndex = 1;
            this.btnHRAdminManageEmployee.Text = "Manage employees profiles";
            this.btnHRAdminManageEmployee.UseVisualStyleBackColor = false;
            this.btnHRAdminManageEmployee.Click += new System.EventHandler(this.btnManageEmployee_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnHRAdminLogOut);
            this.panel2.Controls.Add(this.btnHRAdminAccount);
            this.panel2.Location = new System.Drawing.Point(-1, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 217);
            this.panel2.TabIndex = 0;
            // 
            // btnHRAdminLogOut
            // 
            this.btnHRAdminLogOut.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnHRAdminLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHRAdminLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHRAdminLogOut.Location = new System.Drawing.Point(32, 142);
            this.btnHRAdminLogOut.Name = "btnHRAdminLogOut";
            this.btnHRAdminLogOut.Size = new System.Drawing.Size(146, 43);
            this.btnHRAdminLogOut.TabIndex = 3;
            this.btnHRAdminLogOut.Text = "Log out";
            this.btnHRAdminLogOut.UseVisualStyleBackColor = false;
            this.btnHRAdminLogOut.Click += new System.EventHandler(this.btnHRAdminLogOut_Click);
            // 
            // btnHRAdminAccount
            // 
            this.btnHRAdminAccount.BackColor = System.Drawing.Color.White;
            this.btnHRAdminAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHRAdminAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHRAdminAccount.Location = new System.Drawing.Point(32, 47);
            this.btnHRAdminAccount.Name = "btnHRAdminAccount";
            this.btnHRAdminAccount.Size = new System.Drawing.Size(146, 43);
            this.btnHRAdminAccount.TabIndex = 2;
            this.btnHRAdminAccount.Text = "My account";
            this.btnHRAdminAccount.UseVisualStyleBackColor = false;
            this.btnHRAdminAccount.Click += new System.EventHandler(this.btnHRAdminAccount_Click);
            // 
            // manageEmployeeInterface1
            // 
            this.manageEmployeeInterface1.Location = new System.Drawing.Point(213, 0);
            this.manageEmployeeInterface1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manageEmployeeInterface1.Name = "manageEmployeeInterface1";
            this.manageEmployeeInterface1.Size = new System.Drawing.Size(890, 530);
            this.manageEmployeeInterface1.TabIndex = 28;
            this.manageEmployeeInterface1.Load += new System.EventHandler(this.manageEmployeeInterface1_Load);
            // 
            // hrAdminInterface1
            // 
            this.hrAdminInterface1.Location = new System.Drawing.Point(213, 0);
            this.hrAdminInterface1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hrAdminInterface1.Name = "hrAdminInterface1";
            this.hrAdminInterface1.Size = new System.Drawing.Size(890, 530);
            this.hrAdminInterface1.TabIndex = 27;
            // 
            // HRAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1126, 528);
            this.Controls.Add(this.manageEmployeeInterface1);
            this.Controls.Add(this.hrAdminInterface1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HRAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HRAdminForm";
            this.Load += new System.EventHandler(this.HRAdminForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnHRAdminManageEmployee;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHRAdminLogOut;
        private System.Windows.Forms.Button btnHRAdminAccount;
        private HRAdminInterface hrAdminInterface1;
        private ManageEmployeeInterface manageEmployeeInterface1;
    }
}