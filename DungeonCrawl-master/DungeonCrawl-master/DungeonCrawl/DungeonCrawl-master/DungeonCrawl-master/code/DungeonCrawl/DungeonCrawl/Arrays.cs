using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    class Arrays
    {
        static void arrays()
        {
            const int ROOM_SIZE = 5;
            const int WEAP_SIZE = 4;
            const int POT_SIZE = 2;
            const int TREAS_SIZE = 3;

            string[] roomArray = new string[ROOM_SIZE];
            roomArray[0] = "Entrance";
            roomArray[1] = "Hallway";
            roomArray[2] = "Office";
            roomArray[3] = "Barracks";
            roomArray[4] = "Laboratory";

            string[] weapArray = new string[WEAP_SIZE];
            weapArray[0] = "Two-Handed Sword";
            weapArray[1] = "Dagger";
            weapArray[2] = "Wand";
            weapArray[3] = "Bow";

            string[] potArray = new string[POT_SIZE];
            potArray[0] = "Health Potion";
            potArray[1] = "Armor Potion";   //Increase HP by certain amount.

            string[] treasArray = new string[TREAS_SIZE];
            treasArray[0] = "Gold";
            treasArray[1] = "Armor";
            treasArray[2] = "Gems";
        }
    }
}
