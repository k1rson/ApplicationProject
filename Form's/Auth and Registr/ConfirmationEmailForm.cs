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
    public partial class ConfirmationEmailForm : Form
    {
        public bool OK = false; 
        public ConfirmationEmailForm()
        {
            InitializeComponent();

            OtherFunction.codeGen = IsCode(); 

            SMTP.SendMessage(OtherFunction.emailUser, "Подтверждение почты", "Ваш код подтверждения почты: " + OtherFunction.codeGen);
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            if(!IsConfirmCode())
            {
                OK = false; 
            }
            else
            {
                OK = true;
                Close();
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
            if(int.Parse(Code_TextBox.Text) != OtherFunction.codeGen)
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
