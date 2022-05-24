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

            openFileDialog2.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            string Login_ = OtherFunction.strTextChangeN;
            Username_Label.Text = Login_;

            List<string> files = sqlFuncs.selectUserFiles(Login_);
            for (int i = 0; i < files.Count; i++)
            {
                AllFiles_ListBox.Items.Add(files[i]);
            }

            AllFiles_ListBox.Items.Add(OtherFunction.fileName);

        }
        private void ActionDynamicEdit_Button_Click(object sender, EventArgs e)
        {
            Input_RichBox.ReadOnly = !Input_RichBox.ReadOnly;
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

        private void AllFiles_ListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string username = OtherFunction.strTextChangeN;
            List<string> files = sqlFuncs.selectUserFiles(username);
            Input_RichBox.Clear();
            if (AllFiles_ListBox.SelectedIndex <= files.Count)
            {
                string filename = files[AllFiles_ListBox.SelectedIndex];
                Input_RichBox.Text = sqlFuncs.selectDecryptedText(filename, username);
            }
        }

        private void AddFilePC_Menu_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.Cancel)
                return;
            string username = OtherFunction.strTextChangeN;

            string filePath = openFileDialog2.FileName;
            string fileName = Path.GetFileNameWithoutExtension(filePath);

            string decrypted = System.IO.File.ReadAllText(filePath);
            Input_RichBox.Text = decrypted;

            sqlFuncs.addFile(username, fileName, decrypted);

            List<string> files = sqlFuncs.selectUserFiles(username);
            AllFiles_ListBox.Items.Add(fileName);

            MessageBox.Show("Файл добавлен!");
        }

        private void AddFileManually_Menu_Click(object sender, EventArgs e)
        {
            AddFileManualForm amf = new AddFileManualForm();
            if(amf.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void DeleteAllFile_Menu_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
                "Желаете удалить ВСЕ файлы ?",
                "Удаление файлов", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string username = OtherFunction.strTextChangeN;
                sqlFuncs.deleteAllFiles(username);
                MessageBox.Show("Файлы удалены!");

            }

        }

        private void DeleteSelectFile_Menu_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
                "Желаете удалить файл ?",
                "Удаление файла", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string fileName = AllFiles_ListBox.SelectedItem.ToString();
                string username = OtherFunction.strTextChangeN;
                sqlFuncs.deleteSelectedFile(username, fileName);
                MessageBox.Show("Файл удален!");
                
            }
        }


        

    }
}
