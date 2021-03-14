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
    public partial class DepartmentManagerForm : Form
    {
        private ManageEmployees manageEmployees;
        private int id;

        public DepartmentManagerForm(ManageEmployees manageEmployees, int id)
        {
            InitializeComponent();
            this.manageEmployees = manageEmployees;
            this.id = id;
            this.departmentManagerInterface1.SendInfo(manageEmployees, id);
        }

        private void btnDepartmentMLogOut_Click(object sender, EventArgs e)
        {
            btnDepartmentMAccount.BackColor = Color.SlateGray;
            btnDepartmentMSchedule.BackColor = Color.SlateGray;
            btnDepartmentMLogOut.BackColor = Color.White;
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnDepartmentMSchedule_Click(object sender, EventArgs e)
        {
            btnDepartmentMAccount.BackColor = Color.SlateGray;
            btnDepartmentMSchedule.BackColor = Color.White;
            btnDepartmentMLogOut.BackColor = Color.SlateGray;
            departmentManagerInterface1.Hide();
        }

        private void btnDepartmentMAccount_Click(object sender, EventArgs e)
        {
            btnDepartmentMAccount.BackColor = Color.White;
            btnDepartmentMSchedule.BackColor = Color.SlateGray;
            btnDepartmentMLogOut.BackColor = Color.SlateGray;
            departmentManagerInterface1.Show();
        }

        private void departmentManagerInterface1_Load(object sender, EventArgs e)
        {
            departmentManagerInterface1.BringToFront();
        }
    }
}
