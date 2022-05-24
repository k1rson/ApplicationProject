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

        public void ActionEnter_Button_Click(object sender, EventArgs e)
        {
            // проверка на существование пользователя, доступ к системе
            if(sqlFuncs.IsCheckDataAuth(LoginTextBox.Text, sqlFuncs.sha256(PasswordTextBox.Text)))
            {
                OtherFunction.strTextChangeN = LoginTextBox.Text;
                MainMenuForm form = new MainMenuForm();
                if (form.ShowDialog() == DialogResult.OK)
                {

                }
                Close(); 
            }
            else
            {
                MessageBox.Show("Логин или пароль введены неверно!");
            }
        }

        private void ActionSignUp_Button_Click(object sender, EventArgs e)
        {
            RegistartionForm form = new RegistartionForm();

            if(form.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
