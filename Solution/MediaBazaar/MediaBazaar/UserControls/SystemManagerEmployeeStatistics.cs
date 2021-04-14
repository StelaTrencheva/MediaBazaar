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


        public List<Employee> GetListOfAllEmployees()
        {
            dbMediator = new DatabaseMediator();
            return dbMediator.GetEmployees(); ;
        }


        public List<double> GetEmployeeContractualHours(string contract)   //IndividualEmpStatistics
        {
            List<double> ContractualHours = new List<double>();
            switch (contract)
            {
                case "FULLTIME":
                    ContractualHours.Add(5.7);
                    ContractualHours.Add(40);
                    ContractualHours.Add(160);
                    ContractualHours.Add(2080);
                    return ContractualHours;
                case "EIGHTYPERCENT":
                    ContractualHours.Add(5.7);
                    ContractualHours.Add(40);
                    ContractualHours.Add(160);
                    ContractualHours.Add(2080);
                    return ContractualHours;
                case "FLEX":
                    ContractualHours.Add(0);
                    ContractualHours.Add(0);
                    ContractualHours.Add(0);
                    ContractualHours.Add(0);
                    return ContractualHours; 
                case "LEFT":
                    ContractualHours.Add(0);
                    ContractualHours.Add(0);
                    ContractualHours.Add(0);
                    ContractualHours.Add(0);
                    return ContractualHours;
            }
            return ContractualHours;
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

        // //Overview of EmpStatistics
        public List<double> ShowOverallStatistics(string typeOfStats, string period, DateTime date)
        {
            dbMediator = new DatabaseMediator();
            List<double> EmpStats = new List<double>();
            switch (period)
            {
                case "year":
                    if (typeOfStats == "Total salary")
                    {
                        EmpStats = dbMediator.GetOverallEmpStatTotalSalaryForYear(date.Year.ToString(), "Total salary", "None");
                    }
                    else if (typeOfStats == "Average salary")
                    {
                        EmpStats = dbMediator.GetOverallEmpStatTotalSalaryForYear(date.Year.ToString(), "Total salary", "Average");
                    }
                    else if (typeOfStats == "Total hours worked")
                    {
                        EmpStats = dbMediator.GetOverallEmpStatTotalSalaryForYear(date.Year.ToString(), "Total hours worked", "None");
                    }
                    else if (typeOfStats == "Average hours worked")
                    {
                        EmpStats = dbMediator.GetOverallEmpStatTotalSalaryForYear(date.Year.ToString(), "Total hours worked", "Average");
                    }
                    return EmpStats;
                case "month":
                    if (typeOfStats == "Total salary")
                    {
                        EmpStats = dbMediator.GetOverallEmpStatTotalSalaryForMonth(date, "Total salary", "None");
                    }
                    else if (typeOfStats == "Average salary")
                    {
                        EmpStats = dbMediator.GetOverallEmpStatTotalSalaryForMonth(date, "Total salary", "Average");
                    }
                    else if (typeOfStats == "Total hours worked")
                    {
                        EmpStats = dbMediator.GetOverallEmpStatTotalSalaryForMonth(date, "Total hours worked", "None");
                    }
                    else if (typeOfStats == "Average hours worked")
                    {
                        EmpStats = dbMediator.GetOverallEmpStatTotalSalaryForMonth(date, "Total hours worked", "Average");
                    }
                    return EmpStats;
                    //case "week":
                    //if (typeOfStats == "Total salary")
                    //{
                    //    EmpStats = dbMediator.GetOverallEmpStatTotalSalaryForYear(date.ToString(), "Total salary", "None");
                    //}
                    //else if (typeOfStats == "Average salary")
                    //{
                    //    EmpStats = dbMediator.GetOverallEmpStatTotalSalaryForYear(date.ToString(), "Total salary", "Average");
                    //}
                    //else if (typeOfStats == "Total hours worked")
                    //{
                    //    EmpStats = dbMediator.GetOverallEmpStatTotalSalaryForYear(date.ToString(), "Total hours worked", "None");
                    //}
                    //else if (typeOfStats == "Average hours worked")
                    //{
                    //    EmpStats = dbMediator.GetOverallEmpStatTotalSalaryForYear(date.ToString(), "Total hours worked", "Average");
                    //}
                    //return EmpStats;
            }

            return EmpStats;
        }






    }
}
