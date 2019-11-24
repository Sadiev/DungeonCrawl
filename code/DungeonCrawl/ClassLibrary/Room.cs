using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Room
    {
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public string Description { get; set; }
        public int ExitNorth { get; set; }
        public int ExitSouth { get; set; }

        public static void Display()
        {
            foreach (var item in Global.rooms)
            {
                Console.WriteLine($"{item.RoomName}");
            }
        }
    }
}
