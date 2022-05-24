using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ApplicationProject
{
    internal class sqlFuncs
    {

        public static void regUser(string username, string password)
        {
            MySqlConnection conn = DB.GetDBConnection();
            conn.Open();

            string sql = $"INSERT INTO users (username, password, role) VALUES ('{username}', '{password}', 'User')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

    }
}
