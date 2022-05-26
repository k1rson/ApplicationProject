namespace ApplicationProject
{
    partial class RegistartionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistartionForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.ActionRegistr_Button = new System.Windows.Forms.Button();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Login_Label = new System.Windows.Forms.Label();
            this.CnfmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.ShowPassword_PictureBox = new System.Windows.Forms.PictureBox();
            this.ShowCnfrPassow_PictureBox = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassword_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowCnfrPassow_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Cancel_Button);
            this.flowLayoutPanel1.Controls.Add(this.OK_Button);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 229);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(254, 32);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(176, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(95, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // ActionRegistr_Button
            // 
            this.ActionRegistr_Button.Location = new System.Drawing.Point(61, 189);
            this.ActionRegistr_Button.Name = "ActionRegistr_Button";
            this.ActionRegistr_Button.Size = new System.Drawing.Size(125, 23);
            this.ActionRegistr_Button.TabIndex = 14;
            this.ActionRegistr_Button.Text = "Зарегистрироваться";
            this.ActionRegistr_Button.UseVisualStyleBackColor = true;
            this.ActionRegistr_Button.Click += new System.EventHandler(this.ActionRegistr_Button_Click);
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(68, 136);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(115, 13);
            this.confirmPasswordLabel.TabIndex = 13;
            this.confirmPasswordLabel.Text = "Подтвердить пароль:";
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(102, 82);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(48, 13);
            this.Password_Label.TabIndex = 12;
            this.Password_Label.Text = "Пароль:";
            // 
            // Login_Label
            // 
            this.Login_Label.AutoSize = true;
            this.Login_Label.Location = new System.Drawing.Point(102, 25);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(41, 13);
            this.Login_Label.TabIndex = 11;
            this.Login_Label.Text = "Логин:";
            // 
            // CnfmPasswordTextBox
            // 
            this.CnfmPasswordTextBox.Location = new System.Drawing.Point(61, 152);
            this.CnfmPasswordTextBox.Name = "CnfmPasswordTextBox";
            this.CnfmPasswordTextBox.Size = new System.Drawing.Size(122, 20);
            this.CnfmPasswordTextBox.TabIndex = 10;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(61, 98);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(122, 20);
            this.PasswordTextBox.TabIndex = 9;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(61, 41);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(122, 20);
            this.LoginTextBox.TabIndex = 8;
            // 
            // ShowPassword_PictureBox
            // 
            this.ShowPassword_PictureBox.Image = global::ApplicationProject.Properties.Resources.non_visual;
            this.ShowPassword_PictureBox.Location = new System.Drawing.Point(189, 98);
            this.ShowPassword_PictureBox.Name = "ShowPassword_PictureBox";
            this.ShowPassword_PictureBox.Size = new System.Drawing.Size(27, 20);
            this.ShowPassword_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowPassword_PictureBox.TabIndex = 16;
            this.ShowPassword_PictureBox.TabStop = false;
            this.ShowPassword_PictureBox.Click += new System.EventHandler(this.ShowPassword);
            // 
            // ShowCnfrPassow_PictureBox
            // 
            this.ShowCnfrPassow_PictureBox.Image = global::ApplicationProject.Properties.Resources.non_visual;
            this.ShowCnfrPassow_PictureBox.Location = new System.Drawing.Point(189, 152);
            this.ShowCnfrPassow_PictureBox.Name = "ShowCnfrPassow_PictureBox";
            this.ShowCnfrPassow_PictureBox.Size = new System.Drawing.Size(27, 20);
            this.ShowCnfrPassow_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowCnfrPassow_PictureBox.TabIndex = 17;
            this.ShowCnfrPassow_PictureBox.TabStop = false;
            this.ShowCnfrPassow_PictureBox.Click += new System.EventHandler(this.ShowCnfrmPassword);
            // 
            // RegistartionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 261);
            this.Controls.Add(this.ShowCnfrPassow_PictureBox);
            this.Controls.Add(this.ShowPassword_PictureBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ActionRegistr_Button);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.Login_Label);
            this.Controls.Add(this.CnfmPasswordTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegistartionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassword_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowCnfrPassow_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Button ActionRegistr_Button;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Label Login_Label;
        private System.Windows.Forms.TextBox CnfmPasswordTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.PictureBox ShowPassword_PictureBox;
        private System.Windows.Forms.PictureBox ShowCnfrPassow_PictureBox;
    }
}