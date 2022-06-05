using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Net;

namespace ApplicationProject
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();

            // Control properties
            TabPage3.Parent = null; // убрать видимость третьей вкладки tabControl
            GoToAdminPanel_Button.Visible = false;
            Input_RichBox.BackColor = SystemColors.ControlDark;

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            openFileDialog2.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            // подвязали контектное меню к списку файлов
            AllFiles_ListBox.ContextMenuStrip = ContextMenuAllFiles;


        }

        // Vision Input_RichBox
        private void DynamicEdit_Button_Click(object sender, EventArgs e)
        {
            if (OtherFunction.fileName != null)
            {
                Input_RichBox.ReadOnly = !Input_RichBox.ReadOnly;
                if(!Input_RichBox.ReadOnly)
                    Input_RichBox.BackColor = SystemColors.Control;
                else
                    Input_RichBox.BackColor = SystemColors.ControlDark;
            }
            else
            {
                MessageBox.Show("Вы не выбрали файл!", "Выбор файла", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Open encypt form
        private void Encrypt_Button_Click(object sender, EventArgs e)
        {
            if (OtherFunction.fileName != null)
            {
                if (Input_RichBox.Text != null)
                    OtherFunction.decryption = Input_RichBox.Text;

                EncryptionOptionsForm encOptFomr = new EncryptionOptionsForm();
                encOptFomr.Show();
            }

            else
                MessageBox.Show("Вы не выбрали файл!", "Выбор файла",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        // Decrypt data + vision tabPages3
        private void Decrypt_Button_Click(object sender, EventArgs e)
        {
            TabPage3.Parent = tabControl1; // вернуть видимость третьей вкладке на tabControl 

            // расшифровка 
        }

        // Save selected file
        private void SaveContentFile_Click(object sender, EventArgs e)
        {
            if (OtherFunction.fileName != null)
            {

                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;

                // получаем выбранный файл
                string fileName = saveFileDialog1.FileName;

                // сохраняем текст в файл
                System.IO.File.WriteAllText(fileName, Input_RichBox.Text);
                MessageBox.Show("Файл с исходными данными сохранен!", "Сохранение файла",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
                MessageBox.Show("Вы не выбрали файл!", "Выбор файла",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Save encrypt file
        private void SaveEncyptFile_Click(object sender, EventArgs e)
        {
            if (OtherFunction.fileName != null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;

                // получаем выбранный файл
                string fileName = saveFileDialog1.FileName;

                // сохраняем текст в файл
                System.IO.File.WriteAllText(fileName, Output_RichBox.Text);
                MessageBox.Show("Файл с зашифрованными данными сохранен!", "Сохранение файла",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
                MessageBox.Show("Вы не выбрали файл!", "Выбор файла",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Save decrypt file

        private void SaveDecryptFile_Click(object sender, EventArgs e)
        {

            if (OtherFunction.fileName != null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;

                // получаем выбранный файл
                string fileName = saveFileDialog1.FileName;

                // сохраняем текст в файл
                System.IO.File.WriteAllText(fileName, DecryptedOutput_RichBox.Text);
                MessageBox.Show("Файл с расшифрованными данными сохранен!", "Сохранение файла",
                     MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
                MessageBox.Show("Вы не выбрали файл!", "Выбор файла",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        // Double click, select element list box
        private void AllFiles_ListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                OtherFunction.fileName = AllFiles_ListBox.SelectedItem.ToString();
                string username = OtherFunction.userName;

                List<string> files = sqlFuncs.SelectUserFiles(username);
                Input_RichBox.Clear();

                if (AllFiles_ListBox.SelectedIndex <= files.Count)
                {
                    string filename = files[AllFiles_ListBox.SelectedIndex];
                    string encryption = sqlFuncs.SelectEncryptedText(filename, username);
                    Input_RichBox.Text = sqlFuncs.SelectDecryptedText(filename, username);
                    OtherFunction.encryption = encryption;
                    Output_RichBox.Text = encryption;

                }
            }
            catch (Exception)
            {
                Input_RichBox.Text = string.Empty;
                Output_RichBox.Text = string.Empty;
                return;
            }
        }

        // Add file for PC
        private void AddFilePC_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.Cancel)
                return;
            string username = OtherFunction.userName;

            string filePath = openFileDialog2.FileName;
            string fileName = Path.GetFileNameWithoutExtension(filePath);

            string decrypted = System.IO.File.ReadAllText(filePath);
            Input_RichBox.Text = decrypted;

            int i = 0;
            while (sqlFuncs.IsCheckFilename(username, fileName))
            {
                i++;
                if (i >= 2)
                {
                    fileName = Path.GetFileNameWithoutExtension(filePath);
                }
                fileName = fileName + $" ({i})";
            }

            sqlFuncs.AddFile(username, fileName, decrypted);

            MessageBox.Show("Файл добавлен!", "Добавление файла",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        // Create file

        private void AddFileManually_Click(object sender, EventArgs e)
        {
            AddFileManualForm addManulForm = new AddFileManualForm();
            addManulForm.Show();
        }

        // Delete all files
        private void DeleteAllFile_Click(object sender, EventArgs e)
        {
            if (OtherFunction.fileName != null)
            {
                DialogResult res = MessageBox.Show("Желаете добавить все файлы в корзину ?", "Удаление файлов",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    string username = OtherFunction.userName;
                    sqlFuncs.AddAllFileRecycle(username);

                    Output_RichBox.Text = string.Empty;
                    Input_RichBox.Text = string.Empty;
                    OtherFunction.encryption = string.Empty;
                    OtherFunction.decryption = string.Empty;

                    MessageBox.Show("Файлы добавлены в корзину!", "Удаление файлов",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали файл!", "Выбор файла",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete selected file

        private void DeleteSelectFile_Click(object sender, EventArgs e)
        {
            if (OtherFunction.fileName != null)
            {
                DialogResult res = MessageBox.Show("Желаете поместить файл в корзину ?", "Удаление файла",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    string fileName = OtherFunction.fileName;
                    string username = OtherFunction.userName;

                    Output_RichBox.Text = string.Empty;
                    Input_RichBox.Text = string.Empty;
                    OtherFunction.encryption = string.Empty;
                    OtherFunction.decryption = string.Empty;

                    sqlFuncs.AddFileRecycle(username, fileName);

                    MessageBox.Show("Файл успешно добавлен в корзину!", "Удаление файлов",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали файл!", "Выбор файла",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Change file name // доработать чутка надо, я сам попозже сделаю 
        private void ChangeFileName_Click(object sender, EventArgs e)
        {
            if (OtherFunction.fileName != null)
            {
                DialogResult res = MessageBox.Show("Вы уверены, что хотите изменить название файла?", "Предупреждение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                int filesCount = AllFiles_ListBox.Items.Count;

                if (res == DialogResult.Yes)
                {
                    ChangeFileNameForm chFileName = new ChangeFileNameForm();
                    chFileName.Show();
                }
            }
            else
                MessageBox.Show("Вы не выбрали файл!", "Выбор файла",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Обработка нажатий клавиш // Доработать
        private void MainMenuForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                UpdateListBox(OtherFunction.userName);
            }
        }

        private void MainMenuForm_Activated(object sender, EventArgs e)
        {
            if (OtherFunction.userName != null)
            {
                UpdateListBox(OtherFunction.userName);

                // Инициализация таймера
                string interval = sqlFuncs.SelectValueTimer(OtherFunction.userName);
                if (interval != "never" && interval != "enter")
                {

                    timerRecycle.Interval = int.Parse(interval);
                    timerRecycle.Enabled = true;
                }
                else
                    timerRecycle.Enabled = false;

            }
        }

        // Event Enter TabePage, update data Output_RichBox

        private void TabPage_2_Enter(object sender, EventArgs e)
        {
            Output_RichBox.Text = OtherFunction.encryption;
        }

        private void AllFiles_ListBox_MouseClick(object sender, MouseEventArgs e)
        {
            // Получаем тут имя файла чтобы потом меньше кода писать
            /* Не факт что актуально
            try
            {
                OtherFunction.fileName = AllFiles_ListBox.SelectedItem.ToString();
            }
            catch (Exception)
            {
                Input_RichBox.Text = string.Empty;
                Output_RichBox.Text = string.Empty;
                OtherFunction.fileName = null;
            }
            */
        }

        // Update ListBox
        public void UpdateListBox(string username)
        {
            AllFiles_ListBox.Items.Clear();

            List<string> files = sqlFuncs.SelectUserFiles(username);
            for (int i = 0; i < files.Count; i++)
            {
                AllFiles_ListBox.Items.Add(files[i]);
            }
        }

        private void MainMenuForm_Shown(object sender, EventArgs e)
        {
            AuthorizationForm authForm = new AuthorizationForm();
            authForm.ShowDialog();

            // отображение username 
            string login = OtherFunction.userName;
            Username_Label.Text = login;

            if (sqlFuncs.IsAdmin(login))
                GoToAdminPanel_Button.Visible = true;


            // Очищение корзины при входе
            if (sqlFuncs.SelectValueTimer(OtherFunction.userName) == "enter")
                sqlFuncs.DeleteAllFiles(OtherFunction.userName);


            if (sqlFuncs.IsAdmin(OtherFunction.userName))
                timerReportUpdate.Enabled = true;
        }

        private void GoToAdminPanel_Button_Click(object sender, EventArgs e)
        {
            AdminPanelForm admForm = new AdminPanelForm();
            admForm.ShowDialog(); 
        }

        // Recycle 
        private void ViewContentRecycle_Click(object sender, EventArgs e)
        {
            RecycleBinForm recycleForm = new RecycleBinForm(); 
            recycleForm.ShowDialog();
        }

        private void EmptyRecycle_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены, что хотите очистить корзину? Данное действие приведет к полной потери файлов!", "Очистка корзины",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                sqlFuncs.DeleteAllFiles(OtherFunction.userName);
            }
        }


        // End Recycle

        // Referance
        private void AccountsGitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/k1rson");
            Process.Start("https://github.com/YannGotti");
        }

        private void AccountsTelegram_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/dedushaistele2");
            Process.Start("https://t.me/mironchikk");
        }

        private void AccountsEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email адреса разработчиков были добавлены в буфер обмена!", "Email почты разработчиков", 
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Clipboard.SetText("1. yann.gotti@mail.ru\n2. vlad2k15@bk.ru");
        }

        private void AboutProgramm_Click(object sender, EventArgs e) // САЙТ ВИЗИТКА БЛЯ СУКА НАХУЙ
        {
            Process.Start("https://cyphergo.ru/index.html"); 
        } 
        // End Referance

        // FeedBack
        private void MessageToAdmins_Click(object sender, EventArgs e)
        {
            MessageToAdminForm msgToAdmin = new MessageToAdminForm();
            msgToAdmin.ShowDialog(); 
        }

        private void ReportErrorUser_Click(object sender, EventArgs e)
        {

        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlFuncs.CloseSession(OtherFunction.userName);
        }

        // Работа таймера
        private void TimerRecycle_Tick(object sender, EventArgs e)
        {
            sqlFuncs.DeleteAllFiles(OtherFunction.userName);
        }

        public static int countReports = sqlFuncs.countReports();

        private void timerReportUpdate_Tick(object sender, EventArgs e)
        {
            if(sqlFuncs.countReports() != countReports)
            {
                countReports = sqlFuncs.countReports();
                MessageBox.Show("Появился новый вопрос от пользователя! Скорее ответьте!", "Вопрос от пользователя",
                    MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }
        // End FeedBack
    }
}
