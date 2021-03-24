using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace TheGame
{
    class GoldCard: Card
    {
        private GoldType _type;
        private int[] _possibleValues;
        private int _idx;
        
        public GoldCard(int value, Image image, GoldType goldType, string link):base(value, image, link)
        {
            _idx = 0;
            _type = goldType;
            switch (_type)
            {
                case GoldType.PlusMinusOneOrTwo:
                    _possibleValues=new int[] { 1, 2, -1, -2 };                   
                    break;
                case GoldType.TCard:
                    _value = 1;
                    break;
            }
            try
            {
                _value = _possibleValues[_idx];
            }
            catch
            {

            }
            UpdateImage();
        }
        public int[] PossibleValues
        {
            set
            {
                _possibleValues = value;
            }
            get
            {
                return _possibleValues;
            }
        }
        public static GoldType GetGoldTypeFromString(string type)
        {
            switch (type)
            {
                case "DCard":
                    return GoldType.DCard;
                case "TCard":
                    return GoldType.TCard;
                case "PlusMinusOneOrTwo":
                    return GoldType.PlusMinusOneOrTwo;
                case "ThreeAndSix":
                    return GoldType.ThreeAndSix;
                case "TwoAndFour":
                    return GoldType.TwoAndFour;
                default:
                    throw new Exception();
            }
        }
        public override void UpdateImage()
        {
            Graphics graphics = Graphics.FromImage(_image);            
            switch (_type)
            {
                case GoldType.DCard:                   
                    graphics.DrawString("D", new Font("Arial", 12, FontStyle.Bold), Brushes.White, _image.Width / 2 - 8, _image.Height / 2 - 14);
                    break;
                case GoldType.PlusMinusOneOrTwo:
                    graphics.DrawString("+/- 1 or 2", new Font("Arial", 8, FontStyle.Bold), Brushes.White, _image.Width / 2 - 22, _image.Height / 2 - 14);
                    break;
                case GoldType.TCard:
                    graphics.DrawString("+/-1T", new Font("Arial", 12, FontStyle.Bold), Brushes.White, _image.Width / 2 - 22, _image.Height / 2 - 14);
                    break;
                case GoldType.ThreeAndSix:
                    graphics.DrawString("3&6", new Font("Arial", 12, FontStyle.Bold), Brushes.White, _image.Width / 2 - 18, _image.Height / 2 - 14);
                    break;
                case GoldType.TwoAndFour:
                    graphics.DrawString("2&4", new Font("Arial", 12, FontStyle.Bold), Brushes.White, _image.Width / 2 - 18, _image.Height / 2 - 14);
                    break;
            }
        }
        public void ChangeValue()
        {
            switch (_type)
            {
                case GoldType.TCard:
                    _value = -_value;
                    break;
                case GoldType.PlusMinusOneOrTwo:
                    try
                    {
                        _idx++;
                        _value = _possibleValues[_idx];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        _idx = 0;
                        _value = _possibleValues[_idx];
                    }
                    finally
                    {
                        UpdateImage();
                    }
                    break;
            }
        }
        public GoldType Type
        {
            set
            {
                _type = value;
            }
            get
            {
                return _type;
            }
        }
        public override void Store()
        {
            string path = Environment.CurrentDirectory + @"\Players\" + _owner.NickName + @"\items.dat";
            StreamWriter writer = File.AppendText(path);
            writer.WriteLine($"{this.GetType().Name}|{_type.ToString()}|{_link}|{_buyPrice}|{_salePrice}|{_descriprion}");
            writer.Close();
        }
        public override void AddToDeck(Deck deck)
        {
            switch (_type)
            {
                case GoldType.DCard:
                    deck.Sum += deck.Cards[deck.CurrentIdx-1].Value;
                    deck.Cards.Add(this);
                    deck.Boxes[deck.CurrentIdx].Image = _image;
                    deck.CurrentIdx++;
                    break;
                case GoldType.PlusMinusOneOrTwo:
                    deck.Sum += _value;
                    deck.Cards.Add(this);
                    deck.Boxes[deck.CurrentIdx].Image = _image;
                    deck.CurrentIdx++;
                    break;
                case GoldType.TCard:
                    deck.Sum += _value;
                    deck.Cards.Add(this);
                    deck.Boxes[deck.CurrentIdx].Image = _image;
                    deck.CurrentIdx++;
                    break;
                case GoldType.ThreeAndSix:
                    deck.Sum = 0;
                    foreach(Card card in deck.Cards)
                    {
                        if(!(card is ClassicalCard)&&!(card is FlippableCard) && !(card is GoldCard) && card.Value != 3 && card.Value != 6 || card.Value<0)
                        {
                            deck.Sum += card.Value;
                        }
                        else
                        {
                            deck.Sum -= card.Value;
                        }
                    }
                    deck.Cards.Add(this);
                    deck.Boxes[deck.CurrentIdx].Image = _image;
                    deck.CurrentIdx++;
                    break;
                case GoldType.TwoAndFour:
                    deck.Sum = 0;
                    foreach (Card card in deck.Cards)
                    {
                        if (!(card is ClassicalCard) && !(card is FlippableCard) && !(card is GoldCard) && card.Value != 2 && card.Value != 4 || card.Value < 0)
                        {
                            deck.Sum += card.Value;
                        }
                        else
                        {
                            deck.Sum -= card.Value;
                        }
                    }
                    deck.Cards.Add(this);
                    deck.Boxes[deck.CurrentIdx].Image = _image;
                    deck.CurrentIdx++;
                    break;
            }
        }
    }
}