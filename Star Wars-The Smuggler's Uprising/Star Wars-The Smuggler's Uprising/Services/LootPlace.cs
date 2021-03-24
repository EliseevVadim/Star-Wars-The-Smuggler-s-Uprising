using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheGame
{
    class LootPlace
    {
        private LootPlaceType _type;
        private List<LootItem> _items;        
        public LootPlace(LootPlaceType type)
        {
            _items = new List<LootItem>();
            _type = type;
            switch (_type)
            {
                case LootPlaceType.SithTomb:
                    _items.Add(new LootItem("Голокрон ситхов", "Дает возможность проводить раскопки в древней гробнице. Обменивается на очки престижа в Академии Ситхов.", 2500, 500, QuestItem.Link + @"sith-holocron.png", 300, 0));
                    _items.Add(new LootItem("Световой меч ситхов", "Традиционное ситское оружие. Обменивается на очки престижа в Академии ситхов.", 1000, 200, QuestItem.Link + @"red-lightsaber.png", 250, 0));
                    _items.Add(new LootItem("Красный кристалл", "Составная часть светового меча. Обменивается на очки престижа в Академии ситхов.", 300, 60, QuestItem.Link + @"red-crystal.png", 50, 0));
                    _items.Add(new LootItem("Кодекс ситхов", "Мантра, определяющая поведение последователей Ордена ситхов.", 500, 100, QuestItem.Link + @"sith-code.png", 150, 0));
                    break;
                case LootPlaceType.JediRuins:
                    _items.Add(new LootItem("Великий голокрон", "Самый крупный и наиболее мощный из сохранившихся голокронов джедаев с древних времён. Обменивается на очки мудрости в Анклаве джедаев.", 5500, 1100, QuestItem.Link + @"great-holocron.png", 0, 350));
                    _items.Add(new LootItem("Медальон джедаев", "Награда отличившихся приверженцев Ордена джедаев. Позволяет производить раскопки в руинах Дантуина. Обменивается на очки мудрости в Анклаве джедаев.", 2500, 500, QuestItem.Link + @"jedi-medal.png", 0, 200));
                    _items.Add(new LootItem("Световой меч", "Традиционное оружие Ордена джедаев. Обменивается на очки мудрости в Анклаве джедаев.", 1000, 200, QuestItem.Link + @"lightsaber.png", 0, 250));
                    _items.Add(new LootItem("Голокрон джедаев", "Источник знаний, почитаемый в Ордене джедаев. Обменивается на очки мудрости в Анклаве джедаев.", 1500, 300, QuestItem.Link + @"jedi-holocron.png", 0, 150));
                    break;
            }
        }
        public LootItem Loot()
        {
            Random random = new Random();
            int pos = random.Next(0, 8);
            try
            {
                return _items[pos];
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
