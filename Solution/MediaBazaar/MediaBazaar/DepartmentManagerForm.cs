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
            this.departmentManagerAccountInterface.SendInfo(manageEmployees, id);
        }
        private void PaintAllButtons()
        {
            btnDepartmentMAccount.BackColor = Color.SlateGray;
            btnDepartmentMSchedule.BackColor = Color.SlateGray;
            btnDepartmentMLogOut.BackColor = Color.SlateGray;
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
            departmentManagerAccountInterface.Hide();
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
            departmentManagerAccountInterface.Show();
        }

        private void DepartmentManagerForm_Load(object sender, EventArgs e)
        {
            PaintAllButtons();
            btnDepartmentMAccount.BackColor = Color.White;
            HideAllInterfaces();
            departmentManagerAccountInterface.Show();
        }
    }
}
