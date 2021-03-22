
namespace MediaBazaar
{
    partial class StoreManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreManagerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStoreMEmployeeStatistic = new System.Windows.Forms.Button();
            this.btnStoreMStockStatistic = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStoreMLogOut = new System.Windows.Forms.Button();
            this.btnStoreM = new System.Windows.Forms.Button();
            this.storeManagerInterface1 = new MediaBazaar.StoreManagerInterface();
            this.employeeStatistics1 = new MediaBazaar.EmployeeStatistics();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnStoreMEmployeeStatistic);
            this.panel1.Controls.Add(this.btnStoreMStockStatistic);
            this.panel1.Controls.Add(this.pbxLogo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 528);
            this.panel1.TabIndex = 44;
            // 
            // btnStoreMEmployeeStatistic
            // 
            this.btnStoreMEmployeeStatistic.BackColor = System.Drawing.Color.SlateGray;
            this.btnStoreMEmployeeStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoreMEmployeeStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoreMEmployeeStatistic.Location = new System.Drawing.Point(29, 161);
            this.btnStoreMEmployeeStatistic.Name = "btnStoreMEmployeeStatistic";
            this.btnStoreMEmployeeStatistic.Size = new System.Drawing.Size(146, 64);
            this.btnStoreMEmployeeStatistic.TabIndex = 4;
            this.btnStoreMEmployeeStatistic.Text = "Employee Statistic";
            this.btnStoreMEmployeeStatistic.UseVisualStyleBackColor = false;
            this.btnStoreMEmployeeStatistic.Click += new System.EventHandler(this.btnStoreMEmployeeStatistic_Click);
            // 
            // btnStoreMStockStatistic
            // 
            this.btnStoreMStockStatistic.BackColor = System.Drawing.Color.SlateGray;
            this.btnStoreMStockStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoreMStockStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoreMStockStatistic.Location = new System.Drawing.Point(29, 231);
            this.btnStoreMStockStatistic.Name = "btnStoreMStockStatistic";
            this.btnStoreMStockStatistic.Size = new System.Drawing.Size(146, 64);
            this.btnStoreMStockStatistic.TabIndex = 3;
            this.btnStoreMStockStatistic.Text = "Stock Statistic";
            this.btnStoreMStockStatistic.UseVisualStyleBackColor = false;
            this.btnStoreMStockStatistic.Click += new System.EventHandler(this.btnStoreMStockStatistic_Click);
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnStoreMLogOut);
            this.panel2.Controls.Add(this.btnStoreM);
            this.panel2.Location = new System.Drawing.Point(-1, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 217);
            this.panel2.TabIndex = 0;
            // 
            // btnStoreMLogOut
            // 
            this.btnStoreMLogOut.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnStoreMLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoreMLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoreMLogOut.Location = new System.Drawing.Point(32, 142);
            this.btnStoreMLogOut.Name = "btnStoreMLogOut";
            this.btnStoreMLogOut.Size = new System.Drawing.Size(146, 43);
            this.btnStoreMLogOut.TabIndex = 3;
            this.btnStoreMLogOut.Text = "Log out";
            this.btnStoreMLogOut.UseVisualStyleBackColor = false;
            this.btnStoreMLogOut.Click += new System.EventHandler(this.btnStoreMLogOut_Click);
            // 
            // btnStoreM
            // 
            this.btnStoreM.BackColor = System.Drawing.Color.White;
            this.btnStoreM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoreM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStoreM.Location = new System.Drawing.Point(32, 47);
            this.btnStoreM.Name = "btnStoreM";
            this.btnStoreM.Size = new System.Drawing.Size(146, 43);
            this.btnStoreM.TabIndex = 2;
            this.btnStoreM.Text = "My account";
            this.btnStoreM.UseVisualStyleBackColor = false;
            this.btnStoreM.Click += new System.EventHandler(this.btnStoreM_Click);
            // 
            // storeManagerInterface1
            // 
            this.storeManagerInterface1.Location = new System.Drawing.Point(213, 0);
            this.storeManagerInterface1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.storeManagerInterface1.Name = "storeManagerInterface1";
            this.storeManagerInterface1.Size = new System.Drawing.Size(890, 530);
            this.storeManagerInterface1.TabIndex = 45;
            // 
            // employeeStatistics1
            // 
            this.employeeStatistics1.BackColor = System.Drawing.Color.Transparent;
            this.employeeStatistics1.Location = new System.Drawing.Point(224, -2);
            this.employeeStatistics1.Name = "employeeStatistics1";
            this.employeeStatistics1.Size = new System.Drawing.Size(890, 530);
            this.employeeStatistics1.TabIndex = 46;
            // 
            // StoreManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1126, 528);
            this.Controls.Add(this.employeeStatistics1);
            this.Controls.Add(this.storeManagerInterface1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StoreManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoreManagerForm";
            this.Load += new System.EventHandler(this.StoreManagerForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStoreMLogOut;
        private System.Windows.Forms.Button btnStoreM;
        private System.Windows.Forms.Button btnStoreMStockStatistic;
        private System.Windows.Forms.Button btnStoreMEmployeeStatistic;
        private StoreManagerInterface storeManagerInterface1;
        private EmployeeStatistics employeeStatistics1;
    }
}