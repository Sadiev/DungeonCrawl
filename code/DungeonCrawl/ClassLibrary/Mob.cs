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
            foreach (var item in Lists.mobs)
            {
                return $"{item.MobName}\n";
            }
            return null;
        }
        public static void Upload()
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
                        Lists.mobs.Add(new Mob { MobName = txt,
                                                 Description = roomsFile.ReadLine(),
                                                 HP = int.TryParse(roomsFile.ReadLine(), out int result)?result:0,
                                                 AC= int.TryParse(roomsFile.ReadLine(), out result) ? result : 0,
                                                 Armor= int.TryParse(roomsFile.ReadLine(), out result) ? result : 0
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
    }
}
