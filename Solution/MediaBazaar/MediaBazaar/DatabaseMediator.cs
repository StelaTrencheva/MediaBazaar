using System;
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

        public int GetEmployeeNumber()
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
            finally
            {
                dbConnection.Close();
            }

        }

        public List<string> getEmployees(List<string> emp)
        {
            string sqlStatement = "SELECT * FROM mb_employee";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            try
            {
                MySqlDataReader EmployeeReader;

                dbConnection.Open();
                EmployeeReader = sqlCommand.ExecuteReader();

                while (EmployeeReader.Read())
                {
                    emp.Add(GetEmpInfo(EmployeeReader["bsn"],
                        EmployeeReader["fname"], EmployeeReader["lname"],
                        EmployeeReader["email"], EmployeeReader["uname"], EmployeeReader["pwd"],
                        EmployeeReader["birthdate"], EmployeeReader["street"],
                        EmployeeReader["streetnumber"], EmployeeReader["zipcode"], EmployeeReader["town"],
                        EmployeeReader["country"],EmployeeReader["firstworkingday"],
                        EmployeeReader["emergphonenumber"], EmployeeReader["iban"],
                        EmployeeReader["hourlywage"], EmployeeReader["contracttype"],
                        EmployeeReader["contractstartdate"],
                        EmployeeReader["position"]));
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

        public bool AddEmployee(int bsn, string firstName, string lastName, string email, string username, string password, DateTime birthDay,
            string addrStreet, string addrStreetNumber, string addrZipcode, string addrTown, string addrCountry,
             DateTime firstWorkingDay, string emergencyPhoneNumber, string iban, double hourlyWage, DateTime contractStartDate, ContractType contract, EmployeeType position)
        {
            //string sqlStatement = "INSERT INTO mb_employee VALUES (@1, @2, @3, @4 @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19)"
            //"INSERT INTO table_name(bsn, firstName, lastName, ...) VALUES(value1, value2, value3, ...)";
            //MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            //sqlCommand.Parameters.AddWithValue("@1", bsn);
            //sqlCommand.Parameters.AddWithValue("@1", bsn);
            //sqlCommand.Parameters.AddWithValue("@2", firstName);
            //sqlCommand.Parameters.AddWithValue("@3", lastName);
            //sqlCommand.Parameters.AddWithValue("@4", email);
            //sqlCommand.Parameters.AddWithValue("@5", username);
            //sqlCommand.Parameters.AddWithValue("@6", password);
            //sqlCommand.Parameters.AddWithValue("@7", birthDay);
            //sqlCommand.Parameters.AddWithValue("@8", addrStreet);
            //sqlCommand.Parameters.AddWithValue("@9", addrStreetNumber);
            //sqlCommand.Parameters.AddWithValue("@10", addrZipcode);
            //sqlCommand.Parameters.AddWithValue("@11", addrTown);
            //sqlCommand.Parameters.AddWithValue("@12", addrCountry);
            //sqlCommand.Parameters.AddWithValue("@13", firstWorkingDay);
            //sqlCommand.Parameters.AddWithValue("@14", emergencyPhoneNumber);
            //sqlCommand.Parameters.AddWithValue("@15", iban);
            //sqlCommand.Parameters.AddWithValue("@16", hourlyWage);
            //sqlCommand.Parameters.AddWithValue("@17", contractStartDate);
            //sqlCommand.Parameters.AddWithValue("@18", contract);
            //sqlCommand.Parameters.AddWithValue("@19", position);

            try
            {
                int n = 1;

                dbConnection.Open();
                //n = sqlCommand.ExecuteNonQuery();

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
            finally
            {
                dbConnection.Close();
            }
        }

        public bool RemoveEmployee(int ID)
        {
            string sqlStatement = "DELETE FROM mb_employee WHERE id = @i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            sqlCommand.Parameters.AddWithValue("@i", ID);

            try
            {
                int n;
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
            finally
            {
                dbConnection.Close();
            }
        }

        public string GetEmpInfo(object bsn, object fname, object lname, object email,
            object uname, object pwd, object birthdate, object street, object streetnumber, object zipcode,
            object town, object country, object firstworkingday, object emergphonenumber, object iban,
            object hourlywage, object contractstartdate, object contracttype, object position)
        {
            return $"({bsn})--{fname} {lname} - {position}.";
        }

        //public Employee CreateEMp(object bsn, object fname, object lname, object email,
        //    object uname, object pwd, object birthdate, object street, object streetnumber, object zipcode,
        //    object town, object country, object firstworkingday, object emergphonenumber, object iban,
        //    object hourlywage, object contractstartdate, object contracttype, object position)
        //{

        //    return new Employee(int.Parse(bsn.ToString()),
        //                fname.ToString(), lname.ToString(),
        //                email.ToString(), uname.ToString(), 
        //                pwd.ToString(),
        //                Convert.ToDateTime(birthdate.ToString()), 
        //                street.ToString(), streetnumber.ToString(), 
        //                zipcode.ToString(), town.ToString(),
        //                country.ToString(), Convert.ToDateTime(firstworkingday.ToString()),
        //                emergphonenumber.ToString(), iban.ToString(),
        //                double.Parse(hourlywage.ToString()), Convert.ToDateTime(contractstartdate.ToString()),
        //                (ContractType)int.Parse(contracttype.ToString()),
        //                (EmployeeType)int.Parse(position.ToString()));
        //}

        private string sqlExceptionMessage(string originalExceptionMessage)
        {
            return (
                "For Media Bazaar users: Database problem detected" +
                "\n\n" +
                "For developers: " + originalExceptionMessage
                );
        }
    }
}
