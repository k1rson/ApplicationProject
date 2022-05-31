using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.ComponentModel.DataAnnotations;

namespace ApplicationProject
{
    public partial class NotificationEmailForm : Form
    {
        public NotificationEmailForm()
        {
            InitializeComponent();
        }

        private void Apply_Button_Click(object sender, EventArgs e)
        {
            if(IsValidateData(SubjectMessage_TextBox.Text,
                Message_RichTextBox.Text))
            {
               string word =  AllEmailUsers_ComboBox.SelectedItem.ToString();
               string[] username = word.Split(':');

               string emailUser = sqlFuncs.GetEmailUser(username[1]);

                SMTP.SendMessage(emailUser, SubjectMessage_TextBox.Text,
               Message_RichTextBox.Text);

                MessageBox.Show("Сообщение успешно доставлено адресату!", "Email письмо", 
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }  
        private bool IsValidateData(string subMessage, string bodyMessage)
        {
            if (String.IsNullOrEmpty(subMessage) || String.IsNullOrEmpty(bodyMessage))
            {
                MessageBox.Show("Поля \"Email получателя\", \"Тема сообщения\", \"Текст сообщения\" не могут быть пустыми!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else { return true; }
        }
        #region Buttons - Cancel
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close(); 
        }
        #endregion

        private void NotificationEmailForm_Activated(object sender, EventArgs e)
        {
            AllEmailUsers_ComboBox.Items.Clear();

            List<string> users = sqlFuncs.selectUsersList();
            for (int i = 0; i < users.Count; i++)
            {
                AllEmailUsers_ComboBox.Items.Add(users[i]);
            }
        }
    }
}
