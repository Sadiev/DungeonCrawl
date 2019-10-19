using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Item
    {
        public string ItemName { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }

        public static string Display()
        {
            foreach (var item in Global.items)
            {
                return $"{item.ItemName}\n";
            }
            return null;
        }
    }
}
