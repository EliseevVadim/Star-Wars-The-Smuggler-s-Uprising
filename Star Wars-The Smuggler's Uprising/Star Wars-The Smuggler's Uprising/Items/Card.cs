using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace TheGame
{
    class Card: Item
    {
        protected int _value;
        public int Value { get => _value; set => _value = value; }
        public string Link { get => _link; set => _link = value; }
        public Card(int value, Image image, string link)
        {
            _value = value;
            _image = image;
            _link = link;
        }
        public virtual void UpdateImage()
        {
            Graphics graphics = Graphics.FromImage(_image);
            graphics.DrawString(_value.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.White, _image.Width/2-8, _image.Height/2-14);
        }
        public virtual void AddToDeck(Deck deck)
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
        public override void Store()
        {
            throw new NotImplementedException();
        }
    }
}
