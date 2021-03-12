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
    public partial class LoginForm : Form
    {
        ManageEmployees manageEmployees;
        public LoginForm()
        {
            InitializeComponent();
            manageEmployees = new ManageEmployees(1);
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            int id = manageEmployees.CheckLoginInfo(tbUserName.Text, tbPassword.Text);
            if (id == 0)
            {
                MessageBox.Show("This user does not exist");
                tbPassword.Text = "";
                return;
            }
            else if(manageEmployees.FindEmployee(id).Position == EmployeeType.HR)
            {
                //When the login information of a HR is correct
                HRAdminForm form = new HRAdminForm(manageEmployees,id);
                this.Hide();
                form.ShowDialog();
                this.Close();
            } else if (manageEmployees.FindEmployee(id).Position == EmployeeType.STORE_MANAGER)
            {
                //When the login information of a store manager is correct
            }
            else if (manageEmployees.FindEmployee(id).Position == EmployeeType.DEPARTMENT_MANAGER)
            {
                //When the login information of a department manager is correct
                DepartmentManagerForm form = new DepartmentManagerForm(manageEmployees, id);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else if (manageEmployees.FindEmployee(id).Position == EmployeeType.STOCK_WORKER)
            {
                //When the login information of a stock worker is correct
                StockWorkerForm form = new StockWorkerForm(manageEmployees, id);
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            
            
        }
    }
}