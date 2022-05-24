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
    public partial class SelectWorkZoneForm : Form
    {
        public SelectWorkZoneForm()
        {
            InitializeComponent();
        }

        private void GoToAdmin_Button_Click(object sender, EventArgs e)
        {
            AdminPanelForm adm = new AdminPanelForm();
            if(adm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void GoToUser_Button_Click(object sender, EventArgs e)
        {
            MainMenuForm mnf = new MainMenuForm();
            if(mnf.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void GoToBack_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
