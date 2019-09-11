using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    class Array
    {
        public static void roomArray()
        {
            const int SIZE = 5;
            string[] roomArray = new string[SIZE];
            roomArray[0] = "Entrance";
            roomArray[1] = "Hallway";
            roomArray[2] = "Barracks";
            roomArray[3] = "Laboratory";
            roomArray[4] = "Temple";
        }

        public static void weapArray()
        {
            const int SIZE = 4;
            string[] weapArray = new string[SIZE];
            weapArray[0] = "Longsword";
            weapArray[1] = "Bow";
            weapArray[2] = "Dagger";
            weapArray[3] = "Warhammer";
        }

        public static void potArray()
        {
            const int SIZE = 2;
            string[] potArray = new string[SIZE];
            potArray[0] = "Health potion";
            potArray[1] = "Armor potion";
        }

        public static void tresArray()
        {
            const int SIZE = 3;
            string[] tresArray = new string[SIZE];
            tresArray[0] = "Gold";
            tresArray[1] = "Weapon";
            tresArray[2] = "Trinket";
        }
    }
}
