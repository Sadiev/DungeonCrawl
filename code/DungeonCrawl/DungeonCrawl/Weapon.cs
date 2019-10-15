using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DungeonCrawl
{
    public class Weapon
    {
        public Weapon(string name, string damage, string damageType, int cost)
        {
            Name = name;
            Damage = damage;
            DamageType = damageType;
            Cost = cost;
        }

        public Weapon()
        {
            Name = "";
            Damage = "";
            DamageType = "";
            Cost = 0;
        }

        public string Name { get; set; }
        public string Damage { get; set; }
        public string DamageType { get; set; }
        public int Cost { get; set; }

        public static void Display()
        {
            Console.WriteLine();
            foreach(var i in Global.weapon)
            {
                Console.WriteLine($"{i.Name}");
            }
        }

        //public static void Upload()
        //{
        //    try
        //    {
        //        StreamReader inputFile;
        //        inputFile = File.OpenText("../../../DungeonCrawl/Data/Weapons.txt");

        //        while (!inputFile.EndOfStream)
        //        {

        //            string name = inputFile.ReadLine();
        //            string damage = inputFile.ReadLine();
        //            string damageType = inputFile.ReadLine();
        //            int cost = int.Parse(inputFile.ReadLine());

        //            Global.weapon.Add(new Weapon(name, damage, damageType, cost));
        //        }
        //        inputFile.Close();;
        //    }
        //    catch(Exception)
        //    {
        //        Console.WriteLine("Error reading file 'Weapons.txt'");
        //    }
        //}
    }
}
