using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace TheGame
{
    class QuestItem: Item
    {
        private static string link = Environment.CurrentDirectory + @"\Images\Icons\";
        private GroupBox infoBox;
        public QuestItem(string name, string description, uint buyPrice, uint salePrice, string link)
        {
            _name = name;
            _descriprion = description;
            _buyPrice = buyPrice;
            _salePrice = salePrice;
            _link = link;
            _image = Image.FromFile(link);
            infoBox = new GroupBox();
            PictureBox imageHolder = new PictureBox();
            imageHolder.BackgroundImage = _image;
            imageHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            imageHolder.Location = new System.Drawing.Point(6, 19);  
            imageHolder.Size = new System.Drawing.Size(100, 95);
            imageHolder.TabIndex = 0;
            imageHolder.TabStop = false;
            Label label1 = new Label();
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(112, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(87, 20);
            label1.TabIndex = 1;
            label1.Text = "Название:";
            Label nameField = new Label();
            nameField.AutoSize = true;
            nameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameField.Location = new System.Drawing.Point(112, 39);
            nameField.Name = "label2";
            nameField.Size = new System.Drawing.Size(90, 20);
            nameField.TabIndex = 2;
            nameField.Text = _name;
            Label label2 = new Label();
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(112, 64);
            label2.Name = "label3";
            label2.Size = new System.Drawing.Size(123, 20);
            label2.TabIndex = 3;
            label2.Text = "Цена продажи:";
            Label priceField = new Label();
            priceField.AutoSize = true;
            priceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            priceField.Location = new System.Drawing.Point(112, 84);
            priceField.Name = "label4";
            priceField.Size = new System.Drawing.Size(113, 20);
            priceField.TabIndex = 4;
            priceField.Text = _salePrice > 0 ? _salePrice.ToString() : "не продается";
            RichTextBox descriptionBox = new RichTextBox();
            descriptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(38)))));
            descriptionBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(196)))), ((int)(((byte)(91)))));
            descriptionBox.Location = new System.Drawing.Point(6, 120);
            descriptionBox.Name = "richTextBox1";
            descriptionBox.Size = new System.Drawing.Size(239, 198);
            descriptionBox.TabIndex = 6;
            descriptionBox.Text = _descriprion;
            Button accepBtutton = new Button();
            accepBtutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(101)))), ((int)(((byte)(37)))));
            accepBtutton.Cursor = System.Windows.Forms.Cursors.Hand;
            accepBtutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(45)))), ((int)(((byte)(17)))));
            accepBtutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(76)))), ((int)(((byte)(29)))));
            accepBtutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            accepBtutton.Location = new System.Drawing.Point(71, 324);
            accepBtutton.Name = "button1";
            accepBtutton.Size = new System.Drawing.Size(107, 34);
            accepBtutton.TabIndex = 5;
            accepBtutton.Text = "OK";
            accepBtutton.UseVisualStyleBackColor = false;
            accepBtutton.Click += new System.EventHandler(Hide);
            infoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(126)))), ((int)(((byte)(46)))));
            infoBox.Controls.Add(label1);
            infoBox.Controls.Add(label2);
            infoBox.Controls.Add(nameField);
            infoBox.Controls.Add(priceField);
            infoBox.Controls.Add(descriptionBox);
            infoBox.Controls.Add(imageHolder);
            infoBox.Controls.Add(accepBtutton);
            infoBox.Location = new System.Drawing.Point(800, 199);
            infoBox.Name = "infoBox";
            infoBox.Size = new System.Drawing.Size(251, 364);
            infoBox.TabIndex = 5;
            infoBox.TabStop = false;
            infoBox.Text = "Информация";
            infoBox.Visible = false;
        }
        public void SetOwner(Player player)
        {
            _owner = player;
            infoBox.Parent = _owner.Location.Panel;
        }
        private void Hide(object sender, EventArgs e)
        {
            infoBox.Visible = false;
        }
        public void Show()
        {
            infoBox.Visible = true;
            infoBox.BringToFront();
        }
        public static string Link { get => link; set => link = value; }
        public GroupBox InfoBox { get => infoBox; set => infoBox = value; }

        public override void Store()
        {
            string path = Environment.CurrentDirectory + @"\Players\" + _owner.NickName + @"\items.dat";
            StreamWriter writer = File.AppendText(path);
            writer.WriteLine($"{GetType().Name}|{_name}|{_descriprion}|{_buyPrice}|{_salePrice}|{_link}");
            writer.Close();
        }
    }
}
