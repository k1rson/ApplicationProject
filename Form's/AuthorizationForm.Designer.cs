﻿namespace ApplicationProject
{
    partial class AuthorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ActionSignUp_Button = new System.Windows.Forms.Button();
            this.ActionEnter_Button = new System.Windows.Forms.Button();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Login_Label = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.ToolTipRegistr = new System.Windows.Forms.ToolTip(this.components);
            this.InfoSystem_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ActionSignUp_Button
            // 
            this.ActionSignUp_Button.Location = new System.Drawing.Point(67, 226);
            this.ActionSignUp_Button.Name = "ActionSignUp_Button";
            this.ActionSignUp_Button.Size = new System.Drawing.Size(127, 23);
            this.ActionSignUp_Button.TabIndex = 11;
            this.ActionSignUp_Button.Text = "Зарегистрироваться";
            this.ToolTipRegistr.SetToolTip(this.ActionSignUp_Button, "У Вас нет аккаунта? Пройдите быструю регистрацию, нажав на данную кнопку!\r\n");
            this.ActionSignUp_Button.UseVisualStyleBackColor = true;
            this.ActionSignUp_Button.Click += new System.EventHandler(this.ActionSignUp_Button_Click);
            // 
            // ActionEnter_Button
            // 
            this.ActionEnter_Button.Location = new System.Drawing.Point(92, 183);
            this.ActionEnter_Button.Name = "ActionEnter_Button";
            this.ActionEnter_Button.Size = new System.Drawing.Size(75, 23);
            this.ActionEnter_Button.TabIndex = 10;
            this.ActionEnter_Button.Text = "Войти";
            this.ActionEnter_Button.UseVisualStyleBackColor = true;
            this.ActionEnter_Button.Click += new System.EventHandler(this.ActionEnter_Button_Click);
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(105, 129);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(48, 13);
            this.Password_Label.TabIndex = 9;
            this.Password_Label.Text = "Пароль:";
            // 
            // Login_Label
            // 
            this.Login_Label.AutoSize = true;
            this.Login_Label.Location = new System.Drawing.Point(112, 74);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(41, 13);
            this.Login_Label.TabIndex = 8;
            this.Login_Label.Text = "Логин:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(67, 145);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(122, 20);
            this.PasswordTextBox.TabIndex = 7;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(67, 90);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(122, 20);
            this.LoginTextBox.TabIndex = 6;
            // 
            // InfoSystem_Label
            // 
            this.InfoSystem_Label.AutoSize = true;
            this.InfoSystem_Label.Location = new System.Drawing.Point(64, 34);
            this.InfoSystem_Label.Name = "InfoSystem_Label";
            this.InfoSystem_Label.Size = new System.Drawing.Size(133, 13);
            this.InfoSystem_Label.TabIndex = 12;
            this.InfoSystem_Label.Text = "Программа шифрования";
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 261);
            this.Controls.Add(this.InfoSystem_Label);
            this.Controls.Add(this.ActionSignUp_Button);
            this.Controls.Add(this.ActionEnter_Button);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.Login_Label);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ActionSignUp_Button;
        private System.Windows.Forms.ToolTip ToolTipRegistr;
        private System.Windows.Forms.Button ActionEnter_Button;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Label Login_Label;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label InfoSystem_Label;
    }
}
