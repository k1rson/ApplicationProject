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
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void ActionEnter_Button_Click(object sender, EventArgs e)
        {
            // проверка на существование пользователя, доступ к системе
            if(sqlFuncs.IsCheckDataAuth(LoginTextBox.Text, sqlFuncs.sha256(PasswordTextBox.Text)))
            {
                MainMenuForm form = new MainMenuForm();
                if (form.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void ActionSignUp_Button_Click(object sender, EventArgs e)
        {
            RegistartionForm form = new RegistartionForm();

            if(form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private bool IsDataValid(string username, string password, string passwordConfirm)
        {
            string spl_Chars = "#№@&^%*()_-=+/";

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Поле логин/пароль не может быть пустым!");
                return false;
            }
            else if (username.Intersect(spl_Chars).Any())
            {
                MessageBox.Show("В логине присутствуют запрещенные символы!");
                return false;
            }
            else if (password != passwordConfirm)
            {
                MessageBox.Show("Пароль несовпадает!");
                return false;
            }
            
            else { return true; }
        }


    }
}
