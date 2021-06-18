using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses.LogicLayer
{
    public class EmployeeInScheduleManager
    {
        List<EmployeeInSchedule> employeesInSchedule;
        DBMediatorEmployee dbMediator = new DBMediatorEmployee();
        public EmployeeInScheduleManager(Department department,int weekNumber)
        {
            employeesInSchedule = new List<EmployeeInSchedule>();
            Dictionary<Employee,Shift> employeesAndAvailableShifts=dbMediator.GetEmployeesAvailabilityPerDepartmentAndWeekNumber(department,weekNumber);
            Employee firstEmployee = employeesAndAvailableShifts.Keys.First();
            EmployeeInSchedule employeeInSchedule = new EmployeeInSchedule(firstEmployee);
            foreach (KeyValuePair<Employee,Shift> item in employeesAndAvailableShifts)
            {
                if (item.Key ==firstEmployee)
                {
                    employeeInSchedule.AddAvailability(item.Value);
                }
                else
                {
                    employeesInSchedule.Add(employeeInSchedule);
                    firstEmployee = item.Key;
                    employeeInSchedule = new EmployeeInSchedule(firstEmployee);
                    employeeInSchedule.AddAvailability(item.Value);
                }
            }
            employeesInSchedule.Add(employeeInSchedule);
        }
        public void AddEmployee(EmployeeInSchedule employee)
        {
            if (!employeesInSchedule.Contains(employee))
            {
                employeesInSchedule.Add(employee);
            }
            
        }
        public EmployeeInSchedule[] GetEmployeeInSchedules()
        {
            return this.employeesInSchedule.ToArray();

        }

    }
}
