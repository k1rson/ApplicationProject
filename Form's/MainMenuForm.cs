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
        }

        private void AddFile_Menu_Click(object sender, EventArgs e)
        {

        }

        private void DeleteFile_Menu_Click(object sender, EventArgs e)
        {
            
        }

        private void SaveFilePC_Menu_Click(object sender, EventArgs e)
        {

        }

        private void ActionDynamicEdit_Button_Click(object sender, EventArgs e)
        {

        }

        private void ActiveEncryption_Button_Click(object sender, EventArgs e)
        {
            EncryptionOptionsForm encryptionOptionsForm = new EncryptionOptionsForm();  

            if(encryptionOptionsForm.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
