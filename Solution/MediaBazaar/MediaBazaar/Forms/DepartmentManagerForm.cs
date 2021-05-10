using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectClasses;

namespace MediaBazaar
{
    public partial class DepartmentManagerForm : Form
    {
        private EmployeeManager manageEmployees;
        private Employee currentEmp;

        public DepartmentManagerForm(Employee currentEmp)
        {
            InitializeComponent();
            this.manageEmployees = new EmployeeManager();
            this.currentEmp = currentEmp;
            userInterface1.SendInfo(currentEmp);
        }
        private void PaintAllButtons()
        {
            btnDepartmentMAccount.BackColor = Color.SlateGray;
            btnDepartmentMSchedule.BackColor = Color.SlateGray;
            btnDepartmentMLogOut.BackColor = Color.SlateGray;
            btnDepartment.BackColor = Color.SlateGray;
        }
        private void btnDepartmentMLogOut_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
        private void HideAllInterfaces()
        {
            userInterface1.Hide();
            storeWorkerScheduleInterface.Hide();
        }
        private void btnDepartmentMSchedule_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnDepartmentMSchedule.BackColor = Color.White;
            HideAllInterfaces();
            storeWorkerScheduleInterface.Visible = true;
            storeWorkerScheduleInterface.BringToFront();

        }

        private void btnDepartmentMAccount_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnDepartmentMAccount.BackColor = Color.White;
            HideAllInterfaces();
            userInterface1.Show();
        }

        private void userInterface1_Load(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnDepartmentMAccount.BackColor = Color.White;
            HideAllInterfaces();
            userInterface1.Show();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnDepartment.BackColor = Color.White;
            HideAllInterfaces();
        }
    }
}
