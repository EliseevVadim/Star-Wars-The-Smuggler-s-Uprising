using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheGame
{
    class Deck
    {
        private List<Card> _cards;
        private int _sum;
        private int _currentIdx;
        private PictureBox[] _boxes;
        public Deck(PictureBox[] boxes)
        {
            _sum = 0;
            _cards = new List<Card>();
            _boxes = boxes;
            _currentIdx = 0;
        }
        public int CurrentIdx
        {
            set
            {
                _currentIdx = value;
            }
            get
            {
                return _currentIdx;
            }
        }        
        public List<Card> Cards
        {
            set
            {
                _cards = value;
            }
            get
            {
                return _cards;
            }
        }        
        public PictureBox[] Boxes
        {
            set
            {
                _boxes = value;
            }
            get
            {
                return _boxes;
            }
        }
        public int Sum
        {
            set
            {
                _sum = value;
            }
            get
            {
                return _sum;
            }
        }
    }
}
