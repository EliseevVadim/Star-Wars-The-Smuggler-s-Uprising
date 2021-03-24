using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Drawing;

namespace TheGame
{
    class ExchangePoint
    {
        private GroupBox _exchangeBox;
        private List<LootItem> _items;
        private LootPlaceType _type;
        private Player _player;
        public ExchangePoint(LootPlaceType type, Player player)
        {
            _type = type;
            _player = player;
            _exchangeBox = new GroupBox();
            _items = new List<LootItem>();
            switch (type)
            {
                case LootPlaceType.SithTomb:
                    _items.Add(new LootItem("Голокрон ситхов", "Дает возможность проводить раскопки в древней гробнице. Обменивается на очки престижа в Академии Ситхов.", 2500, 500, QuestItem.Link + @"sith-holocron.png", 300, 0));
                    _items.Add(new LootItem("Световой меч ситхов", "Традиционное ситское оружие. Обменивается на очки престижа в Академии ситхов.", 1000, 200, QuestItem.Link + @"red-lightsaber.png", 250, 0));
                    _items.Add(new LootItem("Красный кристалл", "Составная часть светового меча. Обменивается на очки престижа в Академии ситхов.", 300, 60, QuestItem.Link + @"red-crystal.png", 50, 0));
                    _items.Add(new LootItem("Кодекс ситхов", "Мантра, определяющая поведение последователей Ордена ситхов.", 500, 100, QuestItem.Link + @"sith-code.png", 150, 0));
                    break;
                case LootPlaceType.JediRuins:
                    _items.Add(new LootItem("Великий голокрон", "Самый крупный и наиболее мощный из сохранившихся голокронов джедаев с древних времён. Обменивается на очки мудрости в Анклаве джедаев.", 5500, 1100, QuestItem.Link + @"great-holocron.png", 0, 350));
                    _items.Add(new LootItem("Медальон джедаев", "Награда отличившихся приверженцев Ордена джедаев. Позволяет производить раскопки в руинах Дантуина. Обменивается на очки мудрости в Анклаве джедаев.", 2500, 500, QuestItem.Link + @"jedi-medal.png", 0, 200));
                    _items.Add(new LootItem("Световой меч", "Традиционное оружие Ордена джедаев. Обменивается на очки мудрости в Анклаве джедаев.", 1000, 200, QuestItem.Link + @"lightsaber.png", 0, 250));
                    _items.Add(new LootItem("Голокрон джедаев", "Источник знаний, почитаемый в Ордене джедаев. Обменивается на очки мудрости в Анклаве джедаев.", 1500, 300, QuestItem.Link + @"jedi-holocron.png", 0, 150));
                    break;
            }
        }
        public void Display()
        {
            int i;
            Panel panel = new Panel();
            panel.Parent = _exchangeBox;
            panel.AutoScroll = true;
            panel.Dock = DockStyle.Fill;
            panel.Visible = true;
            panel.Location = new Point(3, 16);
            panel.Size = new Size(_exchangeBox.Width, 281);
            panel.BorderStyle = BorderStyle.Fixed3D;
            for (i = 0; i < _items.Count; i++)
            {
                PictureBox box = new PictureBox();
                box.BackColor = Color.Transparent;
                box.Size = new Size(100, 95);
                box.BackgroundImageLayout = ImageLayout.Stretch;
                box.BorderStyle = BorderStyle.FixedSingle;
                box.Location = new Point(0, box.Height * i);
                box.BackgroundImage = _items[i].Image;
                RichTextBox textBox = new RichTextBox();
                if (_type == LootPlaceType.SithTomb)
                {
                    textBox.Size = new Size(panel.Width - box.Width / 2 + 15, box.Width / 2);
                }
                else
                {
                    textBox.Size = new Size(panel.Width - box.Width / 2 + 15, box.Width / 2);
                }
                textBox.Text = _items[i].Descriprion;
                textBox.ReadOnly = true;
                textBox.Location = new Point(box.Width, box.Height * i);
                Button button = new Button();
                button.Location = new Point(box.Width, box.Height * i + textBox.Height);
                if (_type == LootPlaceType.SithTomb)
                {
                    button.Text = "Сдать (" + _items[i].PrestigeValue.ToString() + " очков престижа)";
                }
                else
                {
                    button.Text = "Сдать (" + _items[i].ScoreValue.ToString() + " очков мудрости)";
                }
                button.BackColor = Color.BlueViolet;
                button.Tag = i;
                button.Cursor = Cursors.Hand;
                button.Click += new EventHandler(Deliver);
                button.Size = new Size(textBox.Width, box.Width / 2);               
                panel.Controls.AddRange(new Control[] { box, button, textBox});
            }
            Button closeButton = new Button();
            closeButton.Location = new Point(0, 95 * _items.Count);
            closeButton.Font = new Font("Arial", 12, FontStyle.Bold);
            closeButton.Parent = panel;
            closeButton.Size = new Size(panel.Width, 50);
            closeButton.Dock = DockStyle.Bottom;
            closeButton.Text = "Закрыть";
            closeButton.Cursor = Cursors.Hand;
            closeButton.BackColor = Color.FromArgb(69, 228, 142);
            closeButton.Click += new EventHandler(Hide);
            panel.Controls.Add(closeButton);
            _exchangeBox.BackColor = System.Drawing.Color.Green;
            _exchangeBox.Controls.Add(panel);
            _exchangeBox.Location = new System.Drawing.Point(600, 300);
            _exchangeBox.Name = "groupBox1";
            _exchangeBox.Size = new System.Drawing.Size(289, 300);
            _exchangeBox.TabIndex = 2;
            _exchangeBox.TabStop = false;
            if (_type == LootPlaceType.SithTomb)
            {
                _exchangeBox.Text = "Академия ситхов";
            }
            else
            {
                _exchangeBox.Text = "Анклав джедаев";
            }
            _exchangeBox.BringToFront();
            _exchangeBox.Visible = true;
        }
        private void Deliver(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            CheckConsistion(_player.Items, _items[Convert.ToInt32(button.Tag)]);
        }
        private void CheckConsistion(List<Item> source, LootItem lootItem)
        {
            List<string> lines = new List<string>();
            string line = $"{lootItem.GetType().Name}|{lootItem.Name}|{lootItem.Descriprion}|{lootItem.BuyPrice}|{lootItem.SalePrice}|{lootItem.Link_}|{lootItem.PrestigeValue}|{lootItem.ScoreValue}";
            foreach(Item it in source)
            {
                if (it is ClassicalCard)
                {
                    ClassicalCard card = (ClassicalCard)it;
                    lines.Add($"{card.GetType().Name}|{card.Value}|{card.Link}|{card.BuyPrice}|{card.SalePrice}|{card.Descriprion}");
                }
                else if (it is FlippableCard)
                {
                    FlippableCard card = (FlippableCard)it;
                    lines.Add($"{card.GetType().Name}|{card.Value}|{card.Link}|{card.BuyPrice}|{card.SalePrice}|{card.Descriprion}");
                }
                else if (it is GoldCard)
                {
                    GoldCard card = (GoldCard)it;
                    lines.Add($"{card.GetType().Name}|{card.Value}|{card.Link}|{card.BuyPrice}|{card.SalePrice}|{card.Descriprion}");
                }
                else if (it is QuestItem)
                {
                    QuestItem questItem = (QuestItem)it;
                    lines.Add($"{questItem.GetType().Name}|{questItem.Name}|{questItem.Descriprion}|{questItem.BuyPrice}|{questItem.SalePrice}|{questItem.Link_}");
                }
                else
                {
                    LootItem li = (LootItem)it;
                    lines.Add($"{li.GetType().Name}|{li.Name}|{li.Descriprion}|{li.BuyPrice}|{li.SalePrice}|{lootItem.Link_}|{li.PrestigeValue}|{li.ScoreValue}");
                }
            }
            if (lines.Contains(line))
            {
                LootItem lootItem1 = (LootItem)_player.Items[lines.IndexOf(line)];
                if (lootItem1.PrestigeValue > 0 && lootItem1.ScoreValue == 0)
                {
                    _player.SithPrestige += lootItem1.PrestigeValue;
                    MessageBox.Show($"Получено {lootItem1.PrestigeValue} очков престижа", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    _player.JediScore += lootItem1.ScoreValue;
                    MessageBox.Show($"Получено {lootItem1.ScoreValue} очков мудрости", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }                               
                _player.Items.RemoveAt(lines.IndexOf(line));                
            }
            else
            {
                MessageBox.Show("Предмет отсутствует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Hide(object sender, EventArgs e)
        {
            _exchangeBox.Visible = false;
        }
        public GroupBox ExchangeBox { get => _exchangeBox; set => _exchangeBox = value; }
    }
}
