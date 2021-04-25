using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    abstract class DBMediator
    {
        private MySqlConnection dbConnection;
        private string server = "studmysql01.fhict.local";
        private string database = "dbi467491";
        private string uid = "dbi467491";
        private string password = "bulcari";
        public MySqlConnection DbConnection
        {
            get { return dbConnection; }
        }

        public DBMediator()
        {
            dbConnection = new MySqlConnection($"server={server};database={database};uid={uid};password={password};");
        }
    }
}
