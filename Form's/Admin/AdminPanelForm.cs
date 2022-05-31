using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationProject
{
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            // подвязываем к листбоксу за счет контекст меню
            AllUsers_ListBox.ContextMenuStrip = ContextMenuAllUsers;
            AllBanUsers_ListBox.ContextMenuStrip = ContextMenuBanUsers; 
        }
        private void DeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                string word = AllUsers_ListBox.SelectedItem.ToString();
                string[] username = word.Split(':');

                DialogResult res = MessageBox.Show("Вы уверены, что хотите удалить данного пользователя?", "Удаление пользователя",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(res == DialogResult.Yes)
                {
                    sqlFuncs.DeleteUser(username[1]);
                    UpdateListBox();

                    MessageBox.Show("Пользователь успешно удален!", "Удаление пользователя",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("гг");
                return;
            }
        }

        private void BanUser_Click(object sender, EventArgs e)
        {
            try
            {
                string word = AllUsers_ListBox.SelectedItem.ToString();
                string[] username = word.Split(':');

                DialogResult res = MessageBox.Show("Вы уверены, что хотите заблокировать данного пользователя?", "Разблокировка пользователя",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    BanCauseForm banCause = new BanCauseForm();
                    banCause.ShowDialog();

                    sqlFuncs.BanUser(username[1], OtherFunction.causeBan); // баним юзера 
                    UpdateListBox();

                    MessageBox.Show("Пользователь успешно заблокирован и оповещен!", "Разблокировка пользователя",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    SMTP.SendMessage(sqlFuncs.GetEmailUser(username[1]), "Вы заблокированы!", $"Доброго времени суток! Вы были забанены {OtherFunction.dateTime}, по причине: {OtherFunction.causeBan}");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите пользователя!", "Разблокировка пользователя", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UnBanUser_Click(object sender, EventArgs e)
        {
            try
            {
                string word = AllBanUsers_ListBox.SelectedItem.ToString();
                string[] username = word.Split(':');

                DialogResult res = MessageBox.Show("Вы уверены, что хотите разблокировать данного пользователя?", "Удаление пользователя",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    sqlFuncs.UnBanUser(username[1], string.Empty); // разбан юзера 
                    UpdateListBox();

                    MessageBox.Show("Пользователь успешно разблокирован!", "Удаление пользователя",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите пользователя!", "Разблокировка пользователя",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Удалить потом дрочь эту аккуратно надо
        private void NotificationUser_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void CreateReport_Click(object sender, EventArgs e)
        {

        }

        private void SaveOriginalData_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            // получаем выбранный файл
            string fileName = saveFileDialog1.FileName;

            // сохраняем текст в файл
            System.IO.File.WriteAllText(fileName, InputAdmin_RichBox.Text);

            MessageBox.Show("Файл с исходными данными пользователя сохранен!", "Сохранение файла", 
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void SaveConvertedData_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            // получаем выбранный файл
            string fileName = saveFileDialog1.FileName;

            // сохраняем текст в файл
            System.IO.File.WriteAllText(fileName, OutputAdmin_RichBox.Text);

            MessageBox.Show("Файл с выходными данными пользователя сохранен!", "Сохранение файла",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void SettingAdmins_Click(object sender, EventArgs e)
        {
            if (sqlFuncs.IsRoot(OtherFunction.userName))
            {
                ActionsAdminForm actionsAdm = new ActionsAdminForm();
                actionsAdm.Show();
            }
            else
                MessageBox.Show("Вы не являетесь Главным Администратором");
        }

        private void AdminPanelForm_Activated(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void AllUsers_ListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                string word = AllUsers_ListBox.SelectedItem.ToString();
                string[] username = word.Split(':');
                AllFilesUser_ListBox.Items.Clear();

                List<string> files = sqlFuncs.SelectUserFiles(username[1]);
                for (int i = 0; i < files.Count; i++)
                {
                    AllFilesUser_ListBox.Items.Add(files[i]);
                }
                OtherFunction.selectedUsername = username[1];
            }
            catch (Exception)
            {

                return;
            }
        }

        private void UpdateListBox()
        {
            AllBanUsers_ListBox.Items.Clear();

            List<string> usersBan = sqlFuncs.SelectBanUsersList();
            for (int i = 0; i < usersBan.Count; i++)
            {
                AllBanUsers_ListBox.Items.Add(usersBan[i]);
            }

            AllUsers_ListBox.Items.Clear();

            List<string> users = sqlFuncs.SelectUsersList();
            for (int i = 0; i < users.Count; i++)
            {
                AllUsers_ListBox.Items.Add(users[i]);
            }
        }

        private void AllFilesUser_ListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                string filename = AllFilesUser_ListBox.SelectedItem.ToString();
                InputAdmin_RichBox.Text = sqlFuncs.SelectDecryptedText(filename, OtherFunction.selectedUsername);
                OutputAdmin_RichBox.Text = sqlFuncs.SelectEncryptedText(filename, OtherFunction.selectedUsername);
            }
            catch (Exception)
            {

                return;
            }
        }

        // Notification user
        private void NotificationEmail_Click(object sender, EventArgs e)
        {
            NotificationEmailForm notificationEmail = new NotificationEmailForm();
            notificationEmail.ShowDialog(); 
        }

        private void NotificationPhone_Click(object sender, EventArgs e)
        {

        }
        // End Notification USer
    }
}
