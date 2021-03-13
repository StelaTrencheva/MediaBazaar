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
        DatabaseMediator dbMediator;

        public ManageEmployees(int currentWeek)
        {
            employees = new List<Employee>();
            schedule = new Schedule(currentWeek);
            dbMediator = new DatabaseMediator();
        }
        public bool AddEmployeeToDb(string bsn, string firstName, string lastName, string email, string username, string password, DateTime birthDay,
            string addrStreet, string addrStreetNumber, string addrZipcode, string addrTown, string addrCountry,
             DateTime firstWorkingDay, string emergencyPhoneNumber, string iban, double hourlyWage, DateTime contractStartDate, ContractType contract, EmployeeType position)
        {
            return dbMediator.AddEmployee(bsn, firstName, lastName, email, username, password, birthDay,
                                          addrStreet, addrStreetNumber, addrZipcode, addrTown, addrCountry,
                                          firstWorkingDay, emergencyPhoneNumber, iban, hourlyWage, contractStartDate, contract, position);
        }

            public bool AddEmployeeToList(int id, string bsn, string firstName, string lastName, string address, string email, string username,string password, DateTime birthDay,
            string addrStreet, string addrStreetNumber, string addrZipcode, string addrTown, string addrCountry,
             DateTime firstWorkingDay, string emergencyPhoneNumber, string iban, double hourlyWage, DateTime contractStartDate, ContractType contract, EmployeeType position)
        {
            foreach(Employee emp in employees)
            {
                if(emp.BSN == bsn||emp.Id == id)
                {
                    return false;
                }
            }
            employees.Add(employee = new Employee(id,bsn,  firstName,  lastName,   email,  username,
            password,  birthDay,  addrStreet,  addrStreetNumber,  addrZipcode,  addrTown,  addrCountry, firstWorkingDay,  emergencyPhoneNumber, iban,
            hourlyWage,  contractStartDate,  contract, position));
            return true;
        }        
        public List<Employee> GetEmployees()
        {
            return this.employees;
        }
        public int GetEmployeeCount()
        {
            return dbMediator.GetEmpCount();
        }

        public Employee FindEmployee(int id)
        {
           foreach(Employee emp in employees)
            {
                if(emp.Id == id)
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
        public int CheckLoginInfo(string username, string password)
        {
            foreach(Employee emp in employees)
            {
                if(emp.Username == username && emp.Password == password)
                {
                    return emp.Id;
                }
            }
            return 0;
        }

        public List<Employee> GetListOFAllEmployees()
        {
            return dbMediator.getEmployees();
        }

        public bool ChangeWorkContract(ContractType contract, int id)
        {
            return dbMediator.ChangeWorkContract(contract, id);
        }
        public void UpdateEmployees()
        {
            this.employees = dbMediator.getEmployees();
        }
    }
}
