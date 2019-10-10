using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary
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

        public static string Display()
        {
            foreach(var i in Lists.treasure)
            {
                return $"{i.Name}";
            }
            return null;
        }

        public static void Upload()
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("../../../ClassLibrary/Data/Treasures.txt");

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
