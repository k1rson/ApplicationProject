﻿using System;
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
            sqlFuncs.answerReports(userName);
            SMTP.SendMessage(sqlFuncs.GetEmailUser(userName), $"Ответ на вопрос, заданный администрации\nТема вашего вопроса: {sqlFuncs.SelectThemeReports(userName)}", Answer_RichBox.Text); 
        }
        #region Buttons - Cancel
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
