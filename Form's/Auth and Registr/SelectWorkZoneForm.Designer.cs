namespace ApplicationProject
{
    partial class SelectWorkZoneForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectWorkZoneForm));
            this.InfoWZ_Label = new System.Windows.Forms.Label();
            this.GoToAdmin_Button = new System.Windows.Forms.Button();
            this.GoToUser_Button = new System.Windows.Forms.Button();
            this.GoToBack_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoWZ_Label
            // 
            this.InfoWZ_Label.AutoSize = true;
            this.InfoWZ_Label.Location = new System.Drawing.Point(34, 37);
            this.InfoWZ_Label.Name = "InfoWZ_Label";
            this.InfoWZ_Label.Size = new System.Drawing.Size(214, 13);
            this.InfoWZ_Label.TabIndex = 0;
            this.InfoWZ_Label.Text = "К какой рабочей зоне желаете перейти?";
            // 
            // GoToAdmin_Button
            // 
            this.GoToAdmin_Button.Location = new System.Drawing.Point(29, 72);
            this.GoToAdmin_Button.Name = "GoToAdmin_Button";
            this.GoToAdmin_Button.Size = new System.Drawing.Size(117, 23);
            this.GoToAdmin_Button.TabIndex = 1;
            this.GoToAdmin_Button.Text = "Администратор";
            this.GoToAdmin_Button.UseVisualStyleBackColor = true;
            this.GoToAdmin_Button.Click += new System.EventHandler(this.GoToAdmin_Button_Click);
            // 
            // GoToUser_Button
            // 
            this.GoToUser_Button.Location = new System.Drawing.Point(152, 72);
            this.GoToUser_Button.Name = "GoToUser_Button";
            this.GoToUser_Button.Size = new System.Drawing.Size(117, 23);
            this.GoToUser_Button.TabIndex = 2;
            this.GoToUser_Button.Text = "Пользователь";
            this.GoToUser_Button.UseVisualStyleBackColor = true;
            this.GoToUser_Button.Click += new System.EventHandler(this.GoToUser_Button_Click);
            // 
            // GoToBack_Button
            // 
            this.GoToBack_Button.Location = new System.Drawing.Point(84, 118);
            this.GoToBack_Button.Name = "GoToBack_Button";
            this.GoToBack_Button.Size = new System.Drawing.Size(117, 23);
            this.GoToBack_Button.TabIndex = 3;
            this.GoToBack_Button.Text = "Вернуться";
            this.GoToBack_Button.UseVisualStyleBackColor = true;
            this.GoToBack_Button.Click += new System.EventHandler(this.GoToBack_Button_Click);
            // 
            // SelectWorkZoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 167);
            this.Controls.Add(this.GoToBack_Button);
            this.Controls.Add(this.GoToUser_Button);
            this.Controls.Add(this.GoToAdmin_Button);
            this.Controls.Add(this.InfoWZ_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SelectWorkZoneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор рабочей зоны";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoWZ_Label;
        private System.Windows.Forms.Button GoToAdmin_Button;
        private System.Windows.Forms.Button GoToUser_Button;
        private System.Windows.Forms.Button GoToBack_Button;
    }
}