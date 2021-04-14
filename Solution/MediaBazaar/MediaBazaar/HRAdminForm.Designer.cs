﻿
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
            this.userInterface1 = new MediaBazaar.UserInterface();
            this.manageEmployeeInterface1 = new MediaBazaar.ManageEmployeeInterface();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 777);
            this.panel1.TabIndex = 26;
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(36, 14);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(164, 168);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 2;
            this.pbxLogo.TabStop = false;
            // 
            // btnHRAdminManageEmployee
            // 
            this.btnHRAdminManageEmployee.BackColor = System.Drawing.Color.SlateGray;
            this.btnHRAdminManageEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHRAdminManageEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHRAdminManageEmployee.Location = new System.Drawing.Point(36, 234);
            this.btnHRAdminManageEmployee.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnHRAdminManageEmployee.Name = "btnHRAdminManageEmployee";
            this.btnHRAdminManageEmployee.Size = new System.Drawing.Size(164, 109);
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
            this.panel2.Location = new System.Drawing.Point(-1, 427);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 349);
            this.panel2.TabIndex = 0;
            // 
            // btnHRAdminLogOut
            // 
            this.btnHRAdminLogOut.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnHRAdminLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHRAdminLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHRAdminLogOut.Location = new System.Drawing.Point(36, 236);
            this.btnHRAdminLogOut.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnHRAdminLogOut.Name = "btnHRAdminLogOut";
            this.btnHRAdminLogOut.Size = new System.Drawing.Size(164, 54);
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
            this.btnHRAdminAccount.Location = new System.Drawing.Point(36, 69);
            this.btnHRAdminAccount.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnHRAdminAccount.Name = "btnHRAdminAccount";
            this.btnHRAdminAccount.Size = new System.Drawing.Size(164, 54);
            this.btnHRAdminAccount.TabIndex = 2;
            this.btnHRAdminAccount.Text = "My account";
            this.btnHRAdminAccount.UseVisualStyleBackColor = false;
            this.btnHRAdminAccount.Click += new System.EventHandler(this.btnHRAdminAccount_Click);
            // 
            // userInterface1
            // 
            this.userInterface1.Location = new System.Drawing.Point(248, 0);
            this.userInterface1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userInterface1.Name = "userInterface1";
            this.userInterface1.Size = new System.Drawing.Size(1345, 896);
            this.userInterface1.TabIndex = 31;
            // 
            // manageEmployeeInterface1
            // 
            this.manageEmployeeInterface1.Location = new System.Drawing.Point(237, 0);
            this.manageEmployeeInterface1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manageEmployeeInterface1.Name = "manageEmployeeInterface1";
            this.manageEmployeeInterface1.Size = new System.Drawing.Size(1119, 777);
            this.manageEmployeeInterface1.TabIndex = 32;
            // 
            // HRAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1336, 777);
            this.Controls.Add(this.manageEmployeeInterface1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userInterface1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.Name = "HRAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR Admin Form";
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
        private UserInterface userInterface1;
        private ManageEmployeeInterface manageEmployeeInterface1;
    }
}