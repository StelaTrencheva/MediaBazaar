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

        private void btnHRAdminEdit_Click(object sender, EventArgs e)
        {
            tbxHRAdminFName.ReadOnly = false;
            tbxHRAdminLName.ReadOnly = false;
            tbxHRAdminBSN.ReadOnly = false;
            tbxHRAdminPhoneNum.ReadOnly = false;
            tbxHRAdminEmail.ReadOnly = false;
            tbxHRAdminAddress.ReadOnly = false;
            btnHRAdminEdit.Visible = false;
            btnHRAdminSave.Visible = true;
        }

        private void btnHRAdminSave_Click(object sender, EventArgs e)
        {
            tbxHRAdminFName.ReadOnly = true;
            tbxHRAdminLName.ReadOnly = true;
            tbxHRAdminBSN.ReadOnly = true;
            tbxHRAdminPhoneNum.ReadOnly = true;
            tbxHRAdminEmail.ReadOnly = true;
            tbxHRAdminAddress.ReadOnly = true;
            btnHRAdminEdit.Visible = true;
            btnHRAdminSave.Visible = false;
        }
    }
}
