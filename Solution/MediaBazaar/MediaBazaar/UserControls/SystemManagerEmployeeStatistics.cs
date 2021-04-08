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

        public List<double> GetTotalSalaryPerTimeUnit(string time,DateTime date)
        {
            dbMediator = new DatabaseMediator();
            List<double> totalSalary = new List<double>();
            switch (time)
            {
                case "year":
                    for (int i = 1; i < 13; i++)
                    {
                        totalSalary.Add(dbMediator.GetOverallEmpStatTotalSalaryForYear(i.ToString()));
                    }
                    break;
                case "month":
                    int daysInMonth = System.DateTime.DaysInMonth(date.Year, date.Month);
                    for (int i = 1; i <= daysInMonth; i++)
                    {
                        totalSalary.Add(dbMediator.GetOverallEmpStatTotalSalaryForMonth(date, i));
                    }
                    break;
            }
            return totalSalary;
        }
        
        public List<double> GetAvgSalaryPerTimeUnit(string time, DateTime date)
        {
            dbMediator = new DatabaseMediator();
            List<double> avgSalary = new List<double>();
            switch (time)
            {
                case "year":
                    for (int i = 1; i < 13; i++)
                    {
                        avgSalary.Add(dbMediator.GetOverallEmpStatAvgSalaryForYear(i.ToString()));
                    }
                    break;
                case "month":
                    int daysInMonth = System.DateTime.DaysInMonth(date.Year, date.Month);
                    for (int i = 1; i <= daysInMonth; i++)
                    {
                        avgSalary.Add(dbMediator.GetOverallEmpStatAvgSalaryForMonth(date, i));
                    }
                    break;
            }
            return avgSalary;
        }
        public List<double> GetTotalHoursWorkedPerTimeUnit(string time, DateTime date)
        {
            dbMediator = new DatabaseMediator();
            List<double> totalHoursWorked = new List<double>();
            switch (time)
            {
                case "year":
                    for (int i = 1; i < 13; i++)
                    {
                        totalHoursWorked.Add(dbMediator.GetOverallEmpStatTotalHoursWorkedForYear(i.ToString()));
                    }
                    break;
                case "month":
                    int daysInMonth = System.DateTime.DaysInMonth(date.Year, date.Month);
                    for (int i = 1; i <= daysInMonth; i++)
                    {
                        totalHoursWorked.Add(dbMediator.GetOverallEmpStatTotalHoursWorkedForMonth(date, i));
                    }
                        break;
            }
            return totalHoursWorked;
        }
        public List<double> GetAvgHoursWorkedPerTimeUnit(string time, DateTime date)
        {
            dbMediator = new DatabaseMediator();
            List<double> avgHoursWorked = new List<double>();
            switch (time)
            {
                case "year":
                    for (int i = 1; i < 13; i++)
                    {
                        avgHoursWorked.Add(dbMediator.GetOverallEmpStatAvgHoursWorkedForYear(i.ToString()));
                    }
                    break;
                case "month":
                    int daysInMonth = System.DateTime.DaysInMonth(date.Year, date.Month);
                    for (int i = 1; i <= daysInMonth; i++)
                    {
                        avgHoursWorked.Add(dbMediator.GetOverallEmpStatAvgHoursWorkedForMonth(date, i));
                    }
                    break;
            }
            return avgHoursWorked;
        }

    }
}
