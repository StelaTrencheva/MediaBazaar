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
        int id;

        public HRAdminForm(ManageEmployees manageEmployees, int id)
        {
            InitializeComponent();
            this.manageEmployees = manageEmployees;
            this.id = id;
            hrAdminInterface1.SendInfo(manageEmployees,id);


        }
        private void HRAdminForm_Load(object sender, EventArgs e)
        {
            hrAdminInterface1.BringToFront();
        }

        
        private void btnManageEmployee_Click(object sender, EventArgs e)
        {
            manageEmployeeInterface1.Show();
            hrAdminInterface1.Hide();
            btnHRAdminManageEmployee.BackColor = Color.White;
            btnHRAdminAccount.BackColor = Color.SlateGray;
            btnHRAdminLogOut.BackColor = Color.SlateGray;
        }

        private void btnHRAdminAccount_Click(object sender, EventArgs e)
        {
            hrAdminInterface1.Show();
            manageEmployeeInterface1.Hide();
            btnHRAdminManageEmployee.BackColor = Color.SlateGray;
            btnHRAdminAccount.BackColor = Color.White;
            btnHRAdminLogOut.BackColor = Color.SlateGray;
        }

        private void btnHRAdminLogOut_Click(object sender, EventArgs e)
        {
            btnHRAdminManageEmployee.BackColor = Color.SlateGray;
            btnHRAdminAccount.BackColor = Color.SlateGray;
            btnHRAdminLogOut.BackColor = Color.White;
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void manageEmployeeInterface1_Load(object sender, EventArgs e)
        {

        }
    }
}
