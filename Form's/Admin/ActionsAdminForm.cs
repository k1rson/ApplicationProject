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
    public partial class ActionsAdminForm : Form
    {
        public ActionsAdminForm()
        {
            InitializeComponent();

            // подкидываем контексное меню на листбок
            AllAdmins_ListBox.ContextMenuStrip = ContextMenuSettings; 
        }

        private void AddAdmin_Button_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Добавить администратора?"
                , "Добавление админа", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (res == DialogResult.Yes)
                    sqlFuncs.addAdmin(Numeric.Value);
                UpdateList();
            }
            catch (Exception)
            {
                MessageBox.Show("Такого пользователя не существует");
            }
        }

        private void DeleteAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Удалить администратора?"
                , "Удаление админа", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (res == DialogResult.Yes)
                    sqlFuncs.delAdmin(Numeric.Value);
                UpdateList();
            }
            catch (Exception)
            {
                MessageBox.Show("Такого пользователя не существует");
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ActionsAdminForm_Activated(object sender, EventArgs e)
        {
            UpdateList();
        }

        public void UpdateList()
        {
            AllAdmins_ListBox.Items.Clear();

            List<string> users = sqlFuncs.selectAdminsList();
            for (int i = 0; i < users.Count; i++)
            {
                AllAdmins_ListBox.Items.Add(users[i]);
            }
        }
    }
}
