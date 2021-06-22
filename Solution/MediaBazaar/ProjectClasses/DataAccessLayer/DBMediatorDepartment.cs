using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
     class DBMediatorDepartment: DBMediator
     {
        public DBMediatorDepartment(DatabaseType databaseType) : base(databaseType) { }

        //ADD DEPARTMENT
        public Department AddDepartment(int code,string name)
        {
            string sqlStatement = "INSERT INTO `mb_department` (code, dept_name) VALUES (@c, @n);";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@c", code);
            sqlCommand.Parameters.AddWithValue("@n", name);

            try
            {
                int n = 0;
                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();
                if (n == 1)
                {
                    return new Department(code, name);
                }
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

        //ASSING DEPARTMENT MANAGER TO DEPARTMENT
        public bool AssignDManagerToDept(int code, int managerId)
        {
            string sqlStatement = "INSERT INTO `mb_dept_with_assigned_dmanager` (`dept_code`, `dmanager_id`) VALUES (@c, @i);";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@c", code);
            sqlCommand.Parameters.AddWithValue("@i", managerId);

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

        //DELETE DEPARTMENT
        public void DeleteDepartment(int code)
        {
            string sqlStatement = "DELETE FROM `mb_department` WHERE code= @c";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection); ;
            sqlCommand.Parameters.AddWithValue("@c", code);
            try
            {
                int n = 0;
                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();

                //if (n == 1)
                //{
                //    return true;
                //}
                //return false;
            }
            catch (MySqlException)
            {
                //MessageBox.Show(sqlExceptionMessage(e.Message));
                //return false;
            }
            catch (Exception)
            {
                //MessageBox.Show(sqlExceptionMessage(e.Message));
                //return false;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        //GET DEPARTMENT
        public List<Department> GetDepartment()
        {
            string sqlStatement = "SELECT code, dept_name FROM mb_department";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            List<Department> d = new List<Department>();

            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    d.Add(new Department((int)reader["code"], (string)reader["dept_name"]));
                }
                return d;
            }
            catch (MySqlException e)
            {
                return d;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        //MODIFY DEPARTMENT
        public void UpdateDepartment(int code, string name)
        {
            string sqlStatement = "UPDATE `mb_department` SET `dept_name` = @n WHERE `code` = @c";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@n", name);
            sqlCommand.Parameters.AddWithValue("@c", code);

            try
            {
                int n = 0;
                DbConnection.Open();
                n = sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                DbConnection.Close();
            }
        }

        //GET DEPARTMENT WTH DEPARTMENT MANAGER
        //public List<Department> GetDepartmentWithDManager()
        //{
        //    string sqlStatement = "SELECT a.dept_code, d.dept_name, a.dmanager_id, e.fname, e.lname FROM mb_department AS d " +
        //        "INNER JOIN mb_dept_with_assigned_dmanager AS a ON d.code = a.dept_code " +
        //        "INNER JOIN mb_employee AS e ON a.dmanager_id = e.id";
        //    MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
        //    List<Department> d = new List<Department>();

        //    try
        //    {
        //        MySqlDataReader reader;
        //        DbConnection.Open();
        //        reader = sqlCommand.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            d.Add(new Department((int)reader["dept_code"], (string)reader["dept_name"], (int)reader["dmanager_id"],
        //                (string)reader["fname"], (string)reader["lname"]));
        //        }
        //        return d;
        //    }
        //    catch (MySqlException e)
        //    {
        //        return d;
        //    }
        //    finally
        //    {
        //        DbConnection.Close();
        //    }
        //}

        //GET DEPARTMENT WITH PRODUCT CATEGORY
        //public List<Department> GetDepartmentWithPCategory()
        //{
        //    string sqlStatement = "SELECT a.dept_code, d.dept_name, a.product_num, p.category FROM mb_department AS d " +
        //        "INNER JOIN mb_dept_with_assigned_product AS a ON d.code = a.dept_code INNER JOIN mb_product AS p " +
        //        "ON a.product_num = p.pNum";
        //    MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
        //    List<Department> d = new List<Department>();

        //    try
        //    {
        //        MySqlDataReader reader;
        //        DbConnection.Open();
        //        reader = sqlCommand.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            d.Add(new Department((int)reader["dept_code"], (string)reader["dept_name"], (int)reader["product_num"],
        //                (string)reader["category"]));
        //        }
        //        return d;
        //    }
        //    catch (MySqlException e)
        //    {
        //        return d;
        //    }
        //    finally
        //    {
        //        DbConnection.Close();
        //    }
        //}

        //CHECK IF THE CREATED DEPARTMENT EXIST
        public bool CheckIfDeptExist(int code, string name)
        {
            string sqlStatement = "SELECT code FROM mb_department WHERE code = @c OR dept_name = @n;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection); ;
            sqlCommand.Parameters.AddWithValue("@c", code);
            sqlCommand.Parameters.AddWithValue("@n", name);

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

        //CHECK IF THE ASSINGN DEPARTMENT MANAGER TO DEPARTMENT EXIST
        public bool CheckIfDManagerToDeptExists(int code, int id)
        {
            string sqlStatement = "SELECT dept_code FROM mb_dept_with_assigned_dmanager WHERE dept_code = @c OR dmanager_id = @i";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection); ;
            sqlCommand.Parameters.AddWithValue("@c", code);
            sqlCommand.Parameters.AddWithValue("@i", id);

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

        //NEW
        //ADD CATEGORY
        public bool AddCategory(int deptId, string name)
        {
            string sqlStatement = "INSERT INTO `mb_dept_category` (dept_id, name) VALUES (@deptId, @name);";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@deptId", deptId);
            sqlCommand.Parameters.AddWithValue("@name", name);

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

        //ADD Subcategory
        public bool AddSubcategory(int deptId, string catName, string name)
        {
            string sqlStatement = "INSERT INTO `mb_dept_subcategory` ( `cat_id`, `name`) VALUES " +
                "((SELECT id FROM mb_dept_category where dept_id=@deptId AND name = @catName), @name);";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@deptId", deptId);
            sqlCommand.Parameters.AddWithValue("@catName", catName);
            sqlCommand.Parameters.AddWithValue("@name", name);

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

        //DELETE Category
        public bool DeleteCategory(int deptId, string name)
        {
            string sqlStatement = "DELETE FROM `mb_dept_category` WHERE dept_id=@deptId and name = @name";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection); ;
            sqlCommand.Parameters.AddWithValue("@deptId", deptId);
            sqlCommand.Parameters.AddWithValue("@name", name);
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
                //MessageBox.Show(sqlExceptionMessage(e.Message));
                return false;
            }
            catch (Exception e)
            {
                //MessageBox.Show(sqlExceptionMessage(e.Message));
                return false;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        //DELETE Subcategory
        public bool DeleteSubcategory(int deptId, string catName, string name)
        {
            string sqlStatement = "DELETE FROM `mb_dept_subcategory` WHERE cat_id = " +
                "(SELECT c.id FROM mb_dept_category as c WHERE dept_id = @deptId AND name = @catName) AND name = @name";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection); ;
            sqlCommand.Parameters.AddWithValue("@deptId", deptId);
            sqlCommand.Parameters.AddWithValue("@catName", catName);
            sqlCommand.Parameters.AddWithValue("@name", name);
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
                //MessageBox.Show(sqlExceptionMessage(e.Message));
                return false;
            }
            catch (Exception e)
            {
                //MessageBox.Show(sqlExceptionMessage(e.Message));
                return false;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        //Get Dept Managers
        public List<Employee> GetDepartmentManagers(int deptId)
        {
            string sqlStatement = "SELECT * FROM `mb_employee` WHERE id IN (select dmanager_id FROM mb_department_dmanager where dept_code = @id)";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@id", deptId);
            List<Employee> managers = new List<Employee>();
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
                    managers.Add(new Employee(Convert.ToInt32(EmployeeReader["id"]), EmployeeReader["bsn"].ToString(),
                    EmployeeReader["fname"].ToString(), EmployeeReader["lname"].ToString(), gender,
                    EmployeeReader["email"].ToString(), EmployeeReader["uname"].ToString(),
                    Convert.ToDateTime(EmployeeReader["birthdate"].ToString()), EmployeeReader["street"].ToString(),
                    EmployeeReader["streetnumber"].ToString(), EmployeeReader["zipcode"].ToString(), EmployeeReader["town"].ToString(),
                    EmployeeReader["country"].ToString(), Convert.ToDateTime(EmployeeReader["firstworkingday"].ToString()),
                    EmployeeReader["emergphonenumber"].ToString(), EmployeeReader["iban"].ToString(),
                    Convert.ToDouble(EmployeeReader["hourlywage"]),
                    Convert.ToDateTime(EmployeeReader["contractstartdate"].ToString()), contracttype, position));
                }
                return managers;
            }
            catch (MySqlException)
            {
                return managers;
            }
            finally
            {
                DbConnection.Close();
            }

        }

        //Get Department categories
        public List<string> GetDepartmentCategories(int deptId)
        {
            string sqlStatement = "SELECT name FROM `mb_dept_category` WHERE dept_id = @id";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@id", deptId);
            List<string> categories = new List<string>();

            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    categories.Add((string)reader["name"]);
                }
                return categories;
            }
            catch (MySqlException e)
            {
                return categories;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        //Get Department subcategories
        public List<string> GetDepartmentSubcategories(int deptId, string category)
        {
            string sqlStatement = "SELECT name FROM `mb_dept_subcategory` WHERE cat_id = " +
                "(SELECT c.id FROM mb_dept_category as c WHERE dept_id = @dept_id AND name = @cat)";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@dept_id", deptId);
            sqlCommand.Parameters.AddWithValue("@cat", category);
            List<string> categories = new List<string>();

            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    categories.Add((string)reader["name"]);
                }
                return categories;
            }
            catch (MySqlException e)
            {
                return categories;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        public List<Employee> GetStoreWorkersFromDepartment(string deptCode)
        {
            string sqlStatement = "SELECT e.*, c.contract as contracttype, c.startdate as contractstartdate FROM `mb_department_storeworker` AS d " +
                                  "INNER JOIN `mb_employee` AS e " +
                                  "ON d.storeworker_id = e.id " +
                                  "LEFT JOIN `mb_employee_contract` AS c on e.id = c.empid " +
                                  "WHERE d.dept_code = @deptCode";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@deptCode", deptCode);
            List<Employee> employees = new List<Employee>();
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
                    employees.Add(new Employee(Convert.ToInt32(EmployeeReader["id"]), EmployeeReader["bsn"].ToString(),
                    EmployeeReader["fname"].ToString(), EmployeeReader["lname"].ToString(), gender,
                    EmployeeReader["email"].ToString(), EmployeeReader["uname"].ToString(),
                    Convert.ToDateTime(EmployeeReader["birthdate"].ToString()), EmployeeReader["street"].ToString(),
                    EmployeeReader["streetnumber"].ToString(), EmployeeReader["zipcode"].ToString(), EmployeeReader["town"].ToString(),
                    EmployeeReader["country"].ToString(), Convert.ToDateTime(EmployeeReader["firstworkingday"].ToString()),
                    EmployeeReader["emergphonenumber"].ToString(), EmployeeReader["iban"].ToString(),
                    Convert.ToDouble(EmployeeReader["hourlywage"]),
                    Convert.ToDateTime(EmployeeReader["contractstartdate"].ToString()), contracttype, position));
                }
                return employees;
            }
            catch (MySqlException)
            {
                return employees;
            }
            finally
            {
                DbConnection.Close();
            }
        }
    }
}
