
namespace ApplicationProject
{
    partial class ResetPasswordForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Apply_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Login_TextBox = new System.Windows.Forms.TextBox();
            this.Code_TextBox = new System.Windows.Forms.TextBox();
            this.NewPassword_Label = new System.Windows.Forms.Label();
            this.Code_Label = new System.Windows.Forms.Label();
            this.NewPassword_TextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Cancel_Button);
            this.flowLayoutPanel1.Controls.Add(this.Apply_Button);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 178);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(291, 32);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(213, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Вернуться";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Apply_Button
            // 
            this.Apply_Button.Location = new System.Drawing.Point(132, 3);
            this.Apply_Button.Name = "Apply_Button";
            this.Apply_Button.Size = new System.Drawing.Size(75, 23);
            this.Apply_Button.TabIndex = 0;
            this.Apply_Button.Text = "Сменить";
            this.Apply_Button.UseVisualStyleBackColor = true;
            this.Apply_Button.Click += new System.EventHandler(this.Apply_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин: ";
            // 
            // Login_TextBox
            // 
            this.Login_TextBox.Location = new System.Drawing.Point(75, 38);
            this.Login_TextBox.Name = "Login_TextBox";
            this.Login_TextBox.Size = new System.Drawing.Size(132, 20);
            this.Login_TextBox.TabIndex = 2;
            // 
            // Code_TextBox
            // 
            this.Code_TextBox.Location = new System.Drawing.Point(75, 89);
            this.Code_TextBox.Name = "Code_TextBox";
            this.Code_TextBox.Size = new System.Drawing.Size(132, 20);
            this.Code_TextBox.TabIndex = 3;
            this.Code_TextBox.Visible = false;
            // 
            // NewPassword_Label
            // 
            this.NewPassword_Label.AutoSize = true;
            this.NewPassword_Label.Location = new System.Drawing.Point(103, 127);
            this.NewPassword_Label.Name = "NewPassword_Label";
            this.NewPassword_Label.Size = new System.Drawing.Size(86, 13);
            this.NewPassword_Label.TabIndex = 4;
            this.NewPassword_Label.Text = "Новый пароль: ";
            this.NewPassword_Label.Visible = false;
            // 
            // Code_Label
            // 
            this.Code_Label.AutoSize = true;
            this.Code_Label.Location = new System.Drawing.Point(93, 73);
            this.Code_Label.Name = "Code_Label";
            this.Code_Label.Size = new System.Drawing.Size(114, 13);
            this.Code_Label.TabIndex = 5;
            this.Code_Label.Text = "Код подтверждения: ";
            this.Code_Label.Visible = false;
            // 
            // NewPassword_TextBox
            // 
            this.NewPassword_TextBox.Location = new System.Drawing.Point(75, 143);
            this.NewPassword_TextBox.Name = "NewPassword_TextBox";
            this.NewPassword_TextBox.Size = new System.Drawing.Size(132, 20);
            this.NewPassword_TextBox.TabIndex = 6;
            this.NewPassword_TextBox.Visible = false;
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 210);
            this.Controls.Add(this.NewPassword_TextBox);
            this.Controls.Add(this.Code_Label);
            this.Controls.Add(this.NewPassword_Label);
            this.Controls.Add(this.Code_TextBox);
            this.Controls.Add(this.Login_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ResetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Смена пароля";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Apply_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Login_TextBox;
        private System.Windows.Forms.TextBox Code_TextBox;
        private System.Windows.Forms.Label NewPassword_Label;
        private System.Windows.Forms.Label Code_Label;
        private System.Windows.Forms.TextBox NewPassword_TextBox;
    }
}