using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TheGame
{
    public partial class RegistrationForm : Form
    {
        List<Image> faces = new List<Image>();
        GameStorage storage;
        int pos = 0;
        Image face;
        string nick, login, password;
        string[] faceArr;
        public RegistrationForm()
        {
            InitializeComponent();
        }
        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + @"\Images\faces\";
            faceArr = Directory.GetFiles(path);
            storage = new GameStorage();
            storage.InitAll();
            foreach (string s in faceArr)
            {
                faces.Add(Image.FromFile(s));
            }
            faceAndNamePanel.Visible = true;
            facesBox.Image = faces[0];
        }
        // передвижение формы
        Point lastPoint;
        private void RegistrationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Cursor = Cursors.SizeAll;
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void RegistrationForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void RegistrationForm_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void closeButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
        private void closeButton1_MouseEnter(object sender, EventArgs e)
        {
            closeButton1.ForeColor = Color.FromArgb(126, 6, 6);
        }

        private void closeButton1_MouseLeave(object sender, EventArgs e)
        {
            closeButton1.ForeColor = Color.FromArgb(238, 9, 9);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pos < faces.Count-1)
            {
                pos++;
            }
            else
            {
                pos = 0;
            }
            facesBox.Image = faces[pos];
        }

        private void previousFaceButton_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos--;
            }
            else
            {
                pos = faces.Count-1;
            }
            facesBox.Image = faces[pos];
        }

        private void continueRegistrationButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nickNameField.Text))
            {
                MessageBox.Show("Введите ник персонажа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                face = facesBox.Image;
                nick = nickNameField.Text;
                loginAndPasswordPanel.Visible = true;
            }
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            passwordField.UseSystemPasswordChar = !showPassword.Checked;
            confirmPasswordField.UseSystemPasswordChar = !showPassword.Checked;
        }

        private void createPlayerButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(loginField.Text) || String.IsNullOrEmpty(passwordField.Text) || String.IsNullOrEmpty(confirmPasswordField.Text) || (passwordField.Text != confirmPasswordField.Text))
            {
                MessageBox.Show("Проверьте правильность введенных данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                login = loginField.Text;
                password = passwordField.Text;
                Planet planet = storage.GetPlanetByName("Нал-Хатта");
                Location location = storage.GetLocationByName("Кантина Нал-Хатты");
                Player player = new Player(login, password, face, 0, nick, faceArr[pos], planet, location, 0, 0, false);
                DirectoryInfo directoryInfo = new DirectoryInfo(Environment.CurrentDirectory);
                string path = directoryInfo.Parent.Parent.FullName + @"\Images\Icons\Datapad.png";
                player.Store();
                player.SaveToFile();
                MessageBox.Show("Персонаж успешно создан", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.No;
                storage.Clear();
                Close();
            }
        }
    }
}
