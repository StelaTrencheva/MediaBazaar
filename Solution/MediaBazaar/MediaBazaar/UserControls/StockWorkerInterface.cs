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
    public partial class StockWorkerInterface : UserControl
    {
        private ManageEmployees manageEmployees;
        private Employee currentEmp;

        public StockWorkerInterface()
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
                pbxStockW.Image = Properties.Resources.Male;
            }
            else if (currentEmp.Gender == Gender.FEMALE)
            {
                pbxStockW.Image = Properties.Resources.Female;

            }
            else if (currentEmp.Gender == Gender.OTHER)
            {
                pbxStockW.Image = Properties.Resources.Other;
            }
        }

        private void UpdateLabel()
        {
            lblStockWFName.Text = $"First name: {currentEmp.FirstName}";
            lblStockWLName.Text = $"Last name: {currentEmp.LastName}";
            lblStockWGender.Text = $"Gender: {currentEmp.Gender}";
            lblStockWBirthday.Text = $"Birthday: {currentEmp.Birthday.ToString("dd-MM-yyyy")}";
            lblStockWBSN.Text = $"BSN: {currentEmp.BSN}";
            lblStockWEmployeeType.Text = $"Eployee type: {currentEmp.Position}";
            lblStockWContractType.Text = $"Contract type: {currentEmp.Contract}";
            lblStockWPhoneNum.Text = $"Phone number: {currentEmp.PhoneNumber}";
            lblStockWEmail.Text = $"Email: {currentEmp.Email}";
            lblStockWAddress.Text = $"Address: {currentEmp.GetAddress()}";
        }
    }
}
