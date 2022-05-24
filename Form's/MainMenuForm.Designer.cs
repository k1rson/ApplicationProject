namespace ApplicationProject
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddFile_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteFile_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ActionAddFile_Button = new System.Windows.Forms.ToolStripButton();
            this.ActionDeleteFile_Button = new System.Windows.Forms.ToolStripButton();
            this.UM_Label = new System.Windows.Forms.Label();
            this.AllFiles_ListBox = new System.Windows.Forms.ListBox();
            this.Username_Label = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage_1 = new System.Windows.Forms.TabPage();
            this.TabPage_2 = new System.Windows.Forms.TabPage();
            this.ActiveEncryption_Button = new System.Windows.Forms.Button();
            this.ActionDynamicEdit_Button = new System.Windows.Forms.Button();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveFilePC_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabPage_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлыToolStripMenuItem
            // 
            this.файлыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddFile_Menu,
            this.DeleteFile_Menu,
            this.toolStripSeparator1,
            this.SaveFilePC_Menu});
            this.файлыToolStripMenuItem.Name = "файлыToolStripMenuItem";
            this.файлыToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.файлыToolStripMenuItem.Text = "Файлы";
            // 
            // AddFile_Menu
            // 
            this.AddFile_Menu.Name = "AddFile_Menu";
            this.AddFile_Menu.Size = new System.Drawing.Size(200, 22);
            this.AddFile_Menu.Text = "Добавить файл";
            this.AddFile_Menu.Click += new System.EventHandler(this.AddFile_Menu_Click);
            // 
            // DeleteFile_Menu
            // 
            this.DeleteFile_Menu.Name = "DeleteFile_Menu";
            this.DeleteFile_Menu.Size = new System.Drawing.Size(200, 22);
            this.DeleteFile_Menu.Text = "Удалить файл";
            this.DeleteFile_Menu.Click += new System.EventHandler(this.DeleteFile_Menu_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionAddFile_Button,
            this.ActionDeleteFile_Button,
            this.toolStripSeparator2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ActionAddFile_Button
            // 
            this.ActionAddFile_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ActionAddFile_Button.Image = ((System.Drawing.Image)(resources.GetObject("ActionAddFile_Button.Image")));
            this.ActionAddFile_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActionAddFile_Button.Name = "ActionAddFile_Button";
            this.ActionAddFile_Button.Size = new System.Drawing.Size(23, 22);
            this.ActionAddFile_Button.Text = "toolStripButton1";
            // 
            // ActionDeleteFile_Button
            // 
            this.ActionDeleteFile_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ActionDeleteFile_Button.Image = ((System.Drawing.Image)(resources.GetObject("ActionDeleteFile_Button.Image")));
            this.ActionDeleteFile_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActionDeleteFile_Button.Name = "ActionDeleteFile_Button";
            this.ActionDeleteFile_Button.Size = new System.Drawing.Size(23, 22);
            this.ActionDeleteFile_Button.Text = "toolStripButton2";
            // 
            // UM_Label
            // 
            this.UM_Label.AutoSize = true;
            this.UM_Label.Location = new System.Drawing.Point(564, 9);
            this.UM_Label.Name = "UM_Label";
            this.UM_Label.Size = new System.Drawing.Size(109, 13);
            this.UM_Label.TabIndex = 2;
            this.UM_Label.Text = "Имя пользователя: ";
            // 
            // AllFiles_ListBox
            // 
            this.AllFiles_ListBox.FormattingEnabled = true;
            this.AllFiles_ListBox.Location = new System.Drawing.Point(12, 49);
            this.AllFiles_ListBox.Name = "AllFiles_ListBox";
            this.AllFiles_ListBox.Size = new System.Drawing.Size(197, 368);
            this.AllFiles_ListBox.TabIndex = 4;
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Location = new System.Drawing.Point(675, 9);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(125, 13);
            this.Username_Label.TabIndex = 10;
            this.Username_Label.Text = "ИМЯ ПОЛЬЗОВАТЕЛЯ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPage_1);
            this.tabControl1.Controls.Add(this.TabPage_2);
            this.tabControl1.Location = new System.Drawing.Point(215, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(585, 389);
            this.tabControl1.TabIndex = 11;
            // 
            // TabPage_1
            // 
            this.TabPage_1.Controls.Add(this.ActionDynamicEdit_Button);
            this.TabPage_1.Location = new System.Drawing.Point(4, 22);
            this.TabPage_1.Name = "TabPage_1";
            this.TabPage_1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_1.Size = new System.Drawing.Size(577, 363);
            this.TabPage_1.TabIndex = 0;
            this.TabPage_1.Text = "Содержимое файла";
            this.TabPage_1.UseVisualStyleBackColor = true;
            // 
            // TabPage_2
            // 
            this.TabPage_2.Location = new System.Drawing.Point(4, 22);
            this.TabPage_2.Name = "TabPage_2";
            this.TabPage_2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_2.Size = new System.Drawing.Size(577, 363);
            this.TabPage_2.TabIndex = 1;
            this.TabPage_2.Text = "Зашифрованные данные";
            this.TabPage_2.UseVisualStyleBackColor = true;
            // 
            // ActiveEncryption_Button
            // 
            this.ActiveEncryption_Button.Location = new System.Drawing.Point(648, 422);
            this.ActiveEncryption_Button.Name = "ActiveEncryption_Button";
            this.ActiveEncryption_Button.Size = new System.Drawing.Size(130, 23);
            this.ActiveEncryption_Button.TabIndex = 12;
            this.ActiveEncryption_Button.Text = "Зашифровать";
            this.ActiveEncryption_Button.UseVisualStyleBackColor = true;
            this.ActiveEncryption_Button.Click += new System.EventHandler(this.ActiveEncryption_Button_Click);
            // 
            // ActionDynamicEdit_Button
            // 
            this.ActionDynamicEdit_Button.Location = new System.Drawing.Point(429, 335);
            this.ActionDynamicEdit_Button.Name = "ActionDynamicEdit_Button";
            this.ActionDynamicEdit_Button.Size = new System.Drawing.Size(140, 22);
            this.ActionDynamicEdit_Button.TabIndex = 0;
            this.ActionDynamicEdit_Button.Text = "Редактировать вручную";
            this.ActionDynamicEdit_Button.UseVisualStyleBackColor = true;
            this.ActionDynamicEdit_Button.Click += new System.EventHandler(this.ActionDynamicEdit_Button_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // SaveFilePC_Menu
            // 
            this.SaveFilePC_Menu.Name = "SaveFilePC_Menu";
            this.SaveFilePC_Menu.Size = new System.Drawing.Size(200, 22);
            this.SaveFilePC_Menu.Text = "Сохранить файл на ПК";
            this.SaveFilePC_Menu.Click += new System.EventHandler(this.SaveFilePC_Menu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ActiveEncryption_Button);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Username_Label);
            this.Controls.Add(this.AllFiles_ListBox);
            this.Controls.Add(this.UM_Label);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenuForm";
            this.Text = "Главное меню";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.TabPage_1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddFile_Menu;
        private System.Windows.Forms.ToolStripMenuItem DeleteFile_Menu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ActionAddFile_Button;
        private System.Windows.Forms.ToolStripButton ActionDeleteFile_Button;
        private System.Windows.Forms.Label UM_Label;
        private System.Windows.Forms.ListBox AllFiles_ListBox;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPage_1;
        private System.Windows.Forms.Button ActionDynamicEdit_Button;
        private System.Windows.Forms.TabPage TabPage_2;
        private System.Windows.Forms.Button ActiveEncryption_Button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SaveFilePC_Menu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}