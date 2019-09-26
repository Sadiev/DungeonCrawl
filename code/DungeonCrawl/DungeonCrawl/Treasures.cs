using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DungeonCrawl
{
    public class Treasures
    {
        public Treasures(string name, string description, int cost)
        {
            Name = name;
            Description = description;
            Cost = cost;
        }

        public Treasures()
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
            foreach(var i in Lists.treasure)
            {
                Console.WriteLine($"{i.Name}");
            }
        }

        public static void Upload()
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("../../../DungeonCrawl/Data/Treasures.txt");

                while (!inputFile.EndOfStream)
                {
                    string name = inputFile.ReadLine();
                    string description = inputFile.ReadLine();
                    int cost = int.Parse(inputFile.ReadLine());

                    Lists.treasure.Add(new Treasures(name, description, cost));
                }
                inputFile.Close();
            }
            catch(Exception)
            {
                Console.WriteLine("Error reading file 'Treasures.txt'");
            }
        }
    }
}
