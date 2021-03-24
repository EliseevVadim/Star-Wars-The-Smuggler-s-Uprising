using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TheGame
{
    class LootItem: Item
    {
        private GroupBox _box;
        private int _prestigeValue;
        private int _scoreValue;
        public LootItem(string name, string description, uint buyPrice, uint salePrice, string link, int prestigeValue, int scoreValue)
        {
            _box = new GroupBox();
            _name = name;
            _descriprion = description;
            _buyPrice = buyPrice;
            _salePrice = salePrice;
            _link = link;
            _image = Image.FromFile(link);
            _prestigeValue = prestigeValue;
            _scoreValue = scoreValue;
        }

        public int PrestigeValue { get => _prestigeValue; set => _prestigeValue = value; }
        public int ScoreValue { get => _scoreValue; set => _scoreValue = value; }
        public void Display()
        {
            Label title = new Label();
            title.AutoSize = true;
            title.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(142)))), ((int)(((byte)(17)))));
            title.Location = new System.Drawing.Point(6, 16);
            title.Size = new System.Drawing.Size(229, 22);
            title.TabIndex = 0;
            title.Text = "Вы получили предмет:";
            PictureBox imageHolder = new PictureBox();
            imageHolder.BackgroundImage = _image;
            imageHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            imageHolder.Location = new System.Drawing.Point(54, 51);
            imageHolder.Size = new System.Drawing.Size(138, 122);
            imageHolder.TabIndex = 1;
            imageHolder.TabStop = false;
            Label extractionName = new Label();
            extractionName.AutoSize = true;
            extractionName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            extractionName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(142)))), ((int)(((byte)(17)))));
            extractionName.Location = new System.Drawing.Point(6, 176);
            extractionName.Size = new System.Drawing.Size(173, 22);
            extractionName.TabIndex = 2;
            extractionName.Text = _name;
            Button acceptButton = new Button();
            acceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(184)))), ((int)(((byte)(36)))));
            acceptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            acceptButton.FlatAppearance.BorderSize = 0;
            acceptButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(14)))));
            acceptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(124)))), ((int)(((byte)(25)))));
            acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            acceptButton.Location = new System.Drawing.Point(54, 207);
            acceptButton.Size = new System.Drawing.Size(138, 37);
            acceptButton.TabIndex = 3;
            acceptButton.Text = "OK";
            acceptButton.UseVisualStyleBackColor = false;
            acceptButton.Click += new System.EventHandler(Accept);
            _box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(54)))), ((int)(((byte)(12)))));
            _box.Location = new System.Drawing.Point(481, 214);
            _box.Name = "groupBox1";
            _box.Size = new System.Drawing.Size(242, 259);
            _box.TabIndex = 2;
            _box.TabStop = false;
            if (_prestigeValue > 0)
            {
                _box.Text = "Раскопки Коррибана";
            }
            else
            {
                _box.Text = "Руины Дантуина";
            }
            _box.Parent = _owner.Location.Panel;
            _box.Visible = true;
            _box.Controls.AddRange(new Control[] { imageHolder, acceptButton, extractionName, title });
            _box.BringToFront();
        }
        private void Accept(object sender, EventArgs e)
        {
            _box.Visible = false;
        }
        public override void Store()
        {
            string path = Environment.CurrentDirectory + @"\Players\" + _owner.NickName + @"\items.dat";
            StreamWriter writer = File.AppendText(path);
            writer.WriteLine($"{GetType().Name}|{_name}|{_descriprion}|{_buyPrice}|{_salePrice}|{_link}|{_prestigeValue}|{_scoreValue}");
            writer.Close();
        }
    }
}
