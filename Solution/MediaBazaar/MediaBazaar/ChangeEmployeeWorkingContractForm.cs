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
        DatabaseMediator dbMediator;
        public ChangeEmployeeWorkingContractForm()
        {
            InitializeComponent();
            dbMediator = new DatabaseMediator();
        }

        public void SetEmployee(Employee emp)
        {
            this.currentEmployee = emp;
        }

        private void ChangeEmployeeWorkingContract_Load(object sender, EventArgs e)
        {
            tbxCurrentContract.Text = currentEmployee.Contract.ToString();
            txbEmployeeInfo.Text = currentEmployee.EmployeeFullInfo;
            cbbChangeCOntract.SelectedIndex = 0;
        }

        private void btnChangeContract_Click(object sender, EventArgs e)
        {
            int index = cbbChangeCOntract.SelectedIndex  ;
            if(currentEmployee.Contract == (ContractType)(index))
            {
                MessageBox.Show($"{currentEmployee.GetEmployeeNames}is already assigned to this contract. \r\n" +
                    $" If you want to change {currentEmployee.GetEmployeeNames}'s contract please choose another option.");
            }
            else
            {
                currentEmployee.Contract = (ContractType)(index);
                bool success = dbMediator.ChangeWorkContract((ContractType)(index + 1), currentEmployee.Id);
                if(success)
                {
                    MessageBox.Show("Success");
                    this.Close();
                }
            }

        }
    }
}
