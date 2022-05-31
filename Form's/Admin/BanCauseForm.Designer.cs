namespace ApplicationProject
{
    partial class BanCauseForm
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
            this.Ban_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.CauseBan = new System.Windows.Forms.Label();
            this.CauseBan_TextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Cancel_Button);
            this.flowLayoutPanel1.Controls.Add(this.Ban_Button);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 81);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(213, 30);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Ban_Button
            // 
            this.Ban_Button.Location = new System.Drawing.Point(10, 3);
            this.Ban_Button.Name = "Ban_Button";
            this.Ban_Button.Size = new System.Drawing.Size(97, 23);
            this.Ban_Button.TabIndex = 0;
            this.Ban_Button.Text = "Заблокировать";
            this.Ban_Button.UseVisualStyleBackColor = true;
            this.Ban_Button.Click += new System.EventHandler(this.Ban_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(113, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(97, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Вернуться";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // CauseBan
            // 
            this.CauseBan.AutoSize = true;
            this.CauseBan.Location = new System.Drawing.Point(28, 21);
            this.CauseBan.Name = "CauseBan";
            this.CauseBan.Size = new System.Drawing.Size(161, 13);
            this.CauseBan.TabIndex = 1;
            this.CauseBan.Text = "Введите причину блокировки: ";
            // 
            // CauseBan_TextBox
            // 
            this.CauseBan_TextBox.Location = new System.Drawing.Point(31, 46);
            this.CauseBan_TextBox.Name = "CauseBan_TextBox";
            this.CauseBan_TextBox.Size = new System.Drawing.Size(149, 20);
            this.CauseBan_TextBox.TabIndex = 2;
            // 
            // BanCauseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 111);
            this.Controls.Add(this.CauseBan_TextBox);
            this.Controls.Add(this.CauseBan);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BanCauseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Причина блокировка";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Ban_Button;
        private System.Windows.Forms.Label CauseBan;
        private System.Windows.Forms.TextBox CauseBan_TextBox;
    }
}