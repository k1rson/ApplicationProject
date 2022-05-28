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
            if(IsValidateData(EmailUser_TextBox.Text, SubjectMessage_TextBox.Text,
                Message_RichTextBox.Text))
            {
                SendMessage(EmailUser_TextBox.Text, SubjectMessage_TextBox.Text,
               Message_RichTextBox.Text);

                MessageBox.Show("Сообщение успешно доставлено адресату!", "Email письмо", 
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }  
        static void SendMessage(string emailUser, string subMessage, string bodyMessage)
        {
            // подключаемся к сервису smtp 
            SmtpClient Smtp = new SmtpClient("smtp.mail.ru", 587);
            Smtp.EnableSsl = true;
            Smtp.Credentials = new NetworkCredential("developmnet@mail.ru", "n6uQHZ1x8sMkxfgN2zVC");

            // генерируем новое сообщение 
            MailMessage Message = new MailMessage();
            Message.From = new MailAddress("developmnet@mail.ru");

            // кому, тема, сообщение 
            Message.To.Add(new MailAddress(emailUser));
            Message.Subject = subMessage;
            Message.Body = bodyMessage;

            try
            {
                Smtp.Send(Message); 
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла непридвиденная ошибка!", "Ошибка!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidateData(string emailUser, string subMessage, string bodyMessage)
        {
            if (String.IsNullOrEmpty(emailUser) || String.IsNullOrEmpty(subMessage) || String.IsNullOrEmpty(bodyMessage))
            {
                MessageBox.Show("Поля \"Email получателя\", \"Тема сообщения\", \"Текст сообщения\" не могут быть пустыми!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(IsValidateEmail(emailUser) == false)
            {
                MessageBox.Show("Email получателя был введен неправильно!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
            else { return true; }
        }
        private bool IsValidateEmail(string source)
        {
            return new EmailAddressAttribute().IsValid(source);
        }
        #region Buttons - Cancel
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close(); 
        }
        #endregion
    }
}
