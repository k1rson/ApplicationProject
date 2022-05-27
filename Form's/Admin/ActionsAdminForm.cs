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
    public partial class ActionsAdminForm : Form
    {
        public ActionsAdminForm()
        {
            InitializeComponent();
        }

        private void AddAdmin_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void DeleteAdmin_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private bool IsValidateData()
        {
            int result;
            if (String.IsNullOrEmpty(EnterIDUser_TextBox.Text))
            {
                return false;
            }
            else if (int.TryParse(EnterIDUser_TextBox.Text, out result))
            {
                MessageBox.Show("Введите ID пользователя!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else { return true; }
            
        }
    }
}
