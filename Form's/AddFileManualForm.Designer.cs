namespace ApplicationProject
{
    partial class AddFileManualForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFileManualForm));
            this.FileName_TextBox = new System.Windows.Forms.TextBox();
            this.FileName_Label = new System.Windows.Forms.Label();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileName_TextBox
            // 
            this.FileName_TextBox.Location = new System.Drawing.Point(115, 20);
            this.FileName_TextBox.Name = "FileName_TextBox";
            this.FileName_TextBox.Size = new System.Drawing.Size(158, 20);
            this.FileName_TextBox.TabIndex = 0;
            // 
            // FileName_Label
            // 
            this.FileName_Label.AutoSize = true;
            this.FileName_Label.Location = new System.Drawing.Point(11, 23);
            this.FileName_Label.Name = "FileName_Label";
            this.FileName_Label.Size = new System.Drawing.Size(98, 13);
            this.FileName_Label.TabIndex = 1;
            this.FileName_Label.Text = "Название файла: ";
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(30, 52);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(95, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "Добавить файл";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(162, 52);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Отмена";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // AddFileManualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 86);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.FileName_Label);
            this.Controls.Add(this.FileName_TextBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddFileManualForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление файла вручную";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileName_TextBox;
        private System.Windows.Forms.Label FileName_Label;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Button Cancel_Button;
    }
}