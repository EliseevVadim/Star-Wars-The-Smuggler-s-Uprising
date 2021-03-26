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
        public QuestItem(string name, string description, uint buyPrice, uint salePrice, string link)
        {
            _name = name;
            _descriprion = description;
            _buyPrice = buyPrice;
            _salePrice = salePrice;
            _link = link;
            _image = Image.FromFile(link);          
        }
        public static string Link { get => link; set => link = value; }

        public override void Store()
        {
            string path = Environment.CurrentDirectory + @"\Players\" + _owner.NickName + @"\items.dat";
            StreamWriter writer = File.AppendText(path);
            writer.WriteLine($"{GetType().Name}|{_name}|{_descriprion}|{_buyPrice}|{_salePrice}|{_link}");
            writer.Close();
        }
    }
}
