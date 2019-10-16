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
        public static void Weapon()
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
                inputFile.Close(); ;
            }
            catch (Exception)
            {
                Console.WriteLine("Error reading file 'Weapons.txt'");
            }
        }

        public static void Treasures()
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("../../../ClassLibrary/Data/Treasures.txt");

                while (!inputFile.EndOfStream)
                {
                    string name = inputFile.ReadLine();
                    string description = inputFile.ReadLine();
                    int cost = int.Parse(inputFile.ReadLine());

                    Lists.treasure.Add(new Treasures(name, description, cost));
                }
                inputFile.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Error reading file 'Treasures.txt'");
            }
        }

        public static void Potion()
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("../../../ClassLibrary/Data/Potion.txt");

                while (!inputFile.EndOfStream)
                {
                    string name = inputFile.ReadLine();
                    string description = inputFile.ReadLine();
                    int cost = int.Parse(inputFile.ReadLine());

                    Lists.potion.Add(new Potion(name, description, cost));
                }
                inputFile.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Error reading file 'Potion.txt'");
            }
        }

        public static void Mob()
        {
            try
            {
                StreamReader roomsFile;
                string txt = "";
                roomsFile = File.OpenText("../../../ClassLibrary/Data/Mobs.txt");
                bool done = false;
                do
                {
                    if ((txt = roomsFile.ReadLine()) == null)
                    {
                        done = true;
                    }
                    else
                    {
                        Lists.mobs.Add(new Mob
                        {
                            MobName = txt,
                            Description = roomsFile.ReadLine(),
                            HP = int.TryParse(roomsFile.ReadLine(), out int result) ? result : 0,
                            AC = int.TryParse(roomsFile.ReadLine(), out result) ? result : 0,
                            Armor = int.TryParse(roomsFile.ReadLine(), out result) ? result : 0
                        });
                    }
                } while (!done);

                roomsFile.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Error reading file 'Mob.txt'");
            }
        }

        public static void Item()
        {
            try
            {
                StreamReader itemFile;
                string txt = "";
                itemFile = File.OpenText("../../../ClassLibrary/Data/Items.txt");
                bool done = false;
                do
                {
                    if ((txt = itemFile.ReadLine()) == null)
                    {
                        done = true;
                    }
                    else
                    {
                        Lists.items.Add(new Item
                        {
                            ItemName = txt,
                            Description = itemFile.ReadLine(),
                            Cost = decimal.TryParse(itemFile.ReadLine(), out decimal result) ? result : 0,
                        });
                    }
                } while (!done);

                itemFile.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Error reading file 'Items.txt'");
            }
        }

        public static void Room()
        {
            try
            {
                StreamReader roomsFile;
                string txt = "";
                roomsFile = File.OpenText("../../../ClassLibrary/Data/Rooms.txt");
                bool done = false;
                do
                {
                    if ((txt = roomsFile.ReadLine()) == null)
                    {
                        done = true;
                    }
                    else
                    {
                        Lists.rooms.Add(new Room { RoomName = txt, Description = roomsFile.ReadLine(), Exits = roomsFile.ReadLine() });
                    }
                } while (!done);

                roomsFile.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Error reading file 'Room.txt'");
            }
        }
    }
}
