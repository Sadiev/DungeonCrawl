using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

/**
 * 9/12/2019
 * CSC 253
 * Bradley Legge
 * Dilshod Sadiev
 * Dungeon Crawl
 */

namespace DungeonCrawl
{
    public class Program
    {
        public static int location = 0;

        //static string[] help = new string[] { "room - to print rooms", "weapon - to print weapons", "potion - to print weapons", "treasure - to print weapons",
        //                                    "north - to move north", "south - to move south", "exit - to exit program" };
        //TODO put in list, help array

        public static void Main(string[] args)//test git hub
        {
            LoginInfo.AskLogin();
            Upload.Weapon();
            Upload.Treasures();
            Upload.Item();
            Upload.Mob();
            Upload.Potion();
            Upload.Room();
            Play();
        }

        static void Play()
        {
            ColorPrint("Welcome to Dungeon Crawl.\n", ConsoleColor.Red);
            bool exit = false;
            string input = "";
            //List<string> inputList
            while (!exit)
            {
                ColorPrint($"HP >", ConsoleColor.Green);
                input = Console.ReadLine();
                var inputList = input.Split(' ');
                
                switch (inputList[0])
                {
                    case "room":
                        Console.WriteLine(Room.Display());
                        break;
                    case "weapon":
                        Console.WriteLine(Weapon.Display());
                        break;
                    case "potion":
                        Console.WriteLine(Potion.Display());
                        break;
                    case "treasure":
                        Console.WriteLine(Treasures.Display());
                        break;
                    case "item":
                        Console.WriteLine(Item.Display());
                        break;
                    case "mob":
                        Console.WriteLine(Mob.Display());
                        break;
                    case "north":
                        Move("north");
                        break;
                    case "south":
                        Move("south");
                        break;
                    case "add room":
                        Room.Write();
                        break;
                    case "look":
                        PrintList(inputList[1]);
                        break;
                    case "exit":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Command not found!");
                        break;
                }
            }
        }
        public static void ColorPrint(string txt, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(txt);
            Console.ResetColor();
        }

        static void PrintList(string name)
        {
            var item = Lists.items.Find(x => x.ItemName.ToLower() == name.ToLower());
            if (item != null)
            {
                Console.WriteLine(item.ItemName);
                Console.WriteLine(item.Description);
                Console.WriteLine(item.Cost);
                return;
            }
            var mob = Lists.mobs.Find(x => x.MobName.ToLower() == name.ToLower());
            if (mob != null)
            {
                Console.WriteLine(mob.MobName);
                Console.WriteLine(mob.Description);
                Console.WriteLine(mob.Armor);
                Console.WriteLine(mob.AC);
                Console.WriteLine(mob.HP);
                return;
            }
            var p = Lists.potion.Find(x => x.Name.ToLower() == name.ToLower());
            if (p != null)
            {
                Console.WriteLine(p.Name);
                Console.WriteLine(p.Description);
                Console.WriteLine(p.Cost);
                return;
            }
            var room = Lists.rooms.Find(x => x.RoomName.ToLower() == name.ToLower());
            if (room != null)
            {
                Console.WriteLine(room.RoomName);
                Console.WriteLine(room.Description);
                Console.WriteLine(room.Exits);
                return;
            }
            var t = Lists.treasure.Find(x => x.Name.ToLower() == name.ToLower());
            if (t != null)
            {
                Console.WriteLine(t.Name);
                Console.WriteLine(t.Description);
                Console.WriteLine(t.Cost);
                return;
            }
            var w = Lists.weapon.Find(x => x.Name.ToLower() == name.ToLower());
            if (w != null)
            {
                Console.WriteLine(w.Name);
                Console.WriteLine(w.Damage);
                Console.WriteLine(w.DamageType);
                Console.WriteLine(w.Cost);
                return;
            }
            Console.WriteLine("The object not found!");
        }

        static void Print(string[] collection)
        {
            Console.WriteLine();
            foreach (var item in collection)
            {
                ColorPrint($"{item}\n",ConsoleColor.Yellow);
            }
            Console.WriteLine();
        }

        public static void Move(string direction)
        {
            switch (direction)
            {
                case "north":
                    if (location < Lists.rooms.Count)
                    {
                        location++;
                    }
                    //Console.WriteLine($"Your location is {roomArray[location]}");
                    break;
                case "south":
                    if (location > 0)
                    {
                        location--;
                    }
                    //Console.WriteLine($"Your location is {roomArray[location]}");
                    break;
                default:
                    Console.WriteLine("Not a valid location");
                    break;
            }
        }
    }
}
