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
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void ActionEnter_Button_Click(object sender, EventArgs e)
        {
            // проверка на существование пользователя, доступ к системе
        }

        private void ActionSignUp_Button_Click(object sender, EventArgs e)
        {
            RegistartionForm form = new RegistartionForm();

            if(form.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
