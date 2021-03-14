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
        private int id;

        public DepartmentManagerInterface()
        {
            InitializeComponent();
        }

        public void SendInfo(ManageEmployees manageEmployees, int id)
        {
            this.manageEmployees = manageEmployees;
            this.id = id;
            this.UpdateLabel();
        }

        private void UpdateLabel()
        {
            lblDepartmentMFName.Text = $"First name: {manageEmployees.FindEmployee(id).FirstName}";
            lblDepartmentMLName.Text = $"Last name: {manageEmployees.FindEmployee(id).LastName}";
            lblDepartmentMBirthday.Text = $"Birthday: {manageEmployees.FindEmployee(id).Birthday}";
            lblDepartmentMBSN.Text = $"BSN: {manageEmployees.FindEmployee(id).BSN}";
            lblDepartmentMEmployeeType.Text = $"Eployee type: {manageEmployees.FindEmployee(id).Position}";
            lblDepartmentMContractType.Text = $"Contract type: {manageEmployees.FindEmployee(id).Contract}";
            lblDepartmentMPhoneNum.Text = $"Phone number: {manageEmployees.FindEmployee(id).PhoneNumber}";
            lblDepartmentMEmail.Text = $"Email: {manageEmployees.FindEmployee(id).Email}";
            lblDepartmentMAddress.Text = $"Address: {manageEmployees.FindEmployee(id).GetAddress()}";
        }
    }
}
