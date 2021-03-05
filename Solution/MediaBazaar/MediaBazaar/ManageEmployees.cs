using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class ManageEmployees
    {
        private Employee employee;
        private List<Employee> employees; 
        private Schedule schedule;

        public ManageEmployees(int currentWeek)
        {
            employees = new List<Employee>();
            schedule = new Schedule(currentWeek);
        }
        public bool AddEmployee(int id, int bsn, string firstName, string lastName, string address, string email, string username,
            string password, DateTime birthDay, DateTime firstWorkingDay, string emergencyPhoneNumber, string iban,
            double hourlyWage, DateTime contractStartDate, ContractType contract,EmployeeType position)
        {
            foreach(Employee emp in employees)
            {
                if(emp.BSN == bsn)
                {
                    return false;
                }
            }
            employees.Add(employee = new Employee( id,  bsn,  firstName,  lastName,  address,  email,  username,
            password,  birthDay,  firstWorkingDay,  emergencyPhoneNumber, iban,
            hourlyWage,  contractStartDate,  contract, position));
            return true;
        }
        
        public bool RemoveEmployee(int bsn) 
        {
            foreach(Employee emp in employees)
            {
                if(emp.BSN == bsn)
                {
                    employees.Remove(emp);
                    return true;
                }
            }
            return false;
        }
        public List<Employee> GetEmployees()
        {
            return this.employees;
        }
        public Employee FindEmployee(int bsn)
        {
           foreach(Employee emp in employees)
            {
                if(emp.BSN == bsn)
                {
                    return emp;
                }
            }
            return null;
        }

        public bool CheckPassword(string password)
        {
            foreach(Employee emp in employees)
            {
                if(emp.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckUsername(string username)
        {
            foreach(Employee emp in employees)
            {
                if(emp.Username == username)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
