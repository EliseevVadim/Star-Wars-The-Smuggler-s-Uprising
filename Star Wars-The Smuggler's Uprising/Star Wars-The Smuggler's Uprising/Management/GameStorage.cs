using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TheGame
{
    class GameStorage
    {
        private string _link;
        private List<Planet> _planets;
        private List<Location> _locations;
        private GroupBox _requestBox;
        private Label _infoField;
        private MainForm _form;
        private Player _player;
        private Planet _selectedPlanet;
        private Label _info;
        private static GroupBox _playerBox;
        public MainForm Form { get => _form; set => _form = value; }
        public Player Player 
        {
            set
            {                
                _player = value;
                PictureBox faceBox = new PictureBox();
                faceBox.BackgroundImage = _player.Face;
                faceBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                faceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                faceBox.Location = new System.Drawing.Point(12, 19);
                faceBox.Name = "faceBox";
                faceBox.Size = new System.Drawing.Size(86, 86);
                faceBox.TabIndex = 0;
                faceBox.TabStop = false;
                PictureBox prestigeBox = new PictureBox();
                prestigeBox.BackgroundImageLayout = ImageLayout.Stretch;
                prestigeBox.BackColor = Color.Transparent;
                prestigeBox.BackgroundImage = Image.FromFile(_link + @"Icons\academy.png");
                prestigeBox.Size = new Size(50, 39);
                prestigeBox.Location = new Point(1000, 10);
                prestigeBox.Name = "prestigeBox";
                PictureBox scoreBox = new PictureBox();
                scoreBox.BackgroundImageLayout = ImageLayout.Stretch;
                scoreBox.BackColor = Color.Transparent;
                scoreBox.BackgroundImage = Image.FromFile(_link + @"Icons\jedi.png");
                scoreBox.Size = new Size(39, 39);
                scoreBox.Location = new Point(1005, 58);
                scoreBox.Name = "scoreBox";
                Label prestigeField = new Label();
                prestigeField.AutoSize = true;
                prestigeField.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                prestigeField.Location = new System.Drawing.Point(1080, 20);
                prestigeField.Name = "prestigeField";
                prestigeField.Text = _player.SithPrestige.ToString();
                prestigeField.Size = new System.Drawing.Size(54, 22);
                Label scoreField = new Label();
                scoreField.AutoSize = true;
                scoreField.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                scoreField.Location = new System.Drawing.Point(1080, 70);
                scoreField.Name = "scoreField";
                scoreField.Text = _player.JediScore.ToString();
                scoreField.Size = new System.Drawing.Size(54, 22);
                Label label = new Label();
                label.AutoSize = true;
                label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                label.Location = new System.Drawing.Point(127, 19);
                label.Name = "label1";
                label.Size = new System.Drawing.Size(54, 22);
                label.TabIndex = 1;
                label.Text = "Имя:";
                Label nameField = new Label();
                nameField.AutoSize = true;
                nameField.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                nameField.Location = new System.Drawing.Point(229, 19);
                nameField.Name = "nameField";
                nameField.Size = new System.Drawing.Size(90, 22);
                nameField.TabIndex = 2;
                nameField.Text = _player.NickName;
                PictureBox creditsBox = new PictureBox();
                creditsBox.BackgroundImage = Image.FromFile(_link+@"Icons\credits11.png");
                creditsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                creditsBox.Location = new System.Drawing.Point(131, 44);
                creditsBox.Name = "pictureBox2";
                creditsBox.Size = new System.Drawing.Size(30, 55);
                creditsBox.TabIndex = 5;
                creditsBox.TabStop = false;
                Label creditsField = new Label();
                creditsField.AutoSize = true;
                creditsField.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                creditsField.Location = new System.Drawing.Point(229, 71);
                creditsField.Name = "creditsField";
                creditsField.Size = new System.Drawing.Size(138, 22);
                creditsField.TabIndex = 4;
                creditsField.Text = _player.Credits.ToString();
                Label label1 = new Label();
                label1.AutoSize = true;
                label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                label1.Location = new System.Drawing.Point(567, 16);
                label1.Name = "label2";
                label1.Size = new System.Drawing.Size(96, 22);
                label1.TabIndex = 6;
                label1.Text = "Планета:";
                Label label2 = new Label();
                label2.AutoSize = true;
                label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                label2.Location = new System.Drawing.Point(567, 71);
                label2.Name = "label3";
                label2.Size = new System.Drawing.Size(98, 22);
                label2.TabIndex = 7;
                label2.Text = "Локация:";
                Label planetField = new Label();
                planetField.AutoSize = true;
                planetField.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                planetField.Location = new System.Drawing.Point(719, 16);
                planetField.Name = "planetField";
                planetField.Size = new System.Drawing.Size(115, 22);
                planetField.TabIndex = 8;
                planetField.Text = _player.Planet.Name;
                Label locationField = new Label();
                locationField.AutoSize = true;
                locationField.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                locationField.Location = new System.Drawing.Point(719, 71);
                locationField.Name = "locationField";
                locationField.Size = new System.Drawing.Size(117, 22);
                locationField.TabIndex = 9;
                locationField.Text = _player.Location.Name;
                ToolTip toolTip = new ToolTip();
                PictureBox gloryBox = new PictureBox();
                gloryBox.BackColor = System.Drawing.Color.Transparent;
                gloryBox.BackgroundImage = Image.FromFile(_link + @"Icons\glory-medal.png");
                gloryBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                gloryBox.Cursor = System.Windows.Forms.Cursors.Hand;
                gloryBox.Location = new System.Drawing.Point(1200, 0);
                gloryBox.Name = "pictureBox2";
                gloryBox.Size = new System.Drawing.Size(100, 100);
                gloryBox.TabIndex = 1;
                gloryBox.TabStop = false;
                toolTip.SetToolTip(gloryBox, "Проблема с долгом решена");
                _playerBox = new GroupBox();
                _playerBox.Parent = _player.Location.Panel;
                _playerBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
                _playerBox.Dock = DockStyle.Top;
                _playerBox.Text = "Информация об игроке";
                _playerBox.Controls.AddRange(new Control[] { label, label1, label2, planetField, locationField, creditsBox, creditsField, nameField, faceBox, prestigeBox, scoreBox, prestigeField, scoreField });
                if (_player.Finished)
                {
                    _playerBox.Controls.Add(gloryBox);
                }
                _playerBox.Visible = false;
                _playerBox.TabIndex = 5;
                _playerBox.VisibleChanged += new EventHandler(UpdatePlayerBox);
            }
            get
            {
                return _player;
            }
        }
        private void UpdatePlayerBox(object sender, EventArgs e)
        {
            if (_player.Finished)
            {
                ToolTip toolTip = new ToolTip();
                PictureBox gloryBox = new PictureBox();
                gloryBox.BackColor = System.Drawing.Color.Transparent;
                gloryBox.BackgroundImage = Image.FromFile(_link + @"Icons\glory-medal.png");
                gloryBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                gloryBox.Cursor = System.Windows.Forms.Cursors.Hand;
                gloryBox.Location = new System.Drawing.Point(1200, 0);
                gloryBox.Name = "pictureBox2";
                gloryBox.Size = new System.Drawing.Size(100, 100);
                gloryBox.TabIndex = 1;
                gloryBox.TabStop = false;
                toolTip.SetToolTip(gloryBox, "Проблема с долгом решена");
                _playerBox.Controls.Add(gloryBox);
            }
            foreach(Control control in _playerBox.Controls)
            {
                switch (control.Name)
                {
                    case "locationField":
                        control.Text = _player.Location.Name;
                        break;
                    case "planetField":
                        control.Text = _player.Planet.Name;
                        break;
                    case "creditsField":
                        control.Text = _player.Credits.ToString();
                        break;
                    case "scoreField":
                        control.Text = _player.JediScore.ToString();
                        break;
                    case "prestigeField":
                        control.Text = _player.SithPrestige.ToString();
                        break;
                }
            }
        }
        public static GroupBox PlayerBox { get => _playerBox; set => _playerBox = value; }
        public GameStorage()
        {
            _link = Environment.CurrentDirectory + @"\Images\";
            _planets = new List<Planet>();
            _locations = new List<Location>();
            _info = new Label();
            _info.AutoSize = true;
            _info.BackColor = System.Drawing.Color.Transparent;
            _info.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            _info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(193)))), ((int)(((byte)(96)))));
            _info.Location = new System.Drawing.Point(1019, 727);
            _info.Name = "info";
            _info.Size = new System.Drawing.Size(0, 32);
            _info.TabIndex = 3;
        }
        public void InitAll()
        {
            _planets.Add(new Planet("Коррибан", Image.FromFile(_link + @"Planets\korriban.png"), "Родина чистокровных ситхов и священное место для их Ордена. В древние времена здесь строили гробницы для сильнейших правителей,поскольку планета\nимела сильную ауру Тёмной стороны Силы. После Великой гиперпространственной войны Коррибан был покинут. Позже, в 3958 ДБЯ, здесь была реконструирована\nАкадемия ситхов, и планета стала обитаемой вновь."));
            _planets.Add(new Planet("Нар-Шаддаа", Image.FromFile(_link + @"Planets\nar-shaddaa.png"), "Крупнейшая луна Нал-Хатты, поверхность которой, подобно Корусанту, с 24500 ДБЯ по 26 ПБЯ была покрыта экуменополисом. Однако, в отличие от главной\nгалактической планеты-города Корусанта, Нар-Шаддаа была довольно трущобным миром, с загрязнённой атмосферой, а также с огромным количеством\nпреступников и многих контрабандистов."));
            _planets.Add(new Planet("Татуин", Image.FromFile(_link + @"Planets\tatooine.png"), "Планета Внешнего Кольца, расположенная в отдаленном крае Галактики. Она находится на пересечении многих гиперпространственных маршрутов, а потому многие\nторговцы используют космопорт Мос-Эйсли в качестве пересадочного пункта. Татуин стал пристанищем для различного рода авантюристов — контрабандистов,\nнаёмников, охотников за головами."));
            _planets.Add(new Planet("Дантуин", Image.FromFile(_link + @"Planets\dantooine.png"), "Красивый мир зеленых равнин, тихих рек и чистых озёр. Дантуин значительно отстоял от основных торговых маршрутов Галактики, его население\nбыло незначительным и сильно разбросанным по планете в виде небольших поселений с обширным землевладением. Разумные расы были представлены\nлюдьми-фермерами, а также примитивными племенами дантари."));
            _planets.Add(new Planet("Нал-Хатта", Image.FromFile(_link + @"Planets\hutta.png"), "Планета, находящаяся в системе Й’Тауб Среднего Кольца, которая является столицей Пространства хаттов. На преступном сленге планета называлась «Хаттой».\nЕё спутник Нар-Шаддаа — пристанище пиратов, всевозможных торговцев оружием и контрабандистов."));
            _locations.Add(new Location("Космопорт", CreateSpaceport()));
            _locations.Add(new Location("Кантина Нал-Хатты", CreateHuttasCantina()));
            _locations.Add(new Location("Город Нал-Хатты", CreateHuttasCity()));
            _locations.Add(new Location("Вход в Академию ситхов", CreateSithAcademyEntrance()));
            _locations.Add(new Location("Долины Гробниц", CreateTombsValley()));
            _locations.Add(new Location("Нар-Шаддаа", CreateNarShaddaaCity()));
            _locations.Add(new Location("Мос-Эйсли", CreateMosEisley()));
            _locations.Add(new Location("Фермы Татуина", CreateFarms()));
            _locations.Add(new Location("Анклав джедаев", CreateJediEnclave()));
            _locations.Add(new Location("Руины Дантуина", CreateRuins()));
            _planets[4].Locations.AddRange(new Location[] { _locations[1], _locations[2] });
            _planets[0].Locations.AddRange(new Location[] { _locations[3], _locations[4] });
            _planets[1].Locations.Add(_locations[5]);
            _planets[2].Locations.AddRange(new Location[] { _locations[6], _locations[7] });
            _planets[3].Locations.AddRange(new Location[] { _locations[8], _locations[9] });
        }      
        private Panel CreateRuins()
        {
            PictureBox lootBox = new PictureBox();
            lootBox.BackgroundImage = Image.FromFile(_link + @"Icons\loot.jpg");
            lootBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            lootBox.Cursor = System.Windows.Forms.Cursors.Hand;
            lootBox.Location = new System.Drawing.Point(605, 266);
            lootBox.Name = "lootBox";
            lootBox.Size = new System.Drawing.Size(118, 114);
            lootBox.TabIndex = 0;
            lootBox.TabStop = false;
            lootBox.Tag = "Раскопки в руинах";
            lootBox.Click += new EventHandler(LootPlaceClick);
            lootBox.MouseEnter += new EventHandler(Highligt);
            lootBox.MouseLeave += new EventHandler(LightBack);
            PictureBox quitBox = new PictureBox();
            quitBox.BackColor = System.Drawing.Color.Transparent;
            quitBox.BackgroundImage = Image.FromFile(_link + @"Icons\Стрелка.png");
            quitBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            quitBox.Cursor = System.Windows.Forms.Cursors.Hand;
            quitBox.Location = new System.Drawing.Point(1177, 639);
            quitBox.Name = "quitBox";
            quitBox.Size = new System.Drawing.Size(171, 50);
            quitBox.TabIndex = 1;
            quitBox.TabStop = false;
            quitBox.Tag = "Древние руины";
            quitBox.MouseEnter += new EventHandler(Highligt);
            quitBox.MouseLeave += new EventHandler(LightBack);
            quitBox.Click += new EventHandler(GoBack);
            Panel panel = new Panel();
            panel.Parent = MainForm.ActiveForm;
            panel.Visible = false;
            panel.Controls.AddRange(new Control[] { _info, quitBox, lootBox });
            panel.BackColor = System.Drawing.Color.Transparent;
            panel.BackgroundImage = Image.FromFile(_link + @"Locations\ruins.jpg");
            panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel.Dock = System.Windows.Forms.DockStyle.Fill;
            panel.Location = new System.Drawing.Point(0, 0);
            panel.Size = new System.Drawing.Size(1360, 768);
            panel.TabIndex = 0;
            return panel;
        }
        private Panel CreateJediEnclave()
        {
            PictureBox shipBox = new PictureBox();
            shipBox.BackColor = System.Drawing.Color.Transparent;
            shipBox.BackgroundImage = Image.FromFile(_link + @"Icons\ship.png");
            shipBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            shipBox.Cursor = System.Windows.Forms.Cursors.Hand;
            shipBox.Location = new System.Drawing.Point(21, 12);
            shipBox.Name = "shipBox";
            shipBox.Size = new System.Drawing.Size(253, 126);
            shipBox.TabIndex = 0;
            shipBox.TabStop = false;
            shipBox.Tag = "Космопорт";
            shipBox.Click += new EventHandler(GoToSpaceport);
            shipBox.MouseEnter += new EventHandler(Highligt);
            shipBox.MouseLeave += new EventHandler(LightBack);
            PictureBox shopBox = new PictureBox();
            shopBox.BackColor = System.Drawing.Color.Transparent;
            shopBox.BackgroundImage = Image.FromFile(_link + @"Icons\credits11.png");
            shopBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            shopBox.Cursor = System.Windows.Forms.Cursors.Hand;
            shopBox.Location = new System.Drawing.Point(367, 266);
            shopBox.Name = "shopBox";
            shopBox.Size = new System.Drawing.Size(64, 82);
            shopBox.TabIndex = 2;
            shopBox.TabStop = false;
            shopBox.Tag = "Магазин";
            shopBox.Click += new EventHandler(OpenShop);
            shopBox.MouseEnter += new EventHandler(Highligt);
            shopBox.MouseLeave += new EventHandler(LightBack);
            PictureBox quitBox = new PictureBox();
            quitBox.BackColor = System.Drawing.Color.Transparent;
            quitBox.BackgroundImage = Image.FromFile(_link + @"Icons\Стрелка.png");
            quitBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            quitBox.Cursor = System.Windows.Forms.Cursors.Hand;
            quitBox.Location = new System.Drawing.Point(1212, 625);
            quitBox.Name = "quitBox";
            quitBox.Size = new System.Drawing.Size(148, 50);
            quitBox.TabIndex = 1;
            quitBox.TabStop = false;
            quitBox.Tag = "Древние руины";
            quitBox.MouseEnter += new EventHandler(Highligt);
            quitBox.MouseLeave += new EventHandler(LightBack);
            quitBox.Click += new EventHandler(ChangeLoc);
            PictureBox enclaveBox = new PictureBox();
            enclaveBox.BackColor = System.Drawing.Color.Transparent;
            enclaveBox.BackgroundImage = Image.FromFile(_link + @"Icons\jedi.png");
            enclaveBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            enclaveBox.Cursor = System.Windows.Forms.Cursors.Hand;
            enclaveBox.Location = new System.Drawing.Point(659, 368);
            enclaveBox.Name = "enclaveBox";
            enclaveBox.Size = new System.Drawing.Size(117, 112);
            enclaveBox.TabIndex = 0;
            enclaveBox.TabStop = false;
            enclaveBox.Tag = "Анклав джедаев";
            enclaveBox.Click += new EventHandler(ExchangePointClick);
            enclaveBox.MouseEnter += new EventHandler(Highligt);
            enclaveBox.MouseLeave += new EventHandler(LightBack);
            Panel panel = new Panel();
            panel.Parent = MainForm.ActiveForm;
            panel.Visible = false;
            panel.Controls.AddRange(new Control[] { _info, shipBox, shopBox, enclaveBox, quitBox });
            panel.BackgroundImage = Image.FromFile(_link + @"Locations\jedi_enclave.jpg");
            panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel.Dock = System.Windows.Forms.DockStyle.Fill;
            panel.Location = new System.Drawing.Point(0, 0);
            panel.Size = new System.Drawing.Size(1360, 768);
            panel.TabIndex = 0;
            return panel;
        }
        private Panel CreateFarms()
        {
            PictureBox dragonBox = new PictureBox();
            dragonBox.BackColor = System.Drawing.Color.Transparent;
            dragonBox.BackgroundImage = Image.FromFile(_link + @"Icons\dragon.png");
            dragonBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            dragonBox.Cursor = System.Windows.Forms.Cursors.Hand;
            dragonBox.Location = new System.Drawing.Point(44, 400);
            dragonBox.Name = "dragonBox";
            dragonBox.Size = new System.Drawing.Size(600, 342);
            dragonBox.TabIndex = 0;
            dragonBox.TabStop = false;
            dragonBox.Tag = "Охота на крайт-дракона";
            dragonBox.Click += new EventHandler(DragonHunt);
            dragonBox.MouseEnter += new EventHandler(Highligt);
            dragonBox.MouseLeave += new EventHandler(LightBack);
            PictureBox quitBox = new PictureBox();
            quitBox.BackColor = System.Drawing.Color.Transparent;
            quitBox.BackgroundImage = Image.FromFile(_link + @"Icons\Стрелка.png");
            quitBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            quitBox.Cursor = System.Windows.Forms.Cursors.Hand;
            quitBox.Location = new System.Drawing.Point(1153, 658);
            quitBox.Name = "quitBox";
            quitBox.Size = new System.Drawing.Size(177, 55);
            quitBox.TabIndex = 1;
            quitBox.TabStop = false;
            quitBox.Tag = "Мос-Эйсли";
            quitBox.MouseEnter += new EventHandler(Highligt);
            quitBox.MouseLeave += new EventHandler(LightBack);
            quitBox.Click += new EventHandler(GoBack);
            Panel panel = new Panel();
            panel.Parent = MainForm.ActiveForm;
            panel.Visible = false;
            panel.Controls.AddRange(new Control[] { _info, quitBox, dragonBox });
            panel.BackgroundImage = Image.FromFile(_link + @"Locations\deserts.jpg");
            panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel.Dock = System.Windows.Forms.DockStyle.Fill;
            panel.Location = new System.Drawing.Point(0, 0);
            panel.Size = new System.Drawing.Size(1360, 768);
            panel.TabIndex = 0;
            return panel;
        }
        private Panel CreateMosEisley()
        {
            PictureBox shipBox = new PictureBox();
            shipBox.BackColor = System.Drawing.Color.Transparent;
            shipBox.BackgroundImage = Image.FromFile(_link + @"Icons\ship.png");
            shipBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            shipBox.Cursor = System.Windows.Forms.Cursors.Hand;
            shipBox.Location = new System.Drawing.Point(1097, 23);
            shipBox.Name = "shipBox";
            shipBox.Size = new System.Drawing.Size(236, 122);
            shipBox.TabIndex = 0;
            shipBox.TabStop = false;
            shipBox.Tag = "Космопорт";
            shipBox.Click += new EventHandler(GoToSpaceport);
            shipBox.MouseEnter += new EventHandler(Highligt);
            shipBox.MouseLeave += new EventHandler(LightBack);
            PictureBox shopBox = new PictureBox();
            shopBox.BackColor = System.Drawing.Color.Transparent;
            shopBox.BackgroundImage = Image.FromFile(_link + @"Icons\credits11.png");
            shopBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            shopBox.Cursor = System.Windows.Forms.Cursors.Hand;
            shopBox.Location = new System.Drawing.Point(22, 403);
            shopBox.Name = "shopBox";
            shopBox.Size = new System.Drawing.Size(98, 109);
            shopBox.TabIndex = 2;
            shopBox.TabStop = false;
            shopBox.Tag = "Магазин";
            shopBox.Click += new EventHandler(OpenShop);
            shopBox.MouseEnter += new EventHandler(Highligt);
            shopBox.MouseLeave += new EventHandler(LightBack);
            PictureBox quitBox = new PictureBox();
            quitBox.BackColor = System.Drawing.Color.Transparent;
            quitBox.BackgroundImage = Image.FromFile(_link + @"Icons\Стрелка.png");
            quitBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            quitBox.Cursor = System.Windows.Forms.Cursors.Hand;
            quitBox.Location = new System.Drawing.Point(1224, 668);
            quitBox.Name = "quitBox";
            quitBox.Size = new System.Drawing.Size(133, 55);
            quitBox.TabIndex = 1;
            quitBox.TabStop = false;
            quitBox.Tag = "В пустыни";
            quitBox.MouseEnter += new EventHandler(Highligt);
            quitBox.MouseLeave += new EventHandler(LightBack);
            quitBox.Click += new EventHandler(ChangeLoc);
            PictureBox pazaakBox = new PictureBox();
            pazaakBox.BackColor = System.Drawing.Color.Transparent;
            pazaakBox.BackgroundImage = Image.FromFile(_link + @"Icons\cards.png");
            pazaakBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            pazaakBox.Cursor = System.Windows.Forms.Cursors.Hand;
            pazaakBox.Location = new System.Drawing.Point(838, 334);
            pazaakBox.Name = "pazaakBox";
            pazaakBox.Size = new System.Drawing.Size(88, 120);
            pazaakBox.TabIndex = 1;
            pazaakBox.TabStop = false;
            pazaakBox.Tag = "Пазаак";
            pazaakBox.MouseEnter += new EventHandler(Highligt);
            pazaakBox.MouseLeave += new EventHandler(LightBack);
            pazaakBox.Click += new EventHandler(PazaakBoxClick);
            Panel panel = new Panel();
            panel.Parent = MainForm.ActiveForm;
            panel.Controls.AddRange(new Control[] { _info, shipBox, shopBox, quitBox, pazaakBox });
            panel.Visible = false;
            panel.BackgroundImage = Image.FromFile(_link + @"Locations\Mos-Eisley.jpg");
            panel.BackgroundImageLayout = ImageLayout.Stretch;
            panel.Dock = System.Windows.Forms.DockStyle.Fill;
            panel.Location = new System.Drawing.Point(0, 0);
            panel.Size = new System.Drawing.Size(1360, 768);
            panel.TabIndex = 0;
            return panel;
        }
        private Panel CreateNarShaddaaCity()
        {
            PictureBox shipBox = new PictureBox(); 
            shipBox.BackColor = System.Drawing.Color.Transparent;
            shipBox.BackgroundImage = Image.FromFile(_link + @"Icons\Sith_Ship.png");
            shipBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            shipBox.Cursor = System.Windows.Forms.Cursors.Hand;
            shipBox.Location = new System.Drawing.Point(1143, 12);
            shipBox.Name = "shipBox";
            shipBox.Size = new System.Drawing.Size(175, 115);
            shipBox.TabIndex = 0;
            shipBox.TabStop = false;
            shipBox.Tag = "Космопорт";
            shipBox.Click += new EventHandler(GoToSpaceport);
            shipBox.MouseEnter += new EventHandler(Highligt);
            shipBox.MouseLeave += new EventHandler(LightBack);
            PictureBox shopBox = new PictureBox();
            shopBox.BackColor = System.Drawing.Color.Transparent;
            shopBox.BackgroundImage = Image.FromFile(_link + @"Icons\credits11.png");
            shopBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            shopBox.Cursor = System.Windows.Forms.Cursors.Hand;
            shopBox.Location = new System.Drawing.Point(1010, 145);
            shopBox.Name = "shopBox";
            shopBox.Size = new System.Drawing.Size(100, 136);
            shopBox.TabIndex = 2;
            shopBox.TabStop = false;
            shopBox.Tag = "Магазин";
            shopBox.Click += new EventHandler(OpenShop);
            shopBox.MouseEnter += new EventHandler(Highligt);
            shopBox.MouseLeave += new EventHandler(LightBack);
            PictureBox finishBox = new PictureBox();
            finishBox.BackColor = System.Drawing.Color.Transparent;
            finishBox.BackgroundImage = Image.FromFile(_link + @"Icons\exchange.png");
            finishBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            finishBox.Cursor = System.Windows.Forms.Cursors.Hand;
            finishBox.Location = new System.Drawing.Point(255, 163);
            finishBox.Name = "finishBox";
            finishBox.Size = new System.Drawing.Size(121, 82);
            finishBox.TabIndex = 3;
            finishBox.TabStop = false;
            finishBox.Tag = "Резиденция обмена";
            finishBox.Click += new EventHandler(FinishGame);
            finishBox.MouseEnter += new EventHandler(Highligt);
            finishBox.MouseLeave += new EventHandler(LightBack);
            PictureBox pazaakBox = new PictureBox();
            pazaakBox.BackColor = System.Drawing.Color.Transparent;
            pazaakBox.BackgroundImage = Image.FromFile(_link + @"Icons\cards.png");
            pazaakBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            pazaakBox.Cursor = System.Windows.Forms.Cursors.Hand;
            pazaakBox.Location = new System.Drawing.Point(605, 251);
            pazaakBox.Name = "pazaakBox";
            pazaakBox.Size = new System.Drawing.Size(128, 130);
            pazaakBox.TabIndex = 1;
            pazaakBox.TabStop = false;
            pazaakBox.Tag = "Пазаак";
            pazaakBox.MouseEnter += new EventHandler(Highligt);
            pazaakBox.MouseLeave += new EventHandler(LightBack);
            pazaakBox.Click += new EventHandler(PazaakBoxClick);
            Panel panel = new Panel();
            panel.Parent = MainForm.ActiveForm;
            panel.BackgroundImage = Image.FromFile(_link + @"Locations\nar-shaddaa.jpg");
            panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel.Cursor = System.Windows.Forms.Cursors.Default;
            panel.Dock = System.Windows.Forms.DockStyle.Fill;
            panel.Location = new System.Drawing.Point(0, 0);
            panel.Controls.AddRange(new Control[] { _info, shipBox, shopBox, finishBox, pazaakBox });
            panel.Visible = false;
            panel.Size = new System.Drawing.Size(1360, 768);
            panel.TabIndex = 0;
            return panel;
        }
        private Panel CreateTombsValley()
        {
            PictureBox lootBox = new PictureBox();
            lootBox.BackColor = System.Drawing.Color.Transparent;
            lootBox.BackgroundImage = Image.FromFile(_link + @"Icons\loot.jpg");
            lootBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            lootBox.Cursor = System.Windows.Forms.Cursors.Hand;
            lootBox.Location = new System.Drawing.Point(681, 384);
            lootBox.Name = "lootBox";
            lootBox.Size = new System.Drawing.Size(107, 104);
            lootBox.TabIndex = 0;
            lootBox.TabStop = false;
            lootBox.Tag = "Древняя гробница";
            lootBox.Click += new EventHandler(LootPlaceClick);
            lootBox.MouseEnter += new EventHandler(Highligt);
            lootBox.MouseLeave += new EventHandler(LightBack);
            PictureBox quitBox = new PictureBox();
            quitBox.BackColor = System.Drawing.Color.Transparent;
            quitBox.BackgroundImage = Image.FromFile(_link + @"Icons\Стрелка.png");
            quitBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            quitBox.Cursor = System.Windows.Forms.Cursors.Hand;
            quitBox.Location = new System.Drawing.Point(1212, 610);
            quitBox.Name = "quitBox";
            quitBox.Size = new System.Drawing.Size(145, 50);
            quitBox.TabIndex = 1;
            quitBox.TabStop = false;
            quitBox.Tag = "К академии";
            quitBox.MouseEnter += new EventHandler(Highligt);
            quitBox.MouseLeave += new EventHandler(LightBack);
            quitBox.Click += new EventHandler(GoBack);
            Panel panel = new Panel();
            panel.BackgroundImage = Image.FromFile(_link + @"Locations\Tombs.png");
            panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel.Parent = MainForm.ActiveForm;
            panel.Dock = System.Windows.Forms.DockStyle.Fill;
            panel.Location = new System.Drawing.Point(0, 0);
            panel.Name = "panel1";
            panel.Controls.AddRange(new Control[] { quitBox, lootBox, _info });
            panel.Visible = false;
            panel.Size = new System.Drawing.Size(1360, 768);
            panel.TabIndex = 0;
            return panel;
        }
        private Panel CreateSithAcademyEntrance()
        {
            PictureBox tombBox = new PictureBox();
            tombBox.BackColor = System.Drawing.Color.Transparent;
            tombBox.BackgroundImage = Image.FromFile(_link + @"Icons\Стрелка.png");
            tombBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            tombBox.Cursor = System.Windows.Forms.Cursors.Hand;
            tombBox.Location = new System.Drawing.Point(162, 706);
            tombBox.Name = "tombBox";
            tombBox.Size = new System.Drawing.Size(113, 50);
            tombBox.TabIndex = 3;
            tombBox.TabStop = false;
            tombBox.Tag = "К гробницам";
            tombBox.MouseEnter += new EventHandler(Highligt);
            tombBox.MouseLeave += new EventHandler(LightBack);
            tombBox.Click += new EventHandler(ChangeLoc);
            PictureBox shipBox = new PictureBox();
            shipBox.BackColor = System.Drawing.Color.Transparent;
            shipBox.BackgroundImage = Image.FromFile(_link + @"Icons\Sith_Ship.png");
            shipBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            shipBox.Cursor = System.Windows.Forms.Cursors.Hand;
            shipBox.Location = new System.Drawing.Point(175, 47);
            shipBox.Name = "shipBox";
            shipBox.Size = new System.Drawing.Size(153, 79);
            shipBox.TabIndex = 0;
            shipBox.TabStop = false;
            shipBox.Tag = "Космопорт";
            shipBox.Click += new EventHandler(GoToSpaceport);
            shipBox.MouseEnter += new EventHandler(Highligt);
            shipBox.MouseLeave += new EventHandler(LightBack);
            PictureBox shopBox = new PictureBox();
            shopBox.BackColor = System.Drawing.Color.Transparent;
            shopBox.BackgroundImage = Image.FromFile(_link + @"Icons\credits11.png");
            shopBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            shopBox.Cursor = System.Windows.Forms.Cursors.Hand;
            shopBox.Location = new System.Drawing.Point(673, 441);
            shopBox.Name = "shopBox";
            shopBox.Size = new System.Drawing.Size(61, 128);
            shopBox.TabIndex = 1;
            shopBox.TabStop = false;
            shopBox.Tag = "Магазин";
            shopBox.Click += new EventHandler(OpenShop);
            shopBox.MouseEnter += new EventHandler(Highligt);
            shopBox.MouseLeave += new EventHandler(LightBack);
            PictureBox academyBox = new PictureBox();
            academyBox.BackColor = System.Drawing.Color.Transparent;
            academyBox.BackgroundImage = Image.FromFile(_link + @"Icons\academy.png");
            academyBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            academyBox.Cursor = System.Windows.Forms.Cursors.Hand;
            academyBox.Location = new System.Drawing.Point(673, 164);
            academyBox.Name = "academyBox";
            academyBox.Size = new System.Drawing.Size(77, 59);
            academyBox.TabIndex = 2;
            academyBox.TabStop = false;
            academyBox.Tag = "Академия ситхов";
            academyBox.Click += new EventHandler(ExchangePointClick);
            academyBox.MouseEnter += new EventHandler(Highligt);
            academyBox.MouseLeave += new EventHandler(LightBack);
            Panel panel = new Panel();
            panel.Parent = MainForm.ActiveForm;
            panel.Visible = false;
            panel.Controls.AddRange(new Control[] { academyBox, shipBox, shopBox, tombBox, _info });
            panel.Dock = System.Windows.Forms.DockStyle.Fill;
            panel.Location = new System.Drawing.Point(0, 0);
            panel.Name = "panel1";
            panel.Size = new System.Drawing.Size(1360, 768);
            panel.TabIndex = 0;
            panel.BackgroundImageLayout = ImageLayout.Stretch;
            panel.BackgroundImage = Image.FromFile(_link + @"Locations\korriban-academy.jpg");
            return panel;
        }
        private Panel CreateHuttasCity()
        {
            PictureBox huttBox = new PictureBox();
            huttBox.BackColor = System.Drawing.Color.Transparent;
            huttBox.BackgroundImage = Image.FromFile(_link + @"Icons\hutt1.png");
            huttBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            huttBox.Location = new System.Drawing.Point(729, 181);
            huttBox.Name = "huttBox";
            huttBox.Size = new System.Drawing.Size(214, 157);
            huttBox.TabIndex = 0;
            huttBox.TabStop = false;
            huttBox.Cursor = Cursors.Hand;
            huttBox.Tag = "Вернуть долг хаттам";
            huttBox.Click += new EventHandler(FinishGame);
            huttBox.MouseEnter += new EventHandler(Highligt);
            huttBox.MouseLeave += new EventHandler(LightBack);
            PictureBox enterBox = new PictureBox();
            enterBox.BackColor = System.Drawing.Color.Transparent;
            enterBox.BackgroundImage = Image.FromFile(_link+@"Icons\стрелка1.png");
            enterBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            enterBox.Cursor = System.Windows.Forms.Cursors.Hand;
            enterBox.Location = new System.Drawing.Point(977, 565);
            enterBox.Name = "enterBox";
            enterBox.Size = new System.Drawing.Size(35, 57);
            enterBox.TabIndex = 1;
            enterBox.Tag = "В кантину";
            enterBox.TabStop = false;
            enterBox.MouseEnter += new EventHandler(Highligt);
            enterBox.MouseLeave += new EventHandler(LightBack);
            enterBox.Click += new EventHandler(GoBack);
            PictureBox shopBox = new PictureBox();
            shopBox.BackColor = System.Drawing.Color.Transparent;
            shopBox.BackgroundImage = Image.FromFile(_link + @"Icons\credits11.png");
            shopBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            shopBox.Cursor = System.Windows.Forms.Cursors.Hand;
            shopBox.Location = new System.Drawing.Point(642, 672);
            shopBox.Name = "shopBox";
            shopBox.Size = new System.Drawing.Size(79, 84);
            shopBox.Tag = "Магазин";
            shopBox.TabIndex = 2;
            shopBox.TabStop = false;
            shopBox.Click += new EventHandler(OpenShop);
            shopBox.MouseEnter += new EventHandler(Highligt);
            shopBox.MouseLeave += new EventHandler(LightBack);
            PictureBox shipBox = new PictureBox();
            shipBox.BackColor = System.Drawing.Color.Transparent;
            shipBox.BackgroundImage = Image.FromFile(_link + @"Icons\ship.png");
            shipBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            shipBox.Cursor = System.Windows.Forms.Cursors.Hand;
            shipBox.Location = new System.Drawing.Point(41, 33);
            shipBox.Name = "shipBox";
            shipBox.Size = new System.Drawing.Size(148, 94);
            shipBox.TabIndex = 0;
            shipBox.TabStop = false;
            shipBox.Tag = "Космопорт";
            shipBox.Click += new EventHandler(GoToSpaceport);
            shipBox.MouseEnter += new EventHandler(Highligt);
            shipBox.MouseLeave += new EventHandler(LightBack);
            Panel huttasCity = new Panel();
            huttasCity.BackgroundImage = Image.FromFile(_link + @"Locations\hutta-city.jpg");
            huttasCity.Parent = MainForm.ActiveForm;
            huttasCity.BackgroundImageLayout = ImageLayout.Stretch;
            huttasCity.Dock = System.Windows.Forms.DockStyle.Fill;
            huttasCity.Location = new System.Drawing.Point(0, 0);
            huttasCity.Name = "huttaCity";
            huttasCity.Size = new System.Drawing.Size(1360, 768);
            huttasCity.TabIndex = 0;
            huttasCity.Controls.AddRange(new Control[] { shipBox, shopBox, enterBox, _info, huttBox });
            huttasCity.Visible = false;
            return huttasCity;
        }
        private Panel CreateHuttasCantina()
        {
            PictureBox shopBox = new PictureBox();
            shopBox.BackColor = System.Drawing.Color.Transparent;
            shopBox.BackgroundImage = Image.FromFile(_link+@"Icons\credits11.png");
            shopBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            shopBox.Cursor = System.Windows.Forms.Cursors.Hand;
            shopBox.Location = new System.Drawing.Point(369, 301);
            shopBox.Name = "shopBox";
            shopBox.Size = new System.Drawing.Size(52, 154);
            shopBox.TabIndex = 1;
            shopBox.TabStop = false;
            shopBox.Tag = "Магазин";
            shopBox.Click += new EventHandler(OpenShop);
            shopBox.MouseEnter += new System.EventHandler(Highligt);
            shopBox.MouseLeave += new System.EventHandler(LightBack);
            PictureBox quitBox = new PictureBox();
            quitBox.BackColor = System.Drawing.Color.Transparent;
            quitBox.BackgroundImage = Image.FromFile(_link + @"Icons\Стрелка.png");
            quitBox.Cursor = System.Windows.Forms.Cursors.Hand;
            quitBox.Location = new System.Drawing.Point(1046, 263);
            quitBox.Name = "quitBox";
            quitBox.Size = new System.Drawing.Size(121, 50);
            quitBox.TabIndex = 2;
            quitBox.TabStop = false;
            quitBox.Tag = "В город";
            quitBox.MouseEnter += new System.EventHandler(Highligt);
            quitBox.MouseLeave += new System.EventHandler(LightBack);
            quitBox.Click += new EventHandler(ChangeLoc);
            PictureBox pazaakBox = new PictureBox();
            pazaakBox.BackColor = System.Drawing.Color.Transparent;
            pazaakBox.BackgroundImage = Image.FromFile(_link + @"Icons\cards.png");
            pazaakBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            pazaakBox.Location = new System.Drawing.Point(425, 650);
            pazaakBox.Name = "pazaakBox";
            pazaakBox.Size = new System.Drawing.Size(135, 76);
            pazaakBox.TabIndex = 4;
            pazaakBox.Cursor = Cursors.Hand;
            pazaakBox.TabStop = false;
            pazaakBox.Tag = "Пазаак";
            pazaakBox.MouseEnter += new System.EventHandler(Highligt);
            pazaakBox.MouseLeave += new System.EventHandler(LightBack);
            pazaakBox.MouseClick += new MouseEventHandler(PazaakBoxClick);
            Panel panel = new Panel();
            panel.Parent = MainForm.ActiveForm;
            panel.Visible = false;
            panel.Controls.AddRange(new Control[] { shopBox, quitBox, pazaakBox, _info });
            panel.Dock = System.Windows.Forms.DockStyle.Fill;
            panel.Location = new System.Drawing.Point(0, 0);
            panel.Name = "panel1";
            panel.Size = new System.Drawing.Size(1360, 768);
            panel.TabIndex = 5;
            panel.BackgroundImage = Image.FromFile(_link + @"Locations\hutta-cantina.jpg");
            panel.BackgroundImageLayout = ImageLayout.Stretch;
            return panel;
        }
        private Panel CreateSpaceport()
        {
            PictureBox korribanBox = new PictureBox();
            korribanBox.Location = new Point(854, 152);
            korribanBox.Name = "korribanBox";
            korribanBox.Cursor = Cursors.Hand;
            korribanBox.Size = new System.Drawing.Size(84, 83);
            korribanBox.TabIndex = 0;
            korribanBox.TabStop = false;
            korribanBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            korribanBox.BackColor = Color.Transparent;
            korribanBox.Tag = 0;
            korribanBox.BackgroundImage = _planets[0].SmallImage;
            korribanBox.Click += new EventHandler(PlanetClick);
            PictureBox tatooineBox = new PictureBox();
            tatooineBox.BackColor = System.Drawing.Color.Transparent;
            tatooineBox.Cursor = Cursors.Hand;
            tatooineBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            tatooineBox.Location = new System.Drawing.Point(287, 463);
            tatooineBox.Name = "pictureBox5";
            tatooineBox.Size = new System.Drawing.Size(84, 83);
            tatooineBox.TabIndex = 2;
            tatooineBox.Tag = 2;
            tatooineBox.BackgroundImage = _planets[2].SmallImage;
            tatooineBox.Click += new EventHandler(PlanetClick);
            tatooineBox.TabStop = false;
            PictureBox dantooineBox = new PictureBox();
            dantooineBox.BackColor = System.Drawing.Color.Transparent;
            dantooineBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            dantooineBox.Location = new System.Drawing.Point(211, 92);
            dantooineBox.Name = "pictureBox4";
            dantooineBox.Size = new System.Drawing.Size(84, 83);
            dantooineBox.TabIndex = 3;
            dantooineBox.Tag = 3;
            dantooineBox.Click += new EventHandler(PlanetClick);
            dantooineBox.Cursor = Cursors.Hand;
            dantooineBox.BackgroundImage = _planets[3].SmallImage;
            dantooineBox.TabStop = false;
            PictureBox huttaBox = new PictureBox();
            huttaBox.BackColor = System.Drawing.Color.Transparent;
            huttaBox.Click += new EventHandler(PlanetClick);
            huttaBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            huttaBox.Location = new System.Drawing.Point(712, 416);
            huttaBox.Name = "pictureBox2";
            huttaBox.Cursor = Cursors.Hand;
            huttaBox.Size = new System.Drawing.Size(84, 83);
            huttaBox.TabIndex = 4;
            huttaBox.Tag = 4;
            huttaBox.BackgroundImage = _planets[4].SmallImage;
            huttaBox.TabStop = false;
            PictureBox narShaddaaBox = new PictureBox();
            narShaddaaBox.Cursor = Cursors.Hand;
            narShaddaaBox.Click += new EventHandler(PlanetClick);
            narShaddaaBox.BackColor = System.Drawing.Color.Transparent;
            narShaddaaBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            narShaddaaBox.Location = new System.Drawing.Point(610, 500);
            narShaddaaBox.Name = "pictureBox1";
            narShaddaaBox.Size = new System.Drawing.Size(84, 83);
            narShaddaaBox.TabIndex = 1;
            narShaddaaBox.Tag = 1;
            narShaddaaBox.BackgroundImage = _planets[1].SmallImage;
            narShaddaaBox.TabStop = false;
            _infoField = new Label();
            _infoField.AutoSize = true;
            _infoField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            _infoField.Location = new System.Drawing.Point(6, 16);
            _infoField.Name = "infoField";
            _infoField.Size = new System.Drawing.Size(54, 19);
            _infoField.TabIndex = 0;
            _infoField.Text = "label1";
            Button travellButton = new Button();
            travellButton.Location = new System.Drawing.Point(1102, 80);
            travellButton.Name = "travellButton";
            travellButton.Size = new System.Drawing.Size(243, 35);
            travellButton.TabIndex = 1;
            travellButton.Text = "Отправиться";
            travellButton.UseVisualStyleBackColor = true;
            travellButton.Click += new EventHandler(TravellToPlanet);
            Button cancellButton = new Button();
            cancellButton.Location = new System.Drawing.Point(6, 80);
            cancellButton.Name = "cancellButton";
            cancellButton.Size = new System.Drawing.Size(243, 35);
            cancellButton.TabIndex = 2;
            cancellButton.Text = "Отмена";
            cancellButton.UseVisualStyleBackColor = true;
            cancellButton.Click += new System.EventHandler(CancellClick);
            _requestBox = new GroupBox();
            _requestBox.BackColor = System.Drawing.SystemColors.Control;
            _requestBox.Controls.AddRange(new Control[] { cancellButton, travellButton, _infoField });
            _requestBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            _requestBox.Location = new System.Drawing.Point(3, 249);
            _requestBox.Name = "requestBox";
            _requestBox.Size = new System.Drawing.Size(1360, 121);
            _requestBox.TabIndex = 5;
            _requestBox.TabStop = false;
            _requestBox.Text = "Отправка";
            _requestBox.Visible = false;
            Panel panel = new Panel();
            panel.Parent = MainForm.ActiveForm;
            panel.Dock = DockStyle.Fill;
            panel.Visible = false;
            panel.BackgroundImageLayout = ImageLayout.Stretch;
            panel.BackgroundImage = Image.FromFile(_link+"Galaxy.jpg");
            panel.Controls.AddRange(new Control[] { korribanBox, huttaBox, tatooineBox, narShaddaaBox, dantooineBox, _requestBox });
            return panel;
        }
        private void TravellToPlanet(object sender, EventArgs e)
        {
            _player.Planet = _selectedPlanet;
        }
        private void Highligt(object sender, EventArgs e)
        {
            PictureBox temp = (PictureBox)sender;
            _info.Parent = _player.Location.Panel;
            _info.Text = temp.Tag.ToString();
        }
        private void LightBack(object sender, EventArgs e)
        {
            _info.Text = string.Empty;           
        }
        private void GoToSpaceport(object sender, EventArgs e)
        {
            _player.Location.Panel.Visible = false;
            _player.Location = _locations[0];
        }
        private void OpenShop(object sender, EventArgs e)
        {
            Shop shop = new Shop(_player);
            shop.ShopBox.Parent = _player.Location.Panel;
            switch (_player.Location.Name)
            {
                case "Кантина Нал-Хатты":
                    shop.InitSimpleCardsGoods(true);
                    break;
                case "Город Нал-Хатты":
                    shop.InitSimpleCardsGoods(false);
                    break;
                case "Вход в Академию ситхов":
                    shop.InitFlippableCardGoods();
                    shop.Items.Add(new LootItem("Голокрон ситхов", "Дает возможность проводить раскопки в древней гробнице. Обменивается на очки престижа в Академии Ситхов.", 2500, 500, QuestItem.Link + @"sith-holocron.png", 300, 0));
                    break;
                case "Анклав джедаев":
                    shop.InitFlippableCardGoods();
                    shop.Items.Add(new LootItem("Медальон джедаев", "Награда отличившихся приверженцев Ордена джедаев. Позволяет производить раскопки в руинах Дантуина. Обменивается на очки мудрости в Анклаве джедаев.", 2500, 500, QuestItem.Link + @"jedi-medal.png", 0, 200));
                    break;
                case "Нар-Шаддаа":
                    shop.InitSimpleCardsGoods(false);
                    shop.InitFlippableCardGoods();
                    shop.InitGoldCardsGoods();
                    break;
                case "Мос-Эйсли":
                    shop.InitGoldCardsGoods();
                    shop.InitFlippableCardGoods();
                    shop.Items.Add(new QuestItem("Набор взрывчатки", "Используется для охоты на крайт-дракона. Шанс успеха 10%", 1500, 300, _link + @"Icons\explosion.png"));
                    shop.Items.Add(new QuestItem("Жемчужина крайт-дракона", "Ценный охотничий трофей", 125000, 25000, _link + @"Icons\dragon-pearl.png"));
                    break;
            }
            shop.Display();
        }
        private void FinishGame(object sender, EventArgs e)
        {
            if (!_player.Finished)
            {
                DialogResult result;
                PictureBox box = (PictureBox)sender;
                switch (box.Name)
                {
                    case "huttBox":
                        result = MessageBox.Show("Вы действительно хотите оплатить долг хаттам? Необходим 1 000 000 кредитов.", "Завершение игры", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if (_player.Credits >= 1000000)
                            {
                                _player.Credits -= 1000000;
                                MessageBox.Show("Долг успешно оплачен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                _player.Finished = true;
                            }
                            else
                            {
                                MessageBox.Show("Недостаточно кредитов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                        }
                        break;
                    case "academyBox":
                        result = MessageBox.Show("Вы действительно хотите принять защиту Ордена Ситхов? Необходимо 15 000 очков престижа.", "Завершение игры", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (_player.SithPrestige >= 15000)
                        {
                            MessageBox.Show("Защита Ордена Ситхов гаранитирована. Проблема с долгом решена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _player.Finished = true;
                        }
                        else
                        {
                            MessageBox.Show("Недостаточно очков престижа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        break;
                    case "finishBox":
                        result = MessageBox.Show("Вы действительно хотите снять заказ на Вашу голову? Необходим 1 000 000 кредитов.", "Завершение игры", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if (_player.Credits >= 1000000)
                            {
                                _player.Credits -= 1000000;
                                MessageBox.Show("Заказ на Вашу голову успешно снят.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                _player.Finished = true;
                            }
                            else
                            {
                                MessageBox.Show("Недостаточно кредитов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                        }
                        break;
                    case "enclaveBox":
                        result = MessageBox.Show("Вы действительно хотите принять защиту Ордена Джедаев? Необходимо 15 000 очков мудрости.", "Завершение игры", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (_player.SithPrestige >= 15000)
                        {
                            MessageBox.Show("Защита Ордена Джедаев гаранитирована. Проблема с долгом решена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _player.Finished = true;
                        }
                        else
                        {
                            MessageBox.Show("Недостаточно очков мудрости!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Проблема с долгом уже решена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void DragonHunt(object sender, EventArgs e)
        {
            int pos = 0;
            QuestItem explosion = new QuestItem("Набор взрывчатки", "Используется для охоты на крайт-дракона. Шанс успеха 10%", 1500, 300, _link + @"Icons\explosion.png");
            if (CheckConsistion(explosion, out pos))
            {
                Random random = new Random();
                _player.Items.RemoveAt(pos);
                int seed = random.Next(0, 10);
                if (seed == 0)
                {
                    QuestItem perl = new QuestItem("Жемчужина крайт-дракона", "Ценный охотничий трофей", 125000, 25000, _link + @"Icons\dragon-pearl.png");
                    perl.Owner = _player;
                    _player.Items.Add(perl);
                    MessageBox.Show("Успех! Получена жемчужина крайт-дракона", "Победа", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Неудача! Вы потеряли набор взрывчатки и ничего не получили.", "Поражение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Для охоты на крайт-дракона необходим набор взрывчатки. Обратитесь в ближайший магазин, чтобы приобрести его.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CheckConsistion(Item item, out int index)
        {
            List<string> lines = new List<string>();
            string line = string.Empty;
            if (item is ClassicalCard)
            {
                ClassicalCard card = (ClassicalCard)item;
                line = $"{card.GetType().Name}|{card.Value}|{card.Link}|{card.BuyPrice}|{card.SalePrice}|{card.Descriprion}";
            }
            else if (item is FlippableCard)
            {
                FlippableCard card = (FlippableCard)item;
                line = $"{card.GetType().Name}|{card.Value}|{card.Link}|{card.BuyPrice}|{card.SalePrice}|{card.Descriprion}";
            }
            else if (item is GoldCard)
            {
                GoldCard card = (GoldCard)item;
                line = $"{card.GetType().Name}|{card.Value}|{card.Link}|{card.BuyPrice}|{card.SalePrice}|{card.Descriprion}";
            }
            else if (item is QuestItem)
            {
                QuestItem questItem = (QuestItem)item;
                line = $"{questItem.GetType().Name}|{questItem.Name}|{questItem.Descriprion}|{questItem.BuyPrice}|{questItem.SalePrice}|{questItem.Link_}";
            }
            else
            {
                LootItem lootItem = (LootItem)item;
                line = $"{lootItem.GetType().Name}|{lootItem.Name}|{lootItem.Descriprion}|{lootItem.BuyPrice}|{lootItem.SalePrice}|{lootItem.Link_}|{lootItem.PrestigeValue}|{lootItem.ScoreValue}";
            }
            foreach (Item it in _player.Items)
            {
                if (it is ClassicalCard)
                {
                    ClassicalCard card = (ClassicalCard)it;
                    lines.Add($"{card.GetType().Name}|{card.Value}|{card.Link}|{card.BuyPrice}|{card.SalePrice}|{card.Descriprion}");
                }
                else if (it is FlippableCard)
                {
                    FlippableCard card = (FlippableCard)it;
                    lines.Add($"{card.GetType().Name}|{card.Value}|{card.Link}|{card.BuyPrice}|{card.SalePrice}|{card.Descriprion}");
                }
                else if (it is GoldCard)
                {
                    GoldCard card = (GoldCard)it;
                    lines.Add($"{card.GetType().Name}|{card.Value}|{card.Link}|{card.BuyPrice}|{card.SalePrice}|{card.Descriprion}");
                }
                else if (it is QuestItem)
                {
                    QuestItem questItem = (QuestItem)it;
                    lines.Add($"{questItem.GetType().Name}|{questItem.Name}|{questItem.Descriprion}|{questItem.BuyPrice}|{questItem.SalePrice}|{questItem.Link_}");
                }
                else
                {
                    LootItem lootItem = (LootItem)it;
                    lines.Add($"{lootItem.GetType().Name}|{lootItem.Name}|{lootItem.Descriprion}|{lootItem.BuyPrice}|{lootItem.SalePrice}|{lootItem.Link_}|{lootItem.PrestigeValue}|{lootItem.ScoreValue}");
                }
            }
            try
            {
                index = lines.IndexOf(line);
            }
            catch
            {
                index = int.MinValue;
            }
            return lines.Contains(line);
        }
        private void CancellClick(object sender, EventArgs e)
        {
            _requestBox.Visible = false;
        }
        public void Clear()
        {
            _planets.Clear();
            _locations.Clear();
        }
        private void PlanetClick(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            int pos = Convert.ToInt32(box.Tag);
            _selectedPlanet = _planets[pos];
            _requestBox.Text = _planets[pos].Name;
            _infoField.Text = _planets[pos].Description;
            _requestBox.Visible = true;
        }
        private void PazaakBoxClick(object sender, EventArgs e)
        {
            _form.PlayPazaakGame();
        }
        private void ChangeLoc(object sender, EventArgs e)
        {
            _player.Location.Panel.Visible = false;
            _player.Location = _player.Planet.Locations[1];
        }
        private void GoBack(object sender, EventArgs e)
        {
            _player.Location.Panel.Visible = false;
            _player.Location = _player.Planet.Locations[0];
        }
        public Planet GetPlanetByName(string name)
        {
            foreach(Planet planet in _planets)
            {
                if (planet.Name == name)
                {
                    return planet;
                }
            }
            throw new Exception();
        }
        public Location GetLocationByName(string name)
        {
            foreach(Location location in _locations)
            {
                if (location.Name == name)
                {
                    return location;
                }
            }
            throw new Exception();
        }
        private void LootPlaceClick(object sender, EventArgs e)
        {
            switch (_player.Location.Name)
            {
                case "Долины Гробниц":
                    LootPlace tomb = new LootPlace(LootPlaceType.SithTomb);
                    int pos = 0;
                    LootItem holocron = new LootItem("Голокрон ситхов", "Дает возможность проводить раскопки в древней гробнице. Обменивается на очки престижа в Академии Ситхов.", 2500, 500, QuestItem.Link + @"sith-holocron.png", 300, 0);
                    if (CheckConsistion(holocron, out pos))
                    {
                        try
                        {
                            LootItem extraction = tomb.Loot();
                            extraction.Owner = _player;
                            extraction.Display();
                            _player.Items.Add(extraction);
                        }
                        catch
                        {
                            MessageBox.Show("Дух темного Лорда напал на Вас, вы проиграли. Вы потеряли голокрон", "Поражение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            _player.Items.RemoveAt(pos);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Для раскопок необходим голокрон ситхов. Его можно приобрести в ближайшем магазине.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;                    
                case "Руины Дантуина":
                    LootPlace ruin = new LootPlace(LootPlaceType.JediRuins);
                    int idx = 0;
                    LootItem medal = new LootItem("Медальон джедаев", "Награда отличившихся приверженцев Ордена джедаев. Позволяет производить раскопки в руинах Дантуина. Обменивается на очки мудрости в Анклаве джедаев.", 2500, 500, QuestItem.Link + @"jedi-medal.png", 0, 200);
                    if (CheckConsistion(medal, out idx))
                    {
                        try
                        {
                            LootItem extraction = ruin.Loot();
                            extraction.Owner = _player;
                            extraction.Display();
                            _player.Items.Add(extraction);
                        }
                        catch
                        {
                            MessageBox.Show("Древний дроид-страж напал на вас, вы проиграли. Вы потеряли медальон.", "Поражение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            _player.Items.RemoveAt(idx);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Для раскопок необходим медальон джедаев. Его можно приобрести в ближайшем магазине.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        } 
        private void ExchangePointClick(object sender, EventArgs e)
        {
            switch (_player.Location.Name)
            {
                case "Вход в Академию ситхов":
                    if (_player.SithPrestige < 15000||_player.Finished)
                    {
                        ExchangePoint sithPoint = new ExchangePoint(LootPlaceType.SithTomb, _player);
                        sithPoint.ExchangeBox.Parent = _player.Location.Panel;
                        sithPoint.Display();
                    }
                    else
                    {
                        FinishGame(sender, e);
                    }
                    break;
                case "Анклав джедаев":
                    if (_player.JediScore < 15000||_player.Finished)
                    {
                        ExchangePoint jediPoint = new ExchangePoint(LootPlaceType.JediRuins, _player);
                        jediPoint.ExchangeBox.Parent = _player.Location.Panel;
                        jediPoint.Display();
                    }
                    else
                    {
                        FinishGame(sender, e);
                    }
                    break;
            }
        }
    }
}