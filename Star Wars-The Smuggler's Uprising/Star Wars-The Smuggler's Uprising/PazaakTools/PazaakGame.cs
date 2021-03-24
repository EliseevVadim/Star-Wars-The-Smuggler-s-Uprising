using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace TheGame
{
    class PazaakGame
    {
        private Card[] _cards;
        private Player _player;
        private uint _amount;
        private PazaakOpponent _opponent;
        private Deck _playersDeck;
        private Deck _compsDeck;
        private Panel _gamePanel;
        private bool _playerStands;
        private bool _compStands;
        private int _compsScore;
        private int _playersScore;

        public PazaakGame(Player player, PazaakOpponent opponent, Deck pdeck, Deck cdeck, Panel gamePanel)
        {
            _player = player;
            _opponent = opponent;
            _playerStands = false;
            _compStands = false;
            _playersDeck = pdeck;
            _compsDeck = cdeck;
            _gamePanel = gamePanel;
            _cards = new Card[10];
            string path = Environment.CurrentDirectory + @"\Images\Cards\cards_07.png";
            for (int i=0; i<_cards.Length; i++)
            {
                _cards[i] = new Card(i+1, Image.FromFile(path), path);
                _cards[i].UpdateImage();
            }
        }
        public void ThrowCardToPlayer()
        {
            if (_playersDeck.Sum >= 20)
            {
                _playerStands = true;
            }
            if (!_playerStands)
            {
                if (_playersDeck.Sum < 20 && _playersDeck.CurrentIdx<9)
                {
                    Random random = new Random();
                    int pos = random.Next(0, _cards.Length);
                    _cards[pos].AddToDeck(_playersDeck);
                    _gamePanel.Update();
                }
                else 
                {
                    _playerStands = true;
                }
            }
        }
        public bool CalculateMove()
        {
            if (!_compStands)
            {
                ThrowCardToComp();
            }
            if (_compsDeck.Sum == 20 || _compsDeck.CurrentIdx == 9||(_playerStands&&_playersDeck.Sum<_compsDeck.Sum&&_compsDeck.Sum<=20||(_playersDeck.Sum>20&&_compsDeck.Sum<=20)))
            {
                _compStands = true;
            }
            if (!_compStands)
            {
                for (int i = 0; i < _opponent.CurrentCards.Length; i++)
                {
                    try
                    {
                        int nextVal = _opponent.CurrentCards[i].Value + _compsDeck.Sum;
                        if (nextVal == 20 || _compsDeck.Sum == 20)
                        {
                            Thread.Sleep(300);
                            _opponent.CurrentCards[i].AddToDeck(_compsDeck);
                            _opponent.CurrentCards[i] = null;
                            _compStands = true;
                            break;
                        }
                        else if (_playerStands && nextVal >= _playersDeck.Sum && nextVal <= 20)
                        {
                            Thread.Sleep(300);
                            _opponent.CurrentCards[i].AddToDeck(_compsDeck);
                            _opponent.CurrentCards[i] = null;
                            _compStands = true;
                            break;
                        }
                        else if (_compsDeck.Sum > 20)
                        {
                            Thread.Sleep(300);
                            if (_opponent.CurrentCards[i] is FlippableCard)
                            {
                                if (_opponent.CurrentCards[i].Value * -1 + _compsDeck.Sum < 20)
                                {
                                    FlippableCard temp = (FlippableCard)_opponent.CurrentCards[i];
                                    temp.Flip();
                                    temp.AddToDeck(_compsDeck);
                                    _opponent.CurrentCards[i] = null;
                                    break;
                                }
                            }
                            else if (_opponent.CurrentCards[i] is ClassicalCard && _opponent.CurrentCards[i].Value < 0 && _compsDeck.Sum + _opponent.CurrentCards[i].Value < 20)
                            {
                                Thread.Sleep(300);
                                _opponent.CurrentCards[i].AddToDeck(_compsDeck);
                                _opponent.CurrentCards[i] = null;
                                break;
                            }
                            else
                            {
                                _compStands = true;
                                break;
                            }
                        }

                        if (_playerStands)
                        {
                            if (_playersDeck.Sum > 20)
                            {
                                _compStands = true;
                            }
                            else if (_playersDeck.Sum <= 20 && _compsDeck.Sum <= 20 && _compsDeck.Sum > _playersDeck.Sum)
                            {
                                _compStands = true;
                            }
                        }
                        else
                        {
                            if (_compsDeck.Sum > 18)
                            {
                                _compStands = true;
                            }
                        }
                    }
                    catch
                    {

                    }
                }                
            }
            return _compStands && _playerStands;
        }
        public bool CheckForGameFinish()
        {
            if (_playersScore == 3)
            {
                MessageBox.Show($"Поздравляем, Вы победили! Ваш выигрыш: {_amount} кредитов!", "Результат матча", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _player.Credits += _amount;
                _playersScore = 0;
                _compsScore = 0;
                return true;
            }
            else if (_compsScore == 3)
            {
                MessageBox.Show($"Вы проиграли! Вы потеряли: {_amount} кредитов!", "Результат матча", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _player.Credits -= _amount;
                _playersScore = 0;
                _compsScore = 0;
                return true;
            }
            return false;
        }
        public void Start()
        {
            _playerStands = false;
            _compStands = false;
            _player.CurrentCards = InitCurrentCards(true);
            _opponent.CurrentCards = InitCurrentCards(false);
            PrepareForTheNewSet();
        }
        public void PrepareForTheNewSet()
        {
            _compsDeck.Sum = 0;
            _playersDeck.Sum = 0;
            for(int i=0; i<_playersDeck.Boxes.Length; i++)
            {
                _playersDeck.Boxes[i].Image = null;
                _compsDeck.Boxes[i].Image = null;
            }
            _playersDeck.CurrentIdx = 0;
            _compsDeck.CurrentIdx = 0;
        }
        public void CheckSetWinner()
        {
            _gamePanel.Update();
            if ((_playersDeck.Sum==20&&_compsDeck.Sum!=20)||(_playersDeck.Sum<=20&&_compsDeck.Sum>20)||(_compsDeck.Sum<_playersDeck.Sum&&_compsDeck.Sum<20&&_playersDeck.Sum<20))
            {
                _playersScore++;
                MessageBox.Show("Вы выиграли раунд!", "Результат сета", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (_playersDeck.Sum == _compsDeck.Sum||(_playersDeck.Sum>20&&_compsDeck.Sum>20))
            {
                MessageBox.Show("Ничья!", "Результат сета", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _compsScore++;
                MessageBox.Show("Вы проиграли раунд!", "Результат сета", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        private void ThrowCardToComp()
        {
            Thread.Sleep(300);
            Random random = new Random();
            int pos = random.Next(0, _cards.Length);
            _cards[pos].AddToDeck(_compsDeck);
            _gamePanel.Update();
        }
        public Card[] InitCurrentCards(bool toPlayer)
        {
            Random random = new Random();
            if (toPlayer)
            {
                string path = Environment.CurrentDirectory + @"\Images\Cards\cards_03.png";
                for (int i = 0; i < 4; i++)
                {
                    int pos = random.Next(0, _player.Cards.Count);
                    _player.CurrentCards[i] = _player.Cards[pos];
                    _player.Cards.RemoveAt(pos);
                }
                return _player.CurrentCards;
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    _opponent.CurrentCards[i] = _opponent.Cards[random.Next(0, _opponent.Cards.Count)];
                }
                return _opponent.CurrentCards;
            }
        }      
        public void CollectAmount()
        {
            GetAmountForm getAmountForm = new GetAmountForm(_player.Credits);
            if (getAmountForm.ShowDialog() == DialogResult.No)
            {
                _gamePanel.Visible = false;
                throw new Exception();
            }
            else
            {
                _amount = getAmountForm.GetAmount();
            }
        }
        public uint Amount => _amount;
        public bool PlayerStands { get => _playerStands; set => _playerStands = value; }
        public bool CompStands { get => _compStands; set => _compStands = value; }
        public int PlayersScore { get => _playersScore; set => _playersScore = value; }
        public int CompsScore { get => _compsScore; set => _compsScore = value; }
    }
}