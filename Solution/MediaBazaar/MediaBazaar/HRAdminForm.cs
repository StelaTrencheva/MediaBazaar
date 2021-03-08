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
        public HRAdminForm()
        {
            InitializeComponent();
            hrAdminInterface1.BringToFront();
        }

        private void btnManageEmployee_Click(object sender, EventArgs e)
        {
            btnManageEmployee.BackColor = Color.White;
            btnHRAdminAccount.BackColor = Color.SlateGray;
            btnHRAdminLogOut.BackColor = Color.SlateGray;
        }

        private void btnHRAdminAccount_Click(object sender, EventArgs e)
        {
            btnManageEmployee.BackColor = Color.SlateGray;
            btnHRAdminAccount.BackColor = Color.White;
            btnHRAdminLogOut.BackColor = Color.SlateGray;
            hrAdminInterface1.BringToFront();
        }

        private void btnHRAdminLogOut_Click(object sender, EventArgs e)
        {
            btnManageEmployee.BackColor = Color.SlateGray;
            btnHRAdminAccount.BackColor = Color.SlateGray;
            btnHRAdminLogOut.BackColor = Color.White;
        }
    }
}
