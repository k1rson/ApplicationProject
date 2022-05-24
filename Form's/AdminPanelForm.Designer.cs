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
            this.AllUsers_ListBox = new System.Windows.Forms.ListBox();
            this.AllUsers_Label = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.InputAdmin_RichBox = new System.Windows.Forms.RichTextBox();
            this.OutputAdmin_RichBox = new System.Windows.Forms.RichTextBox();
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
            this.отчетыToolStripMenuItem});
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
            this.CreateReport_Menu.Size = new System.Drawing.Size(180, 22);
            this.CreateReport_Menu.Text = "Создать отчет";
            this.CreateReport_Menu.Click += new System.EventHandler(this.CreateReport_Menu_Click);
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
            this.TabPage1.Text = "Исходные данные в файле";
            this.TabPage1.UseVisualStyleBackColor = true;
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator3,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Общая информация о пользователе";
            this.toolStripButton1.Click += new System.EventHandler(this.GnrInformation_Menu_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Показать файлы выбранного пользователя";
            this.toolStripButton2.Click += new System.EventHandler(this.ShowFilesUser_Menu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Удалить пользователя";
            this.toolStripButton3.Click += new System.EventHandler(this.DeleteUser_Menu_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Заблокировать пользователя";
            this.toolStripButton4.Click += new System.EventHandler(this.BanUser_Menu_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Уведомить пользователя";
            this.toolStripButton5.Click += new System.EventHandler(this.NotificationUser_Menu_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Создать отчет";
            this.toolStripButton6.Click += new System.EventHandler(this.CreateReport_Menu_Click);
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
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.RichTextBox InputAdmin_RichBox;
        private System.Windows.Forms.RichTextBox OutputAdmin_RichBox;
    }
}