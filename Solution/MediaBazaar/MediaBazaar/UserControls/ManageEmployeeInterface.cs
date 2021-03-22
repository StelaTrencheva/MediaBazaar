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
        ManageEmployees manageEmployees;
        ChangeEmployeeWorkingContractForm changeContractForm;
        public ManageEmployeeInterface()
        {
            InitializeComponent();
            manageEmployees = new ManageEmployees();
        }
       

        private void ManageEmployeeInterface_Load(object sender, EventArgs e)
        {
            UpdateListBoxEmployee();
            SetComboBoxes();
            UpdateListBoxViewEmployees();
        }
        private void UpdateListBoxViewEmployees()
        {
            lbxViewEmployees.Items.Clear();
            foreach (Employee emp in manageEmployees.GetListOFAllEmployees())
            {
                lbxViewEmployees.Items.Add(emp.ToString());
            }

        }
        private void SetComboBoxes()
        {
            cbxContractType.SelectedIndex = 0;
            cbxGender.SelectedIndex = 0;
            cbxTypeOfEmployee.SelectedIndex = 0;
        }
        private void UpdateListBoxEmployee()
        {
            lbxDisplayEMployees.Items.Clear();
            foreach (Employee emp in manageEmployees.GetListOFAllEmployees())
            {
                lbxDisplayEMployees.Items.Add(emp.GetInfo);
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if(lbxDisplayEMployees.SelectedItem == null)
            {
                MessageBox.Show("Please select an employee");
                return;
            }
            changeContractForm = new ChangeEmployeeWorkingContractForm();
            
            foreach (Employee emp in manageEmployees.GetListOFAllEmployees())
            {
               if(emp.GetInfo == lbxDisplayEMployees.SelectedItem.ToString())
                {
                    changeContractForm.SetEmployee(emp);
                    changeContractForm.ShowDialog();
                    UpdateListBoxEmployee();
                    return;
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

                if (manageEmployees.AddEmployeeToDb( bsn, FName, LName, gender,  email,  username,  password,  birthDay,
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
