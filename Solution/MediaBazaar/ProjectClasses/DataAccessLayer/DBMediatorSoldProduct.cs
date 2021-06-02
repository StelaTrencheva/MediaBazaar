using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectClasses
{
    class DBMediatorSoldProduct : DBMediator
    {
        public void updateItems(int empID, List<SoldProduct> basket, PaymentType type)
        {
            MySqlTransaction tr = null;

            try
            {
                DbConnection.Open();
                tr = this.DbConnection.BeginTransaction();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = DbConnection;
                cmd.Transaction = tr;
                
                //Receipt
                cmd.CommandText = "INSERT INTO `mb_receipt`(`empid`, `paymenttype`, `time`) VALUES (@empID,@type,@time)";
                DateTime time = DateTime.Now;
                cmd.Parameters.AddWithValue("@empID", empID);
                cmd.Parameters.AddWithValue("@type", type.ToString());
                cmd.Parameters.AddWithValue("@time", time.ToString("yyyy-MM-dd hh:mm:ss"));
                if (cmd.ExecuteNonQuery() == 0)
                {
                    throw new Exception();
                }
                //ReceiptId
                int receiptId;
                cmd.CommandText = "SELECT MAX(id) FROM mb_receipt";
                object receitIdObject = cmd.ExecuteScalar();
                if (receitIdObject != null)
                {
                    receiptId = Convert.ToInt32(receitIdObject);
                }
                else
                {
                    throw new Exception();
                }


                //Receipt lines
                foreach (SoldProduct soldProduct in basket)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO `mb_receipt_line`(`receiptid`, `productid`, `quantity`, `unitprice`) VALUES (@receiptID,@prodID,@quantity,@unitPrice);";
                    cmd.Parameters.AddWithValue("@receiptID", receiptId);
                    cmd.Parameters.AddWithValue("@prodID", soldProduct.Product.PNumber);
                    cmd.Parameters.AddWithValue("@quantity", soldProduct.Quantity);
                    cmd.Parameters.AddWithValue("@unitPrice", soldProduct.Product.SalePrice);

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        throw new Exception();
                    }
                }

                tr.Commit();
            }
            catch (Exception ex)
            {
                try
                {
                    tr.Rollback();
                }
                catch (MySqlException ex1)
                {
                    MessageBox.Show(ex1.ToString());
                }

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DbConnection.Close();
            }
        }
    }
}

//public DBMediatorSoldProduct() : base() { }

//public bool ExecuteOrder(int empID, List<SoldProduct> basket, PaymentType type, decimal total)
//{
//    string sqlStatement = "INSERT INTO `mb_receipt`(`empid`, `paymenttype`, `totalprice`, `time`) VALUES (@empID,@type,@total,@time);";

//    MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection);
//    DateTime time = DateTime.Now;
//    sqlCommand.Parameters.AddWithValue("@empID", empID);
//    sqlCommand.Parameters.AddWithValue("@type", type.ToString());
//    sqlCommand.Parameters.AddWithValue("@total", total);
//    sqlCommand.Parameters.AddWithValue("@time", time.ToString("yyyy-MM-dd hh:mm:ss"));
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
//    //catch (MySqlException)
//    //{
//    //    return false;
//    //}
//    catch (Exception exe)
//    {
//        return false;
//    }
//    finally
//    {
//        DbConnection.Close();
//        SaveProducts(time, empID, basket, type);
//    }
//}
//private int GetReceitID(DateTime time, int empID)
//{
//    string sqlStatement = "SELECT id FROM `mb_receipt` WHERE time=@time AND empid=@empID";
//    MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, this.DbConnection);
//    sqlCommand.Parameters.AddWithValue("@time", time.ToString("yyyy-MM-dd hh:mm:ss"));
//    sqlCommand.Parameters.AddWithValue("@empID", empID);
//    int receitID = 0;
//    try
//    {
//        MySqlDataReader reader;
//        DbConnection.Open();
//        reader = sqlCommand.ExecuteReader();

