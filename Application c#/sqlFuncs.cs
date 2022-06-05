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

        public static void RegUser(string username, string password, string emailUser, string IP)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();
                string sql = $"INSERT INTO users (username, password, email, ip, role) VALUES ('{username}', '{password}', '{emailUser}', '{IP}', 'User')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        // Проверки

        public static bool CheckUserReg(string username)
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
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public static bool IsCheckEmail(string emailUser)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();
                string sqlCheck = $"SELECT COUNT(email) FROM users WHERE email = '{emailUser}' ";
                MySqlCommand cmd = new MySqlCommand(sqlCheck, conn);
                MySqlDataReader count = cmd.ExecuteReader();
                int cont = 0;
                while (count.Read())
                {
                    cont = int.Parse(count[0].ToString());
                }
                conn.Close();

                if (cont == 1)
                    return false;
                else
                    return true;
            }
            catch (Exception)
            {

                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Забанен ли
        public static bool IsBan(string username)
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

                if (role == "Ban")
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static string BanCause(string username)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();

                string sqlCheck = $"SELECT cause FROM users WHERE username = '{username}'";

                MySqlCommand cmd = new MySqlCommand(sqlCheck, conn);
                MySqlDataReader causeSelect = cmd.ExecuteReader();
                string cause = string.Empty;

                while (causeSelect.Read())
                {
                    cause = causeSelect["cause"].ToString();
                }
                conn.Close();

                return cause;
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
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

                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        // Работа с данными

        public static string SelectDecryptedText(string filename, string username)
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
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }

        }

        public static string SelectEncryptedText(string filename, string username)
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

                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }

        }


        //Работа с пользователями
        // All users
        public static List<string> SelectUsersList()
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();

                string sqlCheck = $"SELECT * FROM users WHERE role = 'User'";

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

                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<string>();
            }

        }
        // Забаненые пользователя
        public static List<string> SelectBanUsersList()
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();

                string sqlCheck = $"SELECT * FROM users WHERE role = 'Ban'";

                MySqlCommand cmd = new MySqlCommand(sqlCheck, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                var users = new List<string>();

                while (reader.Read())
                {
                    // элементы массива [] - это значения столбцов из запроса SELECT
                    users.Add(reader[0].ToString() + ":" + reader[1].ToString() + ": Причина: " + reader[6].ToString());
                }
                reader.Close();
                conn.Close();
                return users;
            }
            catch (Exception)
            {

                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<string>();
            }

        }

        // Get Email User
        public static string GetEmailUser(string userName)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();

                string sqlCheck = $"SELECT * FROM users WHERE username = '{userName}'";

                MySqlCommand cmd = new MySqlCommand(sqlCheck, conn);
                MySqlDataReader emailSelect = cmd.ExecuteReader();

                string emailUser = string.Empty;

                while (emailSelect.Read())
                {
                    emailUser = emailSelect[3].ToString();
                }
                emailSelect.Close();
                conn.Close();

                return emailUser;
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        // Add admin
        public static void AddAdmin(decimal id)
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
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Add admin
        public static void DeleteAdmin(decimal id)
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
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // All admins
        public static List<string> SelectAdminsList()
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

                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<string>();
            }

        }

        public static void DeleteUser(string userName)
        {
            MySqlConnection conn = GetDBConnection();

            try
            {
                conn.Open();

                string sql = $"DELETE FROM users WHERE username = '{userName}'";
                string sqlDel = $"DELETE FROM files WHERE username = '{userName}'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlCommand cmdd = new MySqlCommand(sqlDel, conn);
                cmd.ExecuteNonQuery();
                cmdd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void BanUser(string userName, string cause)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();

                string sql = $"UPDATE users SET role = 'Ban', cause = '{cause}' WHERE username = '{userName}'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void UnBanUser(string userName, string cause)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();

                string sql = $"UPDATE users SET role = 'User', cause = '{cause}' WHERE username = '{userName}'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Сессия
        public static void OpenSession(string username)
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
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void CloseSession(string username)
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
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Работа с файлами
        public static List<string> SelectUserFiles(string username)
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
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<string>();
            }

        }
        public static List<string> SelectUserRecycleFiles(string username)
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
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<string>();
            }

        }

        // Добавление файла по названию
        public static void AddFileManual(string username, string fileName)
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
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обновление данных в файле
        public static void UpdateFile(string username, string fileName, string decrypted, string encrypted)
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
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        // Добавление файла с пк
        public static void AddFile(string username, string fileName, string decrypted)
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
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Add file in basket
        public static void AddFileRecycle(string username, string fileName)
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
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void AddAllFileRecycle(string username)
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
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Восстановить файл
        public static void ReturnFileRecycle(string username, string fileName)
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
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Восстановить все файлы
        public static void ReturnAllFileRecycle(string username)
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
        public static void DeleteAllFiles(string username)
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
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // удаление файла
        public static void DeleteSelectedFile(string username, string fileName)
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
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Таймер
        // Внести интервал
        public static void UpdateIntervalTimer(string username, string interval)
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
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Получить значение интервала
        public static string SelectValueTimer(string username)
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
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }

        }

        // Обратная связь

        // Добавление сообщения
        public static void AddReportUser(string username, string theme, string message)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();

                string sql = $"INSERT INTO report (username, theme, message) VALUES ('{username}', '{theme}' , '{message}')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Получить список вопросов
        public static List<string> SelectReports()
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();

                string sqlCheck = $"SELECT * FROM report WHERE status = 'using'";

                MySqlCommand cmd = new MySqlCommand(sqlCheck, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                var reports = new List<string>();
                while (reader.Read())
                {
                    // элементы массива [] - это значения столбцов из запроса SELECT
                    reports.Add(reader[1].ToString());
                }
                reader.Close();
                conn.Close();
                return reports;
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<string>();
            }
        }

        // Получить тему пользователя
        public static string SelectThemeReports(string userName)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();
                string sqlCheck = $"SELECT theme FROM report WHERE username = '{userName}'";

                MySqlCommand cmd = new MySqlCommand(sqlCheck, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                string theme = string.Empty;

                while (reader.Read())
                {
                    theme = reader["theme"].ToString();
                }
                reader.Close();
                conn.Close();

                return theme;
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        // Получить сообщение пользователя
        public static string SelectMessageReports(string userName)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();

                string sqlCheck = $"SELECT message FROM report WHERE username = '{userName}'";

                MySqlCommand cmd = new MySqlCommand(sqlCheck, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                string message = string.Empty;

                while (reader.Read())
                {
                    message = reader["message"].ToString();
                }
                reader.Close();
                conn.Close();

                return message;
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        // Ответ отправлен
        public static void answerReports(string username, string theme)
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();
                string sql = $"UPDATE report SET status = 'answered' WHERE username = '{username}' AND theme = '{theme}'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Получить количество вопросов
        public static int countReports()
        {
            MySqlConnection conn = GetDBConnection();
            try
            {
                conn.Open();
                string sqlCheck = $"SELECT COUNT(id) FROM report WHERE status = 'using'";
                MySqlCommand cmd = new MySqlCommand(sqlCheck, conn);
                MySqlDataReader count = cmd.ExecuteReader();
                int cont = 0;
                while (count.Read())
                {
                    cont = int.Parse(count[0].ToString());
                }
                conn.Close();

                return cont;
            }
            catch (Exception)
            {

                MessageBox.Show("Проверьте подключение к интернету", "Подлючение отсутствует",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

        }




        // Шифрование
        public static string Sha256(string randomString)
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
