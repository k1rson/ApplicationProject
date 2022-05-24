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

        public static bool ChekUserReg(string username)
        {
            MySqlConnection conn = DB.GetDBConnection();
            conn.Open();

            string sqlCheck = $"SELECT EXISTS(SELECT username FROM users WHERE username = '{username}')";

            MySqlCommand cmd = new MySqlCommand(sqlCheck, conn);
            MySqlDataReader count = cmd.ExecuteReader();
            int cont = 0;
            while (count.Read())
            {   
                cont = int.Parse(count[0].ToString());
            }
            conn.Close();

            if (cont == 1)
                return true;
            else
                return false;
        }

    }
}
