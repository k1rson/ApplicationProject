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
    public partial class AddFileManualForm : Form
    {
        public AddFileManualForm()
        {
            InitializeComponent();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            string username = OtherFunction.strTextChangeN;
            string fileName = FileName_TextBox.Text;
            int i = 0;
            while (!sqlFuncs.IsCheckFilename(username, fileName))
            {
                i++;
                fileName = fileName + $" ({i})";
            }

            sqlFuncs.addFileManual(username, fileName);

            List<string> files = sqlFuncs.selectUserFiles(username);

            MessageBox.Show("Файл добавлен вручную!", "Добавление файла", 
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            Close();
        }
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
