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
        public bool AddDepartment(string name)
        {
            string sqlStatement = "INSERT INTO mb_department (dept_name) VALUES (@dn)";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            sqlCommand.Parameters.AddWithValue("@dn", name);

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
        //GET DEPARTMENT
        public List<Department> GetDepartment()
        {
            string sqlStatement = "SELECT * FROM mb_department";
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
    }
}
