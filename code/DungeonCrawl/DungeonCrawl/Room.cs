using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    class Room
    {
        public string RoomName { get; set; }
        public string Description { get; set; }
        public string Exits { get; set; }

        public static void Write()
        {
            try
            {
                StreamWriter outputFile;
                outputFile = File.AppendText("../../../DungeonCrawl/Data/Rooms.txt");
                Console.Write("Enter a room name > ");
                outputFile.WriteLine(Console.ReadLine());
                Console.Write("Enter the room description > ");
                outputFile.WriteLine(Console.ReadLine());
                Console.Write("Enter the room exits > ");
                outputFile.WriteLine(Console.ReadLine());
                outputFile.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        //public static void Upload()
        //{
        //    try
        //    {
        //        StreamReader roomsFile;
        //        string txt = "";
        //        roomsFile = File.OpenText("../../../DungeonCrawl/Data/Rooms.txt");
        //        bool done = false;
        //        do
        //        {
        //            if ((txt = roomsFile.ReadLine()) == null)
        //            {
        //                done = true;
        //            }
        //            else
        //            {
        //                Global.rooms.Add(new Room { RoomName = txt, Description = roomsFile.ReadLine(), Exits = roomsFile.ReadLine() });
        //            }
        //        } while (!done);

        //        roomsFile.Close();
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("Error reading file 'Room.txt'");
        //    }
        //}

        public static void Display()
        {
            Console.WriteLine();
            foreach (var item in Global.rooms)
            {
                Program.ColorPrint($"{item.RoomName}\n", ConsoleColor.Yellow);
            }
            Console.WriteLine();
        }
    }
}
