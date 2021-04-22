using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
     class DBMediatorDepartment: DBMediator
     {
        public DBMediatorDepartment() : base() { }

        //ADD DEPARTMENT
        public bool AddDepartment(int code, string name)
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

        //public bool AddDepartment(string name, int id)
        //{
        //    string sqlStatement = "INSERT INTO `mb_department` (`dept_name`, `dept_manager_id`) VALUES (@n, @i);";
        //    MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
        //    sqlCommand.Parameters.AddWithValue("@n", name);
        //    sqlCommand.Parameters.AddWithValue("@i", id);

        //    try
        //    {
        //        int n = 0;

        //        DbConnection.Open();
        //        n = sqlCommand.ExecuteNonQuery();
        //        if (n == 1)
        //        {
        //            return true;
        //        }
        //        return false;
        //    }
        //    catch (MySqlException e)
        //    {
        //        return false;
        //    }
        //    catch (Exception e)
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        DbConnection.Close();
        //    }
        //}

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

        //public List<Department> GetDepartment()
        //{
        //    string sqlStatement = "SELECT d.code, d.dept_name, d.dept_manager_id, e.fname, e.lname FROM mb_department AS d INNER JOIN" +
        //        " mb_employee AS e ON d.dept_manager_id = e.id";
        //    MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
        //    List<Department> d = new List<Department>();

        //    try
        //    {
        //        MySqlDataReader reader;
        //        DbConnection.Open();
        //        reader = sqlCommand.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            d.Add(new Department((int)reader["code"], (string)reader["dept_name"], (int)reader["dept_manager_id"],
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

        //CHECK IF CODE & DEPARTMENT NAME EXIST
        public bool CheckIfExists(int code,string name)
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

        //public bool CheckIfExists(int id, string name)
        //{
        //    string sqlStatement = "SELECT dept_mng_id FROM mb_department WHERE dept_mng_id = @i OR dept_name = @n;";
        //    MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection); ;
        //    sqlCommand.Parameters.AddWithValue("@i", id);
        //    sqlCommand.Parameters.AddWithValue("@n", name);

        //    try
        //    {
        //        DbConnection.Open();
        //        Object test = sqlCommand.ExecuteScalar();

        //        if (test != null)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch (MySqlException)
        //    {
        //        return false;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        DbConnection.Close();
        //    }
        //}
     }
}
