using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ApplicationProject
{
    public class sqlFuncs
    {
        public static MySqlConnection GetDBConnection()
        {
            


            // Connection String.
            String connString = "Server=" + config.host + ";Database=" + config.database
                + ";port=" + config.port + ";User Id=" + config.username + ";password=" + config.password + ";CharSet=utf8mb4;";


            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }




        public static void regUser(string username, string password)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();
                string sql = $"INSERT INTO users (username, password, role) VALUES ('{username}', '{password}', 'User')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
            }
            
        }


        // Проверки

        public static bool ChekUserReg(string username)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
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
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
                return false;
            }
        }
        
        public static bool IsCheckDataAuth(string username, string password)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
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
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
                return false;
            }
            
        }

        public static bool IsCheckFilename(string username, string filename)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
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
            catch (Exception)
            {

                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
                return false;
            }
            
        }


        // Админ ли
        public static bool IsAdmin(string username)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
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
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
                return false;
            }

            
        }

        // СуперАдмин
        public static bool IsRoot(string username)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
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
            catch (Exception)
            {

                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
                return false;
            }
            
        }


        public static bool IsSession(string username)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();

                string sqlCheck = $"SELECT session FROM users WHERE username = '{username}'";

                MySqlCommand cmd = new MySqlCommand(sqlCheck, conn);
                MySqlDataReader roleSelect = cmd.ExecuteReader();
                string role = string.Empty;

                while (roleSelect.Read())
                {
                    role = roleSelect["session"].ToString();
                }
                conn.Close();

                if (role == "True")
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
                return false;
            }
            
        }







        // Работа с данными

        public static string selectDecryptedText(string filename, string username)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
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
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
                return string.Empty;
            }
            
        }

        public static string selectEncryptedText(string filename, string username)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
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
            catch (Exception)
            {

                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
                return string.Empty;
            }
            
        }



        



        


        //Работа с пользователями

        // All users
        public static List<string> selectUsersList()
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
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
            catch (Exception)
            {

                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
                return new List<string>();
            }
            
        }




        // Add admin
        public static void addAdmin(decimal id)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();

                string sql = $"UPDATE users SET role = 'Admin' WHERE id = {id}";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
            }
            
        }

        // Add admin
        public static void delAdmin(decimal id)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();

                string sql = $"UPDATE users SET role = 'User' WHERE id = {id}";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
            }
            
        }

        // All admins
        public static List<string> selectAdminsList()
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
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
            catch (Exception)
            {

                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
                return new List<string>();
            }
            
        }


        // Сессия

        public static void openSession(string username)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();

                string sql = $"UPDATE users SET session = True WHERE username = '{username}'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
            }

        }


        public static void closeSession(string username)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();

                string sql = $"UPDATE users SET session = False WHERE username = '{username}'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
            }
            
        }



        // Работа с файлами
        public static List<string> selectUserFiles(string username)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();

                string sqlCheck = $"SELECT * FROM files WHERE username = '{username}' AND status = 'using'";

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
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
                return new List<string>();
            }
            
        }

        public static List<string> selectUserRecycleFiles(string username)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();

                string sqlCheck = $"SELECT * FROM files WHERE username = '{username}' AND status = 'recycle'";

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
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
                return new List<string>();
            }
            
        }

        // Добавление файла по названию

        public static void addFileManual(string username, string fileName)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();

                string sql = $"INSERT INTO files (fileName, username) VALUES ('{fileName}', '{username}')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
            }
        }


        // Обновление данных в файле

        public static void updateFile(string username, string fileName, string decrypted, string encrypted)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();

                string sql = $"UPDATE files SET decrypted = '{decrypted}', encrypted = '{encrypted}' WHERE fileName = '{fileName}' AND username = '{username}'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
            }
        }

        // Добавление файла с пк

        public static void addFile(string username, string fileName, string decrypted)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();

                string sql = $"INSERT INTO files (fileName,decrypted, username) VALUES ('{fileName}', '{decrypted}' , '{username}')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
            }
        }


        // Изменение имени файла
        public static void ChangeFileName(string username, string fileName, string newFileName)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();

                string sql = $"UPDATE files SET fileName = '{newFileName}' WHERE fileName = '{fileName}' AND username = '{username}'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
            }
        }




        // Add file in basket

        public static void addFileRecycle(string username, string fileName)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();

                string sql = $"UPDATE files SET status = 'recycle' WHERE username = '{username}' AND filename = '{fileName}'";
                MySqlCommand cmdSql = new MySqlCommand(sql, conn);
                cmdSql.ExecuteNonQuery();


                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
            }
        }

        public static void addAllFileRecycle(string username)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();

                string sql = $"UPDATE files SET status = 'recycle' WHERE username = '{username}'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
            }
        }

        

        // Восстановить файл

        public static void returnFileRecycle(string username, string fileName)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();

                string sqlDel = $"UPDATE files SET status = 'using' WHERE username = '{username}' AND filename = '{fileName}'";
                MySqlCommand cmd = new MySqlCommand(sqlDel, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
            }
            
        }

        // Восстановить все файлы

        public static void returnAllFileRecycle(string username)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();

                string sqlDel = $"UPDATE files SET status = 'using' WHERE username = '{username}'";
                MySqlCommand cmd = new MySqlCommand(sqlDel, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
            }

        }

        // Del all Files for Basket
        public static void deleteAllFiles(string username)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();

                string sql = $"DELETE FROM files WHERE username = '{username}' AND status = 'recycle'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
            }
        }

        // удаление файла
        public static void deleteSelectedFile(string username, string fileName)
        {
            MySqlConnection conn = GetDBConnection();

            try
            {
                conn.Open();

                string sql = $"DELETE FROM files WHERE username = '{username}' AND fileName = '{fileName}'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
            }

        }

        // Таймер

        // Внести интервал

        public static void updateIntervalTimer(string username, string interval)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();

                string sql = $"UPDATE users SET timer = '{interval}' WHERE username = '{username}'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
            }
            
        }


        // Получить значение интервала
        public static string selectValueTimer(string username)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();

                string sqlCheck = $"SELECT timer FROM users WHERE username = '{username}'";

                MySqlCommand cmd = new MySqlCommand(sqlCheck, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                string text = string.Empty;
                while (reader.Read())
                {
                    // элементы массива [] - это значения столбцов из запроса SELECT
                    text = reader["timer"].ToString();
                }
                reader.Close();
                conn.Close();
                return text;
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует");
                return string.Empty;
            }
            
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
