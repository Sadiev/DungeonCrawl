﻿using ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Item: IInventory
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }

        public static void Display()
        {
            foreach (var item in Global.items)
            {
                Console.WriteLine($"{item.Name}");
            }
        }
    }
}
