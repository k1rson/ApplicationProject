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
            this.label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.LayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.ResetFileName_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.OldFileName_Label = new System.Windows.Forms.Label();
            this.NewFileName_TextBox = new System.Windows.Forms.TextBox();
            this.LayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текущее название файла: ";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 45);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(174, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Введите новое название файла: ";
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
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(98, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "Применить";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.ChangeFileName_Button_Click);
            // 
            // OldFileName_Label
            // 
            this.OldFileName_Label.AutoSize = true;
            this.OldFileName_Label.Location = new System.Drawing.Point(148, 20);
            this.OldFileName_Label.Name = "OldFileName_Label";
            this.OldFileName_Label.Size = new System.Drawing.Size(76, 13);
            this.OldFileName_Label.TabIndex = 3;
            this.OldFileName_Label.Text = "ИМЯ ФАЙЛА";
            // 
            // NewFileName_TextBox
            // 
            this.NewFileName_TextBox.Location = new System.Drawing.Point(188, 42);
            this.NewFileName_TextBox.Name = "NewFileName_TextBox";
            this.NewFileName_TextBox.Size = new System.Drawing.Size(147, 20);
            this.NewFileName_TextBox.TabIndex = 4;
            // 
            // ChangeFileNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 105);
            this.Controls.Add(this.NewFileName_TextBox);
            this.Controls.Add(this.OldFileName_Label);
            this.Controls.Add(this.LayoutPanel);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.FlowLayoutPanel LayoutPanel;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button ResetFileName_Button;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Label OldFileName_Label;
        private System.Windows.Forms.TextBox NewFileName_TextBox;
    }
}