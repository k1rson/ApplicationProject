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
    public partial class EncryptionOptionsForm : Form
    {
        public EncryptionOptionsForm()
        {
            InitializeComponent();
            SelectEncyption_ComboBox.SelectedIndex = 0; 
            SelectAlphabet_ComboBox.SelectedIndex = 0;
            Shift_TextBox.Text = string.Empty; 
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            SelectEncyption_ComboBox.SelectedIndex = -1;
            SelectAlphabet_ComboBox.SelectedIndex = -1;
            Shift_TextBox.Text = string.Empty;
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            // метод шифрования
            GetCypher();
            Close(); 

        }
        private void GetCypher()
        {
            #region Алфавиты
            string alphabetRus = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string alphabetRusCaps = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string alphabetEng = "abcdefghijklmnopqrstuvwxyz";
            string alphabetEngCaps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbersList = "0123456789";
            string alphabetSymbols = "!@№#$;%:^?&*()_-=+";
            #endregion

            switch (SelectEncyption_ComboBox.SelectedIndex)
            {
                case 0:
                    #region Шифр Цезаря

                    string word = OtherFunction.encryption;

                    if (String.IsNullOrEmpty(word))
                        MessageBox.Show("Строка \"Входные данные\" не может быть пустой! Выберите корректный файл!");

                    int shift;
                    try
                    {
                        shift = int.Parse(Shift_TextBox.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка!");
                        return;
                    }
                    if (shift > 32 || shift < 0)
                    {
                        MessageBox.Show("Длина сдвига не может быть меньше 0 или больше 32!");
                        return;
                    }
                    string code = null;
                    for (int i = 0; i < word.Length; i++)
                    {
                        int posihion;

                        char c = word[i];

                        if (word[i] == ' ')
                        {
                            code += ' ';
                        }
                        else if (word[i] == '\t')
                        {
                            code += '\t';
                        }
                        else if (word[i] == '\n')
                        {
                            code += '\n';
                        }
                        else
                        {
                            if (alphabetRusCaps.IndexOf(c) >= 0)
                            {
                                posihion = alphabetRusCaps.IndexOf(c);
                                int a = posihion + shift;
                                if (a > 32)
                                    a -= 33;
                                code += alphabetRusCaps[a];
                            }
                            if (alphabetRus.IndexOf(c) >= 0)
                            {
                                posihion = alphabetRus.IndexOf(c);
                                int a = posihion + shift;
                                if (a > 32)
                                    a -= 33;
                                code += alphabetRus[a];
                            }

                            if (alphabetEng.IndexOf(c) >= 0)
                            {
                                posihion = alphabetEng.IndexOf(c);
                                int a = posihion + shift;
                                if (a > 26)
                                    a -= 27;
                                code += alphabetEng[a];
                            }

                            if (alphabetEngCaps.IndexOf(c) >= 0)
                            {
                                posihion = alphabetEngCaps.IndexOf(c);
                                int a = posihion + shift;
                                if (a > 26)
                                    a -= 27;
                                code += alphabetEngCaps[a];
                            }

                            if (numbersList.IndexOf(c) >= 0)
                            {
                                posihion = numbersList.IndexOf(c);
                                int a = posihion + shift;
                                if (a > 9)
                                    a -= 10;

                                code += numbersList[a];
                            }

                            if (alphabetSymbols.IndexOf(c) >= 0)
                            {
                                posihion = alphabetSymbols.IndexOf(c);
                                int a = posihion + shift;
                                if (a > 17)
                                    a -= 18;
                                code += alphabetSymbols[a];
                            }
                        }
                    }
                    OtherFunction.decryption = code;
                    #endregion
                    break;
                case 1:
                    // someday bro
                    break;
                default:
                    MessageBox.Show("Требуется выбрать шифр!");
                    break;
            }
        }

    }
}
