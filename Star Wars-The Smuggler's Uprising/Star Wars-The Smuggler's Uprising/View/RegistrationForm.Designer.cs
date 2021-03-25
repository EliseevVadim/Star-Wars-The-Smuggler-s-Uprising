namespace TheGame
{
    partial class RegistrationForm
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
            this.faceAndNamePanel = new System.Windows.Forms.Panel();
            this.loginAndPasswordPanel = new System.Windows.Forms.Panel();
            this.createPlayerButton = new System.Windows.Forms.Button();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.confirmPasswordField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.close2_button = new System.Windows.Forms.Label();
            this.continueRegistrationButton = new System.Windows.Forms.Button();
            this.closeButton1 = new System.Windows.Forms.Label();
            this.nickNameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.previousFaceButton = new System.Windows.Forms.Button();
            this.nextFaceButton = new System.Windows.Forms.Button();
            this.facesBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.faceAndNamePanel.SuspendLayout();
            this.loginAndPasswordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facesBox)).BeginInit();
            this.SuspendLayout();
            // 
            // faceAndNamePanel
            // 
            this.faceAndNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.faceAndNamePanel.Controls.Add(this.loginAndPasswordPanel);
            this.faceAndNamePanel.Controls.Add(this.continueRegistrationButton);
            this.faceAndNamePanel.Controls.Add(this.closeButton1);
            this.faceAndNamePanel.Controls.Add(this.nickNameField);
            this.faceAndNamePanel.Controls.Add(this.label2);
            this.faceAndNamePanel.Controls.Add(this.previousFaceButton);
            this.faceAndNamePanel.Controls.Add(this.nextFaceButton);
            this.faceAndNamePanel.Controls.Add(this.facesBox);
            this.faceAndNamePanel.Controls.Add(this.label1);
            this.faceAndNamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faceAndNamePanel.Location = new System.Drawing.Point(0, 0);
            this.faceAndNamePanel.Name = "faceAndNamePanel";
            this.faceAndNamePanel.Size = new System.Drawing.Size(682, 463);
            this.faceAndNamePanel.TabIndex = 0;
            this.faceAndNamePanel.Visible = false;
            this.faceAndNamePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegistrationForm_MouseDown);
            this.faceAndNamePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegistrationForm_MouseMove);
            this.faceAndNamePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RegistrationForm_MouseUp);
            // 
            // loginAndPasswordPanel
            // 
            this.loginAndPasswordPanel.Controls.Add(this.createPlayerButton);
            this.loginAndPasswordPanel.Controls.Add(this.showPassword);
            this.loginAndPasswordPanel.Controls.Add(this.confirmPasswordField);
            this.loginAndPasswordPanel.Controls.Add(this.label5);
            this.loginAndPasswordPanel.Controls.Add(this.passwordField);
            this.loginAndPasswordPanel.Controls.Add(this.label4);
            this.loginAndPasswordPanel.Controls.Add(this.loginField);
            this.loginAndPasswordPanel.Controls.Add(this.label3);
            this.loginAndPasswordPanel.Controls.Add(this.close2_button);
            this.loginAndPasswordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginAndPasswordPanel.Location = new System.Drawing.Point(0, 0);
            this.loginAndPasswordPanel.Name = "loginAndPasswordPanel";
            this.loginAndPasswordPanel.Size = new System.Drawing.Size(682, 463);
            this.loginAndPasswordPanel.TabIndex = 8;
            this.loginAndPasswordPanel.Visible = false;
            this.loginAndPasswordPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegistrationForm_MouseDown);
            this.loginAndPasswordPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegistrationForm_MouseMove);
            this.loginAndPasswordPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RegistrationForm_MouseUp);
            // 
            // createPlayerButton
            // 
            this.createPlayerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(157)))), ((int)(((byte)(30)))));
            this.createPlayerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(130)))), ((int)(((byte)(25)))));
            this.createPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(101)))), ((int)(((byte)(20)))));
            this.createPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createPlayerButton.Location = new System.Drawing.Point(244, 407);
            this.createPlayerButton.Name = "createPlayerButton";
            this.createPlayerButton.Size = new System.Drawing.Size(224, 44);
            this.createPlayerButton.TabIndex = 10;
            this.createPlayerButton.Text = "Создать персонажа";
            this.createPlayerButton.UseVisualStyleBackColor = false;
            this.createPlayerButton.Click += new System.EventHandler(this.createPlayerButton_Click);
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Location = new System.Drawing.Point(190, 310);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(114, 17);
            this.showPassword.TabIndex = 9;
            this.showPassword.Text = "Показать пароль";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // confirmPasswordField
            // 
            this.confirmPasswordField.Location = new System.Drawing.Point(190, 279);
            this.confirmPasswordField.Name = "confirmPasswordField";
            this.confirmPasswordField.Size = new System.Drawing.Size(303, 20);
            this.confirmPasswordField.TabIndex = 8;
            this.confirmPasswordField.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(176, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 45);
            this.label5.TabIndex = 7;
            this.label5.Text = "Подтвердите пароль";
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(190, 180);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(303, 20);
            this.passwordField.TabIndex = 6;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(214, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 45);
            this.label4.TabIndex = 5;
            this.label4.Text = "Введите пароль";
            // 
            // loginField
            // 
            this.loginField.Location = new System.Drawing.Point(190, 70);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(303, 20);
            this.loginField.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(223, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "Введите логин";
            // 
            // close2_button
            // 
            this.close2_button.BackColor = System.Drawing.Color.Transparent;
            this.close2_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close2_button.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close2_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.close2_button.Location = new System.Drawing.Point(657, 0);
            this.close2_button.Name = "close2_button";
            this.close2_button.Size = new System.Drawing.Size(25, 25);
            this.close2_button.TabIndex = 2;
            this.close2_button.Text = "X";
            this.close2_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.close2_button.Click += new System.EventHandler(this.closeButton1_Click);
            this.close2_button.MouseEnter += new System.EventHandler(this.closeButton1_MouseEnter);
            this.close2_button.MouseLeave += new System.EventHandler(this.closeButton1_MouseLeave);
            // 
            // continueRegistrationButton
            // 
            this.continueRegistrationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(48)))), ((int)(((byte)(94)))));
            this.continueRegistrationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(41)))), ((int)(((byte)(80)))));
            this.continueRegistrationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(25)))), ((int)(((byte)(49)))));
            this.continueRegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueRegistrationButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.continueRegistrationButton.Location = new System.Drawing.Point(240, 407);
            this.continueRegistrationButton.Name = "continueRegistrationButton";
            this.continueRegistrationButton.Size = new System.Drawing.Size(202, 44);
            this.continueRegistrationButton.TabIndex = 7;
            this.continueRegistrationButton.Text = "Продолжить";
            this.continueRegistrationButton.UseVisualStyleBackColor = false;
            this.continueRegistrationButton.Click += new System.EventHandler(this.continueRegistrationButton_Click);
            // 
            // closeButton1
            // 
            this.closeButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.closeButton1.Location = new System.Drawing.Point(647, 0);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(30, 30);
            this.closeButton1.TabIndex = 6;
            this.closeButton1.Text = "X";
            this.closeButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton1.Click += new System.EventHandler(this.closeButton1_Click);
            this.closeButton1.MouseEnter += new System.EventHandler(this.closeButton1_MouseEnter);
            this.closeButton1.MouseLeave += new System.EventHandler(this.closeButton1_MouseLeave);
            // 
            // nickNameField
            // 
            this.nickNameField.BackColor = System.Drawing.SystemColors.Control;
            this.nickNameField.ForeColor = System.Drawing.SystemColors.MenuText;
            this.nickNameField.Location = new System.Drawing.Point(195, 333);
            this.nickNameField.Name = "nickNameField";
            this.nickNameField.Size = new System.Drawing.Size(292, 20);
            this.nickNameField.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите свой никнейм";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // previousFaceButton
            // 
            this.previousFaceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(129)))), ((int)(((byte)(7)))));
            this.previousFaceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(105)))), ((int)(((byte)(7)))));
            this.previousFaceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(72)))), ((int)(((byte)(5)))));
            this.previousFaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousFaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.previousFaceButton.Location = new System.Drawing.Point(172, 118);
            this.previousFaceButton.Name = "previousFaceButton";
            this.previousFaceButton.Size = new System.Drawing.Size(98, 39);
            this.previousFaceButton.TabIndex = 3;
            this.previousFaceButton.Text = "Пердыдущий";
            this.previousFaceButton.UseVisualStyleBackColor = false;
            this.previousFaceButton.Click += new System.EventHandler(this.previousFaceButton_Click);
            // 
            // nextFaceButton
            // 
            this.nextFaceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(129)))), ((int)(((byte)(7)))));
            this.nextFaceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(105)))), ((int)(((byte)(7)))));
            this.nextFaceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(72)))), ((int)(((byte)(5)))));
            this.nextFaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextFaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextFaceButton.Location = new System.Drawing.Point(412, 118);
            this.nextFaceButton.Name = "nextFaceButton";
            this.nextFaceButton.Size = new System.Drawing.Size(98, 39);
            this.nextFaceButton.TabIndex = 2;
            this.nextFaceButton.Text = "Следующий";
            this.nextFaceButton.UseVisualStyleBackColor = false;
            this.nextFaceButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // facesBox
            // 
            this.facesBox.Location = new System.Drawing.Point(276, 70);
            this.facesBox.Name = "facesBox";
            this.facesBox.Size = new System.Drawing.Size(130, 130);
            this.facesBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.facesBox.TabIndex = 1;
            this.facesBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите свой аватар";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 463);
            this.Controls.Add(this.faceAndNamePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.faceAndNamePanel.ResumeLayout(false);
            this.faceAndNamePanel.PerformLayout();
            this.loginAndPasswordPanel.ResumeLayout(false);
            this.loginAndPasswordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facesBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel faceAndNamePanel;
        private System.Windows.Forms.PictureBox facesBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label closeButton1;
        private System.Windows.Forms.TextBox nickNameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button previousFaceButton;
        private System.Windows.Forms.Button nextFaceButton;
        private System.Windows.Forms.Button continueRegistrationButton;
        private System.Windows.Forms.Panel loginAndPasswordPanel;
        private System.Windows.Forms.Label close2_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox showPassword;
        private System.Windows.Forms.TextBox confirmPasswordField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Button createPlayerButton;
    }
}