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
    public partial class RecycleBinForm : Form
    {
        public RecycleBinForm()
        {
            InitializeComponent();

            // привязали контекстное меню к листбоксу  
            AllFilesRecycle_ListBox.ContextMenuStrip = ContextMenuRecycle;

            // здесь все файлы отрисовываются 
            UpdateListBox();

            // таймер для очистки корзины
        }

        private void RestoreFile_Button_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены, что хотите восстановить выбранный файл?", "Восстановление файлов", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(res == DialogResult.Yes)
            {
                sqlFuncs.ReturnFileRecycle(OtherFunction.userName, OtherFunction.fileName);
                UpdateListBox();

            }

        }

        private void EmptyRecycle_Button_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены, что хотите очистить корзину? Данное действие приведет к полной потери файлов!", "Очистка корзины", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(res == DialogResult.Yes)
            {
                sqlFuncs.DeleteAllFiles(OtherFunction.userName);
                UpdateListBox();
            }
        }
        private void IntervalAutoCleaning_Click(object sender, EventArgs e)
        {
            RecycleOptionsForm recycleOptions = new RecycleOptionsForm();
            recycleOptions.ShowDialog();
        }

        #region Buttons - Cancel
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close(); 
        }
        #endregion

        public void UpdateListBox()
        {
            AllFilesRecycle_ListBox.Items.Clear();

            List<string> files = sqlFuncs.SelectUserRecycleFiles(OtherFunction.userName);
            for (int i = 0; i < files.Count; i++)
            {
                AllFilesRecycle_ListBox.Items.Add(files[i]);
            }
        }

        private void AllFilesRecycle_ListBox_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                OtherFunction.fileName = AllFilesRecycle_ListBox.SelectedItem.ToString();
            }
            catch (Exception)
            {

                return;
            }
        }
    }
}
