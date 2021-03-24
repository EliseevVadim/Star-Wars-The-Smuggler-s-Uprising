namespace TheGame
{
    partial class GetAmountForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.amountField = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Label();
            this.commitAmountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(130)))), ((int)(((byte)(168)))));
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите вашу ставку";
            // 
            // amountField
            // 
            this.amountField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.amountField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountField.Location = new System.Drawing.Point(127, 51);
            this.amountField.Name = "amountField";
            this.amountField.Size = new System.Drawing.Size(173, 20);
            this.amountField.TabIndex = 1;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.closeButton.Location = new System.Drawing.Point(403, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "X";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // commitAmountButton
            // 
            this.commitAmountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(251)))));
            this.commitAmountButton.FlatAppearance.BorderSize = 0;
            this.commitAmountButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(255)))));
            this.commitAmountButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(252)))));
            this.commitAmountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commitAmountButton.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commitAmountButton.Location = new System.Drawing.Point(101, 105);
            this.commitAmountButton.Name = "commitAmountButton";
            this.commitAmountButton.Size = new System.Drawing.Size(226, 38);
            this.commitAmountButton.TabIndex = 3;
            this.commitAmountButton.Text = "Подтвердить";
            this.commitAmountButton.UseVisualStyleBackColor = false;
            this.commitAmountButton.Click += new System.EventHandler(this.commitAmountButton_Click);
            // 
            // GetAmountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(424, 155);
            this.Controls.Add(this.commitAmountButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.amountField);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GetAmountForm";
            this.Text = "GetAmountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountField;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Button commitAmountButton;
    }
}