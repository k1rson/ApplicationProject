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
    public partial class EncryptionOptionsForm : Form
    {
        public EncryptionOptionsForm()
        {
            InitializeComponent();

            // Сontrol properties
            SelectEncyption_ComboBox.SelectedIndex = 0; 
            SelectAlphabet_ComboBox.SelectedIndex = 0;
            Shift_Numeric.Value = 0; 
        }
        
        private void ResetChanges_Button_Click(object sender, EventArgs e)
        {
            SelectEncyption_ComboBox.SelectedIndex = -1;
            SelectAlphabet_ComboBox.SelectedIndex = -1;
            Shift_Numeric.Value = 0;
        }

        private void Encrypt_Button_Click(object sender, EventArgs e)
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

                    string word = OtherFunction.decryption;

                    if (String.IsNullOrEmpty(word))
                    {
                        MessageBox.Show("Поле \"Содержимое файла\" не может быть пустым!", "Шифрование (входные данные для шифрования)",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (String.IsNullOrEmpty(Shift_Numeric.Text))
                    {
                        MessageBox.Show("Поле \"Сдвиг\" не может быть пустым!", "Шифрование (входные данные для шифрования)",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return; 
                    }

                    int shift = (int)Shift_Numeric.Value; 

                    if (shift > 32 || shift < 0)
                    {
                        MessageBox.Show("Длина сдвига не может быть меньше 0 или больше 32!", "Шифрование (выбор сдвига)",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        Shift_Numeric.Value = 0;
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

                                if (SelectAlphabet_ComboBox.SelectedIndex == 0 || SelectAlphabet_ComboBox.SelectedIndex == 1)
                                {
                                    code += alphabetRusCaps[a];
                                }
                                else
                                    code += alphabetRusCaps[posihion];
                            }
                            if (alphabetRus.IndexOf(c) >= 0)
                            {
                                posihion = alphabetRus.IndexOf(c);
                                int a = posihion + shift;
                                if (a > 32)
                                    a -= 33;

                                if (SelectAlphabet_ComboBox.SelectedIndex == 0 || SelectAlphabet_ComboBox.SelectedIndex == 1)
                                {
                                    code += alphabetRus[a];
                                }
                                else
                                    code += alphabetRus[posihion];
                            }

                            if (alphabetEng.IndexOf(c) >= 0)
                            {
                                posihion = alphabetEng.IndexOf(c);
                                int a = posihion + shift;
                                if (a > 25)
                                    a -= 26;

                                if (SelectAlphabet_ComboBox.SelectedIndex == 0 || SelectAlphabet_ComboBox.SelectedIndex == 2)
                                {
                                    code += alphabetEng[a];
                                }
                                else
                                    code += alphabetEng[posihion];
                            }

                            if (alphabetEngCaps.IndexOf(c) >= 0)
                            {
                                posihion = alphabetEngCaps.IndexOf(c);
                                int a = posihion + shift;
                                if (a > 25)
                                    a -= 26;

                                if (SelectAlphabet_ComboBox.SelectedIndex == 0 || SelectAlphabet_ComboBox.SelectedIndex == 2)
                                {
                                    code += alphabetEngCaps[a];
                                }
                                else
                                    code += alphabetEngCaps[posihion];
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

                                if (SelectAlphabet_ComboBox.SelectedIndex == 0 || SelectAlphabet_ComboBox.SelectedIndex == 3)
                                {
                                    code += alphabetSymbols[a];
                                }
                                else
                                    code += alphabetSymbols[posihion];

                            }
                        }
                    }
                    OtherFunction.encryption = code;
                    #endregion
                    break;
                case 1:
                    // someday bro
                    break;
                default:
                    MessageBox.Show("Требуется выбрать шифр!", "Шифрование (выбор шифра)",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
            }

            sqlFuncs.UpdateFile(OtherFunction.userName, OtherFunction.fileName, OtherFunction.decryption, OtherFunction.encryption);

            MessageBox.Show("Шифрование выполнено успешно!", "Шифрование",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk); 
            Close(); 
        }

        #region Button - Cancel
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
