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

           // sqlFuncs.addFile(username, fileName, decrypted);

            List<string> files = sqlFuncs.selectUserFiles(username);
            //AllFiles_ListBox.Items.Add(fileName);

            MessageBox.Show("Файл добавлен!");
        }
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
