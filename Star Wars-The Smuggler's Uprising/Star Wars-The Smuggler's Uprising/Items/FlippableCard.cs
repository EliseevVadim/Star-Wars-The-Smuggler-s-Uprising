using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TheGame
{
    class FlippableCard: Card 
    {
        private static string path1 = Environment.CurrentDirectory + @"\Images\Cards\cards_05.png";
        private static string path2 = Environment.CurrentDirectory + @"\Images\Cards\cards_06.png";
        private static string[] links = { path1, path2 };
        public FlippableCard(int value, Image image, string link) : base(value, image, link)
        {
            UpdateImage();
        }
        public static string[] Links => links;
        public override void Store()
        {
            string path = Environment.CurrentDirectory + @"\Players\" + _owner.NickName + @"\items.dat";
            StreamWriter writer = File.AppendText(path);
            writer.WriteLine($"{this.GetType().Name}|{_value}|{_link}|{_buyPrice}|{_salePrice}|{_descriprion}");
            writer.Close();
        }
        public override void UpdateImage()
        {
            Graphics graphics = Graphics.FromImage(_image);
            if (_value > 0)
            {
                graphics.DrawString("+/-" + _value.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.White, _image.Width / 2 - 14, _image.Height / 2 - 14);
            }
            else
            {
                graphics.DrawString("+/-" + _value.ToString().Substring(1), new Font("Arial", 12, FontStyle.Bold), Brushes.White, _image.Width / 2 - 14, _image.Height / 2 - 14);
            }
        }
        public void Flip()
        {
            _value = -_value;
            
            if (_value<0)
            {
                _image = Image.FromFile(links[1]);
            }
            else
            {
                _image = Image.FromFile(links[0]);
            }
            UpdateImage();
        }
        public override void AddToDeck(Deck deck)
        {
            try
            {
                deck.Sum += _value;
                deck.Cards.Add(this);
                deck.Boxes[deck.CurrentIdx].Image = _image;
                deck.CurrentIdx++;
            }
            catch
            {
                
            }
        }
    }
}
