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

        private void AddFileManually_Button_Click(object sender, EventArgs e)
        {
            string userName = OtherFunction.userName;
            string fileName = FileName_TextBox.Text;

            int i = 0;
            while (sqlFuncs.IsCheckFilename(userName, fileName))
            {
                i++;
                if(i >= 2)
                {
                    fileName = FileName_TextBox.Text;
                }
                fileName = fileName + $" ({i})";
            }

            sqlFuncs.AddFileManual(userName, fileName);

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
