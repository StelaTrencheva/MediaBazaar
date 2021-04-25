﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
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
        public bool AddProduct(Product newProd)
        {
            string sqlStatement = "INSERT INTO mb_product (brand, type, model, description, category, sub_category, cost_price, " +
                "sales_price, amount_in_store, amount_in_warehouse) VALUES (@br, @ty, @mo, @de, @ca, @sc, @cp, @sp, @as, @aw)";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);

            sqlCommand.Parameters.AddWithValue("@br", newProd.Brand);
            sqlCommand.Parameters.AddWithValue("@ty", newProd.Type);
            sqlCommand.Parameters.AddWithValue("@mo", newProd.Model);
            sqlCommand.Parameters.AddWithValue("@de", newProd.Description);
            sqlCommand.Parameters.AddWithValue("@ca", newProd.Category);
            sqlCommand.Parameters.AddWithValue("@sc", newProd.Subcategory);
            sqlCommand.Parameters.AddWithValue("@cp", newProd.CostPrice);
            sqlCommand.Parameters.AddWithValue("@sp", newProd.SalePrice);
            sqlCommand.Parameters.AddWithValue("@as", newProd.AmountInStore);
            sqlCommand.Parameters.AddWithValue("@aw", newProd.AmountInWarehouse);

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