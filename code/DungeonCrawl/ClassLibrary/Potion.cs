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


        public static void Display()
        {
            foreach(var i in Global.potion)
            {
                Console.WriteLine($"{i.Name}");
            }
        }
    }
}
