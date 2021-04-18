using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class EmployeeManager
    {
        //Instance variables
        private List<Employee> employees;
        private DBMediatorEmployee dbMediator;

        //Constructor
        public EmployeeManager()
        {
            employees = new List<Employee>();
            dbMediator = new DBMediatorEmployee();
        }

        //Methods
        public bool AddEmployeeToDb(Employee newEmp)
        {
            if (dbMediator.CheckIfExists(newEmp.BSN))
            {
                throw new ArgumentException();
            }

            employees.Add(newEmp);
            return dbMediator.AddEmployee(newEmp);
        }
        public List<Employee> GetEmployees()
        {
            return this.employees;
        }
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
            this.employees = dbMediator.GetEmployees();
            return employees;
        }
        public void DeleteEmployee(Employee emp)
        {
            employees.Remove(emp);
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
        public bool EditPersonalInfoDB(int id,string bsn,string fName,string lName,Gender gender,string email,DateTime birthday,string phoneNumber,string iban)
        {
            if (bsn == "" || fName == "" || lName == "" || email == "" || birthday >DateTime.Now|| phoneNumber == "" || iban == "" )
            {
                throw new FormatException();
            }
            return dbMediator.EditPersonalInfo(id, bsn, fName, lName, gender,email, birthday, phoneNumber, iban);
        }
        public bool EditAddressInfoInfoDB(int id,string street, string streetNumber, string zipcode, string town, string country)
        {
            if (street == "" || streetNumber == "" || zipcode == "" || town == "" || country == "")
            {
                throw new FormatException();
            }
            return dbMediator.EditAddressInfo( id,  street,  streetNumber,  zipcode,  town,  country);
        }
        public bool EditWorkInfoDB(int id,string username,DateTime firstWorkingDay, double hourlyWage,ContractType contract,EmployeeType position)
        {
            if (username == "" || hourlyWage <0)
            {
                throw new FormatException();
            }
            return dbMediator.EditWorkInfo(id, username, firstWorkingDay, hourlyWage, contract, position);
        }
    }
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