//        while (reader.Read())
//        {
//            receitID = Convert.ToInt32(reader["id"]);
//        }
//    }
//    finally
//    {
//        this.DbConnection.Close();
//    }
//    return receitID;
//}
//public void SaveProducts(DateTime time, int empID, List<SoldProduct> basket, PaymentType type)
//{
//    int receitID = GetReceitID(time, empID);
//    string sqlStatement = "INSERT INTO `mb_sold_product`(`receiptid`, `productid`, `quantity`, `unitprice`) VALUES (@receiptID,@prodID,@quantity,@unitPrice);";
//    try
//    {
//        using (MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, DbConnection))
//        {
//            sqlCommand.Parameters.Add("@receiptID", (MySqlDbType)SqlDbType.Int, 11);
//            sqlCommand.Parameters.Add("@prodID", (MySqlDbType)SqlDbType.Int, 11);
//            sqlCommand.Parameters.Add("@quantity", (MySqlDbType)SqlDbType.Int, 5);
//            sqlCommand.Parameters.Add("@unitPrice", (MySqlDbType)SqlDbType.Decimal, 7);

//            //sqlCommand.Parameters.AddWithValue("@receiptID", receitID);
//            //sqlCommand.Parameters.AddWithValue("@prodID", type);
//            //sqlCommand.Parameters.AddWithValue("@quantity", total);
//            //sqlCommand.Parameters.AddWithValue("@unitPrice", total);
//            int n = 0;

//            DbConnection.Open();
//            foreach (SoldProduct product in basket)
//            {
//                sqlCommand.Parameters["@receiptID"].Value = receitID;
//                sqlCommand.Parameters["@prodID"].Value = product.Product.PNumber;
//                sqlCommand.Parameters["@quantity"].Value = product.Quantity;
//                sqlCommand.Parameters["@unitPrice"].Value = product.Price / product.Quantity;
//                n = sqlCommand.ExecuteNonQuery();
//            }
//        }
//    }
//    //catch (MySqlException)
//    //{
//    //    return false;
//    //}
//    catch (Exception)
//    {

//    }
//    finally
//    {
//        DbConnection.Close();
//    }
//}

/*
    using (SqlCommand Insertcmd = new SqlCommand(InsertData, sqlconn))
    {
        // create the parameters **ONCE** and define their datatypes
        // I have only *guessed* what the datatypes could be - adapt as needed
        Insertcmd.Parameters.Add("@TestSuite", SqlDbType.VarChar, 50);
        Insertcmd.Parameters.Add("@TestCase", SqlDbType.VarChar, 50);
        Insertcmd.Parameters.Add("@Status", SqlDbType.VarChar, 50);
        Insertcmd.Parameters.Add("@Info", SqlDbType.VarChar, 50);
        Insertcmd.Parameters.Add("@Time", SqlDbType.Time);
        Insertcmd.Parameters.Add("@IsArchived", SqlDbType.Boolean);
        Insertcmd.Parameters.Add("@DateTime", SqlDbType.DateTime);

        sqlconn.Open();

        // now loop over the data and set the parameter values
        for (int j = 1; j < TDData.Length; j +=5)
        {
            string TestSuite = TDData[j];
            string TestCase = TDData[j+1];
            string Status = TDData[j + 2];
            string Info = TDData[j + 3];
            string Time = TDData[j + 4];

            Insertcmd.Parameters["@TestSuite"].Value = TestSuite;
            Insertcmd.Parameters["@TestCase"].Value = TestCase;
            Insertcmd.Parameters["@Status"].Value = Status;
            Insertcmd.Parameters["@Info"].Value = Info;
            Insertcmd.Parameters["@Time"].Value = Time;
            Insertcmd.Parameters["@IsArchived"].Value = true;
            Insertcmd.Parameters["@DateTime"].Value = DateTime.Now;

            // execute the query in the loop
            Insertcmd.ExecuteNonQuery();
        }   

        sqlconn.Close();
             */
