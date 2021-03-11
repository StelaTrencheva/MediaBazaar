using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class StockManagerInterface : UserControl
    {
        public StockManagerInterface()
        {
            InitializeComponent();
        }

        private void btnSManagerEdit_Click(object sender, EventArgs e)
        {
            tbxStockMFName.ReadOnly = false;
            tbxStockMLName.ReadOnly = false;
            tbxStockMBSN.ReadOnly = false;
            tbxStockMPhoneNum.ReadOnly = false;
            tbxStockMEmail.ReadOnly = false;
            tbxStockMAddress.ReadOnly = false;
            btnStockMEdit.Visible = false;
            btnStockMSave.Visible = true;
        }

        private void btnSManagerSave_Click(object sender, EventArgs e)
        {
            tbxStockMFName.ReadOnly = true;
            tbxStockMLName.ReadOnly = true;
            tbxStockMBSN.ReadOnly = true;
            tbxStockMPhoneNum.ReadOnly = true;
            tbxStockMEmail.ReadOnly = true;
            tbxStockMAddress.ReadOnly = true;
            btnStockMEdit.Visible = true;
            btnStockMSave.Visible = false;
        }
    }
}
