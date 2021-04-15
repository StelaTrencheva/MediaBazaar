using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    class DBMediatorEmployee: DBMediator
    {
        public DBMediatorEmployee() : base() { }

        public Employee FindMatchingLoginInfo(string username, string password)
        {
            string sqlStatement = "SELECT * FROM `mb_employee` WHERE uname = @u AND pwd= @p";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            List<Employee> emp = new List<Employee>();
            try
            {
                MySqlDataReader EmployeeReader;
                sqlCommand.Parameters.AddWithValue("@u", username);
                sqlCommand.Parameters.AddWithValue("@p", password);
                DbConnection.Open();

                EmployeeReader = sqlCommand.ExecuteReader();
                if (EmployeeReader.Read())
                {
                    Enum.TryParse(EmployeeReader["contracttype"].ToString(), out ContractType contracttype);
                    Enum.TryParse(EmployeeReader["position"].ToString(), out EmployeeType position);
                    Enum.TryParse(EmployeeReader["gender"].ToString(), out Gender gender);

                    Employee employee = new Employee(Convert.ToInt32(EmployeeReader["id"]), EmployeeReader["bsn"].ToString(),
                    EmployeeReader["fname"].ToString(), EmployeeReader["lname"].ToString(), gender,
                    EmployeeReader["email"].ToString(), EmployeeReader["uname"].ToString(),
                    Convert.ToDateTime(EmployeeReader["birthdate"].ToString()), EmployeeReader["street"].ToString(),
                    EmployeeReader["streetnumber"].ToString(), EmployeeReader["zipcode"].ToString(), EmployeeReader["town"].ToString(),
                    EmployeeReader["country"].ToString(), Convert.ToDateTime(EmployeeReader["firstworkingday"].ToString()),
                    EmployeeReader["emergphonenumber"].ToString(), EmployeeReader["iban"].ToString(),
                    Convert.ToDouble(EmployeeReader["hourlywage"]),
                    Convert.ToDateTime(EmployeeReader["contractstartdate"].ToString()), contracttype, position);
                    return employee;
                }
                else
                    return null;
            }
            catch (MySqlException e)
            {
                return null;
            }
            finally
            {
                DbConnection.Close();
            }

        }
        public List<Employee> GetEmployees()//WORKING!!
        {
            string sqlStatement = "SELECT * FROM mb_employee";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            List<Employee> emp = new List<Employee>();
            try
            {
                MySqlDataReader EmployeeReader;
                DbConnection.Open();

                EmployeeReader = sqlCommand.ExecuteReader();
                while (EmployeeReader.Read())
                {
                    Enum.TryParse(EmployeeReader["contracttype"].ToString(), out ContractType contracttype);
                    Enum.TryParse(EmployeeReader["position"].ToString(), out EmployeeType position);
                    Enum.TryParse(EmployeeReader["gender"].ToString(), out Gender gender);
                    emp.Add(new Employee(Convert.ToInt32(EmployeeReader["id"]), EmployeeReader["bsn"].ToString(),
                    EmployeeReader["fname"].ToString(), EmployeeReader["lname"].ToString(), gender,
                    EmployeeReader["email"].ToString(), EmployeeReader["uname"].ToString(),
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
                return emp;
            }
            finally
            {
                DbConnection.Close();
            }

        }
        public bool AddEmployee(string bsn, string firstName, string lastName, Gender gender, string email, string username, DateTime birthDay,
            string addrStreet, string addrStreetNumber, string addrZipcode, string addrTown, string addrCountry,
             DateTime firstWorkingDay, string emergencyPhoneNumber, string iban, double hourlyWage, ContractType contract, EmployeeType position)
        {
            string sqlStatement = "INSERT INTO mb_employee (bsn, fname, lname, gender, email, uname, pwd, birthdate, street, streetnumber, zipcode, town, country, firstworkingday, emergphonenumber, iban, hourlywage, contractstartdate, contracttype, position)" +
                "VALUES(@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20);";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            string g = firstWorkingDay.ToString("d");
            sqlCommand.Parameters.AddWithValue("@1", bsn);
            sqlCommand.Parameters.AddWithValue("@2", firstName);
            sqlCommand.Parameters.AddWithValue("@3", lastName);
            sqlCommand.Parameters.AddWithValue("@4", gender.ToString());
            sqlCommand.Parameters.AddWithValue("@5", email);
            sqlCommand.Parameters.AddWithValue("@6", username);
            sqlCommand.Parameters.AddWithValue("@7", 0000);
            sqlCommand.Parameters.AddWithValue("@8", birthDay.ToString("yyyy-MM-dd"));
            sqlCommand.Parameters.AddWithValue("@9", addrStreet);
            sqlCommand.Parameters.AddWithValue("@10", addrStreetNumber);
            sqlCommand.Parameters.AddWithValue("@11", addrZipcode);
            sqlCommand.Parameters.AddWithValue("@12", addrTown);
            sqlCommand.Parameters.AddWithValue("@13", addrCountry);
            sqlCommand.Parameters.AddWithValue("@14", firstWorkingDay.ToString("yyyy-MM-dd"));
            sqlCommand.Parameters.AddWithValue("@15", emergencyPhoneNumber);
            sqlCommand.Parameters.AddWithValue("@16", iban);
            sqlCommand.Parameters.AddWithValue("@17", hourlyWage);
            sqlCommand.Parameters.AddWithValue("@18", DateTime.Now.ToString("yyyy-MM-dd"));
            sqlCommand.Parameters.AddWithValue("@19", contract.ToString());
            sqlCommand.Parameters.AddWithValue("@20", position.ToString());
            try
            {
                int n = 0;

                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();

                if (n == 1)
                {
                    return true;
                }
                return false;
            }
            //catch (MySqlException)
            //{
            //    return false;
            //}
            catch (Exception)
            {
                return false;
            }
            finally
            {
                DbConnection.Close();
            }
        }
        public bool DeleteEmployee(int id)
        {
            string sqlStatement = "DELETE FROM `mb_employee` WHERE id=@i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection); ;
            sqlCommand.Parameters.AddWithValue("@i", id);
            try
            {
                int n = 0;
                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();

                if (n == 1)
                {
                    return true;
                }
                return false;
            }
            catch (MySqlException e)
            {
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                DbConnection.Close();
            }
        }
        public bool ChangeWorkContract(ContractType contract, Employee employee)
        {
            string sqlStatement1 = "INSERT INTO `mb_contract_history`( `empid`, `contract`, `startdate`, `lastdate`) VALUES (@empid,@contract,@startdate,@lastdate)";
            MySqlCommand sqlCommand1 = new MySqlCommand(sqlStatement1, DbConnection);
            sqlCommand1.Parameters.AddWithValue("@empid", employee.Id);
            sqlCommand1.Parameters.AddWithValue("@contract", employee.Contract + 1);
            sqlCommand1.Parameters.AddWithValue("@startdate", employee.ContractStartDate);
            sqlCommand1.Parameters.AddWithValue("@lastdate", DateTime.Now.ToString("yyyy-MM-dd"));


            string sqlStatement2 = "UPDATE mb_employee SET contracttype = @c, contractstartdate=@d	WHERE id = @i";
            MySqlCommand sqlCommand2 = new MySqlCommand(sqlStatement2, DbConnection);
            sqlCommand2.Parameters.AddWithValue("@c", contract + 1);
            sqlCommand2.Parameters.AddWithValue("@i", employee.Id);
            sqlCommand2.Parameters.AddWithValue("@d", DateTime.Now.ToString("yyyy-MM-dd"));

            try
            {
                int n = 0;

                DbConnection.Open();
                n = sqlCommand1.ExecuteNonQuery();
                n += sqlCommand2.ExecuteNonQuery();

                if (n > 0)
                {
                    return true;
                }
                return false;
            }
            catch (MySqlException e)
            {
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                DbConnection.Close();
            }
        }
        public bool ChangePassword(string password, int id)
        {
            string sqlStatement = "UPDATE mb_employee SET pwd = @p	WHERE id = @i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@p", password);
            sqlCommand.Parameters.AddWithValue("@i", id);
            try
            {
                int n = 0;

                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();

                if (n == 1)
                {
                    return true;
                }
                return false;
            }
            catch (MySqlException e)
            {
                return false;
            }
            catch (Exception e)
            {  
                return false;
            }
            finally
            {
                DbConnection.Close();
            }
        }
    }
}
