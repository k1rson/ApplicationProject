﻿using System;
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
    public partial class RegistartionForm : Form
    {
        public RegistartionForm()
        {
            InitializeComponent();
        }

        private void ActionRegistr_Button_Click(object sender, EventArgs e)
        {
            // добавление пользователя в БД
            if (IsDataValid(LoginTextBox.Text, PasswordTextBox.Text, CnfmPasswordTextBox.Text))
            {
                sqlFuncs.regUser(LoginTextBox.Text, PasswordTextBox.Text); 
                Close();
            }
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool IsDataValid(string username, string password, string passwordConfirm)
        {
            string spl_Chars = "#№@&^%*()_-=+/";

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Поле логин/пароль не может быть пустым!");
                return false;
            }
            else if (username.Intersect(spl_Chars).Any())
            {
                MessageBox.Show("В логине присутствуют запрещенные символы.");
                return false;
            }
            else if (password != passwordConfirm)
            {
                MessageBox.Show("Пароль несовпадает!");
                return false;
            }
            else { return true; }
        } 
    }
}
