using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    class Item
    {
        public string ItemName { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }

        public static void Display()
        {
            Console.WriteLine();
            foreach (var item in Global.items)
            {
                Program.ColorPrint($"{item.ItemName}\n", ConsoleColor.Yellow);
            }
            Console.WriteLine();
        }
        //public static void Upload()
        //{
        //    try
        //    {
        //        StreamReader itemFile;
        //        string txt = "";
        //        itemFile = File.OpenText("../../../DungeonCrawl/Data/Items.txt");
        //        bool done = false;
        //        do
        //        {
        //            if ((txt = itemFile.ReadLine()) == null)
        //            {
        //                done = true;
        //            }
        //            else
        //            {
        //                Global.items.Add(new Item
        //                {
        //                    ItemName = txt,
        //                    Description = itemFile.ReadLine(),
        //                    Cost = decimal.TryParse(itemFile.ReadLine(), out decimal result) ? result : 0,
        //                });
        //            }
        //        } while (!done);

        //        itemFile.Close();
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("Error reading file 'Items.txt'");
        //    }
        //}
    }
}
