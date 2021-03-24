using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace TheGame
{
    class Authorizator
    {
        private string _path;
        private List<string> _logins;
        private List<string> _passwords;
        private string [] _users;
        private string _current;
        private List<Player> _players;
        public Authorizator(string path)
        {
            _path = path;
            GameStorage storage = new GameStorage();
            storage.InitAll();
            _logins = new List<string>();
            _passwords = new List<string>();
            _users = File.ReadAllLines(path);
            _players = new List<Player>();
            foreach(string user in _users)
            {
                try
                {
                    string[] mas = user.Split('|');
                    Planet planet = storage.GetPlanetByName(mas[5]);
                    Location location = storage.GetLocationByName(mas[6]);
                    Player player = new Player(mas[1], mas[2], Image.FromFile(mas[4]), uint.Parse(mas[3]), mas[0], mas[4], planet, location, int.Parse(mas[7]), int.Parse(mas[8]), bool.Parse(mas[9]));
                    _players.Add(player);
                }
                catch
                {

                }
            }
        }
        public bool IsAuthorized(string login, string password)
        {
            string[] lines = File.ReadAllLines(_path);
            foreach(string s in lines)
            {
                try
                {
                    string[] temp = s.Split('|');
                    _logins.Add(temp[1]);
                    _passwords.Add(temp[2]);
                }
                catch
                {

                }
            }         
            if (_logins.Contains(login) && _passwords.Contains(password))
            {
                if(_logins.IndexOf(login) == _passwords.IndexOf(password))
                {
                    _current = _users[_logins.IndexOf(login)];
                    return true;
                }
            }
            return false;
        }
        public string Current => _current;
    }
}
