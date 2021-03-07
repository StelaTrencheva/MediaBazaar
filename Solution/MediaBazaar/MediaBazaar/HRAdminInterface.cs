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
    public partial class HRAdminInterface : UserControl
    {
        public HRAdminInterface()
        {
            InitializeComponent();
        }

        private void btnStockWEdit_Click(object sender, EventArgs e)
        {
            tbxStockWFName.ReadOnly = false;
            tbxStockWLName.ReadOnly = false;
            tbxStockWBSN.ReadOnly = false;
            tbxStockWPhoneNum.ReadOnly = false;
            tbxStockWEmail.ReadOnly = false;
            tbxStockWAddress.ReadOnly = false;
            btnStockWEdit.Visible = false;
            btnStockWSave.Visible = true;
        }

        private void btnStockWSave_Click(object sender, EventArgs e)
        {
            tbxStockWFName.ReadOnly = true;
            tbxStockWLName.ReadOnly = true;
            tbxStockWBSN.ReadOnly = true;
            tbxStockWPhoneNum.ReadOnly = true;
            tbxStockWEmail.ReadOnly = true;
            tbxStockWAddress.ReadOnly = true;
            btnStockWEdit.Visible = true;
            btnStockWSave.Visible = false;
        }
    }
}
