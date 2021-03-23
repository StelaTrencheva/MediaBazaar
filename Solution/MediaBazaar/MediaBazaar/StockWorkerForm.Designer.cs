
namespace MediaBazaar
{
    partial class StockWorkerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockWorkerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStockWProductData = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnStockWRestockRequest = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStockWLogOut = new System.Windows.Forms.Button();
            this.btnStockWAccount = new System.Windows.Forms.Button();
            this.productData1 = new MediaBazaar.ProductData();
            this.stockWorkerInterface1 = new MediaBazaar.StockWorkerInterface();
            this.restockRequestInterface1 = new MediaBazaar.RestockRequestInterface();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnStockWProductData);
            this.panel1.Controls.Add(this.pbxLogo);
            this.panel1.Controls.Add(this.btnStockWRestockRequest);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 528);
            this.panel1.TabIndex = 52;
            // 
            // btnStockWProductData
            // 
            this.btnStockWProductData.BackColor = System.Drawing.Color.SlateGray;
            this.btnStockWProductData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockWProductData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockWProductData.Location = new System.Drawing.Point(32, 159);
            this.btnStockWProductData.Name = "btnStockWProductData";
            this.btnStockWProductData.Size = new System.Drawing.Size(146, 64);
            this.btnStockWProductData.TabIndex = 3;
            this.btnStockWProductData.Text = "Product data";
            this.btnStockWProductData.UseVisualStyleBackColor = false;
            this.btnStockWProductData.Click += new System.EventHandler(this.btnStockWProductData_Click);
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
            // btnStockWRestockRequest
            // 
            this.btnStockWRestockRequest.BackColor = System.Drawing.Color.SlateGray;
            this.btnStockWRestockRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockWRestockRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockWRestockRequest.Location = new System.Drawing.Point(32, 229);
            this.btnStockWRestockRequest.Name = "btnStockWRestockRequest";
            this.btnStockWRestockRequest.Size = new System.Drawing.Size(146, 64);
            this.btnStockWRestockRequest.TabIndex = 1;
            this.btnStockWRestockRequest.Text = "Restock Request";
            this.btnStockWRestockRequest.UseVisualStyleBackColor = false;
            this.btnStockWRestockRequest.Click += new System.EventHandler(this.btnStockWRestockRequest_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnStockWLogOut);
            this.panel2.Controls.Add(this.btnStockWAccount);
            this.panel2.Location = new System.Drawing.Point(-1, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 217);
            this.panel2.TabIndex = 0;
            // 
            // btnStockWLogOut
            // 
            this.btnStockWLogOut.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnStockWLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockWLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockWLogOut.Location = new System.Drawing.Point(32, 142);
            this.btnStockWLogOut.Name = "btnStockWLogOut";
            this.btnStockWLogOut.Size = new System.Drawing.Size(146, 43);
            this.btnStockWLogOut.TabIndex = 3;
            this.btnStockWLogOut.Text = "Log out";
            this.btnStockWLogOut.UseVisualStyleBackColor = false;
            this.btnStockWLogOut.Click += new System.EventHandler(this.btnStockWLogOut_Click);
            // 
            // btnStockWAccount
            // 
            this.btnStockWAccount.BackColor = System.Drawing.Color.White;
            this.btnStockWAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockWAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockWAccount.Location = new System.Drawing.Point(32, 47);
            this.btnStockWAccount.Name = "btnStockWAccount";
            this.btnStockWAccount.Size = new System.Drawing.Size(146, 43);
            this.btnStockWAccount.TabIndex = 2;
            this.btnStockWAccount.Text = "My account";
            this.btnStockWAccount.UseVisualStyleBackColor = false;
            this.btnStockWAccount.Click += new System.EventHandler(this.btnStockWAccount_Click);
            // 
            // productData1
            // 
            this.productData1.Location = new System.Drawing.Point(213, 0);
            this.productData1.Name = "productData1";
            this.productData1.Size = new System.Drawing.Size(890, 530);
            this.productData1.TabIndex = 54;
            // 
            // stockWorkerInterface1
            // 
            this.stockWorkerInterface1.Location = new System.Drawing.Point(212, 0);
            this.stockWorkerInterface1.Name = "stockWorkerInterface1";
            this.stockWorkerInterface1.Size = new System.Drawing.Size(890, 530);
            this.stockWorkerInterface1.TabIndex = 53;
            // 
            // restockRequestInterface1
            // 
            this.restockRequestInterface1.Location = new System.Drawing.Point(212, 0);
            this.restockRequestInterface1.Name = "restockRequestInterface1";
            this.restockRequestInterface1.Size = new System.Drawing.Size(882, 501);
            this.restockRequestInterface1.TabIndex = 55;
            // 
            // StockWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1126, 528);
            this.Controls.Add(this.restockRequestInterface1);
            this.Controls.Add(this.productData1);
            this.Controls.Add(this.stockWorkerInterface1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StockWorkerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockWorkerForm";
            this.Load += new System.EventHandler(this.StockWorkerForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnStockWRestockRequest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStockWLogOut;
        private System.Windows.Forms.Button btnStockWAccount;
        private System.Windows.Forms.Button btnStockWProductData;
        private StockWorkerInterface stockWorkerInterface1;
        private ProductData productData1;
        private RestockRequestInterface restockRequestInterface1;
    }
}