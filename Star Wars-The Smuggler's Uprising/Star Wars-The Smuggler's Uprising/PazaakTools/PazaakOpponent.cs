using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TheGame
{
    class PazaakOpponent
    {
        private InitCardsType _cardsType;
        private List<Card> _cards;
        private int _credits;
        private Card[] _currentCards;
        public PazaakOpponent(int credits, InitCardsType cardsType)
        {
            _cardsType = cardsType;
            _cards = new List<Card>();
            _credits = credits;
            _currentCards = new Card[4];
            InitCards();
        }

        public void InitCards()
        {
            switch (_cardsType)
            {
                case InitCardsType.JustSimple:
                    InitSimpleDeck();
                    break;
                case InitCardsType.All:
                    break;
                case InitCardsType.FlippAndGold:
                    break;
                case InitCardsType.SimpleAndFlipp:
                    InitSimpleDeck();
                    InitFlipDeck();
                    break;
            }
        }

        private void InitSimpleDeck()
        {
            for (int i = -6; i < 7; i++)
            {
                if (i < 0)
                {
                    _cards.Add(new ClassicalCard(i, Image.FromFile(ClassicalCard.Links[1]), ClassicalCard.Links[1]));
                }
                if (i > 0)
                {
                    _cards.Add(new ClassicalCard(i, Image.FromFile(ClassicalCard.Links[0]), ClassicalCard.Links[0]));
                }
            }
        }
        private void InitFlipDeck()
        {
            for(int i=1; i<7; i++)
            {
                _cards.Add(new FlippableCard(i, Image.FromFile(FlippableCard.Links[0]), FlippableCard.Links[0]));
            }
        }
        public int Credits
        {
            set
            {
                _credits = value;
            }
            get
            {
                return _credits;
            }
        }
        public Card[] CurrentCards
        {
            set
            {
                _currentCards = value;
            }
            get
            {
                return _currentCards;
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
    }
}