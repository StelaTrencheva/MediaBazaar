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
            tbxDManagerFName.ReadOnly = false;
            tbxDManagerLName.ReadOnly = false;
            tbxDManagerBSN.ReadOnly = false;
            tbxDManagerPhoneNum.ReadOnly = false;
            tbxDManagerEmail.ReadOnly = false;
            tbxDManagerBSN.ReadOnly = false;
            btnDManagerEdit.Visible = false;
            btnDManagerSave.Visible = true;
        }

        private void btnDManagerSave_Click(object sender, EventArgs e)
        {
            tbxDManagerFName.ReadOnly = true;
            tbxDManagerLName.ReadOnly = true;
            tbxDManagerBSN.ReadOnly = true;
            tbxDManagerPhoneNum.ReadOnly = true;
            tbxDManagerEmail.ReadOnly = true;
            tbxDManagerAddress.ReadOnly = true;
            btnDManagerEdit.Visible = true;
            btnDManagerSave.Visible = false;
        }
    }
}
