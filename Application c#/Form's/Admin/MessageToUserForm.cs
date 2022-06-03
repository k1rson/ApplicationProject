using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ApplicationProject
{
    public partial class MessageToUserForm : Form
    {
        public MessageToUserForm()
        {
            InitializeComponent();
        }

        private void Apply_Button_Click(object sender, EventArgs e)
        {
            AnswerForm msgToAnswer = new AnswerForm();
            msgToAnswer.ShowDialog();
        }
        #region Buttons - Cancel
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close(); 
        }
        #endregion

        private void MessageToUserForm_Activated(object sender, EventArgs e)
        {
            UpdateListBox();

        }

        private void UpdateListBox()
        {
            AllThemes_ListBox.Items.Clear();

            List<string> reports = sqlFuncs.SelectReports();
            for (int i = 0; i < reports.Count; i++)
            {
                AllThemes_ListBox.Items.Add(reports[i]);
            }
            Answer_RichBox.Text = string.Empty;
        }

        private void AllThemes_ListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                string userName = AllThemes_ListBox.SelectedItem.ToString();
                OtherFunction.selectedUsername = userName;
                Answer_RichBox.Text = userName + "\n" + sqlFuncs.SelectThemeReports(userName) + "\n" + sqlFuncs.SelectMessageReports(userName);
            }
            catch (Exception)
            {
                OtherFunction.selectedUsername = string.Empty;
                return;
            }
        }
    }
}
