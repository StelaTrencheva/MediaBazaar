
namespace MediaBazaar
{
    partial class RestockRequestInterface
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
            this.lblRestockRequest = new System.Windows.Forms.Label();
            this.gbxProductInformation = new System.Windows.Forms.GroupBox();
            this.lblRequestedAmount = new System.Windows.Forms.Label();
            this.pnlAmountInWarehouse = new System.Windows.Forms.Panel();
            this.lblAmountInWarehouse = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStockMessage = new System.Windows.Forms.Label();
            this.pnlAmountInStore = new System.Windows.Forms.Panel();
            this.lblAmountInStore = new System.Windows.Forms.Label();
            this.lblProductBrand = new System.Windows.Forms.Label();
            this.lblProductTypeAndModel = new System.Windows.Forms.Label();
            this.lbxRestockRequests = new System.Windows.Forms.ListBox();
            this.pnlbackground = new System.Windows.Forms.Panel();
            this.btnAcceptRequest = new System.Windows.Forms.Button();
            this.btnDenyRequest = new System.Windows.Forms.Button();
            this.gbxStore = new System.Windows.Forms.GroupBox();
            this.numSendAmount = new System.Windows.Forms.NumericUpDown();
            this.lblSendToStore = new System.Windows.Forms.Label();
            this.btnStoreSend = new System.Windows.Forms.Button();
            this.txbRequestedAmount = new System.Windows.Forms.TextBox();
            this.lblSendRequestToTheSupplier = new System.Windows.Forms.Label();
            this.gbxSupplier = new System.Windows.Forms.GroupBox();
            this.btnSendSupplierRequest = new System.Windows.Forms.Button();
            this.gbxProductInformation.SuspendLayout();
            this.pnlAmountInWarehouse.SuspendLayout();
            this.pnlAmountInStore.SuspendLayout();
            this.pnlbackground.SuspendLayout();
            this.gbxStore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSendAmount)).BeginInit();
            this.gbxSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRestockRequest
            // 
            this.lblRestockRequest.AutoSize = true;
            this.lblRestockRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRestockRequest.Location = new System.Drawing.Point(31, 24);
            this.lblRestockRequest.Name = "lblRestockRequest";
            this.lblRestockRequest.Size = new System.Drawing.Size(233, 32);
            this.lblRestockRequest.TabIndex = 0;
            this.lblRestockRequest.Text = "Restock requests";
            // 
            // gbxProductInformation
            // 
            this.gbxProductInformation.BackColor = System.Drawing.Color.White;
            this.gbxProductInformation.Controls.Add(this.lblRequestedAmount);
            this.gbxProductInformation.Controls.Add(this.pnlAmountInWarehouse);
            this.gbxProductInformation.Controls.Add(this.label3);
            this.gbxProductInformation.Controls.Add(this.lblAmount);
            this.gbxProductInformation.Controls.Add(this.label1);
            this.gbxProductInformation.Controls.Add(this.lblStockMessage);
            this.gbxProductInformation.Controls.Add(this.pnlAmountInStore);
            this.gbxProductInformation.Controls.Add(this.lblProductBrand);
            this.gbxProductInformation.Controls.Add(this.lblProductTypeAndModel);
            this.gbxProductInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxProductInformation.Location = new System.Drawing.Point(579, 65);
            this.gbxProductInformation.Name = "gbxProductInformation";
            this.gbxProductInformation.Size = new System.Drawing.Size(517, 381);
            this.gbxProductInformation.TabIndex = 3;
            this.gbxProductInformation.TabStop = false;
            // 
            // lblRequestedAmount
            // 
            this.lblRequestedAmount.AutoSize = true;
            this.lblRequestedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRequestedAmount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRequestedAmount.Location = new System.Drawing.Point(295, 142);
            this.lblRequestedAmount.Name = "lblRequestedAmount";
            this.lblRequestedAmount.Size = new System.Drawing.Size(41, 29);
            this.lblRequestedAmount.TabIndex = 8;
            this.lblRequestedAmount.Text = "00";
            // 
            // pnlAmountInWarehouse
            // 
            this.pnlAmountInWarehouse.BackColor = System.Drawing.Color.YellowGreen;
            this.pnlAmountInWarehouse.Controls.Add(this.lblAmountInWarehouse);
            this.pnlAmountInWarehouse.Location = new System.Drawing.Point(300, 237);
            this.pnlAmountInWarehouse.Name = "pnlAmountInWarehouse";
            this.pnlAmountInWarehouse.Size = new System.Drawing.Size(178, 63);
            this.pnlAmountInWarehouse.TabIndex = 3;
            // 
            // lblAmountInWarehouse
            // 
            this.lblAmountInWarehouse.AutoSize = true;
            this.lblAmountInWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAmountInWarehouse.Location = new System.Drawing.Point(71, 16);
            this.lblAmountInWarehouse.Name = "lblAmountInWarehouse";
            this.lblAmountInWarehouse.Size = new System.Drawing.Size(39, 29);
            this.lblAmountInWarehouse.TabIndex = 5;
            this.lblAmountInWarehouse.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "In warehouse:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(30, 142);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(222, 29);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Requested amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "In store:";
            // 
            // lblStockMessage
            // 
            this.lblStockMessage.AutoSize = true;
            this.lblStockMessage.Location = new System.Drawing.Point(30, 325);
            this.lblStockMessage.Name = "lblStockMessage";
            this.lblStockMessage.Size = new System.Drawing.Size(31, 29);
            this.lblStockMessage.TabIndex = 4;
            this.lblStockMessage.Text = "...";
            // 
            // pnlAmountInStore
            // 
            this.pnlAmountInStore.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pnlAmountInStore.Controls.Add(this.lblAmountInStore);
            this.pnlAmountInStore.Location = new System.Drawing.Point(34, 237);
            this.pnlAmountInStore.Name = "pnlAmountInStore";
            this.pnlAmountInStore.Size = new System.Drawing.Size(184, 63);
            this.pnlAmountInStore.TabIndex = 2;
            // 
            // lblAmountInStore
            // 
            this.lblAmountInStore.AutoSize = true;
            this.lblAmountInStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAmountInStore.Location = new System.Drawing.Point(71, 16);
            this.lblAmountInStore.Name = "lblAmountInStore";
            this.lblAmountInStore.Size = new System.Drawing.Size(39, 29);
            this.lblAmountInStore.TabIndex = 5;
            this.lblAmountInStore.Text = "00";
            // 
            // lblProductBrand
            // 
            this.lblProductBrand.AutoSize = true;
            this.lblProductBrand.Location = new System.Drawing.Point(30, 84);
            this.lblProductBrand.Name = "lblProductBrand";
            this.lblProductBrand.Size = new System.Drawing.Size(83, 29);
            this.lblProductBrand.TabIndex = 1;
            this.lblProductBrand.Text = "Brand ";
            // 
            // lblProductTypeAndModel
            // 
            this.lblProductTypeAndModel.AutoSize = true;
            this.lblProductTypeAndModel.Location = new System.Drawing.Point(30, 31);
            this.lblProductTypeAndModel.Name = "lblProductTypeAndModel";
            this.lblProductTypeAndModel.Size = new System.Drawing.Size(188, 29);
            this.lblProductTypeAndModel.TabIndex = 0;
            this.lblProductTypeAndModel.Text = "Type and model";
            // 
            // lbxRestockRequests
            // 
            this.lbxRestockRequests.BackColor = System.Drawing.Color.White;
            this.lbxRestockRequests.CausesValidation = false;
            this.lbxRestockRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbxRestockRequests.FormattingEnabled = true;
            this.lbxRestockRequests.ItemHeight = 29;
            this.lbxRestockRequests.Location = new System.Drawing.Point(14, 15);
            this.lbxRestockRequests.Name = "lbxRestockRequests";
            this.lbxRestockRequests.Size = new System.Drawing.Size(489, 236);
            this.lbxRestockRequests.TabIndex = 0;
            this.lbxRestockRequests.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbxRestockRequests_DrawItem_1);
            this.lbxRestockRequests.SelectedIndexChanged += new System.EventHandler(this.lbxRestockRequests_SelectedIndexChanged);
            this.lbxRestockRequests.DoubleClick += new System.EventHandler(this.lbxRestockRequests_DoubleClick);
            this.lbxRestockRequests.MouseLeave += new System.EventHandler(this.lbxRestockRequests_MouseLeave);
            this.lbxRestockRequests.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbxRestockRequests_MouseMove);
            // 
            // pnlbackground
            // 
            this.pnlbackground.BackColor = System.Drawing.Color.White;
            this.pnlbackground.Controls.Add(this.lbxRestockRequests);
            this.pnlbackground.Location = new System.Drawing.Point(37, 65);
            this.pnlbackground.Name = "pnlbackground";
            this.pnlbackground.Size = new System.Drawing.Size(518, 270);
            this.pnlbackground.TabIndex = 4;
            // 
            // btnAcceptRequest
            // 
            this.btnAcceptRequest.BackColor = System.Drawing.SystemColors.Control;
            this.btnAcceptRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAcceptRequest.Location = new System.Drawing.Point(51, 364);
            this.btnAcceptRequest.Name = "btnAcceptRequest";
            this.btnAcceptRequest.Size = new System.Drawing.Size(218, 43);
            this.btnAcceptRequest.TabIndex = 5;
            this.btnAcceptRequest.Text = "View request";
            this.btnAcceptRequest.UseVisualStyleBackColor = false;
            this.btnAcceptRequest.Click += new System.EventHandler(this.btnAcceptRequest_Click);
            this.btnAcceptRequest.MouseLeave += new System.EventHandler(this.btnAcceptRequest_MouseLeave);
            this.btnAcceptRequest.MouseHover += new System.EventHandler(this.btnAcceptRequest_MouseHover);
            // 
            // btnDenyRequest
            // 
            this.btnDenyRequest.BackColor = System.Drawing.SystemColors.Control;
            this.btnDenyRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDenyRequest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDenyRequest.Location = new System.Drawing.Point(322, 364);
            this.btnDenyRequest.Name = "btnDenyRequest";
            this.btnDenyRequest.Size = new System.Drawing.Size(218, 43);
            this.btnDenyRequest.TabIndex = 6;
            this.btnDenyRequest.Text = "Decline request";
            this.btnDenyRequest.UseVisualStyleBackColor = false;
            this.btnDenyRequest.Click += new System.EventHandler(this.btnDenyRequest_Click);
            this.btnDenyRequest.MouseLeave += new System.EventHandler(this.btnDenyRequest_MouseLeave);
            this.btnDenyRequest.MouseHover += new System.EventHandler(this.btnDenyRequest_MouseHover);
            // 
            // gbxStore
            // 
            this.gbxStore.BackColor = System.Drawing.Color.White;
            this.gbxStore.Controls.Add(this.btnStoreSend);
            this.gbxStore.Controls.Add(this.lblSendToStore);
            this.gbxStore.Controls.Add(this.numSendAmount);
            this.gbxStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxStore.Location = new System.Drawing.Point(39, 455);
            this.gbxStore.Name = "gbxStore";
            this.gbxStore.Size = new System.Drawing.Size(516, 134);
            this.gbxStore.TabIndex = 7;
            this.gbxStore.TabStop = false;
            // 
            // numSendAmount
            // 
            this.numSendAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numSendAmount.Location = new System.Drawing.Point(236, 39);
            this.numSendAmount.Name = "numSendAmount";
            this.numSendAmount.Size = new System.Drawing.Size(100, 30);
            this.numSendAmount.TabIndex = 1;
            // 
            // lblSendToStore
            // 
            this.lblSendToStore.AutoSize = true;
            this.lblSendToStore.Location = new System.Drawing.Point(27, 39);
            this.lblSendToStore.Name = "lblSendToStore";
            this.lblSendToStore.Size = new System.Drawing.Size(131, 50);
            this.lblSendToStore.TabIndex = 6;
            this.lblSendToStore.Text = "Send items to\r\nthe store:";
            // 
            // btnStoreSend
            // 
            this.btnStoreSend.BackColor = System.Drawing.SystemColors.Control;
            this.btnStoreSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStoreSend.Location = new System.Drawing.Point(376, 70);
            this.btnStoreSend.Name = "btnStoreSend";
            this.btnStoreSend.Size = new System.Drawing.Size(103, 43);
            this.btnStoreSend.TabIndex = 7;
            this.btnStoreSend.Text = "Send";
            this.btnStoreSend.UseVisualStyleBackColor = false;
            this.btnStoreSend.Click += new System.EventHandler(this.btnStoreSend_Click);
            // 
            // txbRequestedAmount
            // 
            this.txbRequestedAmount.Location = new System.Drawing.Point(235, 37);
            this.txbRequestedAmount.Name = "txbRequestedAmount";
            this.txbRequestedAmount.Size = new System.Drawing.Size(100, 30);
            this.txbRequestedAmount.TabIndex = 0;
            // 
            // lblSendRequestToTheSupplier
            // 
            this.lblSendRequestToTheSupplier.AutoSize = true;
            this.lblSendRequestToTheSupplier.Location = new System.Drawing.Point(26, 37);
            this.lblSendRequestToTheSupplier.Name = "lblSendRequestToTheSupplier";
            this.lblSendRequestToTheSupplier.Size = new System.Drawing.Size(155, 50);
            this.lblSendRequestToTheSupplier.TabIndex = 7;
            this.lblSendRequestToTheSupplier.Text = "Send request to \r\nthe supplier:";
            // 
            // gbxSupplier
            // 
            this.gbxSupplier.BackColor = System.Drawing.Color.White;
            this.gbxSupplier.Controls.Add(this.btnSendSupplierRequest);
            this.gbxSupplier.Controls.Add(this.lblSendRequestToTheSupplier);
            this.gbxSupplier.Controls.Add(this.txbRequestedAmount);
            this.gbxSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxSupplier.Location = new System.Drawing.Point(39, 604);
            this.gbxSupplier.Name = "gbxSupplier";
            this.gbxSupplier.Size = new System.Drawing.Size(516, 128);
            this.gbxSupplier.TabIndex = 8;
            this.gbxSupplier.TabStop = false;
            // 
            // btnSendSupplierRequest
            // 
            this.btnSendSupplierRequest.BackColor = System.Drawing.SystemColors.Control;
            this.btnSendSupplierRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSendSupplierRequest.Location = new System.Drawing.Point(376, 61);
            this.btnSendSupplierRequest.Name = "btnSendSupplierRequest";
            this.btnSendSupplierRequest.Size = new System.Drawing.Size(103, 43);
            this.btnSendSupplierRequest.TabIndex = 8;
            this.btnSendSupplierRequest.Text = "Send";
            this.btnSendSupplierRequest.UseVisualStyleBackColor = false;
            this.btnSendSupplierRequest.Click += new System.EventHandler(this.btnSendSupplierRequest_Click);
            // 
            // RestockRequestInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxSupplier);
            this.Controls.Add(this.gbxStore);
            this.Controls.Add(this.btnDenyRequest);
            this.Controls.Add(this.btnAcceptRequest);
            this.Controls.Add(this.pnlbackground);
            this.Controls.Add(this.gbxProductInformation);
            this.Controls.Add(this.lblRestockRequest);
            this.Name = "RestockRequestInterface";
            this.Size = new System.Drawing.Size(1121, 747);
            this.gbxProductInformation.ResumeLayout(false);
            this.gbxProductInformation.PerformLayout();
            this.pnlAmountInWarehouse.ResumeLayout(false);
            this.pnlAmountInWarehouse.PerformLayout();
            this.pnlAmountInStore.ResumeLayout(false);
            this.pnlAmountInStore.PerformLayout();
            this.pnlbackground.ResumeLayout(false);
            this.gbxStore.ResumeLayout(false);
            this.gbxStore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSendAmount)).EndInit();
            this.gbxSupplier.ResumeLayout(false);
            this.gbxSupplier.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRestockRequest;
        private System.Windows.Forms.GroupBox gbxProductInformation;
        private System.Windows.Forms.ListBox lbxRestockRequests;
        private System.Windows.Forms.Label lblProductTypeAndModel;
        private System.Windows.Forms.Label lblStockMessage;
        private System.Windows.Forms.Panel pnlAmountInWarehouse;
        private System.Windows.Forms.Label lblAmountInWarehouse;
        private System.Windows.Forms.Panel pnlAmountInStore;
        private System.Windows.Forms.Label lblAmountInStore;
        private System.Windows.Forms.Label lblProductBrand;
        private System.Windows.Forms.Label lblRequestedAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlbackground;
        private System.Windows.Forms.Button btnAcceptRequest;
        private System.Windows.Forms.Button btnDenyRequest;
        private System.Windows.Forms.GroupBox gbxStore;
        private System.Windows.Forms.Label lblSendToStore;
        private System.Windows.Forms.NumericUpDown numSendAmount;
        private System.Windows.Forms.Button btnStoreSend;
        private System.Windows.Forms.TextBox txbRequestedAmount;
        private System.Windows.Forms.Label lblSendRequestToTheSupplier;
        private System.Windows.Forms.GroupBox gbxSupplier;
        private System.Windows.Forms.Button btnSendSupplierRequest;
    }
}
