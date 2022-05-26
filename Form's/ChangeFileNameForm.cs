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
    public partial class ChangeFileNameForm : Form
    {
        public ChangeFileNameForm()
        {
            InitializeComponent();
            ChOldFileName_Label.Text = OtherFunction.filename; 
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            sqlFuncs.ChangeNameSelectedFile(OtherFunction.strTextChangeN, OtherFunction.filename, ChFileName_TextBox.Text);

            MessageBox.Show("Изменение прошло успешно!", "Изменение имени файла", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close(); 
        }

        private void ResetFileName_Button_Click(object sender, EventArgs e)
        {
            ChFileName_TextBox.Text = null; 
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
