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
    public partial class EmployeeStatistcsForm : Form
    {
        Employee employee;
        SystemManagerEmployeeStatistics empStatisticsManager;
        DateTime date;
        public EmployeeStatistcsForm()
        {
            InitializeComponent();
            empStatisticsManager = new SystemManagerEmployeeStatistics();
        }
        public void SetEmployee(Employee emp, DateTime date)
        {
            this.employee = emp;
            this.date = date;
        }

        private void EmployeeStatistcsForm_Load(object sender, EventArgs e)
        {
            lblEmpContract.Text = employee.Contract.ToString();
            lblEmpHourlyWage.Text = employee.HourlyWage.ToString();
            lblEmpId.Text = employee.Id.ToString();
            lblEmpPosition.Text = employee.Position.ToString();
            switch (employee.Contract)
            {
                case ContractType.EIGHTYPERCENT:
                    lblContractualHoursPerDay.Text = "4.6 (avg)";
                    lblContractualHoursPerWeek.Text = "32";
                    lblContractualHoursPerMonth.Text = "128";
                    lblContractualHoursPerYear.Text = "1664";
                    break;
                case ContractType.FLEX:
                    lblContractualHoursPerDay.Text = "FLEX";
                    lblContractualHoursPerWeek.Text = "FLEX";
                    lblContractualHoursPerMonth.Text = "FLEX";
                    lblContractualHoursPerYear.Text = "FLEX";
                    break;
                case ContractType.FULLTIME:
                    lblContractualHoursPerDay.Text = "5.7 (avg)";
                    lblContractualHoursPerWeek.Text = "40";
                    lblContractualHoursPerMonth.Text = "160";
                    lblContractualHoursPerYear.Text = "2080";
                    break;
                case ContractType.LEFT:
                    lblContractualHoursPerDay.Text = "LEFT";
                    lblContractualHoursPerWeek.Text = "LEFT";
                    lblContractualHoursPerMonth.Text = "LEFT";
                    lblContractualHoursPerYear.Text = "LEFT";
                    break;
            }

            List<int> EmployeeHoursPerTimeUnit = empStatisticsManager.GetEmployeeHoursPerTimeUnit(employee.Id, date);
            lblTotalSalaryPerDay.Text = (EmployeeHoursPerTimeUnit[0] * employee.HourlyWage).ToString();
            lblTotalSalaryPerWeek.Text = (EmployeeHoursPerTimeUnit[1] * employee.HourlyWage).ToString();
            lblTotalSalaryPerMonth.Text = (EmployeeHoursPerTimeUnit[2] * employee.HourlyWage).ToString();
            lblTotalSalaryPerYear.Text = (EmployeeHoursPerTimeUnit[3] * employee.HourlyWage).ToString();
            lblActualHoursPerDay.Text = EmployeeHoursPerTimeUnit[0].ToString();
            lblActualHoursPerWeek.Text = EmployeeHoursPerTimeUnit[1].ToString();
            lblActualHoursPerMonth.Text = EmployeeHoursPerTimeUnit[2].ToString();
            lblActualHoursPerYear.Text = EmployeeHoursPerTimeUnit[3].ToString();
        }


    }
}
