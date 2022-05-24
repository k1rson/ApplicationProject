using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;


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

        public static bool IsCheckDataAuth(string username, string password)
        {
            MySqlConnection conn = DB.GetDBConnection();
            conn.Open();

            string sqlCheck = $"SELECT COUNT(username) FROM users WHERE password = '{password}' AND username = '{username}'";

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


        // Шифрование
        public static string sha256(string randomString)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }

    }
}
