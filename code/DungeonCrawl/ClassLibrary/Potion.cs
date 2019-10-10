using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary
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


        public static string Display()
        {
            foreach(var i in Lists.potion)
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
                inputFile = File.OpenText("../../../ClassLibrary/Data/Potion.txt");

                while(!inputFile.EndOfStream)
                {
                    string name = inputFile.ReadLine();
                    string description = inputFile.ReadLine();
                    int cost = int.Parse(inputFile.ReadLine());

                    Lists.potion.Add(new Potion(name, description, cost));
                }
                inputFile.Close();
            }
            catch(Exception)
            {
                Console.WriteLine("Error reading file 'Potion.txt'");
            }
        }
    }
}
