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
    public partial class ManageEmployeeInterface : UserControl
    {
        ManageEmployees mngEmp;
        ChangeEmployeeWorkingContract changeContractForm;
        public ManageEmployeeInterface()
        {
            InitializeComponent();
            mngEmp = new ManageEmployees(1);
        }
       

        private void ManageEmployeeInterface_Load(object sender, EventArgs e)
        {
            foreach(Employee emp in mngEmp.GetListOFAllEmployees())
            {
                lbxDisplayEMployees.Items.Add(emp.GetInfo);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            changeContractForm = new ChangeEmployeeWorkingContract();
            
            int index = lbxDisplayEMployees.SelectedIndex;
            foreach (Employee emp in mngEmp.GetListOFAllEmployees())
            {
               if(emp.Id == (index + 1))
                {
                    changeContractForm.SetEmployee(emp);
                    changeContractForm.Show();
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try { 
                string FName = tbxFName.Text.ToString();
                string LName = tbxLName.Text.ToString();
                Gender gender = (Gender)(cbxGender.SelectedIndex);
                string bsn = tbxBSN.Text.ToString();
                string email = tbxEmail.Text.ToString();
                string username = tbxUsername.Text.ToString();
                string password = "0000";
                DateTime birthDay = dtpDateOfBirth.Value;
                string addrStreet = tbxStreet.Text.ToString();
                string addrStreetNumber = tbxHouseNumber.Text.ToString();
                string addrZipcode = tbxZipCode.Text.ToString();
                string addrTown = tbxTown.Text.ToString();
                string addrCountry = tbxCountry.Text.ToString();
                DateTime firstWorkingDay = dtpDateFWD.Value;
                string emergencyPhoneNumber = tbxEmTelNum.Text.ToString();
                string iban = tbxBankAccNum.Text.ToString();
                double hourlyWage = double.Parse(tbxHourlyWage.Text);
                DateTime contractStartDate = dtpContractStartDate.Value;
                ContractType contract = (ContractType)(cbxContractType.SelectedIndex);
                EmployeeType position = (EmployeeType)(cbxTypeOfEmployee.SelectedIndex);

                if (mngEmp.AddEmployeeToDb( bsn, FName, LName, gender,  email,  username,  password,  birthDay,
                 addrStreet,  addrStreetNumber,  addrZipcode,  addrTown,  addrCountry,
                  firstWorkingDay,  emergencyPhoneNumber,  iban,  hourlyWage,  /*contractStartDate,*/ contract,  position))
                {
                    MessageBox.Show("Success!");
                }
                else { MessageBox.Show("Try again"); }
            }
            catch(FormatException)
            {
                MessageBox.Show("Please fill the fields with the correct format");
            }
            catch(Exception exce)
            {
                MessageBox.Show(exce.ToString());
            }
        }

    }
}
