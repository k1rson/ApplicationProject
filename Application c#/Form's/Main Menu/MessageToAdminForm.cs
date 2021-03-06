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
    public partial class MessageToAdminForm : Form
    {
        public MessageToAdminForm()
        {
            InitializeComponent();
        }

        private void Send_Button_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(Theme_TextBox.Text) || String.IsNullOrEmpty(Message_RichBox.Text))
            {
                MessageBox.Show("Поля \"Тема сообщения\" и \"Сообщение\" не могут быть пустыми!", "Сообщение администрации", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sqlFuncs.AddReportUser(OtherFunction.userName, Theme_TextBox.Text, Message_RichBox.Text);
                MessageBox.Show("Вопрос был успешно доставлен!", "Ожидайте ответ в течении 24 часов",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Close();
            }
        }
        #region Buttons - Cancel
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
