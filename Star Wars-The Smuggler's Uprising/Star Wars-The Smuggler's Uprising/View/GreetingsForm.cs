using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheGame
{
    public partial class GreetingsForm : Form
    {
        private PrivateFontCollection fonts = new PrivateFontCollection();
        Font myFont;
        public GreetingsForm()
        {
            InitializeComponent();
            FontManager fontManager = new FontManager(Properties.Resources.StarJediRounded_jW3R, fonts, 36);
            myFont = fontManager.GetFont();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void close_button_MouseEnter(object sender, EventArgs e)
        {
            close_button.ForeColor = Color.FromArgb(82, 16, 1);
        }
        private void close_button_MouseLeave(object sender, EventArgs e)
        {
            close_button.ForeColor = Color.Sienna;
        }
        Point lastPoint;
        private void GreetingsForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Cursor = Cursors.SizeAll;
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }

        }

        private void GreetingsForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void GreetingsForm_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void GreetingsForm_Load(object sender, EventArgs e)
        {
            label1.Font = myFont;
            myFont = new Font(fonts.Families[0], 20);
            label2.Font = myFont;
            BackgroundImage = Properties.Resources.GreetingsImage;
        }

        private void autorization_button_Click(object sender, EventArgs e)
        {
            Hide();
            AutorizationForm autorizationForm = new AutorizationForm();
            if (autorizationForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Вы успешно авторизовались!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm mainForm = new MainForm(autorizationForm.GetCurrentPlayer());
                if (mainForm.ShowDialog() == DialogResult.Cancel)
                {
                    Close();
                }
            }
            else
            {
                Show();
            }
            
        }

        private void registration_button_Click(object sender, EventArgs e)
        {
            Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
            Show();
        }
    }
}
