using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Mob: AliveObject
    {
        public Mob(string name, string description, int hp, int ac, bool dead, string damage )
                    : base(name, hp, ac, dead, damage)
        {
            Description = description;
        }

        public string Description { get; set; }
        public static void Display()
        {
            foreach (var item in Global.mobs)
            {
                Console.WriteLine($"{item.Name}");
            }
        }
    }
}
