namespace ApplicationProject
{
    partial class ActionsAdminForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.AdminsInfo = new System.Windows.Forms.TabPage();
            this.ActionsAdmins = new System.Windows.Forms.TabPage();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Info = new System.Windows.Forms.Label();
            this.AllAdmins_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.AddAdmin_Button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.EnterIDUser_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.AdminsInfo.SuspendLayout();
            this.ActionsAdmins.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.AdminsInfo);
            this.tabControl.Controls.Add(this.ActionsAdmins);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(353, 247);
            this.tabControl.TabIndex = 0;
            // 
            // AdminsInfo
            // 
            this.AdminsInfo.Controls.Add(this.AllAdmins_RichTextBox);
            this.AdminsInfo.Controls.Add(this.Info);
            this.AdminsInfo.Location = new System.Drawing.Point(4, 22);
            this.AdminsInfo.Name = "AdminsInfo";
            this.AdminsInfo.Padding = new System.Windows.Forms.Padding(3);
            this.AdminsInfo.Size = new System.Drawing.Size(345, 221);
            this.AdminsInfo.TabIndex = 0;
            this.AdminsInfo.Text = "Администраторы";
            this.AdminsInfo.UseVisualStyleBackColor = true;
            // 
            // ActionsAdmins
            // 
            this.ActionsAdmins.Controls.Add(this.label1);
            this.ActionsAdmins.Controls.Add(this.EnterIDUser_TextBox);
            this.ActionsAdmins.Controls.Add(this.button2);
            this.ActionsAdmins.Controls.Add(this.AddAdmin_Button);
            this.ActionsAdmins.Location = new System.Drawing.Point(4, 22);
            this.ActionsAdmins.Name = "ActionsAdmins";
            this.ActionsAdmins.Padding = new System.Windows.Forms.Padding(3);
            this.ActionsAdmins.Size = new System.Drawing.Size(345, 221);
            this.ActionsAdmins.TabIndex = 1;
            this.ActionsAdmins.Text = "Настройки";
            this.ActionsAdmins.UseVisualStyleBackColor = true;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(275, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 0;
            this.Cancel_Button.Text = "Вернуться";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Cancel_Button);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 215);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(353, 32);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(111, 12);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(121, 13);
            this.Info.TabIndex = 0;
            this.Info.Text = "Все администраторы: ";
            // 
            // AllAdmins_RichTextBox
            // 
            this.AllAdmins_RichTextBox.Location = new System.Drawing.Point(8, 28);
            this.AllAdmins_RichTextBox.Name = "AllAdmins_RichTextBox";
            this.AllAdmins_RichTextBox.ReadOnly = true;
            this.AllAdmins_RichTextBox.Size = new System.Drawing.Size(329, 162);
            this.AllAdmins_RichTextBox.TabIndex = 1;
            this.AllAdmins_RichTextBox.Text = "qwe | 123 ";
            // 
            // AddAdmin_Button
            // 
            this.AddAdmin_Button.Location = new System.Drawing.Point(8, 124);
            this.AddAdmin_Button.Name = "AddAdmin_Button";
            this.AddAdmin_Button.Size = new System.Drawing.Size(167, 23);
            this.AddAdmin_Button.TabIndex = 1;
            this.AddAdmin_Button.Text = "Добавить администратора";
            this.AddAdmin_Button.UseVisualStyleBackColor = true;
            this.AddAdmin_Button.Click += new System.EventHandler(this.AddAdmin_Button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить администратора";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EnterIDUser_TextBox
            // 
            this.EnterIDUser_TextBox.Location = new System.Drawing.Point(144, 71);
            this.EnterIDUser_TextBox.Name = "EnterIDUser_TextBox";
            this.EnterIDUser_TextBox.Size = new System.Drawing.Size(193, 20);
            this.EnterIDUser_TextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введи ID пользователя: ";
            // 
            // ActionsAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 247);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ActionsAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администраторы";
            this.tabControl.ResumeLayout(false);
            this.AdminsInfo.ResumeLayout(false);
            this.AdminsInfo.PerformLayout();
            this.ActionsAdmins.ResumeLayout(false);
            this.ActionsAdmins.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage AdminsInfo;
        private System.Windows.Forms.TabPage ActionsAdmins;
        private System.Windows.Forms.RichTextBox AllAdmins_RichTextBox;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EnterIDUser_TextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddAdmin_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}