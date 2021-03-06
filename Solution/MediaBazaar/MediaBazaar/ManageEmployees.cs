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
            DefaultValues();
        }
        public bool AddEmployee(int bsn, string firstName, string lastName, string address, string email, string username,
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
            employees.Add(employee = new Employee(bsn,  firstName,  lastName,  address,  email,  username,
            password,  birthDay,  firstWorkingDay,  emergencyPhoneNumber, iban,
            hourlyWage,  contractStartDate,  contract, position));
            return true;
        }
        private void DefaultValues()
        {
            AddEmployee(999999990, "Marvin", "Tommie", "De Koppele 132", "Marvin@mediabazaar.com", "Marvin001", "0000", DateTime.Today, DateTime.Today,"+31888888888", "3333 4444 5555 6666", 20, DateTime.Today, ContractType.FULLTIME, EmployeeType.HR);
            AddEmployee(999999991, "Archie", "Beverly", "Van Renesseweg 59", "Archie@mediabazaar.com", "Archie001", "0000", DateTime.Today, DateTime.Today, "+31888888888", "3333 4444 5555 6666", 16, DateTime.Today, ContractType.FULLTIME, EmployeeType.STORE_MANAGER);
            AddEmployee(999999992, "Jay", "Ross", "Thorvaldsenlaan 135", "Jay@mediabazaar.com", "Jay001", "0000", DateTime.Today, DateTime.Today, "+31888888888", "3333 4444 5555 6666", 16, DateTime.Today, ContractType.FULLTIME, EmployeeType.DEPARTMENT_MANAGER);
            AddEmployee(999999993, "Roberto", "Shaw", "Fellenoord 120", "Roberto@mediabazaar.com", "Roberto001", "0000", DateTime.Today, DateTime.Today, "+31888888888", "3333 4444 5555 6666", 16, DateTime.Today, ContractType.EIGHTYPERCENT, EmployeeType.STORE_WORKER);
            AddEmployee(999999994, "Victoria", "Clark", "Uranuslaan 192", "Victoria@mediabazaar.com", "Victoria001", "0000", DateTime.Today, DateTime.Today, "+31888888888", "3333 4444 5555 6666", 10, DateTime.Today, ContractType.EIGHTYPERCENT, EmployeeType.STORE_WORKER);
            AddEmployee(999999995, "Elizabeth", "Guerrero", "Beukenlaan 179", "Elizabeth@mediabazaar.com", "Elizabeth001", "0000", DateTime.Today, DateTime.Today, "+31888888888", "3333 4444 5555 6666", 10, DateTime.Today, ContractType.EIGHTYPERCENT, EmployeeType.STOCK_MANAGER);
            AddEmployee(999999996, "Oscar", "Patterson", "Bleekweg 44", "Oscar@mediabazaar.com", "Oscar001", "0000", DateTime.Today, DateTime.Today, "+31888888888", "3333 4444 5555 6666", 10, DateTime.Today, ContractType.EIGHTYPERCENT, EmployeeType.DEPARTMENT_MANAGER);
            AddEmployee(999999997, "Orlando", "Holt", "Glaslaan 114", "Orlando@mediabazaar.com", "Orlando001", "0000", DateTime.Today, DateTime.Today, "+31888888888", "3333 4444 5555 6666", 10, DateTime.Today, ContractType.EIGHTYPERCENT, EmployeeType.STORE_WORKER);
            AddEmployee(999999998, "Carlos", "Phillips", "Edelweisstraat 14", "Carlos@mediabazaar.com", "Carlos001", "0000", DateTime.Today, DateTime.Today, "+31888888888", "3333 4444 5555 6666", 10, DateTime.Today, ContractType.FLEX, EmployeeType.STORE_WORKER);
            AddEmployee(999999999, "Mona", "Robertson", "Antonius van Gilsweg 52", "Mona@mediabazaar.com", "Mona001", "0000", DateTime.Today, DateTime.Today, "+31888888888", "3333 4444 5555 6666", 10, DateTime.Today, ContractType.FLEX, EmployeeType.STORE_WORKER);
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
        public int CheckLoginInfo(string username, string password)
        {
            foreach(Employee emp in employees)
            {
                if(emp.Username == username && emp.Password == password)
                {
                    return emp.BSN;
                }
            }
            return 0;
        }
    }
}
