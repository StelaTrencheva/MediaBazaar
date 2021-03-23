﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class Employee
    {
        private int id;
        private string bsn;
        private string firstName;
        private string lastName;
        private Gender gender;
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
        /*private DateTime contractStartDate;*/
        private ContractType contract;
        private EmployeeType position;
        
        public int Id
        {
            get { return this.id; }
        }
        public string BSN
        {
            get { return this.bsn; }
        }
        public string FirstName
        {
            get { return this.firstName; }
        }
        public string LastName
        {
            get { return this.lastName; }
        }

        public Gender Gender { get { return this.gender; } }

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
        public DateTime Birthday
        {
            get { return this.birthDay; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string PhoneNumber
        {
            get { return this.emergencyPhoneNumber; }
            set { this.emergencyPhoneNumber = value; }
        }
        public EmployeeType Position
        {
            get { return this.position; }
        }
        public ContractType Contract
        {
            get { return this.contract; }
            set { this.contract = value; }
        }
       public double HourlyWage
        {
            get { return this.hourlyWage; }
        }
        public string GetEmployeeNames
        {
            get { return $"{this.firstName} {this.lastName}"; }
        }
        public string GetInfo
        {
            get { return $"ID: {this.Id}-\t{this.firstName} {this.lastName} - {this.Position}/ Contract: {this.Contract}"; }
        }
        public string EmployeeFullInfo
        {
            get { return $"ID: {this.Id}-{this.firstName} {this.lastName} - {this.gender} - {this.Position} \r\n" +
                    $"Address: {this.addrStreet} {this.addrStreetNumber}, {this.addrTown}, {this.addrCountry} \r\n" +
                    $"First working day: {this.firstWorkingDay.ToString("dd-MM-yyyy")},\r\n" + /*Contract start date:{this.contractStartDate.ToString("dd-MM-yyyy")}*/
                $"Hourly wage: {this.hourlyWage}, Phone number: {this.emergencyPhoneNumber}"; }
        }
        public string GetTotalSalaryPerTimeUnit
        {
            get { return $"{this.hourlyWage}/Day"; }
        }
 

        public Employee( int id, string bsn, string firstName, string lastName, Gender gender, string email, string username, string password, DateTime birthDay, 
            string addrStreet, string addrStreetNumber, string addrZipcode, string addrTown, string addrCountry,
             DateTime firstWorkingDay, string emergencyPhoneNumber, string iban, double hourlyWage, /*DateTime contractStartDate,*/ ContractType contract, EmployeeType position)
        {
            this.id = id;
            this.bsn = bsn;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.addrStreet = addrStreet;
            this.addrStreetNumber = addrStreetNumber;
            this.addrZipcode = addrZipcode;
            this.addrTown = addrTown;
            this.addrCountry = addrCountry;
            this.email = email;
            this.Username = username;
            this.Password = password;
            this.birthDay = birthDay;
            this.firstWorkingDay = firstWorkingDay;
            this.emergencyPhoneNumber = emergencyPhoneNumber;
            this.iban = iban;
            this.hourlyWage = hourlyWage;
            /*this.contractStartDate = contractStartDate;*/
            this.contract = contract;
            this.position = position;
            
        }
        public string GetAddress()
        {
            return $"{addrStreet} {addrStreetNumber}; {addrZipcode}; {addrCountry}, {addrTown}";
        }
        public override string ToString()
        {
            return $"Bsn: {bsn}, {firstName} {lastName}, {gender}, {position}, {email}, Phone: {emergencyPhoneNumber}, birthday: {birthDay.ToString("yyyy-MM-dd")}, IBAN: {iban}";
        }

    }
}