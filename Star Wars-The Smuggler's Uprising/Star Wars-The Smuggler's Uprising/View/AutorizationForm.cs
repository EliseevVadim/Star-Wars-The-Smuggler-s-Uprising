using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheGame
{
    public partial class AutorizationForm : Form
    {
        string current;
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void AutorizationForm_Load(object sender, EventArgs e)
        {
            passwordField.AutoSize = false;
            passwordField.Size = loginField.Size;
        }
        Point lastPoint;
        private void AutorizationForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void AutorizationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Cursor = Cursors.SizeAll;
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void AutorizationForm_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void close_button_MouseEnter(object sender, EventArgs e)
        {
            close_button.ForeColor = Color.FromArgb(126, 6, 6);
        }

        private void close_button_MouseLeave(object sender, EventArgs e)
        {
            close_button.ForeColor = Color.FromArgb(238, 9, 9);
        }

        private void showPasswordBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordField.UseSystemPasswordChar = !showPasswordBox.Checked;
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + @"\Players\Players.dat";
            Authorizator authorizator = new Authorizator(path);
            if (String.IsNullOrEmpty(loginField.Text) || String.IsNullOrEmpty(passwordField.Text) || !authorizator.IsAuthorized(loginField.Text, passwordField.Text)) 
            {
                MessageBox.Show("Данные введены неверно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                current = authorizator.Current;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        public string GetCurrentPlayer()
        {
            return current;
        }

        private void AutorizationForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                startGameButton_Click(sender, e);
            }
        }
    }
}
