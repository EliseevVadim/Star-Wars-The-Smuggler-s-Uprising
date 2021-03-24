using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace TheGame
{
    class Shop
    {
        private List<Item> _items;
        private GroupBox _shopBox;
        private Player _player;
        public Shop(Player player)
        {
            _player = player;
            _shopBox = new GroupBox();
            _shopBox.Visible = false;
            _items = new List<Item>();
        }
        public void InitGoldCardsGoods()
        {
            string link = Environment.CurrentDirectory + @"\Images\Cards\cards_02.png";
            Card card = new GoldCard(0, Image.FromFile(link), GoldType.DCard, link);
            card.Owner = _player;
            card.BuyPrice = 15000;
            card.SalePrice = 3000;
            card.Descriprion = "Удваивает номинал предыдущей карты";
            _items.Add(card);
            card = new GoldCard(0, Image.FromFile(link), GoldType.PlusMinusOneOrTwo, link);
            card.Owner = _player;
            card.BuyPrice = 15000;
            card.SalePrice = 3000;
            card.Descriprion = "Увеличивает или уменьшает значение суммы карт на 1 или 2";
            _items.Add(card);
            card = new GoldCard(0, Image.FromFile(link), GoldType.TCard, link);
            card.Owner = _player;
            card.BuyPrice = 150000;
            card.SalePrice = 30000;
            card.Descriprion = "Увеличивает или уменьшает значение суммы карт на 1. При равном числе очков гарантирует победу";
            _items.Add(card);
            card = new GoldCard(0, Image.FromFile(link), GoldType.ThreeAndSix, link);
            card.Owner = _player;
            card.BuyPrice = 25000;
            card.SalePrice = 5000;
            card.Descriprion = "Меняет все значения 3 и 6 на противоположные";
            _items.Add(card);
            card = new GoldCard(0, Image.FromFile(link), GoldType.TwoAndFour, link);
            card.Owner = _player;
            card.BuyPrice = 25000;
            card.SalePrice = 5000;
            card.Descriprion = "Меняет все значения 2 и 4 на противоположные";
            _items.Add(card);
        }
        public void InitSimpleCardsGoods(bool onlyIncreasable)
        {
            if (onlyIncreasable)
            {
                for (int i = 1; i <= 6; i++)
                {
                    Card card = new ClassicalCard(i, Image.FromFile(ClassicalCard.Links[0]), ClassicalCard.Links[0]);
                    card.BuyPrice = 50;
                    card.SalePrice = 10;
                    card.Descriprion = $"Увеличивает значение суммы карт на {i}";
                    card.Owner = _player;
                    _items.Add(card);
                }
            }
            else
            {
                for (int i = -6; i <= 6; i++)
                {
                    if (i < 0)
                    {
                        Card card = new ClassicalCard(i, Image.FromFile(ClassicalCard.Links[1]), ClassicalCard.Links[1]);
                        card.BuyPrice = 150;
                        card.SalePrice = 30;
                        card.Descriprion = $"Уменьшает значение суммы карт на {-i}";
                        card.Owner = _player;
                        _items.Add(card);
                    }
                    else if (i > 0)
                    {
                        Card card = new ClassicalCard(i, Image.FromFile(ClassicalCard.Links[0]), ClassicalCard.Links[0]);
                        card.BuyPrice = 50;
                        card.SalePrice = 10;
                        card.Owner = _player;
                        card.Descriprion = $"Увеличивает значение суммы карт на {i}";
                        _items.Add(card);
                    }
                }
            }
        }
        public void InitFlippableCardGoods()
        {
            for(int i=1; i<=6; i++)
            {
                Card card = new FlippableCard(i, Image.FromFile(FlippableCard.Links[0]), FlippableCard.Links[0]);
                card.BuyPrice = 2500;
                card.SalePrice = 500;
                card.Descriprion = $"Увеличивает либо уменьшает значение суммы карт на {i}";
                card.Owner = _player;
                _items.Add(card);
            }
        }
        public void Display()
        {
            int i;
            Panel panel = new Panel();
            panel.Parent = _shopBox;
            panel.AutoScroll = true;
            panel.Dock = DockStyle.Fill;
            panel.Visible = true;
            panel.Location = new Point(3, 16);
            panel.Size = new Size(_shopBox.Width, 281);
            panel.BorderStyle = BorderStyle.Fixed3D;
            for(i=0; i<_items.Count; i++)
            {                
                PictureBox box = new PictureBox();
                box.BackColor = Color.Transparent;
                box.Size = new Size(100, 95);
                box.BackgroundImageLayout = ImageLayout.Zoom;
                box.BorderStyle = BorderStyle.FixedSingle;
                box.Location = new Point(0, box.Height * i);
                box.BackgroundImage = _items[i].Image;
                RichTextBox textBox = new RichTextBox();
                textBox.Size = new Size(panel.Width - box.Width/2+15, box.Width / 2);
                textBox.Text = _items[i].Descriprion;
                textBox.ReadOnly = true;
                textBox.Location = new Point(box.Width, box.Height * i);
                Button button = new Button();
                button.Location = new Point(box.Width, box.Height * i + textBox.Height);
                button.Text = "Купить (" + _items[i].BuyPrice.ToString()+ " кредитов)";
                button.BackColor = Color.BlueViolet;
                button.Tag = i;
                button.Cursor = Cursors.Hand;
                button.Click += new EventHandler(Buy);
                button.Size = new Size(textBox.Width / 2, box.Width / 2);
                Button sButton = new Button();
                sButton.Text = "Продать (" + _items[i].SalePrice.ToString() + " кредитов)";
                sButton.Cursor = Cursors.Hand;
                sButton.Tag = i;
                sButton.Click += new EventHandler(Sell);
                sButton.BackColor = Color.BlueViolet;
                sButton.Location = new Point(button.Left + button.Width, button.Top);
                sButton.Size = new Size(button.Width, button.Height);
                panel.Controls.AddRange(new Control[] { box, button, textBox, sButton });
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
            _shopBox.BackColor = System.Drawing.Color.Green;
            _shopBox.Controls.Add(panel);
            _shopBox.Location = new System.Drawing.Point(600, 300);
            _shopBox.Name = "groupBox1";
            _shopBox.Size = new System.Drawing.Size(289, 300);
            _shopBox.TabIndex = 2;
            _shopBox.TabStop = false;
            _shopBox.Text = "Магазин";
            _shopBox.Controls.Add(panel);
            _shopBox.BringToFront();
            _shopBox.Visible = true;
        }
        private void Buy(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Item purchase = _items[Convert.ToInt32(button.Tag)];
            if (_player.Credits >= purchase.BuyPrice)
            {
                _player.Credits -= purchase.BuyPrice;
                purchase.Owner = _player;
                _player.Items.Add(_items[Convert.ToInt32(button.Tag)]);
                MessageBox.Show("Покупка совершена успешно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Не хватает кредитов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Sell(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Item item = _items[Convert.ToInt32(button.Tag)];
            CheckConsistion(_player.Items, item);
        }        
        private void CheckConsistion(List<Item> source, Item item)
        {
            List<string> lines = new List<string>();
            string line=string.Empty;
            if(item is ClassicalCard)
            {
                ClassicalCard card = (ClassicalCard)item;
                line = $"{card.GetType().Name}|{card.Value}|{card.Link}|{card.BuyPrice}|{card.SalePrice}|{card.Descriprion}";
            }
            else if(item is FlippableCard)
            {
                FlippableCard card = (FlippableCard)item;
                line = $"{card.GetType().Name}|{card.Value}|{card.Link}|{card.BuyPrice}|{card.SalePrice}|{card.Descriprion}";
            }
            else if(item is GoldCard)
            {
                GoldCard card = (GoldCard)item;
                line = $"{card.GetType().Name}|{card.Value}|{card.Link}|{card.BuyPrice}|{card.SalePrice}|{card.Descriprion}";
            }
            else if (item is QuestItem)
            {
                QuestItem questItem = (QuestItem)item;
                line = $"{questItem.GetType().Name}|{questItem.Name}|{questItem.Descriprion}|{questItem.BuyPrice}|{questItem.SalePrice}|{questItem.Link_}";
            }
            else
            {
                LootItem lootItem = (LootItem)item;
                line = $"{lootItem.GetType().Name}|{lootItem.Name}|{lootItem.Descriprion}|{lootItem.BuyPrice}|{lootItem.SalePrice}|{lootItem.Link_}|{lootItem.PrestigeValue}|{lootItem.ScoreValue}";            
            }
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
                    LootItem lootItem = (LootItem)it;
                    lines.Add($"{lootItem.GetType().Name}|{lootItem.Name}|{lootItem.Descriprion}|{lootItem.BuyPrice}|{lootItem.SalePrice}|{lootItem.Link_}|{lootItem.PrestigeValue}|{lootItem.ScoreValue}");
                }
            }
            if (lines.Contains(line))
            {
                _player.Credits += _player.Items[lines.IndexOf(line)].SalePrice;
                MessageBox.Show($"Предмет успешно продан. Получено {_player.Items[lines.IndexOf(line)].SalePrice} кредитов", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                _player.Items.RemoveAt(lines.IndexOf(line));
            }
            else
            {
                MessageBox.Show("Предмет отсутствует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Hide(object sender, EventArgs e)
        {
            _player.Cards.Clear();
            _player.GetCards();
            _shopBox.Visible = false;
        }
        public List<Item> Items { get => _items; set => _items = value; }
        public GroupBox ShopBox { get => _shopBox; set => _shopBox = value; }
    }
}
