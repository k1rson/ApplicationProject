namespace ApplicationProject
{
    partial class NotificationEmailForm
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
            this.SubjectMessage_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Message_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.AllEmailUsers_ComboBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Cancel_Button);
            this.flowLayoutPanel1.Controls.Add(this.Apply_Button);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 230);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(333, 31);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(255, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 0;
            this.Cancel_Button.Text = "Вернуться";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Apply_Button
            // 
            this.Apply_Button.Location = new System.Drawing.Point(137, 3);
            this.Apply_Button.Name = "Apply_Button";
            this.Apply_Button.Size = new System.Drawing.Size(112, 23);
            this.Apply_Button.TabIndex = 1;
            this.Apply_Button.Text = "Отправить письмо";
            this.Apply_Button.UseVisualStyleBackColor = true;
            this.Apply_Button.Click += new System.EventHandler(this.Apply_Button_Click);
            // 
            // SubjectMessage_TextBox
            // 
            this.SubjectMessage_TextBox.Location = new System.Drawing.Point(160, 42);
            this.SubjectMessage_TextBox.Name = "SubjectMessage_TextBox";
            this.SubjectMessage_TextBox.Size = new System.Drawing.Size(161, 20);
            this.SubjectMessage_TextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите Email получателя: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите тему сообщения: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите текст письма: ";
            // 
            // Message_RichTextBox
            // 
            this.Message_RichTextBox.Location = new System.Drawing.Point(145, 81);
            this.Message_RichTextBox.Name = "Message_RichTextBox";
            this.Message_RichTextBox.Size = new System.Drawing.Size(176, 128);
            this.Message_RichTextBox.TabIndex = 9;
            this.Message_RichTextBox.Text = "";
            // 
            // AllEmailUsers_ComboBox
            // 
            this.AllEmailUsers_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AllEmailUsers_ComboBox.FormattingEnabled = true;
            this.AllEmailUsers_ComboBox.Location = new System.Drawing.Point(160, 12);
            this.AllEmailUsers_ComboBox.Name = "AllEmailUsers_ComboBox";
            this.AllEmailUsers_ComboBox.Size = new System.Drawing.Size(161, 21);
            this.AllEmailUsers_ComboBox.TabIndex = 10;
            // 
            // NotificationEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 261);
            this.Controls.Add(this.AllEmailUsers_ComboBox);
            this.Controls.Add(this.Message_RichTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubjectMessage_TextBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "NotificationEmailForm";
            this.Text = "Рассылка писем";
            this.Activated += new System.EventHandler(this.NotificationEmailForm_Activated);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Apply_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox SubjectMessage_TextBox;
        private System.Windows.Forms.RichTextBox Message_RichTextBox;
        private System.Windows.Forms.ComboBox AllEmailUsers_ComboBox;
    }
}