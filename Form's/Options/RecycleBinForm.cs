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

            // таймер для очистки корзины
        }

        private void RestoreFile_Button_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены, что хотите восстановить выбранный файл?", "Восстановление файлов", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(res == DialogResult.Yes)
            {
                // обращение к выбранному файлу, удаление его из данной области и перенос обратно в MainMenuForm 
            }
        }

        private void EmptyRecycle_Button_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены, что хотите очистить корзину? Данное действие приведет к полной потери файлов!", "Очистка корзины", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(res == DialogResult.Yes)
            {
                // listbox.clear, удаление из бд этих файлов
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
    }
}
