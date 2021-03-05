using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    class ManageEmployees
    {
        Employee employee;
        List<Employee> ListOfEmployees; 

        public bool AddEmployee(int ID, int BSN, string firstName, string lastName, string Address, string Email, string Username,
            string Password, DateTime birthDay, DateTime firstWorkingDay, string emergencyPhoneNumber, string IBAN,
            double hourlyWage, DateTime contractStartDate, double FTE, ContractType Contract)
        {
            foreach(Employee emp in ListOfEmployees)
            {
                if(emp.BSN == BSN)
                {
                    return false;
                }
            }
            ListOfEmployees.Add(employee = new Employee( ID,  BSN,  firstName,  lastName,  Address,  Email,  Username,
            Password,  birthDay,  firstWorkingDay,  emergencyPhoneNumber, IBAN,
            hourlyWage,  contractStartDate,  Contract));
            return true;
        }
        
        public bool RemoveEmployee(int bsn) 
        {
            foreach(Employee emp in ListOfEmployees)
            {
                if(emp.BSN == bsn)
                {
                    ListOfEmployees.Remove(emp);
                    return true;
                }
            }
            return false;
        }

        public Employee FindEmployee(int bsn)
        {
           foreach(Employee emp in ListOfEmployees)
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
            foreach(Employee emp in ListOfEmployees)
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
            foreach(Employee emp in ListOfEmployees)
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
