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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            TabPage3.Parent = null; // убрать видимость третьей вкладки tabControl

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            string Login_ = OtherFunction.strTextChangeN;
            Username_Label.Text = Login_;
        }

        private void AddFile_Menu_Click(object sender, EventArgs e)
        {
            // мирон 
        }

        private void DeleteFile_Menu_Click(object sender, EventArgs e)
        {
            // мирон
        }

        private void ActionDynamicEdit_Button_Click(object sender, EventArgs e)
        {
            Input_RichBox.ReadOnly = !Input_RichBox.ReadOnly;
            Input_RichBox.Text = null; 
        }

        private void ActiveEncryption_Button_Click(object sender, EventArgs e)
        {
            EncryptionOptionsForm encryptionOptionsForm = new EncryptionOptionsForm();  

            if(encryptionOptionsForm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void ActiveDecrypt_Button_Click(object sender, EventArgs e)
        {
            TabPage3.Parent = tabControl1; // вернуть видимость третьей вкладке 
        }

        private void SaveFileInput_Menu_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            // получаем выбранный файл
            string fileName = saveFileDialog1.FileName;

            // сохраняем текст в файл
            System.IO.File.WriteAllText(fileName, Input_RichBox.Text);
            MessageBox.Show("Файл с исходными данными сохранен!");
        }

        private void SaveFileOutputEncypt_Menu_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            // получаем выбранный файл
            string fileName = saveFileDialog1.FileName;

            // сохраняем текст в файл
            System.IO.File.WriteAllText(fileName, Output_RichBox.Text);
            MessageBox.Show("Файл с зашифрованными данными сохранен!");
        }

        private void SaveFileOutputDecrypt_Menu_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            // получаем выбранный файл
            string fileName = saveFileDialog1.FileName;

            // сохраняем текст в файл
            System.IO.File.WriteAllText(fileName, DecryptedOutput_RichBox.Text);
            MessageBox.Show("Файл с расшифрованными данными сохранен!");
        }
    }
}
