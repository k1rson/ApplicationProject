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

            PasswordTextBox.UseSystemPasswordChar = true;
            CnfmPasswordTextBox.UseSystemPasswordChar = true;
        }
        private void ActionRegistr_Button_Click(object sender, EventArgs e)
        {
            // добавление пользователя в БД
            if (IsDataValid(LoginTextBox.Text, PasswordTextBox.Text, CnfmPasswordTextBox.Text))
            {
                sqlFuncs.regUser(LoginTextBox.Text, sqlFuncs.sha256(PasswordTextBox.Text));
                MessageBox.Show("Регистрация аккаунта успешно завершена! Приятного времяпровождения!", "Регистрация аккаунта", 
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Close();
            }
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool IsDataValid(string username, string password, string passwordConfirm)
        {
            string spl_Chars = "#№@&^%*()_-=+/$;?+!'.{}[]";

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Поле логин/пароль не может быть пустым!", "Регистрация аккаунта",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (username.Intersect(spl_Chars).Any())
            {
                DialogResult res = MessageBox.Show("В логине присутствуют запрещенные символы! Требуется помощь?", "Регистрация аккаунта",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (res == DialogResult.Yes)
                    MessageBox.Show("Пожалуйста, используйте в логине только буквы русского и английского алфавитов и цифры!", "Помощь",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (password != passwordConfirm)
            {
                MessageBox.Show("Пароли не совпадают!", "Регистрация аккаунта",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (sqlFuncs.ChekUserReg(username))
            {
                MessageBox.Show("Пользователь с таким логином уже зарегистрирован!", "Регистрация аккаунта",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (username.Length > 10)
            {
                MessageBox.Show("Логин не может быть больше 10-ти символов!", "Регистрация аккаунта",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (password.Length <= 5 || password.Length > 20)
            {
                 DialogResult res = MessageBox.Show("Пароль не может быть меньше 10-ти символов или больше 20! Требуется помощь?", "Регистрация аккаунта",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (res == DialogResult.Yes)
                    MessageBox.Show("Если Вам трудно придумать подходящий пароль, воспользуйтесь кнопкой \"Генерация пароля\"", "Помощь", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false; 
            }
            else { return true; }
        }

        private void ShowPassword(object sender, EventArgs e)
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

        private void ShowCnfrmPassword(object sender, EventArgs e)
        {
            if (CnfmPasswordTextBox.UseSystemPasswordChar == true)
            {
                CnfmPasswordTextBox.UseSystemPasswordChar = false;
                ShowCnfrPassow_PictureBox.Image = Properties.Resources.visual;
            }
            else
            {
                CnfmPasswordTextBox.UseSystemPasswordChar = true;
                ShowCnfrPassow_PictureBox.Image = Properties.Resources.non_visual;
            }
        }
    }
}
