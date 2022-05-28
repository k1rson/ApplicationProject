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
            Interval_Combobox.SelectedIndex = 0; 
        }

        private void Apply_Button_Click(object sender, EventArgs e)
        {
            // задается интервал
        }
        #region Buttons - Cancel 
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
