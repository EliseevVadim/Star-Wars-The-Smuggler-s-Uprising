using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TheGame
{
    abstract class Item: IStoreable
    {
        protected string _descriprion;
        protected Image _image;
        protected uint _buyPrice;
        protected string _link;
        protected uint _salePrice;
        protected string _name;
        protected Player _owner;
        public string Name { get => _name; set => _name = value; }
        public string Link_ { get => _link; set => _link = value; }
        public uint BuyPrice
        {
            set
            {
                _buyPrice = value;
            }
            get
            {
                return _buyPrice;
            }
        }
        public uint SalePrice
        {
            set
            {
                _salePrice = value;
            }
            get
            {
                return _salePrice;
            }
        }

        public Image Image { get => _image; set => _image = value; }
        public string Descriprion { get => _descriprion; set => _descriprion = value; }
        public Player Owner { get => _owner; set => _owner = value; }

        public abstract void Store();
    }
}
