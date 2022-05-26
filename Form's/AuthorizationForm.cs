using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationProject
{
    public partial class AuthorizationForm : Form
    {
        private Worker _worker; 
        public AuthorizationForm()
        {
            InitializeComponent();

            PasswordTextBox.UseSystemPasswordChar = true; // маска на пароль 

            // подписываемся на события клика
           // ActionEnter_Button.Click += ActionEnter_Button_Click; 
        }
        public void ActionEnter_Button_Click(object sender, EventArgs e)
        {
            //_worker = new Worker();
            //_worker.ProcessChanged += _worker_ProcessChanged;

            //ActionEnter_Button.Enabled = false; // нехуй тыкать по 10 раз на одну кнопку

           // _worker.Work();

            // проверка на существование пользователя, доступ к системе
            if (sqlFuncs.IsCheckDataAuth(LoginTextBox.Text, sqlFuncs.sha256(PasswordTextBox.Text)))
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
                DialogResult res = MessageBox.Show("Логин или пароль введены неверно! Требуется помощь?", "Вход в аккаунт",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (res == DialogResult.Yes)
                    MessageBox.Show("Если Вы забыли свой логин или пароль, воспользуйтесь кнопкой \"Восстановить логин/пароль\"", "Помощь", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //private void _worker_ProcessChanged(int progress)
        //{
        //    progressBar1.Value = progress; 
        //}

        private void ActionSignUp_Button_Click(object sender, EventArgs e)
        {
            RegistartionForm registrForm = new RegistartionForm();
            registrForm.Show(); 
        }

        private void ShowPassword_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.UseSystemPasswordChar == true)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
                ShowPassword_PictureBox.Image = Properties.Resources.visual; 
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
                ShowPassword_PictureBox.Image = Properties.Resources.non_visual;
            }
        }
    }
}
