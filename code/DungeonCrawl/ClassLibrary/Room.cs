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
        public string RoomName { get; set; }
        public string Description { get; set; }
        public string Exits { get; set; }

        public static void Write()
        {
            try
            {
                StreamWriter outputFile;
                outputFile = File.AppendText("../../../ClassLibrary/Data/Rooms.txt");
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

        public static string Display()
        {
            foreach (var item in Lists.rooms)
            {
                return $"{item.RoomName}\n";
            }
            return null;
        }
    }
}
