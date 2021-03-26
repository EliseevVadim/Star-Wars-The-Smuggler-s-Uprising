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
        private Image _smallImage;
        private string _description;
        public string Name { get => _name; set => _name = value; }
        public List<Location> Locations { get => _locations; set => _locations = value; }
        public Image SmallImage { get => _smallImage; set => _smallImage = value; }
        public string Description { get => _description; set => _description = value; }

        public Planet(string name, Image image, string description)
        {
            _name = name;
            _smallImage = image;
            _locations = new List<Location>();
            _description = description;
        }
    }
}
