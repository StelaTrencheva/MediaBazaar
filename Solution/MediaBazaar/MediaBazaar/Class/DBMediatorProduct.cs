using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    class DBMediatorProduct: DBMediator
    {
        public DBMediatorProduct() : base() { }


        //TAKE ALL PRODUCTS
        public List<Product> GetProducts()
        {
            string sqlStatement = "SELECT * FROM mb_product";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            List<Product> p = new List<Product>();

            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
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
                //MessageBox.Show(sqlExceptionMessage(e.Message));
                return p;
            }
            finally
            {
                DbConnection.Close();
            }
        }

        //ADD PRODUCT
        public bool AddProduct(string brand, string type, string model, string description, string category,
            string subcategory, decimal costPrice, decimal salePrice, int amountInStore, int amountInWarehouse)
        {
            string sqlStatement = "INSERT INTO mb_product (brand, type, model, description, category, sub_category, cost_price, " +
                "sales_price, amount_in_store, amount_in_warehouse) VALUES (@br, @ty, @mo, @de, @ca, @sc, @cp, @sp, @as, @aw)";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);

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

        //DELETE PRODUCT
        public bool DeleteProduct(int id)
        {
            string sqlStatement = "DELETE FROM `mb_product` WHERE pNum=@i";
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
        public bool CheckIfExists(string model, string brand)
        {
            //SELECT pNum FROM mb_product WHERE model = 'EasyDrill 1200 12V' AND brand = 'Bosch';
            string sqlStatement = "SELECT pNum FROM mb_product WHERE model = @M AND brand = @B;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection); ;
            sqlCommand.Parameters.AddWithValue("@M", model);
            sqlCommand.Parameters.AddWithValue("@B", brand);

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

    }
}
