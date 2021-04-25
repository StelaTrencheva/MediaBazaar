using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    class DBMediatorEmployee: DBMediator
    {
        //Constructor
        public DBMediatorEmployee() : base() { }

        //Methods
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
            catch (MySqlException)
            {
                return null;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                DbConnection.Close();
            }

        }
        public List<Employee> GetEmployees()
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
            catch (MySqlException)
            {
                return emp;
            }
            finally
            {
                DbConnection.Close();
            }

        }
        public bool AddEmployee(Employee newEmp)
        {
            string sqlStatement = "INSERT INTO mb_employee (bsn, fname, lname, gender, email, uname, pwd, birthdate, street, streetnumber, zipcode, town, country, firstworkingday, emergphonenumber, iban, hourlywage, contractstartdate, contracttype, position)" +
                "VALUES(@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20);";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@1", newEmp.BSN);
            sqlCommand.Parameters.AddWithValue("@2", newEmp.FirstName);
            sqlCommand.Parameters.AddWithValue("@3", newEmp.LastName);
            sqlCommand.Parameters.AddWithValue("@4", newEmp.Gender.ToString());
            sqlCommand.Parameters.AddWithValue("@5", newEmp.Email);
            sqlCommand.Parameters.AddWithValue("@6", newEmp.Username);
            sqlCommand.Parameters.AddWithValue("@7", 0000);
            sqlCommand.Parameters.AddWithValue("@8", newEmp.Birthday);
            sqlCommand.Parameters.AddWithValue("@9", newEmp.Street);
            sqlCommand.Parameters.AddWithValue("@10", newEmp.StreetNumber);
            sqlCommand.Parameters.AddWithValue("@11", newEmp.Zipcode);
            sqlCommand.Parameters.AddWithValue("@12", newEmp.Town);
            sqlCommand.Parameters.AddWithValue("@13", newEmp.Country);
            sqlCommand.Parameters.AddWithValue("@14", newEmp.FirstWorkingDay);
            sqlCommand.Parameters.AddWithValue("@15", newEmp.PhoneNumber);
            sqlCommand.Parameters.AddWithValue("@16", newEmp.Iban);
            sqlCommand.Parameters.AddWithValue("@17", newEmp.HourlyWage);
            sqlCommand.Parameters.AddWithValue("@18", newEmp.ContractStartDate);
            sqlCommand.Parameters.AddWithValue("@19", newEmp.Contract.ToString());
            sqlCommand.Parameters.AddWithValue("@20", newEmp.Position.ToString());
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
            catch (Exception exe)
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
            catch (MySqlException)
            {
                return false;
            }
            catch (Exception)
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
            catch (MySqlException)
            {
                return false;
            }
            catch (Exception)
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
            catch (MySqlException)
            {
                return false;
            }
            catch (Exception)
            {  
                return false;
            }
            finally
            {
                DbConnection.Close();
            }
        }
        public bool CheckIfExists(string bsn)
        {
            string sqlStatement = "SELECT bsn FROM mb_employee WHERE bsn = @B;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection); ;
            sqlCommand.Parameters.AddWithValue("@B", bsn);

            try
            {
                DbConnection.Open();
                Object test = sqlCommand.ExecuteScalar();

                if (test != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                DbConnection.Close();
            }
        }
        public bool EditPersonalInfo(Employee newEmpInfo)
        {
            string sqlStatement = "UPDATE mb_employee SET bsn = @bsn, fname=@fname, lname=@lname, gender=@gender,email=@email," +
                                  "birthdate=@bday, emergphonenumber=@phonenumber, iban=@iban, uname = @uname, firstworkingday=@fwd, hourlywage=@hourlywage, " +
                                  "contracttype=@contracttype,position=@position,street = @street, streetnumber = @streetnumber, zipcode = @zipcode, town = @town , country = @country WHERE id = @i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@i", newEmpInfo.Id);
            sqlCommand.Parameters.AddWithValue("@bsn", newEmpInfo.BSN);
            sqlCommand.Parameters.AddWithValue("@fname", newEmpInfo.FirstName);
            sqlCommand.Parameters.AddWithValue("@lname", newEmpInfo.LastName);
            sqlCommand.Parameters.AddWithValue("@gender", newEmpInfo.Gender + 1);
            sqlCommand.Parameters.AddWithValue("@email", newEmpInfo.Email);
            sqlCommand.Parameters.AddWithValue("@bday", newEmpInfo.Birthday);
            sqlCommand.Parameters.AddWithValue("@phonenumber", newEmpInfo.PhoneNumber);
            sqlCommand.Parameters.AddWithValue("@iban", newEmpInfo.Iban);
            sqlCommand.Parameters.AddWithValue("@uname", newEmpInfo.Username);
            sqlCommand.Parameters.AddWithValue("@fwd", newEmpInfo.FirstWorkingDay);
            sqlCommand.Parameters.AddWithValue("@hourlywage", newEmpInfo.HourlyWage);
            sqlCommand.Parameters.AddWithValue("@contracttype", newEmpInfo.Contract + 1);
            sqlCommand.Parameters.AddWithValue("@position", newEmpInfo.Position + 1);
            sqlCommand.Parameters.AddWithValue("@street", newEmpInfo.Street);
            sqlCommand.Parameters.AddWithValue("@streetnumber", newEmpInfo.StreetNumber);
            sqlCommand.Parameters.AddWithValue("@zipcode", newEmpInfo.Zipcode);
            sqlCommand.Parameters.AddWithValue("@town", newEmpInfo.Town);
            sqlCommand.Parameters.AddWithValue("@country", newEmpInfo.Country);
            try
            {
                int n = 0;

                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();

                if (n > 0)
                {
                    return true;
                }
                return false;
            }
            catch (MySqlException)
            {
                return false;
            }
            catch (Exception)
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
