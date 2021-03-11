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
    public partial class HRAdminForm : Form
    {
        ManageEmployees manageEmployees;
        int bsn;

        public HRAdminForm(ManageEmployees manageEmployees,int bsn)
        {
            InitializeComponent();
            this.manageEmployees = manageEmployees;
            this.bsn = bsn;
        }

        private void btnManageEmployee_Click(object sender, EventArgs e)
        {
            btnHRAdminManageEmployee.BackColor = Color.White;
            btnHRAdminAccount.BackColor = Color.SlateGray;
            btnHRAdminLogOut.BackColor = Color.SlateGray;
        }

        private void btnHRAdminAccount_Click(object sender, EventArgs e)
        {
            btnHRAdminManageEmployee.BackColor = Color.SlateGray;
            btnHRAdminAccount.BackColor = Color.White;
            btnHRAdminLogOut.BackColor = Color.SlateGray;
        }

        private void btnHRAdminLogOut_Click(object sender, EventArgs e)
        {
            btnHRAdminManageEmployee.BackColor = Color.SlateGray;
            btnHRAdminAccount.BackColor = Color.SlateGray;
            btnHRAdminLogOut.BackColor = Color.White;
        }
    }
}
