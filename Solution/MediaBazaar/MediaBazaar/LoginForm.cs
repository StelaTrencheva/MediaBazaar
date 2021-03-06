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
            int bsn = manageEmployees.CheckLoginInfo(tbUserName.Text, tbPassword.Text);
            if (bsn == 0)
            {
                MessageBox.Show("This user does not exist");
                return;
            }
            else if(manageEmployees.FindEmployee(bsn).Position==EmployeeType.HR)
            {
                
            } else if (manageEmployees.FindEmployee(bsn).Position == EmployeeType.STORE_MANAGER)
            {

            }else if (manageEmployees.FindEmployee(bsn).Position == EmployeeType.DEPARTMENT_MANAGER)
            {

            }else if (manageEmployees.FindEmployee(bsn).Position == EmployeeType.STOCK_WORKER)
            {

            }
            
            
        }
    }
}