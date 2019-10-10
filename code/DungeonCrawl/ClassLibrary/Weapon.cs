using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary
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

        public static string Display()
        {
            foreach(var i in Lists.weapon)
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
                inputFile = File.OpenText("../../../ClassLibrary/Data/Weapons.txt");

                while (!inputFile.EndOfStream)
                {

                    string name = inputFile.ReadLine();
                    string damage = inputFile.ReadLine();
                    string damageType = inputFile.ReadLine();
                    int cost = int.Parse(inputFile.ReadLine());

                    Lists.weapon.Add(new Weapon(name, damage, damageType, cost));
                }
                inputFile.Close();;
            }
            catch(Exception)
            {
                Console.WriteLine("Error reading file 'Weapons.txt'");
            }
        }
    }
}
