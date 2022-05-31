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
    public partial class MessageToUserForm : Form
    {
        public MessageToUserForm()
        {
            InitializeComponent();
        }

        private void Apply_Button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Answer_RichBox.Text))
            {
                MessageBox.Show("Ответ пользователю не может быть пустым!", "Обратная связь",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            else 
            { 

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
