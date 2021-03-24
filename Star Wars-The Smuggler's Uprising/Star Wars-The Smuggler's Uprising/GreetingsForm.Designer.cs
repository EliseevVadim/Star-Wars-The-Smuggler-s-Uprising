namespace TheGame
{
    partial class GreetingsForm
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
            this.registration_button = new System.Windows.Forms.Button();
            this.autorization_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.Transparent;
            this.close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_button.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_button.ForeColor = System.Drawing.Color.Sienna;
            this.close_button.Location = new System.Drawing.Point(489, -1);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(25, 25);
            this.close_button.TabIndex = 0;
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(108)))), ((int)(((byte)(30)))));
            this.label1.Location = new System.Drawing.Point(102, -12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Star Wars";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GreetingsForm_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GreetingsForm_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GreetingsForm_MouseUp);
            // 
            // registration_button
            // 
            this.registration_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.registration_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(166)))), ((int)(((byte)(105)))));
            this.registration_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registration_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.registration_button.FlatAppearance.BorderSize = 0;
            this.registration_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(41)))));
            this.registration_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(78)))), ((int)(((byte)(49)))));
            this.registration_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registration_button.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registration_button.Location = new System.Drawing.Point(127, 520);
            this.registration_button.Name = "registration_button";
            this.registration_button.Size = new System.Drawing.Size(261, 51);
            this.registration_button.TabIndex = 2;
            this.registration_button.Text = "Создание персонажа";
            this.registration_button.UseVisualStyleBackColor = false;
            this.registration_button.Click += new System.EventHandler(this.registration_button_Click);
            // 
            // autorization_button
            // 
            this.autorization_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.autorization_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(166)))), ((int)(((byte)(105)))));
            this.autorization_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autorization_button.FlatAppearance.BorderSize = 0;
            this.autorization_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(41)))));
            this.autorization_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(78)))), ((int)(((byte)(49)))));
            this.autorization_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autorization_button.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autorization_button.Location = new System.Drawing.Point(127, 421);
            this.autorization_button.Name = "autorization_button";
            this.autorization_button.Size = new System.Drawing.Size(261, 51);
            this.autorization_button.TabIndex = 3;
            this.autorization_button.Text = "Авторизация";
            this.autorization_button.UseVisualStyleBackColor = false;
            this.autorization_button.Click += new System.EventHandler(this.autorization_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(151)))), ((int)(((byte)(28)))));
            this.label2.Location = new System.Drawing.Point(91, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Smuggler\'s uprising";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GreetingsForm_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GreetingsForm_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GreetingsForm_MouseUp);
            // 
            // GreetingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.autorization_button);
            this.Controls.Add(this.registration_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close_button);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GreetingsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GreetingsForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GreetingsForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GreetingsForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GreetingsForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registration_button;
        private System.Windows.Forms.Button autorization_button;
        private System.Windows.Forms.Label label2;
    }
}

