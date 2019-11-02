using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class AliveObject
    {
        public AliveObject(string name, int hp, int ac, bool dead, string damage)
        {
            Name = name;
            HP = hp;
            AC = ac;
            Dead = dead;
            Damage = damage;
        }
        public AliveObject()
        { 
        
        }
        public string Name { get; set; }
        public int HP { get; set; }
        public int AC { get; set; }
        public bool Dead { get; set; }
        public string Damage { get; set; }
    }
}
