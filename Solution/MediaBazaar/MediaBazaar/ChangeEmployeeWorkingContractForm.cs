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
    public partial class ChangeEmployeeWorkingContractForm : Form
    {
        Employee currentEmployee;
        EmployeeManager employeeManager;
        public ChangeEmployeeWorkingContractForm(Employee currentEmployee)
        {
            InitializeComponent();
            employeeManager = new EmployeeManager();
            this.currentEmployee = currentEmployee;
            PictureBoxUpdate();
        }
        

        
        private void PictureBoxUpdate()
        {
            if (currentEmployee.Gender == Gender.MALE)
            {
                pictureBox.Image = Properties.Resources.Male;
            }else if (currentEmployee.Gender == Gender.FEMALE)
            {
                pictureBox.Image = Properties.Resources.Female;

            }else if (currentEmployee.Gender == Gender.OTHER)
            {
                pictureBox.Image = Properties.Resources.Other;
            }
        }

        private void ChangeEmployeeWorkingContract_Load(object sender, EventArgs e)
        {
            tbxCurrentContract.Text = currentEmployee.Contract.ToString();
            txbEmployeeInfo.Text = currentEmployee.EmployeeFullInfo;
            cbbChangeCOntract.SelectedIndex = 0;
        }

        private void btnChangeContract_Click(object sender, EventArgs e)
        {
            int index = cbbChangeCOntract.SelectedIndex;
            if(currentEmployee.Contract == (ContractType)(index))
            {
                MessageBox.Show($"{currentEmployee.GetEmployeeNames}is already assigned to this contract. \r\n" +
                    $" If you want to change {currentEmployee.GetEmployeeNames}'s contract please choose another option.");
            }
            else
            {
                bool success = employeeManager.ChangeWorkContractDB((ContractType)(index), currentEmployee);
                if(success)
                {
                    MessageBox.Show("Success");
                    this.Close();
                }
            }

        }
    }
}
