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
    public partial class ResetPasswordForm : Form
    {
        public ResetPasswordForm()
        {
            InitializeComponent();
            OtherFunction.codeGen = 10; 
        }

        private void Apply_Button_Click(object sender, EventArgs e)
        {
            if(sqlFuncs.CheckUserReg(Login_TextBox.Text))
            {
                Code_Label.Visible = true;
                Code_TextBox.Visible = true;
                Code_TextBox.Text = "10"; 

                SMTP.SendMessage(sqlFuncs.GetEmailUser(Login_TextBox.Text), "Смена пароля", $"Доброго времени суток, {Login_TextBox.Text}. \n Ваш код подтверждения: {OtherFunction.codeGen}");
                
                if(!IsConfirmCode())
                {

                }
                else
                {
                    Login_TextBox.Visible = false; 
                    Code_Label.Visible = false;
                    Code_TextBox.Visible = false;

                    NewPassword_Label.Visible = true; 
                    NewPassword_TextBox.Visible = true;

                    sqlFuncs.ResetPassword(NewPassword_TextBox.Text, Login_TextBox.Text);

                    MessageBox.Show("Вы успешно сменили пароль!", "Смена пароля", 
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Close(); 
                }
            }
            else
            {
                MessageBox.Show("Такого логина не существует!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int IsCode()
        {
            var rand = new Random();

            string symbols = "0123456789";

            string code = string.Empty;
            for (int i = 0; i <= 3; i++)
            {
                int value = rand.Next(0, symbols.Length);
                code += symbols[value];
            }

            return int.Parse(code);
        }
        private bool IsConfirmCode()
        {
            if (int.Parse(Code_TextBox.Text) != OtherFunction.codeGen)
            {
                MessageBox.Show("Введен неверный код, повторите попытку!", "Подтверждение почты",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("Почта успешно подтверждена!", "Подтверждение почты",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
            }
        }
        #region Buttons - Cancel
        private void Cancel_Button_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
