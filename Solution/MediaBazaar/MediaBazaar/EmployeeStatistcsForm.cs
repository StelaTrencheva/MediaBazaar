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
        ManageEmployees mngEmp;
        DatabaseMediator dbMediator;
        DateTime date;
        public EmployeeStatistcsForm()
        {
            InitializeComponent();
            mngEmp = new ManageEmployees();
            dbMediator = new DatabaseMediator();
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
            ShowStatistics();

        }
        public void ShowStatistics()
        {
            int EmpHoursPerDay = dbMediator.GetEmployeeAssignedHoursForStatPerDay(employee.Id, date.Day.ToString());
            int EmpHoursPerWeek = dbMediator.GetEmployeeAssignedHoursForStatPerWeek(employee.Id, date.ToString("yyyy-MM-dd"));
            int EmpHoursPerMonth = dbMediator.GetEmployeeAssignedHoursForStatPerMonth(employee.Id, date.Month.ToString());
            int EmpHoursPerYear = dbMediator.GetEmployeeAssignedHoursForStatPerYear(employee.Id, date.Year.ToString());

            lblTotalSalaryPerDay.Text = (EmpHoursPerDay * employee.HourlyWage).ToString();
            lblTotalSalaryPerWeek.Text = (EmpHoursPerWeek * employee.HourlyWage).ToString();
            lblTotalSalaryPerMonth.Text = (EmpHoursPerMonth * employee.HourlyWage).ToString();
            lblTotalSalaryPerYear.Text = (EmpHoursPerYear * employee.HourlyWage).ToString();
            lblActualHoursPerDay.Text = EmpHoursPerDay.ToString();
            lblActualHoursPerWeek.Text = EmpHoursPerWeek.ToString();
            lblActualHoursPerMonth.Text = EmpHoursPerMonth.ToString();
            lblActualHoursPerYear.Text = EmpHoursPerYear.ToString();
        }

    }
}
