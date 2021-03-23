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
    public partial class StockManagerInterface : UserControl
    {
        private ManageEmployees manageEmployees;
        private Employee currentEmp;
        public StockManagerInterface()
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
                pbxStockM.Image = Properties.Resources.Male;
            }
            else if (currentEmp.Gender == Gender.FEMALE)
            {
                pbxStockM.Image = Properties.Resources.Female;

            }
            else if (currentEmp.Gender == Gender.OTHER)
            {
                pbxStockM.Image = Properties.Resources.Other;
            }

        }

        private void UpdateLabel()
        {
            lblStockMFName.Text = $"First name: {currentEmp.FirstName}";
            lblStockMLName.Text = $"Last name: {currentEmp.LastName}";
            lblStockMGender.Text = $"Gender: {currentEmp.Gender}";
            lblStockMBirthday.Text = $"Birthday: {currentEmp.Birthday.ToString("dd-MM-yyyy")}";
            lblStockMBSN.Text = $"BSN: {currentEmp.BSN}";
            lblStockMEmployeeType.Text = $"Eployee type: {currentEmp.Position}";
            lblStockMContractType.Text = $"Contract type: {currentEmp.Contract}";
            lblStockMPhoneNum.Text = $"Phone number: {currentEmp.PhoneNumber}";
            lblStockMEmail.Text = $"Email: {currentEmp.Email}";
            lblStockMAddress.Text = $"Address: {currentEmp.GetAddress()}";
        }
    }
}
