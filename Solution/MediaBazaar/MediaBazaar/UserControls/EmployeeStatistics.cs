using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar
{

    public partial class EmployeeStatistics : UserControl
    {
        DatabaseMediator dbMediator;
        ManageEmployees mngEmp;
        EmployeeStatistcsForm empStats;
        List<int> EmployeeID;
        public EmployeeStatistics()
        {
            InitializeComponent();
            mngEmp = new ManageEmployees();
            dbMediator = new DatabaseMediator();
            C_ZeroHourContractAvgPerDay.Visible = false;
            C_ZeroHourContractAvgPerMonth.Visible = false;
            C_ZeroHourContractAvgPerWeek.Visible = false;
            C_ZeroHourContractAvgPerYear.Visible = false;
        }

        private void EmployeeStatistics_Load(object sender, EventArgs e)
        {
            EmployeeID = new List<int>();
            foreach (Employee emp in mngEmp.GetListOFAllEmployees())
            {
                EmployeeID.Add(emp.Id);
                lbxEmployees.Items.Add(emp.GetEmployeeNames);
            }
            //ShowStatistics();
        }

        private void dtDateStatistic_ValueChanged(object sender, EventArgs e)
        {
            //ShowStatistics();
        }

        //public void ShowStatistics()
        //{

        //    DateTime date;
        //    if (String.IsNullOrEmpty(dtDateStatistic.Text.ToString()))
        //    { date = DateTime.Today; }
        //    else { date = Convert.ToDateTime(dtDateStatistic.Text.ToString()); }

        //    List<int> EmpHoursPerDay = dbMediator.GetEmployeesAssignedHoursForStatPerDay(EmployeeID, date.Day.ToString());
        //    List<int> EmpHoursPerWeek = dbMediator.GetEmployeesAssignedHoursForStatPerWeek(EmployeeID, date.ToString("yyyy-MM-dd"));
        //    List<int> EmpHoursPerMonth = dbMediator.GetEmployeesAssignedHoursForStatPerMonth(EmployeeID, date.Month.ToString());
        //    List<int> EmpHoursPerYear = dbMediator.GetEmployeesAssignedHoursForStatPerYear(EmployeeID, date.Year.ToString());
        //    dtgvEmployeeStatistics.Rows.Clear();
        //    int i = 0;
        //    foreach (Employee emp in mngEmp.GetListOFAllEmployees())
        //    {
        //        switch (emp.Contract)
        //        {
        //            case ContractType.EIGHTYPERCENT:
        //                dtgvEmployeeStatistics.Rows.Add(emp.Id, emp.GetEmployeeNames, emp.Position, emp.Contract, emp.Email, emp.HourlyWage,
        //               (EmpHoursPerDay[i] * emp.HourlyWage), (EmpHoursPerWeek[i] * emp.HourlyWage), (EmpHoursPerMonth[i] * emp.HourlyWage),
        //               (EmpHoursPerYear[i] * emp.HourlyWage), EmpHoursPerDay[i], EmpHoursPerWeek[i], EmpHoursPerMonth[i], EmpHoursPerYear[i],
        //               "4.6", "32", "128", "1664");
        //                break;
        //            case ContractType.FLEX:
        //                dtgvEmployeeStatistics.Rows.Add(emp.Id, emp.GetEmployeeNames, emp.Position, emp.Contract, emp.Email, emp.HourlyWage,
        //           (EmpHoursPerDay[i] * emp.HourlyWage), (EmpHoursPerWeek[i] * emp.HourlyWage), (EmpHoursPerMonth[i] * emp.HourlyWage),
        //           (EmpHoursPerYear[i] * emp.HourlyWage), EmpHoursPerDay[i], EmpHoursPerWeek[i], EmpHoursPerMonth[i], EmpHoursPerYear[i],
        //           "FLEX", "FLEX", "FLEX", "FLEX");
        //                break;
        //            case ContractType.FULLTIME:
        //                dtgvEmployeeStatistics.Rows.Add(emp.Id, emp.GetEmployeeNames, emp.Position, emp.Contract, emp.Email, emp.HourlyWage,
        //           (EmpHoursPerDay[i] * emp.HourlyWage), (EmpHoursPerWeek[i] * emp.HourlyWage), (EmpHoursPerMonth[i] * emp.HourlyWage),
        //           (EmpHoursPerYear[i] * emp.HourlyWage), EmpHoursPerDay[i], EmpHoursPerWeek[i], EmpHoursPerMonth[i], EmpHoursPerYear[i],
        //           "5.7", "40", "160", "2080");
        //                break;
        //            case ContractType.LEFT:
        //                dtgvEmployeeStatistics.Rows.Add(emp.Id, emp.GetEmployeeNames, emp.Position, emp.Contract, emp.Email, emp.HourlyWage,
        //           (EmpHoursPerDay[i] * emp.HourlyWage), (EmpHoursPerWeek[i] * emp.HourlyWage), (EmpHoursPerMonth[i] * emp.HourlyWage),
        //           (EmpHoursPerYear[i] * emp.HourlyWage), EmpHoursPerDay[i], EmpHoursPerWeek[i], EmpHoursPerMonth[i], EmpHoursPerYear[i],
        //           "LEFT", "LEFT", "LEFT", "LEFT");
        //                break;
        //        }

        //        i++;
        //    }
        //}

        private void tbpAllEmployees_Click(object sender, EventArgs e)
        {

        }

        private void txbEmployees_TextChanged(object sender, EventArgs e)
        {
            lbxEmployees.Items.Clear();
            string empName = txbEmployees.Text.ToString();
            if (String.IsNullOrEmpty(empName))
            {
                foreach (Employee emp in mngEmp.GetListOFAllEmployees())
                { lbxEmployees.Items.Add(emp.GetEmployeeNames); }
            }
            foreach (Employee emp in mngEmp.GetListOFAllEmployees())
            {
                if (emp.GetEmployeeNames.Contains(empName))
                {
                    lbxEmployees.Items.Add(emp.GetEmployeeNames);
                }

            }
        }
        private void btnShowStatistics_Click(object sender, EventArgs e)
        {
            
            foreach (Employee emp in mngEmp.GetListOFAllEmployees())
            {
                if(emp.GetEmployeeNames == lbxEmployees.SelectedItem.ToString())
                {
                    empStats = new EmployeeStatistcsForm();
                    empStats.SetEmployee(emp, dtpTimePeriod.Value);
                    empStats.ShowDialog();
                }
            }
        }
    }
}
