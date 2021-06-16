namespace MediaBazaar
{
    partial class StockManagerSupplierRequest
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
            this.btnDenyRequest = new System.Windows.Forms.Button();
            this.btnProceedRequest = new System.Windows.Forms.Button();
            this.gbxSupplierRequestProductInfo = new System.Windows.Forms.GroupBox();
            this.lblRequestedAmount = new System.Windows.Forms.Label();
            this.pnlMinimumStock = new System.Windows.Forms.Panel();
            this.lblSupplierRequestAmount = new System.Windows.Forms.Label();
            this.lblProductBrand = new System.Windows.Forms.Label();
            this.lblProductTypeAndModel = new System.Windows.Forms.Label();
            this.pnlViewSupplierRequests = new System.Windows.Forms.Panel();
            this.lbxSupplierRequests = new System.Windows.Forms.ListBox();
            this.lblViewSupplierRequests = new System.Windows.Forms.Label();
            this.gbxSupplierRequestProductInfo.SuspendLayout();
            this.pnlMinimumStock.SuspendLayout();
            this.pnlViewSupplierRequests.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDenyRequest
            // 
            this.btnDenyRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDenyRequest.Location = new System.Drawing.Point(851, 334);
            this.btnDenyRequest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDenyRequest.Name = "btnDenyRequest";
            this.btnDenyRequest.Size = new System.Drawing.Size(227, 49);
            this.btnDenyRequest.TabIndex = 14;
            this.btnDenyRequest.Text = "Deny request";
            this.btnDenyRequest.UseVisualStyleBackColor = true;
            this.btnDenyRequest.Click += new System.EventHandler(this.btnDenyRequest_Click);
            // 
            // btnProceedRequest
            // 
            this.btnProceedRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProceedRequest.Location = new System.Drawing.Point(575, 334);
            this.btnProceedRequest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProceedRequest.Name = "btnProceedRequest";
            this.btnProceedRequest.Size = new System.Drawing.Size(227, 49);
            this.btnProceedRequest.TabIndex = 13;
            this.btnProceedRequest.Text = "Proceed request";
            this.btnProceedRequest.UseVisualStyleBackColor = true;
            this.btnProceedRequest.Click += new System.EventHandler(this.btnProceedRequest_Click);
            // 
            // gbxSupplierRequestProductInfo
            // 
            this.gbxSupplierRequestProductInfo.BackColor = System.Drawing.Color.White;
            this.gbxSupplierRequestProductInfo.Controls.Add(this.lblRequestedAmount);
            this.gbxSupplierRequestProductInfo.Controls.Add(this.pnlMinimumStock);
            this.gbxSupplierRequestProductInfo.Controls.Add(this.lblProductBrand);
            this.gbxSupplierRequestProductInfo.Controls.Add(this.lblProductTypeAndModel);
            this.gbxSupplierRequestProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxSupplierRequestProductInfo.Location = new System.Drawing.Point(575, 86);
            this.gbxSupplierRequestProductInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSupplierRequestProductInfo.Name = "gbxSupplierRequestProductInfo";
            this.gbxSupplierRequestProductInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSupplierRequestProductInfo.Size = new System.Drawing.Size(503, 229);
            this.gbxSupplierRequestProductInfo.TabIndex = 12;
            this.gbxSupplierRequestProductInfo.TabStop = false;
            // 
            // lblRequestedAmount
            // 
            this.lblRequestedAmount.AutoSize = true;
            this.lblRequestedAmount.Location = new System.Drawing.Point(29, 146);
            this.lblRequestedAmount.Name = "lblRequestedAmount";
            this.lblRequestedAmount.Size = new System.Drawing.Size(228, 29);
            this.lblRequestedAmount.TabIndex = 7;
            this.lblRequestedAmount.Text = "Requested amount: ";
            // 
            // pnlMinimumStock
            // 
            this.pnlMinimumStock.BackColor = System.Drawing.Color.YellowGreen;
            this.pnlMinimumStock.Controls.Add(this.lblSupplierRequestAmount);
            this.pnlMinimumStock.Location = new System.Drawing.Point(294, 146);
            this.pnlMinimumStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMinimumStock.Name = "pnlMinimumStock";
            this.pnlMinimumStock.Size = new System.Drawing.Size(178, 63);
            this.pnlMinimumStock.TabIndex = 6;
            // 
            // lblSupplierRequestAmount
            // 
            this.lblSupplierRequestAmount.AutoSize = true;
            this.lblSupplierRequestAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSupplierRequestAmount.Location = new System.Drawing.Point(71, 16);
            this.lblSupplierRequestAmount.Name = "lblSupplierRequestAmount";
            this.lblSupplierRequestAmount.Size = new System.Drawing.Size(39, 29);
            this.lblSupplierRequestAmount.TabIndex = 5;
            this.lblSupplierRequestAmount.Text = "00";
            // 
            // lblProductBrand
            // 
            this.lblProductBrand.AutoSize = true;
            this.lblProductBrand.Location = new System.Drawing.Point(29, 84);
            this.lblProductBrand.Name = "lblProductBrand";
            this.lblProductBrand.Size = new System.Drawing.Size(83, 29);
            this.lblProductBrand.TabIndex = 1;
            this.lblProductBrand.Text = "Brand ";
            // 
            // lblProductTypeAndModel
            // 
            this.lblProductTypeAndModel.AutoSize = true;
            this.lblProductTypeAndModel.Location = new System.Drawing.Point(29, 31);
            this.lblProductTypeAndModel.Name = "lblProductTypeAndModel";
            this.lblProductTypeAndModel.Size = new System.Drawing.Size(188, 29);
            this.lblProductTypeAndModel.TabIndex = 0;
            this.lblProductTypeAndModel.Text = "Type and model";
            // 
            // pnlViewSupplierRequests
            // 
            this.pnlViewSupplierRequests.BackColor = System.Drawing.Color.White;
            this.pnlViewSupplierRequests.Controls.Add(this.lbxSupplierRequests);
            this.pnlViewSupplierRequests.Location = new System.Drawing.Point(37, 86);
            this.pnlViewSupplierRequests.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlViewSupplierRequests.Name = "pnlViewSupplierRequests";
            this.pnlViewSupplierRequests.Size = new System.Drawing.Size(505, 297);
            this.pnlViewSupplierRequests.TabIndex = 11;
            // 
            // lbxSupplierRequests
            // 
            this.lbxSupplierRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxSupplierRequests.FormattingEnabled = true;
            this.lbxSupplierRequests.ItemHeight = 29;
            this.lbxSupplierRequests.Location = new System.Drawing.Point(13, 20);
            this.lbxSupplierRequests.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxSupplierRequests.Name = "lbxSupplierRequests";
            this.lbxSupplierRequests.Size = new System.Drawing.Size(478, 265);
            this.lbxSupplierRequests.TabIndex = 0;
            this.lbxSupplierRequests.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbxSupplierRequests_DrawItem);
            this.lbxSupplierRequests.DoubleClick += new System.EventHandler(this.lbxSupplierRequests_DoubleClick);
            this.lbxSupplierRequests.MouseLeave += new System.EventHandler(this.lbxSupplierRequests_MouseLeave);
            this.lbxSupplierRequests.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbxSupplierRequests_MouseMove);
            // 
            // lblViewSupplierRequests
            // 
            this.lblViewSupplierRequests.AutoSize = true;
            this.lblViewSupplierRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblViewSupplierRequests.Location = new System.Drawing.Point(32, 37);
            this.lblViewSupplierRequests.Name = "lblViewSupplierRequests";
            this.lblViewSupplierRequests.Size = new System.Drawing.Size(374, 32);
            this.lblViewSupplierRequests.TabIndex = 10;
            this.lblViewSupplierRequests.Text = "View supplier stock requests";
            // 
            // StockManagerSupplierRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDenyRequest);
            this.Controls.Add(this.btnProceedRequest);
            this.Controls.Add(this.gbxSupplierRequestProductInfo);
            this.Controls.Add(this.pnlViewSupplierRequests);
            this.Controls.Add(this.lblViewSupplierRequests);
            this.Name = "StockManagerSupplierRequest";
            this.Size = new System.Drawing.Size(1129, 785);
            this.gbxSupplierRequestProductInfo.ResumeLayout(false);
            this.gbxSupplierRequestProductInfo.PerformLayout();
            this.pnlMinimumStock.ResumeLayout(false);
            this.pnlMinimumStock.PerformLayout();
            this.pnlViewSupplierRequests.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDenyRequest;
        private System.Windows.Forms.Button btnProceedRequest;
        private System.Windows.Forms.GroupBox gbxSupplierRequestProductInfo;
        private System.Windows.Forms.Label lblRequestedAmount;
        private System.Windows.Forms.Panel pnlMinimumStock;
        private System.Windows.Forms.Label lblSupplierRequestAmount;
        private System.Windows.Forms.Label lblProductBrand;
        private System.Windows.Forms.Label lblProductTypeAndModel;
        private System.Windows.Forms.Panel pnlViewSupplierRequests;
        private System.Windows.Forms.ListBox lbxSupplierRequests;
        private System.Windows.Forms.Label lblViewSupplierRequests;
    }
}
