﻿using System;
using System.Threading;
using Engine.Models;
using MajorEngine.Models;

namespace MajorEngine.Factories
{
    public static class MonsterFactory
    {
        public static Monster GetMonster(int monsterID)
        {
            switch (monsterID)
            {
                case 1:
                    Monster snake =
                        new Monster("Snake", "Snake.png", 4, 4, 5, 1);
                    AddLootItem(snake, 1003, 25);
                    AddLootItem(snake, 1004, 75);
                    return snake;
                case 2:
                    Monster rat =
                        new Monster("Rat", "Rat.png", 5, 5, 5, 1);
                    AddLootItem(rat, 1001, 25);
                    AddLootItem(rat, 1002, 75);
                    return rat;
                case 3:
                    Monster giantSpider =
                        new Monster("Giant Spider", "GiantSpider.png", 10, 10, 10, 3);
                    AddLootItem(giantSpider, 1005, 25);
                    AddLootItem(giantSpider, 1001, 75);
                    return giantSpider;
                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
            }
        }
        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if (RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.Inventory.Add(new ItemQuantity(itemID, 1));
            }
        }
    }
}