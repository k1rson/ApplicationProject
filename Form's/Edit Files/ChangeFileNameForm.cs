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

            // Other function 
            OldFileName_Label.Text = OtherFunction.fileName; 
        }

        private void ChangeFileName_Button_Click(object sender, EventArgs e)
        {
            sqlFuncs.ChangeFileName(OtherFunction.userName, OtherFunction.fileName, NewFileName_TextBox.Text);

            MessageBox.Show("Изменение прошло успешно!", "Изменение имени файла", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close(); 
        }

        private void ResetFileName_Button_Click(object sender, EventArgs e)
        {
            NewFileName_TextBox.Text = string.Empty;  
        }

        #region Button - Cancel
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close(); 
        }
        #endregion
    }
}
