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
        }

        private void GnrInformation_Click(object sender, EventArgs e)
        {

        }

        private void ShowFilesUser_Click(object sender, EventArgs e)
        {

        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {

        }

        private void BanUser_Click(object sender, EventArgs e)
        {
        }

        private void NotificationUser_Click(object sender, EventArgs e)
        {

        }

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
            ActionsAdminForm actionsAdm = new ActionsAdminForm();
            actionsAdm.Show();
        }

        private void AdminPanelForm_Activated(object sender, EventArgs e)
        {
            AllUsers_ListBox.Items.Clear();

            List<string> users = sqlFuncs.selectUsersList();
            for (int i = 0; i < users.Count; i++)
            {
                AllUsers_ListBox.Items.Add(users[i]);
            }
        }

        

        private void AllUsers_ListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                string word = AllUsers_ListBox.SelectedItem.ToString();
                string[] username = word.Split(':');
                AllFilesUser_ListBox.Items.Clear();

                List<string> files = sqlFuncs.selectUserFiles(username[1]);
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

        private void AllFilesUser_ListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                string filename = AllFilesUser_ListBox.SelectedItem.ToString();
                InputAdmin_RichBox.Text = sqlFuncs.selectDecryptedText(filename, OtherFunction.selectedUsername);
                OutputAdmin_RichBox.Text = sqlFuncs.selectEncryptedText(filename, OtherFunction.selectedUsername);
            }
            catch (Exception)
            {

                return;
            }
        }
    }
}
