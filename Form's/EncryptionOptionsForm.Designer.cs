namespace ApplicationProject
{
    partial class EncryptionOptionsForm
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
            this.SelectEncyption_Label = new System.Windows.Forms.Label();
            this.Shift_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Alphabet_ComboBox = new System.Windows.Forms.ComboBox();
            this.LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LayoutPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectEncyption_Label
            // 
            this.SelectEncyption_Label.AutoSize = true;
            this.SelectEncyption_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectEncyption_Label.Location = new System.Drawing.Point(3, 0);
            this.SelectEncyption_Label.Name = "SelectEncyption_Label";
            this.SelectEncyption_Label.Size = new System.Drawing.Size(142, 27);
            this.SelectEncyption_Label.TabIndex = 0;
            this.SelectEncyption_Label.Text = "Метод шифрования: ";
            this.SelectEncyption_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Shift_Label
            // 
            this.Shift_Label.AutoSize = true;
            this.Shift_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Shift_Label.Location = new System.Drawing.Point(3, 27);
            this.Shift_Label.Name = "Shift_Label";
            this.Shift_Label.Size = new System.Drawing.Size(142, 26);
            this.Shift_Label.TabIndex = 1;
            this.Shift_Label.Text = "Сдвиг: ";
            this.Shift_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Алфавит для шифрования:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Alphabet_ComboBox
            // 
            this.Alphabet_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Alphabet_ComboBox.FormattingEnabled = true;
            this.Alphabet_ComboBox.Items.AddRange(new object[] {
            "Зашифровать все",
            "Зашифровать только русские буквы",
            "Зашифровать только английские буквы",
            "Зашифровать только символы"});
            this.Alphabet_ComboBox.Location = new System.Drawing.Point(151, 56);
            this.Alphabet_ComboBox.Name = "Alphabet_ComboBox";
            this.Alphabet_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Alphabet_ComboBox.TabIndex = 7;
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.ColumnCount = 3;
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutPanel.Controls.Add(this.label4, 0, 3);
            this.LayoutPanel.Controls.Add(this.textBox1, 1, 3);
            this.LayoutPanel.Controls.Add(this.label3, 0, 2);
            this.LayoutPanel.Controls.Add(this.Shift_Label, 0, 1);
            this.LayoutPanel.Controls.Add(this.textBox2, 1, 1);
            this.LayoutPanel.Controls.Add(this.SelectEncyption_Label, 0, 0);
            this.LayoutPanel.Controls.Add(this.Alphabet_ComboBox, 1, 2);
            this.LayoutPanel.Controls.Add(this.comboBox1, 1, 0);
            this.LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.RowCount = 5;
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutPanel.Size = new System.Drawing.Size(290, 216);
            this.LayoutPanel.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Cancel_Button);
            this.flowLayoutPanel1.Controls.Add(this.Reset_Button);
            this.flowLayoutPanel1.Controls.Add(this.OK_Button);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 185);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(290, 31);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(3, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(91, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "Применить";
            this.OK_Button.UseVisualStyleBackColor = true;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(197, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(90, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Выйти";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // Reset_Button
            // 
            this.Reset_Button.Location = new System.Drawing.Point(100, 3);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(91, 23);
            this.Reset_Button.TabIndex = 2;
            this.Reset_Button.Text = "Сбросить";
            this.Reset_Button.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Шифр Цезаря",
            "Шифр Виженера"});
            this.comboBox1.Location = new System.Drawing.Point(151, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // EncryptionOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 216);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.LayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EncryptionOptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Параметры шифрования";
            this.LayoutPanel.ResumeLayout(false);
            this.LayoutPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SelectEncyption_Label;
        private System.Windows.Forms.Label Shift_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Alphabet_ComboBox;
        private System.Windows.Forms.TableLayoutPanel LayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}