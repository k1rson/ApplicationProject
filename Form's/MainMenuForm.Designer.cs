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
            this.Files_ToolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteFile_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveFilePC_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileInput_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileOutputEncypt_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileOutputDecrypt_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ActionAddFile_Button = new System.Windows.Forms.ToolStripButton();
            this.ActionDeleteFile_Button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveFileInput_Button = new System.Windows.Forms.ToolStripButton();
            this.SaveFileOutputEncypt_Button = new System.Windows.Forms.ToolStripButton();
            this.SaveFileOutputDecrypt_Button = new System.Windows.Forms.ToolStripButton();
            this.UM_Label = new System.Windows.Forms.Label();
            this.AllFiles_ListBox = new System.Windows.Forms.ListBox();
            this.Username_Label = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage_1 = new System.Windows.Forms.TabPage();
            this.Input_RichBox = new System.Windows.Forms.RichTextBox();
            this.TabPage_2 = new System.Windows.Forms.TabPage();
            this.Output_RichBox = new System.Windows.Forms.RichTextBox();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.DecryptedOutput_RichBox = new System.Windows.Forms.RichTextBox();
            this.ActionDynamicEdit_Button = new System.Windows.Forms.Button();
            this.ActiveEncryption_Button = new System.Windows.Forms.Button();
            this.ActiveDecrypt_Button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.AllFiles_Label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabPage_1.SuspendLayout();
            this.TabPage_2.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Files_ToolMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Files_ToolMenu
            // 
            this.Files_ToolMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile_Menu,
            this.DeleteFile_Menu,
            this.toolStripSeparator1,
            this.SaveFilePC_Menu});
            this.Files_ToolMenu.Name = "Files_ToolMenu";
            this.Files_ToolMenu.Size = new System.Drawing.Size(57, 20);
            this.Files_ToolMenu.Text = "Файлы";
            // 
            // OpenFile_Menu
            // 
            this.OpenFile_Menu.Name = "OpenFile_Menu";
            this.OpenFile_Menu.Size = new System.Drawing.Size(200, 22);
            this.OpenFile_Menu.Text = "Добавить файл";
            this.OpenFile_Menu.Click += new System.EventHandler(this.AddFile_Menu_Click);
            // 
            // DeleteFile_Menu
            // 
            this.DeleteFile_Menu.Name = "DeleteFile_Menu";
            this.DeleteFile_Menu.Size = new System.Drawing.Size(200, 22);
            this.DeleteFile_Menu.Text = "Удалить файл";
            this.DeleteFile_Menu.Click += new System.EventHandler(this.DeleteFile_Menu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // SaveFilePC_Menu
            // 
            this.SaveFilePC_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveFileInput_Menu,
            this.SaveFileOutputEncypt_Menu,
            this.SaveFileOutputDecrypt_Menu});
            this.SaveFilePC_Menu.Name = "SaveFilePC_Menu";
            this.SaveFilePC_Menu.Size = new System.Drawing.Size(200, 22);
            this.SaveFilePC_Menu.Text = "Сохранить файл на ПК";
            // 
            // SaveFileInput_Menu
            // 
            this.SaveFileInput_Menu.Name = "SaveFileInput_Menu";
            this.SaveFileInput_Menu.Size = new System.Drawing.Size(281, 22);
            this.SaveFileInput_Menu.Text = "Сохранить исходные данные";
            this.SaveFileInput_Menu.Click += new System.EventHandler(this.SaveFileInput_Menu_Click);
            // 
            // SaveFileOutputEncypt_Menu
            // 
            this.SaveFileOutputEncypt_Menu.Name = "SaveFileOutputEncypt_Menu";
            this.SaveFileOutputEncypt_Menu.Size = new System.Drawing.Size(281, 22);
            this.SaveFileOutputEncypt_Menu.Text = "Сохранить зашифрованные данные";
            this.SaveFileOutputEncypt_Menu.Click += new System.EventHandler(this.SaveFileOutputEncypt_Menu_Click);
            // 
            // SaveFileOutputDecrypt_Menu
            // 
            this.SaveFileOutputDecrypt_Menu.Name = "SaveFileOutputDecrypt_Menu";
            this.SaveFileOutputDecrypt_Menu.Size = new System.Drawing.Size(281, 22);
            this.SaveFileOutputDecrypt_Menu.Text = "Сохранить расшифрованные данные";
            this.SaveFileOutputDecrypt_Menu.Click += new System.EventHandler(this.SaveFileOutputDecrypt_Menu_Click);
            // 
            // ToolStrip
            // 
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionAddFile_Button,
            this.ActionDeleteFile_Button,
            this.toolStripSeparator3,
            this.SaveFileInput_Button,
            this.SaveFileOutputEncypt_Button,
            this.SaveFileOutputDecrypt_Button});
            this.ToolStrip.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(800, 25);
            this.ToolStrip.TabIndex = 1;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // ActionAddFile_Button
            // 
            this.ActionAddFile_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ActionAddFile_Button.Image = ((System.Drawing.Image)(resources.GetObject("ActionAddFile_Button.Image")));
            this.ActionAddFile_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActionAddFile_Button.Name = "ActionAddFile_Button";
            this.ActionAddFile_Button.Size = new System.Drawing.Size(23, 22);
            this.ActionAddFile_Button.Text = "Добавить файл";
            this.ActionAddFile_Button.Click += new System.EventHandler(this.AddFile_Menu_Click);
            // 
            // ActionDeleteFile_Button
            // 
            this.ActionDeleteFile_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ActionDeleteFile_Button.Image = ((System.Drawing.Image)(resources.GetObject("ActionDeleteFile_Button.Image")));
            this.ActionDeleteFile_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActionDeleteFile_Button.Name = "ActionDeleteFile_Button";
            this.ActionDeleteFile_Button.Size = new System.Drawing.Size(23, 22);
            this.ActionDeleteFile_Button.Text = "Удалить файл";
            this.ActionDeleteFile_Button.Click += new System.EventHandler(this.DeleteFile_Menu_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // SaveFileInput_Button
            // 
            this.SaveFileInput_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveFileInput_Button.Image = ((System.Drawing.Image)(resources.GetObject("SaveFileInput_Button.Image")));
            this.SaveFileInput_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveFileInput_Button.Name = "SaveFileInput_Button";
            this.SaveFileInput_Button.Size = new System.Drawing.Size(23, 22);
            this.SaveFileInput_Button.Text = "Сохранить исходный файл";
            this.SaveFileInput_Button.Click += new System.EventHandler(this.SaveFileInput_Menu_Click);
            // 
            // SaveFileOutputEncypt_Button
            // 
            this.SaveFileOutputEncypt_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveFileOutputEncypt_Button.Image = ((System.Drawing.Image)(resources.GetObject("SaveFileOutputEncypt_Button.Image")));
            this.SaveFileOutputEncypt_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveFileOutputEncypt_Button.Name = "SaveFileOutputEncypt_Button";
            this.SaveFileOutputEncypt_Button.Size = new System.Drawing.Size(23, 22);
            this.SaveFileOutputEncypt_Button.Text = "Сохранить зашифрованные данные";
            this.SaveFileOutputEncypt_Button.Click += new System.EventHandler(this.SaveFileOutputEncypt_Menu_Click);
            // 
            // SaveFileOutputDecrypt_Button
            // 
            this.SaveFileOutputDecrypt_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveFileOutputDecrypt_Button.Image = ((System.Drawing.Image)(resources.GetObject("SaveFileOutputDecrypt_Button.Image")));
            this.SaveFileOutputDecrypt_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveFileOutputDecrypt_Button.Name = "SaveFileOutputDecrypt_Button";
            this.SaveFileOutputDecrypt_Button.Size = new System.Drawing.Size(23, 22);
            this.SaveFileOutputDecrypt_Button.Text = "Сохранить расшифрованные данные";
            this.SaveFileOutputDecrypt_Button.Click += new System.EventHandler(this.SaveFileOutputDecrypt_Menu_Click);
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
            this.AllFiles_ListBox.Location = new System.Drawing.Point(12, 75);
            this.AllFiles_ListBox.Name = "AllFiles_ListBox";
            this.AllFiles_ListBox.Size = new System.Drawing.Size(197, 342);
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
            this.tabControl1.Controls.Add(this.TabPage3);
            this.tabControl1.Location = new System.Drawing.Point(215, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(585, 389);
            this.tabControl1.TabIndex = 11;
            // 
            // TabPage_1
            // 
            this.TabPage_1.Controls.Add(this.Input_RichBox);
            this.TabPage_1.Location = new System.Drawing.Point(4, 22);
            this.TabPage_1.Name = "TabPage_1";
            this.TabPage_1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_1.Size = new System.Drawing.Size(577, 363);
            this.TabPage_1.TabIndex = 0;
            this.TabPage_1.Text = "Содержимое файла";
            this.TabPage_1.UseVisualStyleBackColor = true;
            // 
            // Input_RichBox
            // 
            this.Input_RichBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Input_RichBox.Location = new System.Drawing.Point(3, 3);
            this.Input_RichBox.Name = "Input_RichBox";
            this.Input_RichBox.ReadOnly = true;
            this.Input_RichBox.Size = new System.Drawing.Size(571, 357);
            this.Input_RichBox.TabIndex = 1;
            this.Input_RichBox.Text = "";
            // 
            // TabPage_2
            // 
            this.TabPage_2.Controls.Add(this.Output_RichBox);
            this.TabPage_2.Location = new System.Drawing.Point(4, 22);
            this.TabPage_2.Name = "TabPage_2";
            this.TabPage_2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_2.Size = new System.Drawing.Size(577, 363);
            this.TabPage_2.TabIndex = 1;
            this.TabPage_2.Text = "Зашифрованные данные";
            this.TabPage_2.UseVisualStyleBackColor = true;
            // 
            // Output_RichBox
            // 
            this.Output_RichBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Output_RichBox.Location = new System.Drawing.Point(3, 3);
            this.Output_RichBox.Name = "Output_RichBox";
            this.Output_RichBox.ReadOnly = true;
            this.Output_RichBox.Size = new System.Drawing.Size(571, 357);
            this.Output_RichBox.TabIndex = 0;
            this.Output_RichBox.Text = "";
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.DecryptedOutput_RichBox);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(577, 363);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Расшифрованные данные";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // DecryptedOutput_RichBox
            // 
            this.DecryptedOutput_RichBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecryptedOutput_RichBox.Location = new System.Drawing.Point(3, 3);
            this.DecryptedOutput_RichBox.Name = "DecryptedOutput_RichBox";
            this.DecryptedOutput_RichBox.ReadOnly = true;
            this.DecryptedOutput_RichBox.Size = new System.Drawing.Size(571, 357);
            this.DecryptedOutput_RichBox.TabIndex = 0;
            this.DecryptedOutput_RichBox.Text = "";
            // 
            // ActionDynamicEdit_Button
            // 
            this.ActionDynamicEdit_Button.Location = new System.Drawing.Point(356, 423);
            this.ActionDynamicEdit_Button.Name = "ActionDynamicEdit_Button";
            this.ActionDynamicEdit_Button.Size = new System.Drawing.Size(140, 22);
            this.ActionDynamicEdit_Button.TabIndex = 0;
            this.ActionDynamicEdit_Button.Text = "Редактировать вручную";
            this.ActionDynamicEdit_Button.UseVisualStyleBackColor = true;
            this.ActionDynamicEdit_Button.Click += new System.EventHandler(this.ActionDynamicEdit_Button_Click);
            // 
            // ActiveEncryption_Button
            // 
            this.ActiveEncryption_Button.Location = new System.Drawing.Point(502, 422);
            this.ActiveEncryption_Button.Name = "ActiveEncryption_Button";
            this.ActiveEncryption_Button.Size = new System.Drawing.Size(140, 23);
            this.ActiveEncryption_Button.TabIndex = 12;
            this.ActiveEncryption_Button.Text = "Зашифровать";
            this.ActiveEncryption_Button.UseVisualStyleBackColor = true;
            this.ActiveEncryption_Button.Click += new System.EventHandler(this.ActiveEncryption_Button_Click);
            // 
            // ActiveDecrypt_Button
            // 
            this.ActiveDecrypt_Button.Location = new System.Drawing.Point(648, 422);
            this.ActiveDecrypt_Button.Name = "ActiveDecrypt_Button";
            this.ActiveDecrypt_Button.Size = new System.Drawing.Size(140, 23);
            this.ActiveDecrypt_Button.TabIndex = 13;
            this.ActiveDecrypt_Button.Text = "Расшифровать";
            this.ActiveDecrypt_Button.UseVisualStyleBackColor = true;
            this.ActiveDecrypt_Button.Click += new System.EventHandler(this.ActiveDecrypt_Button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AllFiles_Label
            // 
            this.AllFiles_Label.AutoSize = true;
            this.AllFiles_Label.Location = new System.Drawing.Point(72, 55);
            this.AllFiles_Label.Name = "AllFiles_Label";
            this.AllFiles_Label.Size = new System.Drawing.Size(66, 13);
            this.AllFiles_Label.TabIndex = 14;
            this.AllFiles_Label.Text = "Все файлы:";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AllFiles_Label);
            this.Controls.Add(this.ActiveDecrypt_Button);
            this.Controls.Add(this.ActionDynamicEdit_Button);
            this.Controls.Add(this.ActiveEncryption_Button);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Username_Label);
            this.Controls.Add(this.AllFiles_ListBox);
            this.Controls.Add(this.UM_Label);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.TabPage_1.ResumeLayout(false);
            this.TabPage_2.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Files_ToolMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenFile_Menu;
        private System.Windows.Forms.ToolStripMenuItem DeleteFile_Menu;
        private System.Windows.Forms.ToolStrip ToolStrip;
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
        private System.Windows.Forms.TabPage TabPage3;
        private System.Windows.Forms.Button ActiveDecrypt_Button;
        private System.Windows.Forms.RichTextBox Input_RichBox;
        private System.Windows.Forms.RichTextBox Output_RichBox;
        private System.Windows.Forms.RichTextBox DecryptedOutput_RichBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label AllFiles_Label;
        private System.Windows.Forms.ToolStripMenuItem SaveFileInput_Menu;
        private System.Windows.Forms.ToolStripMenuItem SaveFileOutputEncypt_Menu;
        private System.Windows.Forms.ToolStripMenuItem SaveFileOutputDecrypt_Menu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton SaveFileInput_Button;
        private System.Windows.Forms.ToolStripButton SaveFileOutputEncypt_Button;
        private System.Windows.Forms.ToolStripButton SaveFileOutputDecrypt_Button;
    }
}