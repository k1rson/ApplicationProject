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
    public partial class AnswerForm : Form
    {
        public AnswerForm()
        {
            InitializeComponent();
        }

        private void Apply_Button_Click(object sender, EventArgs e)
        {
            string userName = OtherFunction.selectedUsername;
            sqlFuncs.answerReports(userName, sqlFuncs.SelectThemeReports(userName));
            
            SMTP.SendMessage(sqlFuncs.GetEmailUser(userName), "Вам пришел ответ от Администрации cypherGo", $"Доброго времени суток, {userName}. \nОтвет на Ваш вопрос: {Answer_RichBox.Text}");
           
            MessageBox.Show("Ответ был успешно доставлен!", "Ответ на вопрос пользователя", 
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Close();
        }
        #region Buttons - Cancel
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
