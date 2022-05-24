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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Username_Label = new System.Windows.Forms.Label();
            this.файлыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddFile_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteFile_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.ActionAddFile_Button = new System.Windows.Forms.ToolStripButton();
            this.ActionDeleteFile_Button = new System.Windows.Forms.ToolStripButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionAddFile_Button,
            this.ActionDeleteFile_Button});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Location = new System.Drawing.Point(616, 9);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(103, 13);
            this.Username_Label.TabIndex = 2;
            this.Username_Label.Text = "Имя пользователя";
            // 
            // файлыToolStripMenuItem
            // 
            this.файлыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddFile_Menu,
            this.DeleteFile_Menu});
            this.файлыToolStripMenuItem.Name = "файлыToolStripMenuItem";
            this.файлыToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.файлыToolStripMenuItem.Text = "Файлы";
            // 
            // AddFile_Menu
            // 
            this.AddFile_Menu.Name = "AddFile_Menu";
            this.AddFile_Menu.Size = new System.Drawing.Size(180, 22);
            this.AddFile_Menu.Text = "Добавить файл";
            this.AddFile_Menu.Click += new System.EventHandler(this.AddFile_Menu_Click);
            // 
            // DeleteFile_Menu
            // 
            this.DeleteFile_Menu.Name = "DeleteFile_Menu";
            this.DeleteFile_Menu.Size = new System.Drawing.Size(180, 22);
            this.DeleteFile_Menu.Text = "Удалить файл";
            this.DeleteFile_Menu.Click += new System.EventHandler(this.DeleteFile_Menu_Click);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(56, 237);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "ewewq",
            "sdfsdfsdf",
            "sdfsdf"});
            this.listBox1.Location = new System.Drawing.Point(297, 173);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 4;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Username_Label);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenuForm";
            this.Text = "Главное меню";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}