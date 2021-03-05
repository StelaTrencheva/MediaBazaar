using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    class Employee
    {
        public int ID;
        public int BSN;
        public string firstName;
        public string lastName;
        public string Address;
        public string Email;
        public string Username;
        public string Password;
        public DateTime birthDay;
        public DateTime firstWorkingDay;
        public string emergencyPhoneNumber;
        public string IBAN;
        public double hourlyWage;
        public DateTime contractStartDate;
        public ContractType Contract;

        public Employee(int ID, int BSN, string firstName, string lastName, string Address, string Email, string Username, string Password, DateTime birthDay,
             DateTime firstWorkingDay, string emergencyPhoneNumber, string IBAN, double hourlyWage, DateTime contractStartDate, ContractType Contract)
        {
            this.ID = ID;
            this.BSN = BSN;
            this.firstName = firstName;
            this.lastName = lastName;
            this.Address = Address;
            this.Email = Email;
            this.Username = Username;
            this.Password = Password;
            this.birthDay = birthDay;
            this.firstWorkingDay = firstWorkingDay;
            this.emergencyPhoneNumber = emergencyPhoneNumber;
            this.IBAN = IBAN;
            this.hourlyWage = hourlyWage;
            this.contractStartDate = contractStartDate;
            this.Contract = Contract;
        }
    }
}
