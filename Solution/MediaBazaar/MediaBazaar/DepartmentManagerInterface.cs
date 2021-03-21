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

        public DepartmentManagerInterface()
        {
            InitializeComponent();
        }

        public void SendInfo(Employee currentEmp)
        {
            this.manageEmployees = new ManageEmployees();
            this.currentEmp = currentEmp;
            this.UpdateLabel();
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
    }
}
