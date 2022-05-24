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
    public partial class EncryptionOptionsForm : Form
    {
        public EncryptionOptionsForm()
        {
            InitializeComponent();
            SelectEncyption_ComboBox.SelectedIndex = 0; 
            SelectAlphabet_ComboBox.SelectedIndex = 0;
            Shift_TextBox.Text = string.Empty; 
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            SelectEncyption_ComboBox.SelectedIndex = -1;
            SelectAlphabet_ComboBox.SelectedIndex = -1;
            Shift_TextBox.Text = string.Empty;
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            // метод шифрования
        }
    }
}
