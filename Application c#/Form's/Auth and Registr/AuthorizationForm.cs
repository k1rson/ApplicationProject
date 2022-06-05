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
        public AuthorizationForm()
        {
            InitializeComponent();

            CheckIP.GetMyIP_2ip(); 

            // Сontrol properties
            PasswordTextBox.UseSystemPasswordChar = true; // password mask 
        }
        public void Enter_Button_Click(object sender, EventArgs e)
        {
            OtherFunction.emailUser = sqlFuncs.GetEmailUser(LoginTextBox.Text); // передаем в ConfirmIP
            OtherFunction.userName = LoginTextBox.Text; // передаем в ConfirmIP


            if (sqlFuncs.IsSession(LoginTextBox.Text))
            {
                MessageBox.Show("Данный пользователь уже находится в системе");
                SMTP.SendMessage(sqlFuncs.GetEmailUser(LoginTextBox.Text), "Предупреждение!", "В " + OtherFunction.dateTime + " по МСК была попытка входа на Ваш аккаунт! Если это были не Вы, то советуем Вам сменить пароль!");
            }
            else
            {
                if (OtherFunction.IP != sqlFuncs.GetIPUser(LoginTextBox.Text))
                {
                    ConfirmIPForm cnfrIP = new ConfirmIPForm();
                    cnfrIP.ShowDialog();

                    if (!cnfrIP.OK)
                    {

                    }
                    else
                    {
                        // проверка на существование пользователя, доступ к системе
                        if (sqlFuncs.IsCheckDataAuth(LoginTextBox.Text, sqlFuncs.Sha256(PasswordTextBox.Text)))
                        {

                            if (sqlFuncs.IsAdmin(LoginTextBox.Text))
                            {
                                OtherFunction.userName = LoginTextBox.Text;
                                MessageBox.Show("Выполнен успешный вход в аккаунт!", "Вход в аккаунт",
                                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                sqlFuncs.OpenSession(OtherFunction.userName);
                                Close();
                            }
                            else
                            {
                                if (sqlFuncs.IsBan(LoginTextBox.Text))
                                {
                                    MessageBox.Show($"Уважаемый пользователь, вы были заблокированы администратором по причине: {sqlFuncs.BanCause(LoginTextBox.Text)}", "Вход в аккаунт",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    OtherFunction.userName = LoginTextBox.Text;
                                    MessageBox.Show("Выполнен успешный вход в аккаунт!", "Вход в аккаунт",
                                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    sqlFuncs.OpenSession(OtherFunction.userName);
                                    Close();
                                }
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
                }
            }
        }

        private void SignUp_Button_Click(object sender, EventArgs e)
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

        private void AuthorizationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (OtherFunction.userName == null)
                OtherFunction.MainMenuForm.Close();
            }
        }
    }
