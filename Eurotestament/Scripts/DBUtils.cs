using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SqlConn
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "c9113991.beget.tech";
            int port = 3306;
            string database = "c9113991_et";
            string username = "c9113991_et";
            string password = "Xaker1415";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }


        public static string GetDBString()
        {
            string host = "c9113991.beget.tech";
            int port = 3306;
            string database = "c9113991_et";
            string username = "c9113991_et";
            string password = "Xaker1415";

            return DBMySQLUtils.GetDBString(host, port, database, username, password);
        }
    }
}