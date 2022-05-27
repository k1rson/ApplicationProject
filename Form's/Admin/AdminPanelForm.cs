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
    }
}
