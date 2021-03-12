
namespace MediaBazaar
{
    partial class DepartmentManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentManagerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDepartmentMSchedule = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDepartmentMLogOut = new System.Windows.Forms.Button();
            this.btnDepartmentMAccount = new System.Windows.Forms.Button();
            this.departmentManagerInterface1 = new MediaBazaar.DepartmentManagerInterface();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDepartmentMSchedule);
            this.panel1.Controls.Add(this.pbxLogo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 660);
            this.panel1.TabIndex = 34;
            // 
            // btnDepartmentMSchedule
            // 
            this.btnDepartmentMSchedule.BackColor = System.Drawing.Color.SlateGray;
            this.btnDepartmentMSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmentMSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartmentMSchedule.Location = new System.Drawing.Point(36, 258);
            this.btnDepartmentMSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDepartmentMSchedule.Name = "btnDepartmentMSchedule";
            this.btnDepartmentMSchedule.Size = new System.Drawing.Size(164, 52);
            this.btnDepartmentMSchedule.TabIndex = 3;
            this.btnDepartmentMSchedule.Text = "Schedule";
            this.btnDepartmentMSchedule.UseVisualStyleBackColor = false;
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(36, 15);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(164, 168);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 2;
            this.pbxLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDepartmentMLogOut);
            this.panel2.Controls.Add(this.btnDepartmentMAccount);
            this.panel2.Location = new System.Drawing.Point(-1, 389);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 271);
            this.panel2.TabIndex = 0;
            // 
            // btnDepartmentMLogOut
            // 
            this.btnDepartmentMLogOut.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDepartmentMLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmentMLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartmentMLogOut.Location = new System.Drawing.Point(36, 178);
            this.btnDepartmentMLogOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDepartmentMLogOut.Name = "btnDepartmentMLogOut";
            this.btnDepartmentMLogOut.Size = new System.Drawing.Size(164, 54);
            this.btnDepartmentMLogOut.TabIndex = 3;
            this.btnDepartmentMLogOut.Text = "Log out";
            this.btnDepartmentMLogOut.UseVisualStyleBackColor = false;
            this.btnDepartmentMLogOut.Click += new System.EventHandler(this.btnDepartmentMLogOut_Click);
            // 
            // btnDepartmentMAccount
            // 
            this.btnDepartmentMAccount.BackColor = System.Drawing.Color.White;
            this.btnDepartmentMAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmentMAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartmentMAccount.Location = new System.Drawing.Point(36, 59);
            this.btnDepartmentMAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDepartmentMAccount.Name = "btnDepartmentMAccount";
            this.btnDepartmentMAccount.Size = new System.Drawing.Size(164, 54);
            this.btnDepartmentMAccount.TabIndex = 2;
            this.btnDepartmentMAccount.Text = "My account";
            this.btnDepartmentMAccount.UseVisualStyleBackColor = false;
            // 
            // departmentManagerInterface1
            // 
            this.departmentManagerInterface1.Location = new System.Drawing.Point(240, 0);
            this.departmentManagerInterface1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.departmentManagerInterface1.Name = "departmentManagerInterface1";
            this.departmentManagerInterface1.Size = new System.Drawing.Size(807, 662);
            this.departmentManagerInterface1.TabIndex = 35;
            // 
            // DepartmentManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1019, 660);
            this.Controls.Add(this.departmentManagerInterface1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DepartmentManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepartmentManagerFormcs";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDepartmentMSchedule;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDepartmentMLogOut;
        private System.Windows.Forms.Button btnDepartmentMAccount;
        private DepartmentManagerInterface departmentManagerInterface1;
    }
}