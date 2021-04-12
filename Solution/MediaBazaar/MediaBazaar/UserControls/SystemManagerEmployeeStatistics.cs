using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    class SystemManagerEmployeeStatistics
    {
        //Employee employee;
        List<Employee> ListOfAllEmployees;
        DatabaseMediator dbMediator;

        EmployeeStatistcsForm IndividualEmpStats;
        OverallEmployeeSatisticsForm AllEmpStats;

        public List<int> GetAllEmployeesIds()
        {
            dbMediator = new DatabaseMediator();
            ListOfAllEmployees = dbMediator.GetEmployees();
            List<int> employeeId = new List<int>();
            foreach (Employee emp in ListOfAllEmployees)
            {
                employeeId.Add(emp.Id);
            }
            return employeeId;
        }

        public void ShowIndividualEmpStats(Employee emp, DateTime date)   //IndividualEmpStatistics
        {
            IndividualEmpStats = new EmployeeStatistcsForm();
            IndividualEmpStats.SetEmployee(emp, date);
            IndividualEmpStats.ShowDialog();
        }

        public List<int> GetEmployeeHoursPerTimeUnit(int empId, DateTime date)  //IndividualEmpStatistics
        {
            List<int> EmpHoursPerTimeUnit = new List<int>();
            dbMediator = new DatabaseMediator();
            EmpHoursPerTimeUnit.Add(dbMediator.GetEmployeeAssignedHoursForStatPerDay(empId, date.Day.ToString()));
            EmpHoursPerTimeUnit.Add(dbMediator.GetEmployeeAssignedHoursForStatPerWeek(empId, date.ToString("yyyy-MM-dd")));
            EmpHoursPerTimeUnit.Add(dbMediator.GetEmployeeAssignedHoursForStatPerMonth(empId, date.Month.ToString()));
            EmpHoursPerTimeUnit.Add(dbMediator.GetEmployeeAssignedHoursForStatPerYear(empId, date.Year.ToString()));
            return EmpHoursPerTimeUnit;
        }

        public void ShowOverviewEmpStats(string stats, DateTime date)   //Overview of EmpStatistics
        {
            AllEmpStats = new OverallEmployeeSatisticsForm();
            AllEmpStats.SetTypeOfStatistics(stats, date);
            AllEmpStats.ShowDialog();
        }

        public List<double> GetTotalSalary_HoursPerTimeUnit(string time, DateTime date, string conditionTotal, string conditionAverage)
        {
            dbMediator = new DatabaseMediator();
            List<double> TotalSalaryForWholeYear = new List<double>();
            switch (time)
            {
                case "year":
                    TotalSalaryForWholeYear = dbMediator.GetOverallEmpStatTotalSalaryForYear(date.Year.ToString(), conditionTotal, conditionAverage);
                    return TotalSalaryForWholeYear;
                case "month":
                    TotalSalaryForWholeYear = dbMediator.GetOverallEmpStatTotalSalaryForMonth(date, conditionTotal, conditionAverage);
                    return TotalSalaryForWholeYear;
            }
            return TotalSalaryForWholeYear;
        }

       
        

    }
}
