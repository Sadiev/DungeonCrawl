using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Mob
    {
        //public int ID { get; set; }
        public string MobName { get; set; }
        public string Description { get; set; }
        public int HP { get; set; }
        public int AC { get; set; }
        public int Armor { get; set; }
        public static string Display()
        {
            foreach (var item in Global.mobs)
            {
                return $"{item.MobName}\n";
            }
            return null;
        }
    }
}
