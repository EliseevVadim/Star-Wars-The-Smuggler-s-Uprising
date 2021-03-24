namespace TheGame
{
    partial class AutorizationForm
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
            this.close_button = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.showPasswordBox = new System.Windows.Forms.CheckBox();
            this.startGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.Transparent;
            this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.close_button.Location = new System.Drawing.Point(620, 0);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(25, 25);
            this.close_button.TabIndex = 1;
            this.close_button.Text = "X";
            this.close_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            this.close_button.MouseEnter += new System.EventHandler(this.close_button_MouseEnter);
            this.close_button.MouseLeave += new System.EventHandler(this.close_button_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(165)))), ((int)(((byte)(6)))));
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginField.Location = new System.Drawing.Point(12, 183);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(361, 40);
            this.loginField.TabIndex = 3;
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.Location = new System.Drawing.Point(12, 317);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(361, 35);
            this.passwordField.TabIndex = 4;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(6)))), ((int)(((byte)(17)))));
            this.label2.Location = new System.Drawing.Point(138, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Логин";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(6)))), ((int)(((byte)(17)))));
            this.label3.Location = new System.Drawing.Point(138, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showPasswordBox
            // 
            this.showPasswordBox.AutoSize = true;
            this.showPasswordBox.BackColor = System.Drawing.Color.Transparent;
            this.showPasswordBox.FlatAppearance.BorderSize = 0;
            this.showPasswordBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPasswordBox.Location = new System.Drawing.Point(12, 358);
            this.showPasswordBox.Name = "showPasswordBox";
            this.showPasswordBox.Size = new System.Drawing.Size(111, 17);
            this.showPasswordBox.TabIndex = 7;
            this.showPasswordBox.Text = "Показать пароль";
            this.showPasswordBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showPasswordBox.UseVisualStyleBackColor = false;
            this.showPasswordBox.CheckedChanged += new System.EventHandler(this.showPasswordBox_CheckedChanged);
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(166)))), ((int)(((byte)(105)))));
            this.startGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startGameButton.FlatAppearance.BorderSize = 0;
            this.startGameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(41)))));
            this.startGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(78)))), ((int)(((byte)(49)))));
            this.startGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startGameButton.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startGameButton.Location = new System.Drawing.Point(12, 558);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(340, 56);
            this.startGameButton.TabIndex = 8;
            this.startGameButton.Text = "Начать игру";
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheGame.Properties.Resources.Auth;
            this.ClientSize = new System.Drawing.Size(645, 693);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.showPasswordBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close_button);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(113)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "AutorizationForm";
            this.Text = "AutorizationForm";
            this.Load += new System.EventHandler(this.AutorizationForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AutorizationForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AutorizationForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AutorizationForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AutorizationForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox showPasswordBox;
        private System.Windows.Forms.Button startGameButton;
    }
}