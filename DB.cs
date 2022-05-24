using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ApplicationProject
{
    internal class DB
    {
        public static MySqlConnection GetDBConnection(string host, int port, string database, string username, string password)
        {
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password + ";CharSet=utf8mb4;";

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }

        public static MySqlConnection GetDBConnection()
        {
            string host = "31.31.198.99";
            int port = 3306;
            string database = "u1625777_database";
            string username = "u1625777_shift";
            string password = "cS6sC6wJ3pmD7j";

            return DB.GetDBConnection(host, port, database, username, password);
        }
    }
}
