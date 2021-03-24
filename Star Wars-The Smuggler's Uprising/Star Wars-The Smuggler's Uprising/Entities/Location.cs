using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheGame
{
    class Location
    {
        private string _name;
        private Panel _panel;
        public string Name { get => _name; set => _name = value; }
        public Panel Panel { get => _panel; set => _panel = value; }
        public Location(string name, Panel panel)
        {
            _name = name;
            _panel = panel;
        }
    }
}
