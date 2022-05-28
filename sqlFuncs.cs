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

        public static bool IsCheckFilename(string username, string filename)
        {
            MySqlConnection conn = DB.GetDBConnection();
            conn.Open();
            string sqlCheck = $"SELECT COUNT(fileName) FROM files WHERE username = '{username}' AND fileName = '{filename}'";
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

        public static List<string> selectUserFiles(string username)
        {
            MySqlConnection conn = DB.GetDBConnection();
            conn.Open();

            string sqlCheck = $"SELECT * FROM files WHERE username = '{username}'";

            MySqlCommand cmd = new MySqlCommand(sqlCheck, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            var files = new List<string>();
            while (reader.Read())
            {
                // элементы массива [] - это значения столбцов из запроса SELECT
                files.Add(reader[1].ToString());
            }
            reader.Close();
            conn.Close();
            return files;
        }


        public static string selectDecryptedText(string filename, string username)
        {
            MySqlConnection conn = DB.GetDBConnection();
            conn.Open();

            string sqlCheck = $"SELECT * FROM files WHERE fileName = '{filename}' AND username = '{username}'";

            MySqlCommand cmd = new MySqlCommand(sqlCheck, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            string text = string.Empty;
            while (reader.Read())
            {
                // элементы массива [] - это значения столбцов из запроса SELECT
                text = reader[2].ToString();
            }
            reader.Close();
            conn.Close();
            return text;
        }

        public static string selectEncryptedText(string filename, string username)
        {
            MySqlConnection conn = DB.GetDBConnection();
            conn.Open();

            string sqlCheck = $"SELECT * FROM files WHERE fileName = '{filename}' AND username = '{username}'";

            MySqlCommand cmd = new MySqlCommand(sqlCheck, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            string text = string.Empty;
            while (reader.Read())
            {
                // элементы массива [] - это значения столбцов из запроса SELECT
                text = reader[3].ToString();
            }
            reader.Close();
            conn.Close();
            return text;
        }



        public static void addFileManual(string username, string fileName)
        {
            MySqlConnection conn = DB.GetDBConnection();
            conn.Open();

            string sql = $"INSERT INTO files (fileName, username) VALUES ('{fileName}', '{username}')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }


        public static void updateFile(string username, string fileName, string decrypted, string encrypted)
        {
            MySqlConnection conn = DB.GetDBConnection();
            conn.Open();

            string sql = $"UPDATE files SET decrypted = '{decrypted}', encrypted = '{encrypted}' WHERE fileName = '{fileName}' AND username = '{username}'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }


        public static void addFile(string username, string fileName, string decrypted)
        {
            MySqlConnection conn = DB.GetDBConnection();
            conn.Open();

            string sql = $"INSERT INTO files (fileName,decrypted, username) VALUES ('{fileName}', '{decrypted}' , '{username}')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void deleteAllFiles(string username)
        {
            MySqlConnection conn = DB.GetDBConnection();
            conn.Open();

            string sql = $"DELETE FROM files WHERE username = '{username}'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void ChangeFileName(string username, string fileName, string newFileName)
        {
            MySqlConnection conn = DB.GetDBConnection();
            conn.Open();

            string sql = $"UPDATE files SET fileName = '{newFileName}' WHERE fileName = '{fileName}' AND username = '{username}'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        // All users
        public static List<string> selectUsersList()
        {
            MySqlConnection conn = DB.GetDBConnection();
            conn.Open();

            string sqlCheck = $"SELECT * FROM users";

            MySqlCommand cmd = new MySqlCommand(sqlCheck, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            var users = new List<string>();

            while (reader.Read())
            {
                // элементы массива [] - это значения столбцов из запроса SELECT
                users.Add(reader[0].ToString() + ":" + reader[1].ToString());
            }
            reader.Close();
            conn.Close();
            return users;
        }


        // Админ ли
        public static bool IsAdmin(string username)
        {
            MySqlConnection conn = DB.GetDBConnection();
            conn.Open();

            string sqlCheck = $"SELECT role FROM users WHERE username = '{username}'";

            MySqlCommand cmd = new MySqlCommand(sqlCheck, conn);
            MySqlDataReader roleSelect = cmd.ExecuteReader();
            string role = string.Empty;

            while (roleSelect.Read())
            {
                role = roleSelect["role"].ToString();
            }
            conn.Close();

            if (role == "Admin")
                return true;
            else if (role == "root")
                return true;
            else
                return false;
        }

        // СуперАдмин
        public static bool IsRoot(string username)
        {
            MySqlConnection conn = DB.GetDBConnection();
            conn.Open();

            string sqlCheck = $"SELECT role FROM users WHERE username = '{username}'";

            MySqlCommand cmd = new MySqlCommand(sqlCheck, conn);
            MySqlDataReader roleSelect = cmd.ExecuteReader();
            string role = string.Empty;

            while (roleSelect.Read())
            {
                role = roleSelect["role"].ToString();
            }
            conn.Close();

            if (role == "root")
                return true;
            else
                return false;
        }


        // Add admin
        public static void addAdmin(decimal id)
        {
            MySqlConnection conn = DB.GetDBConnection();
            conn.Open();

            string sql = $"UPDATE users SET role = 'Admin' WHERE id = {id}";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // Add admin
        public static void delAdmin(decimal id)
        {
            MySqlConnection conn = DB.GetDBConnection();
            conn.Open();

            string sql = $"UPDATE users SET role = 'User' WHERE id = {id}";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // All admins
        public static List<string> selectAdminsList()
        {
            MySqlConnection conn = DB.GetDBConnection();
            conn.Open();

            string sqlCheck = $"SELECT * FROM users WHERE role = 'Admin'";

            MySqlCommand cmd = new MySqlCommand(sqlCheck, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            var users = new List<string>();

            while (reader.Read())
            {
                // элементы массива [] - это значения столбцов из запроса SELECT
                users.Add(reader[0].ToString() + ":" + reader[1].ToString());
            }
            reader.Close();
            conn.Close();
            return users;
        }

        // Add file in basket

        public static void addFileRecycle(string username, string fileName, string decrypted, string encrypted)
        {
            MySqlConnection conn = DB.GetDBConnection();
            conn.Open();

            string sqlDel = $"DELETE FROM files WHERE username = '{username}' AND filename = '{fileName}'";
            string sql = $"INSERT INTO recycle (fileName, encrypted, decrypted, username) VALUES ('{fileName}', {encrypted},'{decrypted}' , '{username}')";
            MySqlCommand cmd = new MySqlCommand(sqlDel, conn);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        // Восстановить файл

        public static void returnFileRecycle(string username, string fileName, string decrypted, string encrypted)
        {
            MySqlConnection conn = DB.GetDBConnection();
            conn.Open();

            string sqlDel = $"DELETE FROM recycle WHERE username = '{username}' AND filename = '{fileName}'";
            string sql = $"INSERT INTO files (fileName, encrypted, decrypted, username) VALUES ('{fileName}', {encrypted},'{decrypted}' , '{username}')";
            MySqlCommand cmd = new MySqlCommand(sqlDel, conn);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        // удаление файла
        public static void deleteSelectedFile(string username, string fileName)
        {
            MySqlConnection conn = DB.GetDBConnection();
            conn.Open();

            string sql = $"DELETE FROM recycle WHERE username = '{username}' AND fileName = '{fileName}'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
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
