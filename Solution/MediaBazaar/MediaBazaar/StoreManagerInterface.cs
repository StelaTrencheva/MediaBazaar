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
    public partial class StoreManagerInterface : UserControl
    {
        private Employee currentEmp;

        public StoreManagerInterface()
        {
            InitializeComponent();
        }

        public void SendInfo(Employee currentEmp)
        {
            this.currentEmp = currentEmp;
            this.UpdateLabel();
        }
        private void UpdateLabel()
        {
            lblStoreMFName.Text = $"First name: {currentEmp.FirstName}";
            lblStoreMLName.Text = $"Last name: {currentEmp.LastName}";
            lblStoreMGender.Text = $"Gender: {currentEmp.Gender}";
            lblStoreMBirthday.Text = $"Birthday: {currentEmp.Birthday.ToString("dd-MM-yyyy")}";
            lblStoreMBSN.Text = $"BSN: {currentEmp.BSN}";
            lblStoreMEmployeeType.Text = $"Eployee type: {currentEmp.Position}";
            lblStoreMContractType.Text = $"Contract type: {currentEmp.Contract}";
            lblStoreMPhoneNum.Text = $"Phone number: {currentEmp.PhoneNumber}";
            lblStoreMEmail.Text = $"Email: {currentEmp.Email}";
            lblStoreMAddress.Text = $"Address: {currentEmp.GetAddress()}";
        }
    }
}
