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
        }

        // Vision Input_RichBox

        private void ActionDynamicEdit_Button_Click(object sender, EventArgs e)
        {
            Input_RichBox.ReadOnly = !Input_RichBox.ReadOnly;
        }

        // Open coding form

        private void ActiveEncryption_Button_Click(object sender, EventArgs e)
        {
            if (Input_RichBox.Text != null)
            OtherFunction.encryption = Input_RichBox.Text;

            EncryptionOptionsForm encOptFomr = new EncryptionOptionsForm();
            encOptFomr.Show(); 
        }

        // Event vision tabControl

        private void ActiveDecrypt_Button_Click(object sender, EventArgs e)
        {
            TabPage3.Parent = tabControl1; // вернуть видимость третьей вкладке на tabControl 

            // расшифровка 
        }

        // Save selected file

        private void SaveFileInput_Menu_Click(object sender, EventArgs e)
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

        // Save encrypt file

        private void SaveFileOutputEncypt_Menu_Click(object sender, EventArgs e)
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

        // Save decrypt file

        private void SaveFileOutputDecrypt_Menu_Click(object sender, EventArgs e)
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


        // Double click, select element list box

        private void AllFiles_ListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string username = OtherFunction.strTextChangeN;

            List<string> files = sqlFuncs.selectUserFiles(username);
            Input_RichBox.Clear();

            try
            {
                if (AllFiles_ListBox.SelectedIndex <= files.Count)
                {
                    string filename = files[AllFiles_ListBox.SelectedIndex];
                    string decryption = sqlFuncs.selectEncryptedText(filename, username);
                    Input_RichBox.Text = sqlFuncs.selectDecryptedText(filename, username);
                    OtherFunction.decryption = decryption;
                    Output_RichBox.Text = decryption;

                }
            }
            catch (Exception)
            {

                return;
            }

            
        }

        // Add file for PC

        private void AddFilePC_Menu_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.Cancel)
                return;
            string username = OtherFunction.strTextChangeN;

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

            sqlFuncs.addFile(username, fileName, decrypted);

            MessageBox.Show("Файл добавлен!", "Добавление файла",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        // Create file

        private AddFileManualForm addManulForm;
        private void AddFileManually_Menu_Click(object sender, EventArgs e)
        {
            addManulForm = new AddFileManualForm();
            addManulForm.Show();
        }

        



        // Delete all files

        private void DeleteAllFile_Menu_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
                "Желаете удалить ВСЕ файлы ?",
                "Удаление файлов", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string username = OtherFunction.strTextChangeN;
                sqlFuncs.deleteAllFiles(username);

                MessageBox.Show("Файлы удалены!", "Удаление файлов",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        // Delete selected file

        private void DeleteSelectFile_Menu_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
                "Желаете удалить файл ?",
                "Удаление файла", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string fileName = OtherFunction.filename;
                string username = OtherFunction.strTextChangeN;
                sqlFuncs.deleteSelectedFile(username, fileName);

                MessageBox.Show("Файл успешно удален!", "Удаление файлов",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        // Обработка нажатий клавиш // Доработать

        private void MainMenuForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                UpdateListBox(OtherFunction.strTextChangeN);
            }
        }


        // Обработчик при входе в окно mainForm // В сто раз меньше кода

        private void MainMenuForm_Activated(object sender, EventArgs e)
        {
            // Срабатывает каждый раз при входе в это окно/ выходе из другого
            UpdateListBox(OtherFunction.strTextChangeN);
        }


        // Update ListBox

        public void UpdateListBox(string username)
        {
            AllFiles_ListBox.Items.Clear();  

            List<string> files = sqlFuncs.selectUserFiles(username);
            for (int i = 0; i < files.Count; i++)
            {
                AllFiles_ListBox.Items.Add(files[i]);
            }
        }

        // Event Enter TabePage, update data Output_RichBox

        private void TabPage_2_Enter(object sender, EventArgs e)
        {
            Output_RichBox.Text = OtherFunction.decryption;

        }

        private void AllFiles_ListBox_MouseClick(object sender, MouseEventArgs e)
        {
            // Получаем тут имя файла чтобы потом меньше кода писать
            try
            {
                OtherFunction.filename = AllFiles_ListBox.SelectedItem.ToString();
            }
            catch (Exception)
            {

                return;
            }
        }
    }
}
