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

        private void GnrInformation_Menu_Click(object sender, EventArgs e)
        {

        }

        private void ShowFilesUser_Menu_Click(object sender, EventArgs e)
        {

        }

        private void DeleteUser_Menu_Click(object sender, EventArgs e)
        {

        }

        private void BanUser_Menu_Click(object sender, EventArgs e)
        {
        }

        private void NotificationUser_Menu_Click(object sender, EventArgs e)
        {

        }

        private void CreateReport_Menu_Click(object sender, EventArgs e)
        {

        }

        private void SaveFileInpurAdmin_Menu_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            // получаем выбранный файл
            string fileName = saveFileDialog1.FileName;

            // сохраняем текст в файл
            System.IO.File.WriteAllText(fileName, InputAdmin_RichBox.Text);
            MessageBox.Show($"Файл с исходными данными пользователя сохранен!");
        }

        private void SaveFileOutputAdmin_Menu_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            // получаем выбранный файл
            string fileName = saveFileDialog1.FileName;

            // сохраняем текст в файл
            System.IO.File.WriteAllText(fileName, OutputAdmin_RichBox.Text);
            MessageBox.Show($"Файл с выходными данными пользователя сохранен!");
        }
    }
}
