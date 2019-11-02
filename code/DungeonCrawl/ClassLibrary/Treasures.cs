using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClassLibrary.Interfaces;

namespace ClassLibrary
{
    public class Treasures : IInventory
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public Treasures(string name, string description, decimal cost)
        {
            Name = name;
            Description = description;
            Cost = cost;
        }

        public Treasures()
        {

        }

        public static void Display()
        {
            foreach(var i in Global.treasure)
            {
                Console.WriteLine($"{i.Name}");
            }
        }
    }
}
