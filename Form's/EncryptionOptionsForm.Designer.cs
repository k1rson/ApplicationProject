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
            this.Shift_TextBox = new System.Windows.Forms.TextBox();
            this.SelectAlphabet_ComboBox = new System.Windows.Forms.ComboBox();
            this.LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SelectEncyption_ComboBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
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
            // Shift_TextBox
            // 
            this.Shift_TextBox.Location = new System.Drawing.Point(151, 30);
            this.Shift_TextBox.Name = "Shift_TextBox";
            this.Shift_TextBox.Size = new System.Drawing.Size(215, 20);
            this.Shift_TextBox.TabIndex = 4;
            // 
            // SelectAlphabet_ComboBox
            // 
            this.SelectAlphabet_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectAlphabet_ComboBox.FormattingEnabled = true;
            this.SelectAlphabet_ComboBox.Items.AddRange(new object[] {
            "Зашифровать все",
            "Зашифровать только русские буквы",
            "Зашифровать только английские буквы",
            "Зашифровать только символы"});
            this.SelectAlphabet_ComboBox.Location = new System.Drawing.Point(151, 56);
            this.SelectAlphabet_ComboBox.Name = "SelectAlphabet_ComboBox";
            this.SelectAlphabet_ComboBox.Size = new System.Drawing.Size(215, 21);
            this.SelectAlphabet_ComboBox.TabIndex = 7;
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.ColumnCount = 2;
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LayoutPanel.Controls.Add(this.label3, 0, 2);
            this.LayoutPanel.Controls.Add(this.Shift_Label, 0, 1);
            this.LayoutPanel.Controls.Add(this.Shift_TextBox, 1, 1);
            this.LayoutPanel.Controls.Add(this.SelectEncyption_Label, 0, 0);
            this.LayoutPanel.Controls.Add(this.SelectAlphabet_ComboBox, 1, 2);
            this.LayoutPanel.Controls.Add(this.SelectEncyption_ComboBox, 1, 0);
            this.LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.RowCount = 5;
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutPanel.Size = new System.Drawing.Size(369, 189);
            this.LayoutPanel.TabIndex = 8;
            // 
            // SelectEncyption_ComboBox
            // 
            this.SelectEncyption_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectEncyption_ComboBox.FormattingEnabled = true;
            this.SelectEncyption_ComboBox.Items.AddRange(new object[] {
            "Шифр Цезаря",
            "Шифр Виженера"});
            this.SelectEncyption_ComboBox.Location = new System.Drawing.Point(151, 3);
            this.SelectEncyption_ComboBox.Name = "SelectEncyption_ComboBox";
            this.SelectEncyption_ComboBox.Size = new System.Drawing.Size(215, 21);
            this.SelectEncyption_ComboBox.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Cancel_Button);
            this.flowLayoutPanel1.Controls.Add(this.Reset_Button);
            this.flowLayoutPanel1.Controls.Add(this.OK_Button);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 158);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(369, 31);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(276, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(90, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Выйти";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Reset_Button
            // 
            this.Reset_Button.Location = new System.Drawing.Point(179, 3);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(91, 23);
            this.Reset_Button.TabIndex = 2;
            this.Reset_Button.Text = "Сбросить";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(82, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(91, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "Применить";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // EncryptionOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 189);
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
        private System.Windows.Forms.TextBox Shift_TextBox;
        private System.Windows.Forms.ComboBox SelectAlphabet_ComboBox;
        private System.Windows.Forms.TableLayoutPanel LayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.ComboBox SelectEncyption_ComboBox;
    }
}