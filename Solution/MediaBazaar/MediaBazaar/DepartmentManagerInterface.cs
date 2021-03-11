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
    public partial class DepartmentManagerInterface : UserControl
    {
        public DepartmentManagerInterface()
        {
            InitializeComponent();
        }

        private void btnDManagerEdit_Click(object sender, EventArgs e)
        {
            tbxDepartmentMFName.ReadOnly = false;
            tbxDepartmentMLName.ReadOnly = false;
            tbxDepartmentMBSN.ReadOnly = false;
            tbxDepartmentMPhoneNum.ReadOnly = false;
            tbxDepartmentMEmail.ReadOnly = false;
            tbxDepartmentMBSN.ReadOnly = false;
            btnDepartmentMEdit.Visible = false;
            btnDepartmentMSave.Visible = true;
        }

        private void btnDManagerSave_Click(object sender, EventArgs e)
        {
            tbxDepartmentMFName.ReadOnly = true;
            tbxDepartmentMLName.ReadOnly = true;
            tbxDepartmentMBSN.ReadOnly = true;
            tbxDepartmentMPhoneNum.ReadOnly = true;
            tbxDepartmentMEmail.ReadOnly = true;
            tbxDepartmentMAddress.ReadOnly = true;
            btnDepartmentMEdit.Visible = true;
            btnDepartmentMSave.Visible = false;
        }
    }
}
