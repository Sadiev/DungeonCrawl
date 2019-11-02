using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClassLibrary.Interfaces;

namespace ClassLibrary
{
    public class Weapon: IInventory
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string Damage { get; set; }
        public string DamageType { get; set; }
        public Weapon(string name, string damage, string damageType, decimal cost)
        {
            Name = name;
            Damage = damage;
            DamageType = damageType;
            Cost = cost;
        }

        public Weapon()
        {

        }

        public static void Display()
        {
            foreach(var i in Global.weapon)
            {
                Console.WriteLine($"{i.Name}");
            }
        }
    }
}
