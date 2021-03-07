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
    public partial class StockManager : UserControl
    {
        public StockManager()
        {
            InitializeComponent();
        }

        private void btnSManagerEdit_Click(object sender, EventArgs e)
        {
            tbxSManagerFName.ReadOnly = false;
            tbxSManagerLName.ReadOnly = false;
            tbxSManagerBSN.ReadOnly = false;
            tbxSManagerPhoneNum.ReadOnly = false;
            tbxSManagerEmail.ReadOnly = false;
            tbxSManagerAddress.ReadOnly = false;
            btnSManagerEdit.Visible = false;
            btnSManagerSave.Visible = true;
        }

        private void btnSManagerSave_Click(object sender, EventArgs e)
        {
            tbxSManagerFName.ReadOnly = true;
            tbxSManagerLName.ReadOnly = true;
            tbxSManagerBSN.ReadOnly = true;
            tbxSManagerPhoneNum.ReadOnly = true;
            tbxSManagerEmail.ReadOnly = true;
            tbxSManagerAddress.ReadOnly = true;
            btnSManagerEdit.Visible = true;
            btnSManagerSave.Visible = false;
        }
    }
}
