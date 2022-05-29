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
    public partial class RecycleOptionsForm : Form
    {
        public RecycleOptionsForm()
        {
            InitializeComponent();

            // Control properties 
             
        }

        private void Apply_Button_Click(object sender, EventArgs e)
        {
            // задается интервал
            string username = OtherFunction.userName;

            switch (Interval_Combobox.SelectedIndex)
            {
                case 0:
                    sqlFuncs.updateIntervalTimer(username, "300000");
                    break;
                case 1:
                    sqlFuncs.updateIntervalTimer(username, "3600000");
                    break;
                case 2:
                    sqlFuncs.updateIntervalTimer(username, "86400000");
                    break;
                case 3:
                    sqlFuncs.updateIntervalTimer(username, "enter");
                    break;
                case 4:
                    sqlFuncs.updateIntervalTimer(username, "never");
                    break;
            }

            MessageBox.Show("Интервал очищения корзины изменен");
                

        }
        #region Buttons - Cancel 
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void RecycleOptionsForm_Activated(object sender, EventArgs e)
        {
            string username = OtherFunction.userName;

            if (sqlFuncs.selectValueTimer(username) == "300000")
                Interval_Combobox.SelectedIndex = 0;
            else if (sqlFuncs.selectValueTimer(username) == "3600000")
                Interval_Combobox.SelectedIndex = 1;
            else if (sqlFuncs.selectValueTimer(username) == "86400000")
                Interval_Combobox.SelectedIndex = 2;
            else if (sqlFuncs.selectValueTimer(username) == "enter")
                Interval_Combobox.SelectedIndex = 3;
            else
                Interval_Combobox.SelectedIndex = 4;

        }
    }
}
