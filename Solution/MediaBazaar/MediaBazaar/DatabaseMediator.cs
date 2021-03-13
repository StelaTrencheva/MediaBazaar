﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace MediaBazaar
{
    class DatabaseMediator
    {
        private MySqlConnection dbConnection;

        public DatabaseMediator()
        {
            dbConnection = new MySqlConnection("server=studmysql01.fhict.local;database=dbi467491;uid=dbi467491;password=bulcari;");
        }

        public int GetEmpCount()//WORKING!!
        {
            int numOfEmp = 0;
            string sqlStatement = "SELECT COUNT(*) FROM mb_employee";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            try
            {
                dbConnection.Open();
                numOfEmp = int.Parse(sqlCommand.ExecuteScalar().ToString());
                return numOfEmp;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(sqlExceptionMessage(e.Message));
                return numOfEmp;
            }
            catch (Exception e)
            {
                MessageBox.Show(sqlExceptionMessage(e.Message));
                return numOfEmp;
            }
            finally
            {
                 dbConnection.Close();
            }

        }

        public List<Employee> getEmployees()//WORKING!!
        {
            string sqlStatement = "SELECT * FROM mb_employee";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);
            List<Employee> emp = new List<Employee>();
            try
            {
                MySqlDataReader EmployeeReader;
                dbConnection.Open();
                
                EmployeeReader = sqlCommand.ExecuteReader();
                while (EmployeeReader.Read())
                {
                    Enum.TryParse(EmployeeReader["contracttype"].ToString(), out ContractType contracttype);
                    Enum.TryParse(EmployeeReader["position"].ToString(), out EmployeeType position);
                    emp.Add(new Employee(Convert.ToInt32(EmployeeReader["id"]), EmployeeReader["bsn"].ToString(),
                    EmployeeReader["fname"].ToString(), EmployeeReader["lname"].ToString(),
                    EmployeeReader["email"].ToString(), EmployeeReader["uname"].ToString(), EmployeeReader["pwd"].ToString(),
                    Convert.ToDateTime(EmployeeReader["birthdate"].ToString()), EmployeeReader["street"].ToString(),
                    EmployeeReader["streetnumber"].ToString(), EmployeeReader["zipcode"].ToString(), EmployeeReader["town"].ToString(),
                    EmployeeReader["country"].ToString(), Convert.ToDateTime(EmployeeReader["firstworkingday"].ToString()),
                    EmployeeReader["emergphonenumber"].ToString(), EmployeeReader["iban"].ToString(),
                    Convert.ToDouble(EmployeeReader["hourlywage"]),
                    Convert.ToDateTime(EmployeeReader["contractstartdate"].ToString()), contracttype, position));
                }
                return emp;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(sqlExceptionMessage(e.Message));
                return emp;
            }
            finally
            {
                dbConnection.Close();
            }
        }
        

        public bool AddEmployee(string bsn, string firstName, string lastName, string email, string username, string password, DateTime birthDay,
            string addrStreet, string addrStreetNumber, string addrZipcode, string addrTown, string addrCountry,
             DateTime firstWorkingDay, string emergencyPhoneNumber, string iban, double hourlyWage, DateTime contractStartDate, ContractType contract, EmployeeType position)
        {
            string sqlStatement = "INSERT INTO mb_employee (bsn, fname, lname, email, uname, pwd, birthdate, street, streetnumber, zipcode, town, country, firstworkingday, emergphonenumber, iban, hourlywage, contracttype, contractstartdate, position)" +
                "VALUES(@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19);";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);
            string g = firstWorkingDay.ToString("d");
            sqlCommand.Parameters.AddWithValue("@1", bsn);
            sqlCommand.Parameters.AddWithValue("@2", firstName);
            sqlCommand.Parameters.AddWithValue("@3", lastName);
            sqlCommand.Parameters.AddWithValue("@4", email);
            sqlCommand.Parameters.AddWithValue("@5", username);
            sqlCommand.Parameters.AddWithValue("@6", password);
            sqlCommand.Parameters.AddWithValue("@7",  birthDay.ToString("yyyy-MM-dd"));
            sqlCommand.Parameters.AddWithValue("@8", addrStreet);
            sqlCommand.Parameters.AddWithValue("@9", addrStreetNumber);
            sqlCommand.Parameters.AddWithValue("@10", addrZipcode);
            sqlCommand.Parameters.AddWithValue("@11", addrTown);
            sqlCommand.Parameters.AddWithValue("@12", addrCountry);
            sqlCommand.Parameters.AddWithValue("@13", firstWorkingDay.ToString("yyyy-MM-dd"));
            sqlCommand.Parameters.AddWithValue("@14", emergencyPhoneNumber);
            sqlCommand.Parameters.AddWithValue("@15", iban);
            sqlCommand.Parameters.AddWithValue("@16", hourlyWage);
            sqlCommand.Parameters.AddWithValue("@17", contract.ToString());
            sqlCommand.Parameters.AddWithValue("@18", contractStartDate.ToString("yyyy-MM-dd"));
            sqlCommand.Parameters.AddWithValue("@19", position.ToString());
            try
            {
                int n = 0;

                dbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();

                if (n == 1)
                {
                    return true;
                }
                return false;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(sqlExceptionMessage(e.Message));
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(sqlExceptionMessage(e.Message));
                return false;
            }
            finally
            {
                dbConnection.Close();
            }
        }

       public bool ChangeWorkContract(ContractType contract, int id)
        {
            string sqlStatement = "UPDATE mb_employee SET contracttype = @c	WHERE id = @i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);
            sqlCommand.Parameters.AddWithValue("@c", contract);
            sqlCommand.Parameters.AddWithValue("@i", id);
            try
            {
                int n = 0;

                dbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();

                if (n == 1)
                {
                    return true;
                }
                return false;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(sqlExceptionMessage(e.Message));
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(sqlExceptionMessage(e.Message));
                return false;
            }
            finally
            {
                dbConnection.Close();
            }

        }

        private string sqlExceptionMessage(string originalExceptionMessage)//WORKING!!
        {
            return (
                "For Media Bazaar users: Database problem detected" +
                "\n\n" +
                "For developers: " + originalExceptionMessage
                );
        }
    }
}
