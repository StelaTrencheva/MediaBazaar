using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    class DBMediatorRestockRequest : DBMediator
    {
        public DBMediatorRestockRequest() : base() { }

        public Dictionary<int, Product> GetListOfRequestedProducts()
        {
            string sqlStatement = "SELECT *, r.pQuantity as quantity FROM `mb_product` as p " +
                                  "INNER JOIN `mb_restock_request` as r " +
                                  "ON r.pNum = p.pNum";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
            Dictionary<int, Product> p = new Dictionary<int, Product>();

            try
            {
                MySqlDataReader reader;
                DbConnection.Open();
                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    p.Add((int)reader["quantity"], new Product((int)reader["pNum"], (string)reader["brand"], (string)reader["type"], (string)reader["model"],
                        (string)reader["description"], (string)reader["barcode"], (decimal)reader["cost_price"], (decimal)reader["sales_price"],
                        (int)reader["amount_in_store"], (int)reader["amount_in_warehouse"]));
                }
                return p;
            }
            catch (MySqlException e)
            {
                return p;
            }
            finally
            {
                DbConnection.Close();
            }
        }


    }
}
