using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace TheGame
{
    class Player: IStoreable
    {
        private string _login;
        private string _password;
        private string _nickName;
        private Image _face;
        private uint _credits;
        private string _facePath;
        private List<Item> _items;
        private List<Card> _cards;
        private Card[] _currentCards;
        private Planet _planet;
        private bool _finished;
        private int _sithPrestige;
        private int _jediScore;
        private Location location_;
        public List<Card> Cards => _cards;

        public Planet Planet
        {
            set
            {
                try
                {
                    location_.Panel.Visible = false;
                }
                catch
                {

                }
                _planet = value;
                Location = _planet.Locations[0];
            }
            get
            {
                return _planet;
            }
        }
        public Card[] CurrentCards { get => _currentCards; set => _currentCards = value; }
        public uint Credits { get => _credits; set => _credits = value; }
        public string FacePath { get => _facePath; set => _facePath = value; }
        public string Login { get => _login; set => _login = value; }
        public string Password { get => _password; set => _password = value; }
        public string NickName { get => _nickName; set => _nickName = value; }
        public Image Face { get => _face; set => _face = value; }
        public List<Item> Items { get => _items; set => _items = value; }
        public Location Location
        {
            set
            {
                try
                {
                    location_.Panel.Visible = false;
                }
                catch
                {

                }
                location_ = value;
                location_.Panel.Visible = true;
                if (location_.Name != "Космопорт")
                {
                    GameStorage.PlayerBox.Parent = location_.Panel;
                }
            }
            get
            {
                return location_;
            }
        }
        public int SithPrestige { get => _sithPrestige; set => _sithPrestige = value; }
        public int JediScore { get => _jediScore; set => _jediScore = value; }
        public bool Finished { get => _finished; set => _finished = value; }

        public void GetCards()
        {
            foreach (var item in _items)
            {
                if(item is ClassicalCard)
                {
                    ClassicalCard card = (ClassicalCard)item;
                    _cards.Add(card);
                }
                if(item is FlippableCard)
                {
                    FlippableCard card = (FlippableCard)item;
                    _cards.Add(card);
                }
                if(item is GoldCard)
                {
                    GoldCard card = (GoldCard)item;
                    _cards.Add(card);
                }
            }
        }
        public Player(string login, string password, Image face, uint credits, string nick, string fp, Planet currenrtPlanet, Location currentLocation, int sithPrestige, int jediScore, bool finished) {
            _login = login;
            _password = password;
            _face = face;
            _credits = credits;
            _nickName = nick;
            _facePath = fp;
            _cards = new List<Card>();
            _items = new List<Item>();
            _currentCards = new Card[4];
            _planet = currenrtPlanet;
            location_ = currentLocation;
            _sithPrestige = sithPrestige;
            _jediScore = jediScore;
            _finished = finished;
        }
        public void GetItemsFromFile()
        {
            string path = Environment.CurrentDirectory + @"\Players\" + _nickName + @"\items.dat";
            string[] sItems = File.ReadAllLines(path);
            foreach(string line in sItems)
            {
                string[] temp = line.Split('|');
                switch (temp[0])
                {
                    case "ClassicalCard":
                        Card card=new ClassicalCard(int.Parse(temp[1]), Image.FromFile(temp[2]), temp[2]);
                        card.Owner = this;
                        card.Descriprion = temp[5];
                        card.SalePrice = uint.Parse(temp[4]);
                        card.BuyPrice = uint.Parse(temp[3]);
                        _items.Add(card);
                        _cards.Add(card);
                        break;
                    case "FlippableCard":
                        Card flipCard=new FlippableCard(int.Parse(temp[1]), Image.FromFile(temp[2]), temp[2]);
                        flipCard.Owner = this;
                        flipCard.Descriprion = temp[5];
                        flipCard.SalePrice = uint.Parse(temp[4]);
                        flipCard.BuyPrice = uint.Parse(temp[3]);
                        _items.Add(flipCard);
                        _cards.Add(flipCard);
                        break;
                    case "GoldCard":
                        Card goldCard = new GoldCard(0, Image.FromFile(temp[2]), GoldCard.GetGoldTypeFromString(temp[1]), temp[2]);
                        goldCard.Owner = this;
                        _items.Add(goldCard);
                        _cards.Add(goldCard);
                        break;
                    case "QuestItem":
                        QuestItem item = new QuestItem(temp[1], temp[2], uint.Parse(temp[3]), uint.Parse(temp[4]), temp[5]);
                        item.Owner = this;
                        _items.Add(item);
                        break;
                    case "LootItem":
                        LootItem lootItem = new LootItem(temp[1], temp[2], uint.Parse(temp[3]), uint.Parse(temp[4]), temp[5], int.Parse(temp[6]), int.Parse(temp[7]));
                        lootItem.Owner = this;
                        _items.Add(lootItem);
                        break;
                }
            }
        }
        public string GetCurrentPositionNameFromFile(bool planet)
        {
            string path = Environment.CurrentDirectory + @"\Players\Players.dat";
            string[] mas = File.ReadAllLines(path);
            if (planet)
            {

                foreach (string line in mas)
                {
                    string[] temp = line.Split('|');
                    if (temp[0] == _nickName)
                    {
                        return temp[5];
                    }
                }
                throw new Exception();
            }
            else
            {
                foreach (string line in mas)
                {
                    string[] temp = line.Split('|');
                    if (temp[0] == _nickName)
                    {
                        return temp[6];
                    }
                }
                throw new Exception();
            }
        }
        public void Store()
        {
            string path = Environment.CurrentDirectory + @"\Players\";
            DirectoryInfo playersDir = new DirectoryInfo(path);
            playersDir.CreateSubdirectory(_nickName);
            FileStream stream = File.Create(path + _nickName + @"\items.dat");
            stream.Close();
            FileStream fileStream = new FileStream(path + @"Players.dat", FileMode.Append);
            StreamWriter writer = new StreamWriter(fileStream);
            writer.WriteLine($"{_nickName}|{_login}|{_password}|{_credits}|{_facePath}|{_planet.Name}|{location_.Name}|{_sithPrestige}|{_jediScore}|{_finished}");
            writer.Close();
            fileStream.Close();            
        }
        public void SaveToFile()
        {
            string path = Environment.CurrentDirectory + @"\Players\";
            string[] mas = File.ReadAllLines(path + @"Players.dat");
            for(int i=0; i<mas.Length; i++)
            {
                string[] arr=mas[i].Split('|');
                if (arr[0] == _nickName)
                {
                    mas[i] = $"{_nickName}|{_login}|{_password}|{_credits}|{_facePath}|{_planet.Name}|{location_.Name}|{_sithPrestige}|{_jediScore}|{_finished}";
                    break;
                }
            }
            StreamWriter writer = new StreamWriter(path + @"Players.dat");
            foreach(string record in mas)
            {
                writer.WriteLine(record);
            }
            writer.Close();
            path = Environment.CurrentDirectory + @"\Players\";
            if (_items.Count > 0)
            {
                File.Delete(path + _nickName + @"\items.dat");
                foreach (Item item in _items)
                {
                    item.Store();
                }
            }
        }
    }
}