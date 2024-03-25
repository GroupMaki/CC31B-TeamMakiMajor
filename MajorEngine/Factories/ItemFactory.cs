using MajorEngine.Models;

namespace MajorEngine.Factories
{
    public static class ItemFactory
    {
        private static List<GameItem> _standardGameItems;
        static ItemFactory()
        {

            _standardGameItems = new List<GameItem>();
            _standardGameItems.Add(new Weapon(1001, "Mjölnir", 1, 1, 2, "Strong Hammer"));
            _standardGameItems.Add(new Weapon(1002, "Fafnir's Fang", 5, 1, 3,"Doggy Tooth"));
            _standardGameItems.Add(new Food(1003, "Siopao", 30, 20, "Pilipino tayo"));
            _standardGameItems.Add(new Food(1004, "Siomai", 10, 10, "Bayang Magiliw"));
            _standardGameItems.Add(new Food(1005, "Suman", 5, 50, "Perlas ng Silanganan"));
        }
        public static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);
            if (standardItem != null)
            {
                return standardItem.Clone();
            }
            return null;
        }
    }
}