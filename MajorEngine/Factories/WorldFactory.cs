using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MajorEngine.Models;


namespace MajorEngine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()

        {
            World newWorld = new World();

            // Draugr Burial Mounds
            newWorld.AddLocation(
                0, 0,
                "C:\\Users\\Lenovo\\MajorEngine\\Images\\Titles\\The Mines.png",
                "C:\\Users\\Lenovo\\MajorEngine\\Images\\sec\\Burial.png",
                "C:\\Users\\Lenovo\\MajorEngine\\Images\\Locations\\second.jpg"
                );
            newWorld.LocationAt(0, 0).AddMonster(3, 100);

            newWorld.LocationAt(0,0).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));

            // The Mines
            newWorld.AddLocation(
                0, 1,
                "C:\\Users\\Lenovo\\MajorEngine\\Images\\Titles\\Draugr Burial Mound.png",
                "C:\\Users\\Lenovo\\MajorEngine\\Images\\sec\\3.png",
                "C:\\Users\\Lenovo\\MajorEngine\\Images\\Locations\\siomai rice.png"
                );
            newWorld.LocationAt(0, 1).AddMonster(3, 100);
            newWorld.LocationAt(0, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(2));

            // Abandoned Draugr Village
            newWorld.AddLocation(
                1, 1,
                "C:\\Users\\Lenovo\\MajorEngine\\Images\\Titles\\3.png",
                "C:\\Users\\Lenovo\\MajorEngine\\Images\\sec\\Abandoned.png",
                "C:\\Users\\Lenovo\\MajorEngine\\Images\\Locations\\tapa rice.jpg"
                );
            newWorld.LocationAt(1, 1).AddMonster(2, 100);
            newWorld.LocationAt(1, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(3));

            // Black Tree on the White Mound
            newWorld.AddLocation(
                1, 0,
                "C:\\Users\\Lenovo\\MajorEngine\\Images\\Titles\\4.png",
                "C:\\Users\\Lenovo\\MajorEngine\\Images\\sec\\Tree.png",
                "C:\\Users\\Lenovo\\MajorEngine\\Images\\Locations\\hotsilog.jpg"
                );
            newWorld.LocationAt(1, 0).AddMonster(1, 100);
            newWorld.LocationAt(1, 0).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(4));

            // Forest of Lost Valor
            newWorld.AddLocation(
                -1, -1,
                "C:\\Users\\Lenovo\\MajorEngine\\Images\\Titles\\5.png",
                "C:\\Users\\Lenovo\\MajorEngine\\Images\\sec\\Forest.png",
                "C:\\Users\\Lenovo\\MajorEngine\\Images\\hamster.jpg"
                );
            newWorld.LocationAt(-1, -1).AddMonster(3, 100);
            newWorld.LocationAt(-1, -1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(5));

            // Dwarven Forge
            newWorld.AddLocation(
                2, 0,
                "C:\\Users\\Lenovo\\MajorEngine\\Images\\Titles\\6.png",
                "C:\\Users\\Lenovo\\MajorEngine\\Images\\sec\\Forge.png",
                "C:\\Users\\Lenovo\\MajorEngine\\Images\\hamster.jpg"
                );
            newWorld.LocationAt(2, 0).AddMonster(2, 100);
            newWorld.LocationAt(2, 0).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(6));

            //Bifrost Gate: Valheim Entrance
            newWorld.AddLocation(
                -1, 0,
                "C:\\Users\\Lenovo\\MajorEngine\\Images\\Titles\\7.png",
                "C:\\Users\\Lenovo\\MajorEngine\\Images\\sec\\Gate.png", 
                "C:\\Users\\Lenovo\\MajorEngine\\Images\\hamster.jpg")
                ;
            newWorld.LocationAt(-1, 0).AddMonster(1, 100);
            newWorld.LocationAt(-1, 0).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(7));

            return newWorld;
        }
    }
}