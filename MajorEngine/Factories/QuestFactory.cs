using System.Collections.Generic;
using System.Linq;
using MajorEngine.Models;

namespace MajorEngine.Factories
{
    internal static class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();
        static QuestFactory()
        {
            // Declare the items need to complete the quest, and its reward items
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();
            itemsToComplete.Add(new ItemQuantity(1005, 1));
            rewardItems.Add(new ItemQuantity(1001, 1));
            // Create the quest
            _quests.Add(new Quest(1,
                                  "Kill nearby enemies to heal a small portion of your health",
                                  "Go to the next area...",
                                  itemsToComplete,
                                  25, 10,
                                  rewardItems));
            _quests.Add(new Quest(2,
                     "Pass through the mines",
                     "Go to the next area...",
                     itemsToComplete,
                     25, 10,
                     rewardItems));

            _quests.Add(new Quest(3,
                                 "Hello",
                                 "Go to the next area...",
                                 itemsToComplete,
                                 25, 10,
                                 rewardItems));

            _quests.Add(new Quest(4,
                                 "World",
                                 "Go to the next area...",
                                 itemsToComplete,
                                 25, 10,
                                 rewardItems));

            _quests.Add(new Quest(5,
                                 "Gahdamn",
                                 "Go to the next area...",
                                 itemsToComplete,
                                 25, 10,
                                 rewardItems));

            _quests.Add(new Quest(6,
                                 "Oh hear the wails of the orphan",
                                 "Go to the next area...",
                                 itemsToComplete,
                                 25, 10,
                                 rewardItems));


            _quests.Add(new Quest(7,
                                 "????????",
                                 "Go to the next area...",
                                 itemsToComplete,
                                 25, 10,
                                 rewardItems));


        }
        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}