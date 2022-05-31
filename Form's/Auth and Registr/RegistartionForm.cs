using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
            
            // Сontrol properties
            PasswordTextBox.UseSystemPasswordChar = true;  // password mask
            CnfmPasswordTextBox.UseSystemPasswordChar = true; // password mask

        }
        private void Registration_Button_Click(object sender, EventArgs e)
        {
            OtherFunction.emailUser = EmailUser_TextBox.Text;
            // Add a user to the database
            if (IsDataValid(LoginTextBox.Text, PasswordTextBox.Text, CnfmPasswordTextBox.Text))
            {

                ConfirmationEmailForm cnfForm = new ConfirmationEmailForm();
                cnfForm.ShowDialog(); 

                if(!cnfForm.OK)
                {
                   
                }
                else
                {
                    sqlFuncs.regUser(LoginTextBox.Text, sqlFuncs.sha256(PasswordTextBox.Text), OtherFunction.emailUser);
                    MessageBox.Show("Регистрация аккаунта успешно завершена! Приятного времяпровождения!", "Регистрация аккаунта",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Close();
                }
              
            }
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

        private void ShowCnfrmPassword_Click(object sender, EventArgs e)
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

        private bool IsDataValid(string userName, string password, string confirmPassword)
        {
            string spl_Chars = "#№@&^%*()_-=+/$;?+!'.{}[]";

            if (String.IsNullOrEmpty(userName) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Поле логин/пароль не может быть пустым!", "Регистрация аккаунта",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (userName.Intersect(spl_Chars).Any())
            {
                DialogResult res = MessageBox.Show("В логине присутствуют запрещенные символы! Требуется помощь?", "Регистрация аккаунта",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (res == DialogResult.Yes)
                    MessageBox.Show("Пожалуйста, используйте в логине только буквы русского и английского алфавитов и цифры!", "Помощь",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают!", "Регистрация аккаунта",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (sqlFuncs.ChekUserReg(userName))
            {
                MessageBox.Show("Пользователь с таким логином уже зарегистрирован!", "Регистрация аккаунта",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (userName.Length > 10)
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
            else if(!sqlFuncs.IsCheckEmail(OtherFunction.emailUser))
            {
                MessageBox.Show("Пользователь с такой почтой уже зарегистрирован!", "Регистрация аккаунта",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
            else if(!IsValidEmail(OtherFunction.emailUser))
            {
                MessageBox.Show("Проверьте корректность вводимой почты!", "Регистрация аккаунта",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else { return true; }
        }
        private void AutoGeneratePassword_PictureBox_Click(object sender, EventArgs e)
        {
            PasswordTextBox.Text = GeneratePass();
            CnfmPasswordTextBox.Text = PasswordTextBox.Text; 
        }
        private string GeneratePass()
        {
            string iPass = "";
            string[] arr = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Z", "b", "c", "d", "f", "g", "h", "j", "k", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z", "A", "E", "U", "Y", "a", "e", "i", "o", "u", "y" };
            Random rnd = new Random();
            for (int i = 0; i < 16; i++)
            {
                iPass = iPass + arr[rnd.Next(0, 57)];
            }
            return iPass; 
        }
        public bool IsValidEmail(string source)
        {
            return new EmailAddressAttribute().IsValid(source);
        }

        #region Buttons - OK/Cancel
        private void OK_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
       
    }
}
