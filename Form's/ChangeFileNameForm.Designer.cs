namespace ApplicationProject
{
    partial class ChangeFileNameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeFileNameForm));
            this.NonOldFileName_Label = new System.Windows.Forms.Label();
            this.NewFileName_Label = new System.Windows.Forms.Label();
            this.LayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.ResetFileName_Button = new System.Windows.Forms.Button();
            this.ChOldFileName_Label = new System.Windows.Forms.Label();
            this.ChFileName_TextBox = new System.Windows.Forms.TextBox();
            this.LayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NonOldFileName_Label
            // 
            this.NonOldFileName_Label.AutoSize = true;
            this.NonOldFileName_Label.Location = new System.Drawing.Point(12, 20);
            this.NonOldFileName_Label.Name = "NonOldFileName_Label";
            this.NonOldFileName_Label.Size = new System.Drawing.Size(144, 13);
            this.NonOldFileName_Label.TabIndex = 0;
            this.NonOldFileName_Label.Text = "Текущее название файла: ";
            // 
            // NewFileName_Label
            // 
            this.NewFileName_Label.AutoSize = true;
            this.NewFileName_Label.Location = new System.Drawing.Point(12, 48);
            this.NewFileName_Label.Name = "NewFileName_Label";
            this.NewFileName_Label.Size = new System.Drawing.Size(174, 13);
            this.NewFileName_Label.TabIndex = 1;
            this.NewFileName_Label.Text = "Введите новое название файла: ";
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.Controls.Add(this.Cancel_Button);
            this.LayoutPanel.Controls.Add(this.ResetFileName_Button);
            this.LayoutPanel.Controls.Add(this.OK_Button);
            this.LayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.LayoutPanel.Location = new System.Drawing.Point(0, 75);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.Size = new System.Drawing.Size(338, 30);
            this.LayoutPanel.TabIndex = 2;
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(98, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "Применить";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(260, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Вернуться обратно";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // ResetFileName_Button
            // 
            this.ResetFileName_Button.Location = new System.Drawing.Point(179, 3);
            this.ResetFileName_Button.Name = "ResetFileName_Button";
            this.ResetFileName_Button.Size = new System.Drawing.Size(75, 23);
            this.ResetFileName_Button.TabIndex = 2;
            this.ResetFileName_Button.Text = "Сбросить";
            this.ResetFileName_Button.UseVisualStyleBackColor = true;
            this.ResetFileName_Button.Click += new System.EventHandler(this.ResetFileName_Button_Click);
            // 
            // ChOldFileName_Label
            // 
            this.ChOldFileName_Label.AutoSize = true;
            this.ChOldFileName_Label.Location = new System.Drawing.Point(162, 20);
            this.ChOldFileName_Label.Name = "ChOldFileName_Label";
            this.ChOldFileName_Label.Size = new System.Drawing.Size(76, 13);
            this.ChOldFileName_Label.TabIndex = 3;
            this.ChOldFileName_Label.Text = "ИМЯ ФАЙЛА";
            // 
            // ChFileName_TextBox
            // 
            this.ChFileName_TextBox.Location = new System.Drawing.Point(192, 48);
            this.ChFileName_TextBox.Name = "ChFileName_TextBox";
            this.ChFileName_TextBox.Size = new System.Drawing.Size(136, 20);
            this.ChFileName_TextBox.TabIndex = 4;
            // 
            // ChangeFileNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 105);
            this.Controls.Add(this.ChFileName_TextBox);
            this.Controls.Add(this.ChOldFileName_Label);
            this.Controls.Add(this.LayoutPanel);
            this.Controls.Add(this.NewFileName_Label);
            this.Controls.Add(this.NonOldFileName_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChangeFileNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение имени файла";
            this.LayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NonOldFileName_Label;
        private System.Windows.Forms.Label NewFileName_Label;
        private System.Windows.Forms.FlowLayoutPanel LayoutPanel;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button ResetFileName_Button;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Label ChOldFileName_Label;
        private System.Windows.Forms.TextBox ChFileName_TextBox;
    }
}