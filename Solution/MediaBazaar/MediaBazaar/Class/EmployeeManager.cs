using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class EmployeeManager
    {
        //private Employee employee;
        private List<Employee> employees;
        private DBMediatorEmployee dbMediator;

        public EmployeeManager()
        {
            employees = new List<Employee>();
            dbMediator = new DBMediatorEmployee();
        }
        public bool AddEmployeeToDb(string bsn, string firstName, string lastName, Gender gender, string email, string username,  DateTime birthDay,
            string addrStreet, string addrStreetNumber, string addrZipcode, string addrTown, string addrCountry,
             DateTime firstWorkingDay, string emergencyPhoneNumber, string iban, double hourlyWage, ContractType contract, EmployeeType position)
        {
            if (bsn == "" || firstName == "" || lastName == "" || email == "" || username == "" || addrStreet == "" || addrStreetNumber == "" || addrZipcode == "" || addrTown == "" || addrCountry == "" || emergencyPhoneNumber == "" || iban == "")
            {
                throw new NullReferenceException();
            }
            foreach (Employee emp in GetListOFAllEmployees())
            {
                if (emp.BSN == bsn)
                {
                    throw new RepeatingObjectException();
                }
            }
            return dbMediator.AddEmployee(bsn, firstName, lastName, gender, email, username,  birthDay,
                                          addrStreet, addrStreetNumber, addrZipcode, addrTown, addrCountry,
                                          firstWorkingDay, emergencyPhoneNumber, iban, hourlyWage, contract, position);
        }

        /*public bool AddEmployeeToList(int id, string bsn, string firstName, string lastName, string address, string email, string username,string password, DateTime birthDay,
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
        }*/
        
        public List<Employee> GetEmployees()
        {
            return this.employees;
        }

        //public Employee FindEmployee(int id)
        //{
        //   foreach(Employee emp in employees)
        //    {
        //        if(emp.Id == id)
        //        {
        //            return emp;
        //        }
        //    }
        //    return null;
        //}


        public bool ChangePassword(string password, int id)
        {
            return dbMediator.ChangePassword(password, id);
        }
        public bool DeleteEmployeeFromDb(int id)
        {
            return dbMediator.DeleteEmployee(id);
        }
        

        public List<Employee> GetListOFAllEmployees()
        {
            return dbMediator.GetEmployees();
        }
        public Employee Login(string username,string password)
        {
            return dbMediator.FindMatchingLoginInfo(username, password);
        }

        
        public void UpdateEmployees()
        {
            this.employees = dbMediator.GetEmployees();
        }
        public bool ChangeWorkContractDB(ContractType contract, Employee employee)//<3
        {
            return dbMediator.ChangeWorkContract(contract, employee);
        }
    }
}
