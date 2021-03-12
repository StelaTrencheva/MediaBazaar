using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class Employee
    {
        private int id;
        private int bsn;
        private string firstName;
        private string lastName;
        private string email;
        private string username;
        private string password;
        private DateTime birthDay;
        private string addrStreet;
        private string addrStreetNumber;
        private string addrZipcode;
        private string addrTown;
        private string addrCountry;
        private DateTime firstWorkingDay;
        private string emergencyPhoneNumber;
        private string iban;
        private double hourlyWage;
        private DateTime contractStartDate;
        private ContractType contract;
        private EmployeeType position;
        private int maxWorkingHours;
        private int assignedHours;

        public int Id
        {
            get { return this.id; }
        }
        public int BSN
        {
            get { return this.bsn; }
        }
        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public EmployeeType Position
        {
            get { return this.position; }
        }
        public ContractType Contract
        {
            get { return this.contract; }
        }
        public int MaxWorkingHours
        {
            get { return this.maxWorkingHours; }
        }
        public int AvailableWorkingHours
        {
            get { return this.AvailableWorkingHours; }
            set { this.AvailableWorkingHours = value; }
        }

        public Employee( int id,int bsn, string firstName, string lastName, string address, string email, string username, string password, DateTime birthDay, 
            string addrStreet, string addrStreetNumber, string addrZipcode, string addrTown, string addrCountry,
             DateTime firstWorkingDay, string emergencyPhoneNumber, string iban, double hourlyWage, DateTime contractStartDate, ContractType contract,EmployeeType position)
        {
            this.id = id;
            this.bsn = bsn;
            this.firstName = firstName;
            this.lastName = lastName;
            this.addrStreet =addrStreet ;
            this.addrStreetNumber =addrStreetNumber;
            this.addrZipcode =addrZipcode;
            this.addrTown =addrTown;
            this.addrCountry =addrCountry;
            this.email = email;
            this.Username = username;
            this.Password = password;
            this.birthDay = birthDay;
            this.firstWorkingDay = firstWorkingDay;
            this.emergencyPhoneNumber = emergencyPhoneNumber;
            this.iban = iban;
            this.hourlyWage = hourlyWage;
            this.contractStartDate = contractStartDate;
            this.contract = contract;
            this.position = position;
            if (position == EmployeeType.STOCK_WORKER || position == EmployeeType.STORE_WORKER)
            {
                switch (contract)
                {
                    case ContractType.FULLTIME: {
                            this.maxWorkingHours = 40;
                            this.assignedHours = 0;
                        }
                        break;
                    case ContractType.EIGHTYPERCENT:
                        {
                            this.maxWorkingHours = 32;
                            this.assignedHours = 0;
                        }
                        break;
                }
            }
        }
    }
}
