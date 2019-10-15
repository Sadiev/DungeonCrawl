using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DungeonCrawl
{
    public class Potion
    {
        public Potion(string name, string description, int cost)
        {
            Name = name;
            Description = description;
            Cost = cost;
        }

        public Potion()
        {
            Name = "";
            Description = "";
            Cost = 0;
        }
        
        public string Name { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }


        public static void Display()
        {
            Console.WriteLine();
            foreach(var i in Global.potion)
            {
                Console.WriteLine($"{i.Name}");
            }
        }

        //public static void Upload()
        //{
        //    try
        //    {
        //        StreamReader inputFile;
        //        inputFile = File.OpenText("../../../DungeonCrawl/Data/Potion.txt");

        //        while(!inputFile.EndOfStream)
        //        {
        //            string name = inputFile.ReadLine();
        //            string description = inputFile.ReadLine();
        //            int cost = int.Parse(inputFile.ReadLine());

        //            Global.potion.Add(new Potion(name, description, cost));
        //        }
        //        inputFile.Close();
        //    }
        //    catch(Exception)
        //    {
        //        Console.WriteLine("Error reading file 'Potion.txt'");
        //    }
        //}
    }
}
