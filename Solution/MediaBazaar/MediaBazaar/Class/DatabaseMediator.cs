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

        public Employee FindMatchingLoginInfo(string username, string password)
        {
            string sqlStatement = "SELECT * FROM `mb_employee` WHERE uname = @u AND pwd= @p";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);
            List<Employee> emp = new List<Employee>();
            try
            {
                MySqlDataReader EmployeeReader;
                sqlCommand.Parameters.AddWithValue("@u", username);
                sqlCommand.Parameters.AddWithValue("@p", password);
                dbConnection.Open();

                EmployeeReader = sqlCommand.ExecuteReader();
                if (EmployeeReader.Read())
                {
                    Enum.TryParse(EmployeeReader["contracttype"].ToString(), out ContractType contracttype);
                    Enum.TryParse(EmployeeReader["position"].ToString(), out EmployeeType position);
                    Enum.TryParse(EmployeeReader["gender"].ToString(), out Gender gender);

                    Employee employee = new Employee(Convert.ToInt32(EmployeeReader["id"]), EmployeeReader["bsn"].ToString(),
                    EmployeeReader["fname"].ToString(), EmployeeReader["lname"].ToString(), gender,
                    EmployeeReader["email"].ToString(), EmployeeReader["uname"].ToString(), EmployeeReader["pwd"].ToString(),
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
                MessageBox.Show(sqlExceptionMessage(e.Message));
                return null;
            }
            finally
            {
                dbConnection.Close();
            }

        }


        public List<Employee> GetEmployees()//WORKING!!
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
                    Enum.TryParse(EmployeeReader["gender"].ToString(), out Gender gender);
                    emp.Add(new Employee(Convert.ToInt32(EmployeeReader["id"]), EmployeeReader["bsn"].ToString(),
                    EmployeeReader["fname"].ToString(), EmployeeReader["lname"].ToString(), gender,
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


        public bool AddEmployee(string bsn, string firstName, string lastName, Gender gender, string email, string username, DateTime birthDay,
            string addrStreet, string addrStreetNumber, string addrZipcode, string addrTown, string addrCountry,
             DateTime firstWorkingDay, string emergencyPhoneNumber, string iban, double hourlyWage, ContractType contract, EmployeeType position)
        {
            string sqlStatement = "INSERT INTO mb_employee (bsn, fname, lname, gender, email, uname, pwd, birthdate, street, streetnumber, zipcode, town, country, firstworkingday, emergphonenumber, iban, hourlywage, contractstartdate, contracttype, position)" +
                "VALUES(@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16, @17, @18, @19, @20);";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);
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
        public bool DeleteEmployee(int id)
        {
            string sqlStatement = "DELETE FROM `mb_employee` WHERE id=@i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection); ;
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
        public bool ChangeWorkContract(ContractType contract, Employee employee)
        {
            string sqlStatement1 = "INSERT INTO `mb_contract_history`( `empid`, `contract`, `startdate`, `lastdate`) VALUES (@empid,@contract,@startdate,@lastdate)";
            MySqlCommand sqlCommand1 = new MySqlCommand(sqlStatement1, dbConnection);
            sqlCommand1.Parameters.AddWithValue("@empid", employee.Id);
            sqlCommand1.Parameters.AddWithValue("@contract", employee.Contract + 1);
            sqlCommand1.Parameters.AddWithValue("@startdate", employee.ContractStartDate);
            sqlCommand1.Parameters.AddWithValue("@lastdate", DateTime.Now.ToString("yyyy-MM-dd"));


            string sqlStatement2 = "UPDATE mb_employee SET contracttype = @c, contractstartdate=@d	WHERE id = @i";
            MySqlCommand sqlCommand2 = new MySqlCommand(sqlStatement2, dbConnection);
            sqlCommand2.Parameters.AddWithValue("@c", contract + 1);
            sqlCommand2.Parameters.AddWithValue("@i", employee.Id);
            sqlCommand2.Parameters.AddWithValue("@d", DateTime.Now.ToString("yyyy-MM-dd"));

            try
            {
                int n = 0;

                dbConnection.Open();
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
        public List<ContractHistory> GetContractHystory(int id)///
        {
            string sqlStatement = "SELECT empid,contract,startdate,lastdate FROM `mb_contract_history` INNER JOIN mb_employee ON empid = mb_employee.id where empid = @id;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);
            sqlCommand.Parameters.AddWithValue("@id", id);

            List<ContractHistory> contracts = new List<ContractHistory>();
            try
            {
                MySqlDataReader EmployeeReader;
                dbConnection.Open();

                EmployeeReader = sqlCommand.ExecuteReader();
                while (EmployeeReader.Read())
                {
                    Enum.TryParse(EmployeeReader["contract"].ToString(), out ContractType contracttype);
                    contracts.Add(new ContractHistory(Convert.ToInt32(EmployeeReader["empid"]),
                                                       contracttype,
                                                       Convert.ToDateTime(EmployeeReader["startdate"].ToString()),
                                                       Convert.ToDateTime(EmployeeReader["lastdate"].ToString())));
                }
                return contracts;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(sqlExceptionMessage(e.Message));
                return contracts;
            }
            finally
            {
                dbConnection.Close();
            }
        }
        public bool ChangePassword(string password, int id)
        {
            string sqlStatement = "UPDATE mb_employee SET pwd = @p	WHERE id = @i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);
            sqlCommand.Parameters.AddWithValue("@p", password);
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

        //TAKE ALL PRODUCTS
        public List<Product> GetProducts()
        {
            string sqlStatement = "SELECT * FROM mb_product";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);
            List<Product> p = new List<Product>();

            try
            {
                MySqlDataReader reader;
                dbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    p.Add(new Product((int)reader["pNum"], (string)reader["brand"], (string)reader["type"], (string)reader["model"],
                        (string)reader["description"], (string)reader["category"], (string)reader["sub_category"],
                        (decimal)reader["cost_price"], (decimal)reader["sales_price"], (int)reader["amount_in_store"],
                        (int)reader["amount_in_warehouse"]));
                }
                return p;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(sqlExceptionMessage(e.Message));
                return p;
            }
            finally
            {
                dbConnection.Close();
            }
        }

        //ADD PRODUCT
        public bool AddProduct(string brand, string type, string model, string description, string category,
            string subcategory, decimal costPrice, decimal salePrice, int amountInStore, int amountInWarehouse)
        {
            string sqlStatement = "INSERT INTO mb_product (brand, type, model, description, category, sub_category, cost_price, " +
                "sales_price, amount_in_store, amount_in_warehouse) VALUES (@br, @ty, @mo, @de, @ca, @sc, @cp, @sp, @as, @aw)";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            sqlCommand.Parameters.AddWithValue("@br", brand);
            sqlCommand.Parameters.AddWithValue("@ty", type);
            sqlCommand.Parameters.AddWithValue("@mo", model);
            sqlCommand.Parameters.AddWithValue("@de", description);
            sqlCommand.Parameters.AddWithValue("@ca", category);
            sqlCommand.Parameters.AddWithValue("@sc", subcategory);
            sqlCommand.Parameters.AddWithValue("@cp", costPrice);
            sqlCommand.Parameters.AddWithValue("@sp", salePrice);
            sqlCommand.Parameters.AddWithValue("@as", amountInStore);
            sqlCommand.Parameters.AddWithValue("@aw", amountInWarehouse);

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

        //DELETE PRODUCT
        public bool DeleteProduct(int id)
        {
            string sqlStatement = "DELETE FROM `mb_product` WHERE pNum=@i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection); ;
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

        public int GetEmployeeAssignedHoursForStatPerDay(int id, string date)
        {
            string sqlStatement = " select IF(es.times IS NULL, 0, es.times) as assignedHours, e.id from mb_employee e left join " +
                "(select count(*) as times, employeeID from mb_shift_with_assigned_employee where shiftID in " +
                "(select id from mb_shift where EXTRACT(DAY FROM date) = @date ) group by employeeID) es ON es.employeeID = e.id" +
                " where e.id like @i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.dbConnection);
            sqlCommand.Parameters.AddWithValue("@date", date);
            sqlCommand.Parameters.AddWithValue("@i", id.ToString());
            int assignedHours = 0;

            try
            {
                MySqlDataReader reader;
                dbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    assignedHours = Convert.ToInt32(reader["assignedHours"]) * 4;
                }
            }
            finally
            {
                this.dbConnection.Close();

            }
            return assignedHours;
        }
        public int GetEmployeeAssignedHoursForStatPerWeek(int id, string date)
        {
            string sqlStatement = " select IF(es.times IS NULL, 0, es.times) as assignedHours, e.id from mb_employee e left join " +
                "(select count(*) as times, employeeID from mb_shift_with_assigned_employee where shiftID in " +
                "(select id from mb_shift where week(date, 1) = week(@date, 1)) group by employeeID) es ON es.employeeID = e.id" +
                " where e.id like @i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.dbConnection);
            sqlCommand.Parameters.AddWithValue("@date", date);
            sqlCommand.Parameters.AddWithValue("@i", id.ToString());
            int assignedHours = 0;

            try
            {
                MySqlDataReader reader;
                dbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    assignedHours = Convert.ToInt32(reader["assignedHours"]) * 4;
                }
            }
            finally
            {
                this.dbConnection.Close();

            }
            return assignedHours;
        }
        public int GetEmployeeAssignedHoursForStatPerMonth(int id, string month)
        {
            string sqlStatement = " select IF(es.times IS NULL, 0, es.times) as assignedHours, e.id from mb_employee e left join " +
                "(select count(*) as times, employeeID from mb_shift_with_assigned_employee where shiftID in " +
                "(select id from mb_shift where EXTRACT(MONTH FROM date) = @month ) group by employeeID) es ON es.employeeID = e.id" +
                " where e.id like @i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.dbConnection);
            sqlCommand.Parameters.AddWithValue("@month", month);
            sqlCommand.Parameters.AddWithValue("@i", id.ToString());
            int assignedHours = 0;

            try
            {
                MySqlDataReader reader;
                dbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    assignedHours = Convert.ToInt32(reader["assignedHours"]) * 4;
                }
            }
            finally
            {
                this.dbConnection.Close();

            }
            return assignedHours;
        }

        public int GetEmployeeAssignedHoursForStatPerYear(int id, string year)
        {
            string sqlStatement = " select IF(es.times IS NULL, 0, es.times) as assignedHours, e.id from mb_employee e left join " +
                "(select count(*) as times, employeeID from mb_shift_with_assigned_employee where shiftID in " +
                "(select id from mb_shift where EXTRACT(YEAR FROM date) = @year ) group by employeeID) es ON es.employeeID = e.id" +
                " where e.id like @i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.dbConnection);
            sqlCommand.Parameters.AddWithValue("@year", year);
            sqlCommand.Parameters.AddWithValue("@i", id.ToString());
            int assignedHours = 0;

            try
            {
                MySqlDataReader reader;
                dbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {

                    assignedHours = Convert.ToInt32(reader["assignedHours"]) * 4;
                }
            }
            finally
            {
                this.dbConnection.Close();

            }
            return assignedHours;
        }

        public List<double> GetOverallEmpStatTotalSalaryForYear(string year, string conditionTotal, string conditionAvg)
        {
            string sqlStatement = "SELECT IFNULL((em.employeeID),0) as assignedHours, IFNULL((emp.hourlywage),0) as wage, EXTRACT(MONTH FROM sh.date) AS month " +
                                  "FROM `mb_shift_with_assigned_employee` as em  " +
                                  "INNER JOIN `mb_shift` as sh " +
                                  "ON sh.id = em.shiftID " +
                                  "INNER JOIN `mb_employee`as emp " +
                                  "ON em.employeeID = emp.id " +
                                  "WHERE EXTRACT(YEAR FROM sh.date) = @year " +
                                  "GROUP BY EXTRACT(DAY FROM sh.date), month";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.dbConnection);
            sqlCommand.Parameters.AddWithValue("@year", year);
            List<double> TotalSalaryPerMonths = new List<double>();
            List<double> counter = new List<double>();
            for (int i = 0; i < 12; i++)
            {
                TotalSalaryPerMonths.Add(0);
                counter.Add(1);
            }
            try
            {
                MySqlDataReader reader;
                dbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    int month = Convert.ToInt32(reader["month"]);
                    double hours = Convert.ToDouble(reader["assignedHours"]);
                    double wage = Convert.ToDouble(reader["wage"]);
                    if (conditionTotal == "TotalSalary")
                    {
                        for (int i = 1; i < 13; i++)
                        {
                            if (i == month)
                            {
                                TotalSalaryPerMonths[i - 1] += (hours * wage * 4);
                                counter[i - 1] += 1;
                            }
                        }
                    }
                    else if(conditionTotal == "TotalHoursWorked")
                    {
                        for (int i = 1; i < 13; i++)
                        {
                            if (i == month)
                            {
                                TotalSalaryPerMonths[i - 1] += (hours);
                                counter[i - 1] += 1;
                            }
                        }
                    }

                }
            }
            finally
            {
                this.dbConnection.Close();
                if(conditionAvg=="Average")
                {
                    for (int i = 0; i < 12; i++)
                    {
                        TotalSalaryPerMonths[i]/=counter[i];
                    }
                }
            }
            return TotalSalaryPerMonths;
        }
        public List<double> GetOverallEmpStatTotalSalaryForMonth(DateTime date, string conditionTotal, string conditionAvg)
        {
            string sqlStatement = "SELECT IFNULL((em.employeeID),0) as assignedHours, IFNULL((emp.hourlywage),0) as wage, EXTRACT(DAY FROM sh.date) AS day " +
                "FROM `mb_shift_with_assigned_employee` as em " +
                "INNER JOIN `mb_shift` as sh " +
                "ON sh.id = em.shiftID " +
                "INNER JOIN `mb_employee`as emp " +
                "ON em.employeeID = emp.id " +
                "WHERE EXTRACT(MONTH FROM sh.date) = @month " +
                "GROUP BY day";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.dbConnection);
            sqlCommand.Parameters.AddWithValue("@month", date.Month.ToString());
            List<double> TotalSalaryPerMonths = new List<double>();
            List<double> counter = new List<double>();
            int days = DateTime.DaysInMonth(date.Year, date.Month);
            for (int j = 0; j < days; j++)
            {
                TotalSalaryPerMonths.Add(0);
                counter.Add(1);
            }
            try
            {
                MySqlDataReader reader;
                dbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    int day = Convert.ToInt32(reader["day"]);
                    double hours = Convert.ToDouble(reader["assignedHours"]);
                    double wage = Convert.ToDouble(reader["wage"]);
                    if (conditionTotal == "TotalSalary")
                    {
                        for (int i = 1; i < days + 1; i++)
                        {
                            if (i == day)
                            {
                                TotalSalaryPerMonths[i - 1] += (hours * wage * 4);
                                counter[i - 1] += 1;
                            }
                        }
                    }
                    else if (conditionTotal == "TotalHoursWorked")
                    {
                        for (int i = 1; i < days + 1; i++)
                        {
                            if (i == day)
                            {
                                TotalSalaryPerMonths[i - 1] += (hours);
                                counter[i - 1] += 1;
                            }
                        }
                    }

                }
            }
            finally
            {
                this.dbConnection.Close();
                if (conditionAvg == "Average")
                {
                    for (int i = 0; i < days; i++)
                    {
                        TotalSalaryPerMonths[i] /= counter[i];
                    }
                }
            }
            return TotalSalaryPerMonths;
        }
       
       

        
        private string sqlExceptionMessage(string originalExceptionMessage)//WORKING!!
        {
            return (
                "For Media Bazaar users: Database problem detected" +
                "\n\n" +
                "For developers: " + originalExceptionMessage
                );
        }

        // Schedule DB mediator
        public MySqlConnection GetDBConnection()
        {
            return this.dbConnection;
        }
        public MySqlDataReader OpenExecuteReader(MySqlCommand sqlReaderCommand)
        {
            this.dbConnection.Open();
            MySqlDataReader reader = sqlReaderCommand.ExecuteReader();

            return reader;
        }
        public void CloseExecuteReader(MySqlDataReader reader)
        {
            if (reader != null)
                reader.Close();

            this.dbConnection.Close();
        }
        public int ExecuteNonQuery(MySqlCommand sqlNonQueryCommand)
        {
            try
            {
                this.dbConnection.Open();
                int numberAffectedRows = sqlNonQueryCommand.ExecuteNonQuery();

                return numberAffectedRows;
            }
            finally
            {
                this.dbConnection.Close();
            }
        }
        public int ExecuteScalar(MySqlCommand sqlCommand)
        {
            try
            {
                this.dbConnection.Open();
                int n = Convert.ToInt32(sqlCommand.ExecuteScalar());

                return n;
            }
            finally
            {
                this.dbConnection.Close();
            }
        }

    }
}
