using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TheGame
{
    class Planet
    {
        private string _name;
        private List<Location> _locations;
        private int _travellCost;
        private Image _smallImage;
        private string _description;
        public string Name { get => _name; set => _name = value; }
        public int TravellCost { get => _travellCost; set => _travellCost = value; }
        public List<Location> Locations { get => _locations; set => _locations = value; }
        public Image SmallImage { get => _smallImage; set => _smallImage = value; }
        public string Description { get => _description; set => _description = value; }

        public Planet(string name, int travellCost, Image image, string description)
        {
            _name = name;
            _travellCost = travellCost;
            _smallImage = image;
            _locations = new List<Location>();
            _description = description;
        }

    }
}
