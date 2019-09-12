using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    class Class
    {
        List<string> mobs = new List<string>();
        List<string> items = new List<string>();
        public static int location = 0;


        public static void Move(string direction, string[] rooms)
        {
            switch (direction)
            {
                case "north":
                    if (location < rooms.Length)
                        location++;                   
                    break;
                case "south":
                    if (location > 0)
                        location--;
                    break;
                default:
                    Console.WriteLine("Not a valid location");
                    break;
            }
            Console.WriteLine($"Your location is {rooms[location]}");

        }
    }
}
