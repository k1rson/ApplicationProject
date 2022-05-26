namespace ApplicationProject
{
    partial class AdminPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьИнформациюОПользователеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GnrInformation_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowFilesUser_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteUser_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.BanUser_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.NotificationUser_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateReport_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.файлыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileInpurAdmin_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileOutputAdmin_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.AllUsers_ListBox = new System.Windows.Forms.ListBox();
            this.AllUsers_Label = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.InputAdmin_RichBox = new System.Windows.Forms.RichTextBox();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.OutputAdmin_RichBox = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.GnrlInformation_Button = new System.Windows.Forms.ToolStripButton();
            this.ShowFilesUser_Button = new System.Windows.Forms.ToolStripButton();
            this.DeleteUser_Button = new System.Windows.Forms.ToolStripButton();
            this.BanUser_Button = new System.Windows.Forms.ToolStripButton();
            this.NotificationUser_Button = new System.Windows.Forms.ToolStripButton();
            this.CreateReport_Button = new System.Windows.Forms.ToolStripButton();
            this.SaveFileInputAdmin_Button = new System.Windows.Forms.ToolStripButton();
            this.SaveFileOutputAdmin_Button = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователиToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.файлыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотретьИнформациюОПользователеToolStripMenuItem,
            this.toolStripSeparator1,
            this.DeleteUser_Menu,
            this.BanUser_Menu,
            this.NotificationUser_Menu});
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            // 
            // просмотретьИнформациюОПользователеToolStripMenuItem
            // 
            this.просмотретьИнформациюОПользователеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GnrInformation_Menu,
            this.ShowFilesUser_Menu});
            this.просмотретьИнформациюОПользователеToolStripMenuItem.Name = "просмотретьИнформациюОПользователеToolStripMenuItem";
            this.просмотретьИнформациюОПользователеToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.просмотретьИнформациюОПользователеToolStripMenuItem.Text = "Просмотреть информацию о пользователе";
            // 
            // GnrInformation_Menu
            // 
            this.GnrInformation_Menu.Name = "GnrInformation_Menu";
            this.GnrInformation_Menu.Size = new System.Drawing.Size(243, 22);
            this.GnrInformation_Menu.Text = "Общая информация";
            this.GnrInformation_Menu.Click += new System.EventHandler(this.GnrInformation_Menu_Click);
            // 
            // ShowFilesUser_Menu
            // 
            this.ShowFilesUser_Menu.Name = "ShowFilesUser_Menu";
            this.ShowFilesUser_Menu.Size = new System.Drawing.Size(243, 22);
            this.ShowFilesUser_Menu.Text = "Показать файлы пользователя";
            this.ShowFilesUser_Menu.Click += new System.EventHandler(this.ShowFilesUser_Menu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(312, 6);
            // 
            // DeleteUser_Menu
            // 
            this.DeleteUser_Menu.Name = "DeleteUser_Menu";
            this.DeleteUser_Menu.Size = new System.Drawing.Size(315, 22);
            this.DeleteUser_Menu.Text = "Удалить пользователя";
            this.DeleteUser_Menu.Click += new System.EventHandler(this.DeleteUser_Menu_Click);
            // 
            // BanUser_Menu
            // 
            this.BanUser_Menu.Name = "BanUser_Menu";
            this.BanUser_Menu.Size = new System.Drawing.Size(315, 22);
            this.BanUser_Menu.Text = "Заблокировать пользователя";
            this.BanUser_Menu.Click += new System.EventHandler(this.BanUser_Menu_Click);
            // 
            // NotificationUser_Menu
            // 
            this.NotificationUser_Menu.Name = "NotificationUser_Menu";
            this.NotificationUser_Menu.Size = new System.Drawing.Size(315, 22);
            this.NotificationUser_Menu.Text = "Уведомить пользователя";
            this.NotificationUser_Menu.Click += new System.EventHandler(this.NotificationUser_Menu_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateReport_Menu});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // CreateReport_Menu
            // 
            this.CreateReport_Menu.Name = "CreateReport_Menu";
            this.CreateReport_Menu.Size = new System.Drawing.Size(150, 22);
            this.CreateReport_Menu.Text = "Создать отчет";
            this.CreateReport_Menu.Click += new System.EventHandler(this.CreateReport_Menu_Click);
            // 
            // файлыToolStripMenuItem
            // 
            this.файлыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveFileInpurAdmin_Menu,
            this.SaveFileOutputAdmin_Menu});
            this.файлыToolStripMenuItem.Name = "файлыToolStripMenuItem";
            this.файлыToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.файлыToolStripMenuItem.Text = "Файлы";
            // 
            // SaveFileInpurAdmin_Menu
            // 
            this.SaveFileInpurAdmin_Menu.Name = "SaveFileInpurAdmin_Menu";
            this.SaveFileInpurAdmin_Menu.Size = new System.Drawing.Size(236, 22);
            this.SaveFileInpurAdmin_Menu.Text = "Сохранить исходные данные";
            this.SaveFileInpurAdmin_Menu.Click += new System.EventHandler(this.SaveFileInpurAdmin_Menu_Click);
            // 
            // SaveFileOutputAdmin_Menu
            // 
            this.SaveFileOutputAdmin_Menu.Name = "SaveFileOutputAdmin_Menu";
            this.SaveFileOutputAdmin_Menu.Size = new System.Drawing.Size(236, 22);
            this.SaveFileOutputAdmin_Menu.Text = "Сохранить выходные данные";
            this.SaveFileOutputAdmin_Menu.Click += new System.EventHandler(this.SaveFileOutputAdmin_Menu_Click);
            // 
            // AllUsers_ListBox
            // 
            this.AllUsers_ListBox.FormattingEnabled = true;
            this.AllUsers_ListBox.Location = new System.Drawing.Point(12, 69);
            this.AllUsers_ListBox.Name = "AllUsers_ListBox";
            this.AllUsers_ListBox.Size = new System.Drawing.Size(205, 368);
            this.AllUsers_ListBox.TabIndex = 2;
            // 
            // AllUsers_Label
            // 
            this.AllUsers_Label.AutoSize = true;
            this.AllUsers_Label.Location = new System.Drawing.Point(44, 53);
            this.AllUsers_Label.Name = "AllUsers_Label";
            this.AllUsers_Label.Size = new System.Drawing.Size(106, 13);
            this.AllUsers_Label.TabIndex = 5;
            this.AllUsers_Label.Text = "Все пользователи: ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPage1);
            this.tabControl1.Controls.Add(this.TabPage2);
            this.tabControl1.Location = new System.Drawing.Point(223, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(577, 392);
            this.tabControl1.TabIndex = 9;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.InputAdmin_RichBox);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(569, 366);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Исходные данные";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // InputAdmin_RichBox
            // 
            this.InputAdmin_RichBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputAdmin_RichBox.Location = new System.Drawing.Point(3, 3);
            this.InputAdmin_RichBox.Name = "InputAdmin_RichBox";
            this.InputAdmin_RichBox.ReadOnly = true;
            this.InputAdmin_RichBox.Size = new System.Drawing.Size(563, 360);
            this.InputAdmin_RichBox.TabIndex = 0;
            this.InputAdmin_RichBox.Text = "";
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.OutputAdmin_RichBox);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(569, 366);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Преобразованные данные";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // OutputAdmin_RichBox
            // 
            this.OutputAdmin_RichBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputAdmin_RichBox.Location = new System.Drawing.Point(3, 3);
            this.OutputAdmin_RichBox.Name = "OutputAdmin_RichBox";
            this.OutputAdmin_RichBox.ReadOnly = true;
            this.OutputAdmin_RichBox.Size = new System.Drawing.Size(563, 360);
            this.OutputAdmin_RichBox.TabIndex = 0;
            this.OutputAdmin_RichBox.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GnrlInformation_Button,
            this.ShowFilesUser_Button,
            this.toolStripSeparator2,
            this.DeleteUser_Button,
            this.BanUser_Button,
            this.NotificationUser_Button,
            this.toolStripSeparator3,
            this.CreateReport_Button,
            this.toolStripSeparator4,
            this.SaveFileInputAdmin_Button,
            this.SaveFileOutputAdmin_Button});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // GnrlInformation_Button
            // 
            this.GnrlInformation_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GnrlInformation_Button.Image = global::ApplicationProject.Properties.Resources.general_users_info;
            this.GnrlInformation_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GnrlInformation_Button.Name = "GnrlInformation_Button";
            this.GnrlInformation_Button.Size = new System.Drawing.Size(23, 22);
            this.GnrlInformation_Button.Text = "Общая информация о пользователе";
            this.GnrlInformation_Button.Click += new System.EventHandler(this.GnrInformation_Menu_Click);
            // 
            // ShowFilesUser_Button
            // 
            this.ShowFilesUser_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ShowFilesUser_Button.Image = global::ApplicationProject.Properties.Resources.showAllFilesUSer;
            this.ShowFilesUser_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowFilesUser_Button.Name = "ShowFilesUser_Button";
            this.ShowFilesUser_Button.Size = new System.Drawing.Size(23, 22);
            this.ShowFilesUser_Button.Text = "Показать файлы выбранного пользователя";
            this.ShowFilesUser_Button.Click += new System.EventHandler(this.ShowFilesUser_Menu_Click);
            // 
            // DeleteUser_Button
            // 
            this.DeleteUser_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteUser_Button.Image = global::ApplicationProject.Properties.Resources.delete_user;
            this.DeleteUser_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteUser_Button.Name = "DeleteUser_Button";
            this.DeleteUser_Button.Size = new System.Drawing.Size(23, 22);
            this.DeleteUser_Button.Text = "Удалить пользователя";
            this.DeleteUser_Button.Click += new System.EventHandler(this.DeleteUser_Menu_Click);
            // 
            // BanUser_Button
            // 
            this.BanUser_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BanUser_Button.Image = global::ApplicationProject.Properties.Resources.ban_user;
            this.BanUser_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BanUser_Button.Name = "BanUser_Button";
            this.BanUser_Button.Size = new System.Drawing.Size(23, 22);
            this.BanUser_Button.Text = "Заблокировать пользователя";
            this.BanUser_Button.Click += new System.EventHandler(this.BanUser_Menu_Click);
            // 
            // NotificationUser_Button
            // 
            this.NotificationUser_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NotificationUser_Button.Image = global::ApplicationProject.Properties.Resources.notification_user;
            this.NotificationUser_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NotificationUser_Button.Name = "NotificationUser_Button";
            this.NotificationUser_Button.Size = new System.Drawing.Size(23, 22);
            this.NotificationUser_Button.Text = "Уведомить пользователя";
            this.NotificationUser_Button.Click += new System.EventHandler(this.NotificationUser_Menu_Click);
            // 
            // CreateReport_Button
            // 
            this.CreateReport_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CreateReport_Button.Image = global::ApplicationProject.Properties.Resources.create_report;
            this.CreateReport_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateReport_Button.Name = "CreateReport_Button";
            this.CreateReport_Button.Size = new System.Drawing.Size(23, 22);
            this.CreateReport_Button.Text = "Создать отчет";
            this.CreateReport_Button.Click += new System.EventHandler(this.CreateReport_Menu_Click);
            // 
            // SaveFileInputAdmin_Button
            // 
            this.SaveFileInputAdmin_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveFileInputAdmin_Button.Image = global::ApplicationProject.Properties.Resources.save_input__output_file_ADMIN;
            this.SaveFileInputAdmin_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveFileInputAdmin_Button.Name = "SaveFileInputAdmin_Button";
            this.SaveFileInputAdmin_Button.Size = new System.Drawing.Size(23, 22);
            this.SaveFileInputAdmin_Button.Text = "Сохранить исходные данные";
            this.SaveFileInputAdmin_Button.Click += new System.EventHandler(this.SaveFileInpurAdmin_Menu_Click);
            // 
            // SaveFileOutputAdmin_Button
            // 
            this.SaveFileOutputAdmin_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveFileOutputAdmin_Button.Image = global::ApplicationProject.Properties.Resources.save_input__output_file_ADMIN;
            this.SaveFileOutputAdmin_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveFileOutputAdmin_Button.Name = "SaveFileOutputAdmin_Button";
            this.SaveFileOutputAdmin_Button.Size = new System.Drawing.Size(23, 22);
            this.SaveFileOutputAdmin_Button.Text = "Сохранить выходные данные";
            this.SaveFileOutputAdmin_Button.Click += new System.EventHandler(this.SaveFileOutputAdmin_Menu_Click);
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.AllUsers_Label);
            this.Controls.Add(this.AllUsers_ListBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "AdminPanelForm";
            this.Text = "Админ панель";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьИнформациюОПользователеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem DeleteUser_Menu;
        private System.Windows.Forms.ToolStripMenuItem BanUser_Menu;
        private System.Windows.Forms.ToolStripMenuItem NotificationUser_Menu;
        private System.Windows.Forms.ListBox AllUsers_ListBox;
        private System.Windows.Forms.ToolStripMenuItem GnrInformation_Menu;
        private System.Windows.Forms.ToolStripMenuItem ShowFilesUser_Menu;
        private System.Windows.Forms.Label AllUsers_Label;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateReport_Menu;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.TabPage TabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton GnrlInformation_Button;
        private System.Windows.Forms.ToolStripButton ShowFilesUser_Button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton DeleteUser_Button;
        private System.Windows.Forms.ToolStripButton BanUser_Button;
        private System.Windows.Forms.ToolStripButton NotificationUser_Button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton CreateReport_Button;
        private System.Windows.Forms.RichTextBox InputAdmin_RichBox;
        private System.Windows.Forms.RichTextBox OutputAdmin_RichBox;
        private System.Windows.Forms.ToolStripMenuItem файлыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFileInpurAdmin_Menu;
        private System.Windows.Forms.ToolStripMenuItem SaveFileOutputAdmin_Menu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton SaveFileInputAdmin_Button;
        private System.Windows.Forms.ToolStripButton SaveFileOutputAdmin_Button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}