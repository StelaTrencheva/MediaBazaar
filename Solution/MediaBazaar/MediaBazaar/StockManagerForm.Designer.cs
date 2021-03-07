
namespace MediaBazaar
{
    partial class StockManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockManagerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSManagerSchedule = new System.Windows.Forms.Button();
            this.btnSManagerStockStatistic = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSManagerLogOut = new System.Windows.Forms.Button();
            this.btnSManagerAccount = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.stockManagerInterface1 = new MediaBazaar.StockManagerInterface();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSManagerSchedule);
            this.panel1.Controls.Add(this.pbxLogo);
            this.panel1.Controls.Add(this.btnSManagerStockStatistic);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 528);
            this.panel1.TabIndex = 43;
            // 
            // btnSManagerSchedule
            // 
            this.btnSManagerSchedule.BackColor = System.Drawing.Color.SlateGray;
            this.btnSManagerSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSManagerSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSManagerSchedule.Location = new System.Drawing.Point(32, 242);
            this.btnSManagerSchedule.Name = "btnSManagerSchedule";
            this.btnSManagerSchedule.Size = new System.Drawing.Size(146, 42);
            this.btnSManagerSchedule.TabIndex = 3;
            this.btnSManagerSchedule.Text = "Schedule";
            this.btnSManagerSchedule.UseVisualStyleBackColor = false;
            // 
            // btnSManagerStockStatistic
            // 
            this.btnSManagerStockStatistic.BackColor = System.Drawing.Color.SlateGray;
            this.btnSManagerStockStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSManagerStockStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSManagerStockStatistic.Location = new System.Drawing.Point(32, 152);
            this.btnSManagerStockStatistic.Name = "btnSManagerStockStatistic";
            this.btnSManagerStockStatistic.Size = new System.Drawing.Size(146, 64);
            this.btnSManagerStockStatistic.TabIndex = 1;
            this.btnSManagerStockStatistic.Text = "Stock Statistic";
            this.btnSManagerStockStatistic.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSManagerLogOut);
            this.panel2.Controls.Add(this.btnSManagerAccount);
            this.panel2.Location = new System.Drawing.Point(-1, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 217);
            this.panel2.TabIndex = 0;
            // 
            // btnSManagerLogOut
            // 
            this.btnSManagerLogOut.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSManagerLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSManagerLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSManagerLogOut.Location = new System.Drawing.Point(32, 142);
            this.btnSManagerLogOut.Name = "btnSManagerLogOut";
            this.btnSManagerLogOut.Size = new System.Drawing.Size(146, 43);
            this.btnSManagerLogOut.TabIndex = 3;
            this.btnSManagerLogOut.Text = "Log out";
            this.btnSManagerLogOut.UseVisualStyleBackColor = false;
            // 
            // btnSManagerAccount
            // 
            this.btnSManagerAccount.BackColor = System.Drawing.Color.White;
            this.btnSManagerAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSManagerAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSManagerAccount.Location = new System.Drawing.Point(32, 47);
            this.btnSManagerAccount.Name = "btnSManagerAccount";
            this.btnSManagerAccount.Size = new System.Drawing.Size(146, 43);
            this.btnSManagerAccount.TabIndex = 2;
            this.btnSManagerAccount.Text = "My account";
            this.btnSManagerAccount.UseVisualStyleBackColor = false;
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
            // stockManagerInterface1
            // 
            this.stockManagerInterface1.Location = new System.Drawing.Point(212, 0);
            this.stockManagerInterface1.Name = "stockManagerInterface1";
            this.stockManagerInterface1.Size = new System.Drawing.Size(717, 530);
            this.stockManagerInterface1.TabIndex = 44;
            // 
            // StockManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(906, 528);
            this.Controls.Add(this.stockManagerInterface1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StockManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockManagerForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSManagerSchedule;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnSManagerStockStatistic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSManagerLogOut;
        private System.Windows.Forms.Button btnSManagerAccount;
        private StockManagerInterface stockManagerInterface1;
    }
}