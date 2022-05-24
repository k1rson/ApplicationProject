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
    public partial class RegistartionForm : Form
    {
        public RegistartionForm()
        {
            InitializeComponent();
        }

        private void ActionRegistr_Button_Click(object sender, EventArgs e)
        {
            // добавление пользователя в БД

            // проверка логина, пароля 
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool IsDataValid()
        {
            string spl_Chars = "#№@&^%*()_-=+/";

            if (String.IsNullOrEmpty(LoginTextBox.Text) && String.IsNullOrEmpty(PasswordTextBox.Text))
            {
                return false;
            }
            else if (LoginTextBox.Text.Intersect(spl_Chars).Any())
            {
                return false;
            }
            else { return true; }
        } 
    }
}
