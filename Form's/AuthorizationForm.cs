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

                if (sqlFuncs.IsAdmin(LoginTextBox.Text))
                {
                    MessageBox.Show("Выполнен успешный вход в аккаунт!", "Вход в аккаунт", 
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk); 

                    SelectWorkZoneForm workZone = new SelectWorkZoneForm(); 
                    workZone.Show();
                } 
                else
                {
                    MainMenuForm mainForm = new MainMenuForm();
                    mainForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Логин или пароль введены неверно!", "Вход в аккаунт",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ActionSignUp_Button_Click(object sender, EventArgs e)
        {
            RegistartionForm registrForm = new RegistartionForm();
            registrForm.Show(); 
        }
    }
}
