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
    public partial class BanCauseForm : Form
    {
        public BanCauseForm()
        {
            InitializeComponent();
        }

        private void Ban_Button_Click(object sender, EventArgs e)
        {
            OtherFunction.causeBan = CauseBan_TextBox.Text;
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
