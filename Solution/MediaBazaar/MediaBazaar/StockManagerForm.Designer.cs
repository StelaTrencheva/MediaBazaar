
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
            this.btnStockMSchedule = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStockMLogOut = new System.Windows.Forms.Button();
            this.btnStockMAccount = new System.Windows.Forms.Button();
            this.stockManagerInterface1 = new MediaBazaar.StockManagerInterface();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnStockMSchedule);
            this.panel1.Controls.Add(this.pbxLogo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 528);
            this.panel1.TabIndex = 43;
            // 
            // btnStockMSchedule
            // 
            this.btnStockMSchedule.BackColor = System.Drawing.Color.SlateGray;
            this.btnStockMSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockMSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockMSchedule.Location = new System.Drawing.Point(32, 206);
            this.btnStockMSchedule.Name = "btnStockMSchedule";
            this.btnStockMSchedule.Size = new System.Drawing.Size(146, 42);
            this.btnStockMSchedule.TabIndex = 3;
            this.btnStockMSchedule.Text = "Schedule";
            this.btnStockMSchedule.UseVisualStyleBackColor = false;
            this.btnStockMSchedule.Click += new System.EventHandler(this.btnStockMSchedule_Click);
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
            this.panel2.Controls.Add(this.btnStockMLogOut);
            this.panel2.Controls.Add(this.btnStockMAccount);
            this.panel2.Location = new System.Drawing.Point(-1, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 217);
            this.panel2.TabIndex = 0;
            // 
            // btnStockMLogOut
            // 
            this.btnStockMLogOut.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnStockMLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockMLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockMLogOut.Location = new System.Drawing.Point(32, 142);
            this.btnStockMLogOut.Name = "btnStockMLogOut";
            this.btnStockMLogOut.Size = new System.Drawing.Size(146, 43);
            this.btnStockMLogOut.TabIndex = 3;
            this.btnStockMLogOut.Text = "Log out";
            this.btnStockMLogOut.UseVisualStyleBackColor = false;
            this.btnStockMLogOut.Click += new System.EventHandler(this.btnStockMLogOut_Click);
            // 
            // btnStockMAccount
            // 
            this.btnStockMAccount.BackColor = System.Drawing.Color.White;
            this.btnStockMAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockMAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockMAccount.Location = new System.Drawing.Point(32, 47);
            this.btnStockMAccount.Name = "btnStockMAccount";
            this.btnStockMAccount.Size = new System.Drawing.Size(146, 43);
            this.btnStockMAccount.TabIndex = 2;
            this.btnStockMAccount.Text = "My account";
            this.btnStockMAccount.UseVisualStyleBackColor = false;
            this.btnStockMAccount.Click += new System.EventHandler(this.btnStockMAccount_Click);
            // 
            // stockManagerInterface1
            // 
            this.stockManagerInterface1.Location = new System.Drawing.Point(213, 0);
            this.stockManagerInterface1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stockManagerInterface1.Name = "stockManagerInterface1";
            this.stockManagerInterface1.Size = new System.Drawing.Size(890, 530);
            this.stockManagerInterface1.TabIndex = 44;
            this.stockManagerInterface1.Load += new System.EventHandler(this.stockManagerInterface1_Load);
            // 
            // StockManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1126, 528);
            this.Controls.Add(this.stockManagerInterface1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StockManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockManagerForm";
            this.Load += new System.EventHandler(this.StockManagerForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStockMSchedule;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStockMLogOut;
        private System.Windows.Forms.Button btnStockMAccount;
        private StockManagerInterface stockManagerInterface1;
    }
}