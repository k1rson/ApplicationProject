namespace ApplicationProject
{
    partial class RecycleBinForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecycleBinForm));
            this.RecycleInfo = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.EmptyRecycle_Button = new System.Windows.Forms.Button();
            this.RestoreFile_Button = new System.Windows.Forms.Button();
            this.AllFilesRecycle_ListBox = new System.Windows.Forms.ListBox();
            this.ContextMenuRecycle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ResetFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EmptyFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.IntervalAutoCleaning = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.ContextMenuRecycle.SuspendLayout();
            this.SuspendLayout();
            // 
            // RecycleInfo
            // 
            this.RecycleInfo.AutoSize = true;
            this.RecycleInfo.Location = new System.Drawing.Point(105, 9);
            this.RecycleInfo.Name = "RecycleInfo";
            this.RecycleInfo.Size = new System.Drawing.Size(119, 13);
            this.RecycleInfo.TabIndex = 0;
            this.RecycleInfo.Text = "Содержимое корзины";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Cancel_Button);
            this.flowLayoutPanel1.Controls.Add(this.EmptyRecycle_Button);
            this.flowLayoutPanel1.Controls.Add(this.RestoreFile_Button);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 212);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(333, 31);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(255, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 2;
            this.Cancel_Button.Text = "Вернуться";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // EmptyRecycle_Button
            // 
            this.EmptyRecycle_Button.Location = new System.Drawing.Point(129, 3);
            this.EmptyRecycle_Button.Name = "EmptyRecycle_Button";
            this.EmptyRecycle_Button.Size = new System.Drawing.Size(120, 23);
            this.EmptyRecycle_Button.TabIndex = 1;
            this.EmptyRecycle_Button.Text = "Очистить корзину";
            this.EmptyRecycle_Button.UseVisualStyleBackColor = true;
            this.EmptyRecycle_Button.Click += new System.EventHandler(this.EmptyRecycle_Button_Click);
            // 
            // RestoreFile_Button
            // 
            this.RestoreFile_Button.Location = new System.Drawing.Point(3, 3);
            this.RestoreFile_Button.Name = "RestoreFile_Button";
            this.RestoreFile_Button.Size = new System.Drawing.Size(120, 23);
            this.RestoreFile_Button.TabIndex = 0;
            this.RestoreFile_Button.Text = "Восстановить файл";
            this.RestoreFile_Button.UseVisualStyleBackColor = true;
            this.RestoreFile_Button.Click += new System.EventHandler(this.RestoreFile_Button_Click);
            // 
            // AllFilesRecycle_ListBox
            // 
            this.AllFilesRecycle_ListBox.FormattingEnabled = true;
            this.AllFilesRecycle_ListBox.Location = new System.Drawing.Point(6, 35);
            this.AllFilesRecycle_ListBox.Name = "AllFilesRecycle_ListBox";
            this.AllFilesRecycle_ListBox.Size = new System.Drawing.Size(324, 173);
            this.AllFilesRecycle_ListBox.TabIndex = 2;
            // 
            // ContextMenuRecycle
            // 
            this.ContextMenuRecycle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResetFile,
            this.toolStripSeparator1,
            this.EmptyFiles,
            this.toolStripSeparator2,
            this.IntervalAutoCleaning});
            this.ContextMenuRecycle.Name = "ContextMenuRecycle";
            this.ContextMenuRecycle.Size = new System.Drawing.Size(213, 82);
            // 
            // ResetFile
            // 
            this.ResetFile.Name = "ResetFile";
            this.ResetFile.Size = new System.Drawing.Size(212, 22);
            this.ResetFile.Text = "Восстановить файл";
            this.ResetFile.Click += new System.EventHandler(this.RestoreFile_Button_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(209, 6);
            // 
            // EmptyFiles
            // 
            this.EmptyFiles.Name = "EmptyFiles";
            this.EmptyFiles.Size = new System.Drawing.Size(212, 22);
            this.EmptyFiles.Text = "Очистить корзину";
            this.EmptyFiles.Click += new System.EventHandler(this.EmptyRecycle_Button_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(209, 6);
            // 
            // IntervalAutoCleaning
            // 
            this.IntervalAutoCleaning.Name = "IntervalAutoCleaning";
            this.IntervalAutoCleaning.Size = new System.Drawing.Size(212, 22);
            this.IntervalAutoCleaning.Text = "Интервал автоочищения";
            this.IntervalAutoCleaning.Click += new System.EventHandler(this.IntervalAutoCleaning_Click);
            // 
            // RecycleBinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 243);
            this.Controls.Add(this.AllFilesRecycle_ListBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.RecycleInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RecycleBinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Корзина";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ContextMenuRecycle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RecycleInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button EmptyRecycle_Button;
        private System.Windows.Forms.Button RestoreFile_Button;
        private System.Windows.Forms.ListBox AllFilesRecycle_ListBox;
        private System.Windows.Forms.ContextMenuStrip ContextMenuRecycle;
        private System.Windows.Forms.ToolStripMenuItem ResetFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem EmptyFiles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem IntervalAutoCleaning;
    }
}