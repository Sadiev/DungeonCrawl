using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary
{
    public class Upload
    {
       public static void Items()
        {
            using (var reader = new StreamReader(@"../../../ClassLibrary/Data/Items.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Global.items.Add(new Item
                    {
                        Name = values[0],
                        Description = values[1],
                        Cost = decimal.TryParse(values[1], out decimal result) ? result : 0
                    });
                }
            }
        }
        public static void Mobs()
        {
            using (var reader = new StreamReader(@"../../../ClassLibrary/Data/Mobs.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Global.mobs.Add(new Mob
                    {
                        Name = values[0],
                        Description = values[1],
                        HP = int.TryParse(values[2], out int result) ? result : 0,
                        AC = int.TryParse(values[3], out result) ? result : 0,
                        Dead = bool.Parse(values[4]),
                        Damage = values[5]
                    });
                }
            }
        }
        public static void Potions()
        {
            using (var reader = new StreamReader(@"../../../ClassLibrary/Data/Potions.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Global.potion.Add(new Potion
                    {
                        Name = values[0],
                        Description = values[1],
                        Cost = decimal.TryParse(values[2], out decimal result) ? result : 0
                    });
                }
            }
        }
        public static void Rooms()
        {
            using (var reader = new StreamReader(@"../../../ClassLibrary/Data/Rooms.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Global.rooms.Add(new Room { RoomName = values[0], Description = values[1], Exits = values[2] });
                }
            }
        }
        public static void Treasures()
        {
            using (var reader = new StreamReader(@"../../../ClassLibrary/Data/Treasures.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Global.treasure.Add(new Treasures { Name = values[0], Description = values[1], Cost = decimal.TryParse(values[2], out decimal result) ? result : 0 });
                }
            }
        }
        public static void Weapons()
        {
            using (var reader = new StreamReader(@"../../../ClassLibrary/Data/Weapons.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Global.weapon.Add(new Weapon
                    {
                        Name = values[0],
                        Damage = values[1],
                        DamageType = values[2],
                        Cost = decimal.TryParse(values[3], out decimal result) ? result : 0
                    });
                }
            }
        }
    }
}
