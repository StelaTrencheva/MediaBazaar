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
        private ManageEmployees manageEmployees;
        private Employee currentEmp;
        ChangePasswordForm changePasswordForm;
        public DepartmentManagerInterface()
        {
            InitializeComponent();
        }

        public void SendInfo(Employee currentEmp)
        {
            this.manageEmployees = new ManageEmployees();
            this.currentEmp = currentEmp;
            this.UpdateLabel();
            PictureBoxUpdate();
        }
        private void PictureBoxUpdate()
        {
            if (currentEmp.Gender == Gender.MALE)
            {
                pbxDepartmentM.Image = Properties.Resources.Male;
            }
            else if (currentEmp.Gender == Gender.FEMALE)
            {
                pbxDepartmentM.Image = Properties.Resources.Female;

            }
            else if (currentEmp.Gender == Gender.OTHER)
            {
                pbxDepartmentM.Image = Properties.Resources.Other;
            }

        }

        private void UpdateLabel()
        {
            lblDepartmentMFName.Text = $"First name: {currentEmp.FirstName}";
            lblDepartmentMLName.Text = $"Last name: {currentEmp.LastName}";
            lblDepartmentMGender.Text = $"Gender: {currentEmp.Gender}";
            lblDepartmentMBirthday.Text = $"Birthday: {currentEmp.Birthday.ToString("dd-MM-yyyy")}";
            lblDepartmentMBSN.Text = $"BSN: {currentEmp.BSN}";
            lblDepartmentMEmployeeType.Text = $"Eployee type: {currentEmp.Position}";
            lblDepartmentMContractType.Text = $"Contract type: {currentEmp.Contract}";
            lblDepartmentMPhoneNum.Text = $"Phone number: {currentEmp.PhoneNumber}";
            lblDepartmentMEmail.Text = $"Email: {currentEmp.Email}";
            lblDepartmentMAddress.Text = $"Address: {currentEmp.GetAddress()}";
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            changePasswordForm = new ChangePasswordForm(currentEmp);
            changePasswordForm.ShowDialog();
        }
    }
}
