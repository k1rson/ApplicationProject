using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationProject
{
    public class SMTP
    {
        public static void SendMessage(string emailUser, string subMessage, string bodyMessage)
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
    }
}
