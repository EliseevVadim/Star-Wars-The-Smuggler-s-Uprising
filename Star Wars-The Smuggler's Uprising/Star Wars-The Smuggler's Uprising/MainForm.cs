using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace TheGame
{
    public partial class MainForm : Form
    {
        PictureBox currentBox;
        Card addition;
        Player currentPlayer;
        PazaakOpponent opponent;
        PictureBox[] playerBoxes;
        PictureBox[] compBoxes;
        Deck playersDeck;
        Deck compDeck;
        PazaakGame game;
        GameStorage storage;
        bool needToUpdate = true;
        string currentLine;
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(string current)
        {
            InitializeComponent();
            currentLine = current;
            opponent = new PazaakOpponent(1500000, InitCardsType.SimpleAndFlipp);
            storage = new GameStorage();
            storage.Form = this;
            storage.InitAll();
            string[] mas = current.Split('|');
            Planet planet = storage.GetPlanetByName(mas[5]);
            Location location = storage.GetLocationByName(mas[6]);
            currentPlayer = new Player(mas[1], mas[2], Image.FromFile(mas[4]), uint.Parse(mas[3]), mas[0], mas[4], planet, location, int.Parse(mas[7]), int.Parse(mas[8]), bool.Parse(mas[9]));
            storage.Player = currentPlayer;
            playerBoxes = new PictureBox[9] { PC1, PC2, PC3, PC4, PC5, PC6, PC7, PC8, PC9 };
            compBoxes = new PictureBox[9] { CC1, CC2, CC3, CC4, CC5, CC6, CC7, CC8, CC9 };
            playersDeck = new Deck(playerBoxes);
            compDeck = new Deck(compBoxes);
            game = new PazaakGame(currentPlayer, opponent, playersDeck, compDeck, pazaakPanel);
            WindowState = FormWindowState.Maximized;
            playerNickField.Text = currentPlayer.NickName;
            storage.Clear();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            opponent = new PazaakOpponent(1500000, InitCardsType.SimpleAndFlipp);
            storage.InitAll();
            WindowState = FormWindowState.Maximized;
            string planetName = currentPlayer.GetCurrentPositionNameFromFile(true);
            string locationName = currentPlayer.GetCurrentPositionNameFromFile(false);
            currentPlayer.GetItemsFromFile();
            currentPlayer.Planet = storage.GetPlanetByName(planetName);
            currentPlayer.Location = storage.GetLocationByName(locationName);
            DirectoryInfo directoryInfo = new DirectoryInfo(Environment.CurrentDirectory);
            string path = directoryInfo.Parent.Parent.FullName + @"\Images\Icons\Datapad.png";
            currentPlayer.Credits += 5000;
            MessageBox.Show("Получено 5000 кредитов за вход в игру.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void mainCloseButton_Click(object sender, EventArgs e)
        {
            needToUpdate = false;
            if (MessageBox.Show("Вы действительно хотите выйти?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                currentPlayer.SaveToFile();
                DialogResult = DialogResult.Cancel;
                Close();
            }
            else
            {
                needToUpdate = true;
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    needToUpdate = false;
                    if (MessageBox.Show("Вы действительно хотите выйти?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        currentPlayer.SaveToFile();
                        DialogResult = DialogResult.Cancel;
                        Close();
                    }
                    else
                    {
                        needToUpdate = true;
                    }
                    break;
                case Keys.X:
                    WindowState = FormWindowState.Minimized;
                    break;
                case Keys.F:
                    if(addition is FlippableCard)
                    {
                        FlippableCard card = (FlippableCard)addition;
                        card.Flip();
                        addition = card;
                        currentBox.Image = addition.Image; 
                    }
                    else if(addition is GoldCard)
                    {
                        GoldCard card = (GoldCard)addition;
                        card.ChangeValue();
                        addition = card;
                        currentBox.Image = addition.Image;
                    }
                    break;
                case Keys.C:
                    GameStorage.PlayerBox.Visible = !GameStorage.PlayerBox.Visible;
                    if (GameStorage.PlayerBox.Visible)
                    {
                        GameStorage.PlayerBox.BringToFront();
                    }
                    break;
                case Keys.F1:
                    HelpForm helpForm = new HelpForm();
                    helpForm.Show();
                    break; 
            }
        }

        public void PlayPazaakGame()
        {
            playerCount.Text = 0.ToString();
            playersScore.Text = 0.ToString();
            compCount.Text = 0.ToString();
            opponentsScore.Text = 0.ToString();
            string path = Environment.CurrentDirectory + @"\Images\Cards\cards_02.png";
            needToUpdate = false;
            try
            {
                game.CollectAmount();
            }
            catch
            {
                return;
            }
            try
            {
                game.Start();
            }
            catch
            {
                MessageBox.Show("Не хватает карт!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pazaakPanel.Visible = true;
            needToUpdate = true;
            game.ThrowCardToPlayer();
            playerCount.Text = playersDeck.Sum.ToString();
            pazaakPanel.Update();
            needToUpdate = false;
        }

        private void pazaakPanel_Paint(object sender, PaintEventArgs e)
        {
            if (needToUpdate)
            {
                PictureBox[] phs = { PH1, PH2, PH3, PH4 };
                PictureBox[] chs = { CH1, CH2, CH3, CH4 };
                DirectoryInfo directoryInfo = new DirectoryInfo(Environment.CurrentDirectory);
                //string path = directoryInfo.Parent.Parent.FullName + @"\Images\Cards\cards_01.png";
                string path = Environment.CurrentDirectory + @"\Images\Cards\cards_01.png";
                Image back = Image.FromFile(path);
                playersScore.Text = game.PlayersScore.ToString();
                opponentsScore.Text = game.CompsScore.ToString();
                for (int i = 0; i < currentPlayer.CurrentCards.Length; i++)
                {
                    try
                    {
                        phs[i].Image = currentPlayer.CurrentCards[i].Image;
                    }
                    catch
                    {

                    }
                }
                for (int i = 0; i < 4; i++)
                {
                    phs[i].Cursor = Cursors.Hand;
                    chs[i].Cursor = Cursors.Hand;
                    chs[i].Image = back;
                }
            }
        }
        private void endMoveButton_Click(object sender, EventArgs e)
        {
            if (game.PlayerStands)
            {
                standButton_Click(sender, e);
            }
            else
            {
                if (!game.CompStands)
                {
                    game.CalculateMove();
                    compCount.Text = compDeck.Sum.ToString();
                    game.ThrowCardToPlayer();
                    playerCount.Text = playersDeck.Sum.ToString();
                    needToUpdate = true;
                    pazaakPanel.Update();
                    needToUpdate = false;
                }
                else
                {
                    game.ThrowCardToPlayer();
                    playerCount.Text = playersDeck.Sum.ToString();
                    needToUpdate = true;
                    pazaakPanel.Update();
                    needToUpdate = false;
                }
            }
            if (game.CompStands && game.PlayerStands)
            {
                RestartGame();
            }
        }

        private void RestartGame()
        {
            game.CheckSetWinner();
            if (!game.CheckForGameFinish())
            {
                game.PrepareForTheNewSet();
                playerCount.Text = 0.ToString();
                compCount.Text = 0.ToString();
                needToUpdate = true;
                pazaakPanel.Update();
                needToUpdate = false;
                game.PlayerStands = false;
                game.CompStands = false;
            }
            else
            {
                pazaakPanel.Visible = false;
            }
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            game.PlayerStands = true;
            while (!game.CalculateMove())
            {
                compCount.Text = compDeck.Sum.ToString();
            }
            RestartGame();
        }
        private void PlayersCardClick(object sender, EventArgs e)
        {
            currentBox = (PictureBox)sender;
            int pos = int.Parse(currentBox.Name.Substring(2)) - 1;
            addition = currentPlayer.CurrentCards[pos];
        }
        private void PlayersCardDoubleClick(object sender, EventArgs e)
        {
            if (!game.PlayerStands)
            {
                try
                {
                    addition.AddToDeck(playersDeck);
                    currentBox = (PictureBox)sender;
                    int pos = int.Parse(currentBox.Name.Substring(2)) - 1;
                    currentPlayer.CurrentCards[pos] = null;
                    currentBox.Image = null;
                    playerCount.Text = playersDeck.Sum.ToString();
                    needToUpdate = true;
                    pazaakPanel.Update();
                    needToUpdate = false;
                    game.CalculateMove();
                    compCount.Text = compDeck.Sum.ToString();
                }
                catch (NullReferenceException)
                {

                }
                playerCount.Text = playersDeck.Sum.ToString();
                needToUpdate = true;
                pazaakPanel.Update();
                needToUpdate = false;
            }
            else if (game.PlayerStands && game.CompStands)
            {
                RestartGame();
            }

            if (!game.CompStands)
            {
                game.CalculateMove();
                compCount.Text = compDeck.Sum.ToString();
            }
        }
    }
}
