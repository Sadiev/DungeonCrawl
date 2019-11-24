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
            Upload.Weapons();
            Upload.Treasures();
            Upload.Potions();
            Upload.Items();
            Upload.Mobs();
            Upload.Rooms();
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
                        Room.Display();
                        break;
                    case "weapon":
                        Weapon.Display();
                        break;
                    case "potion":
                        Potion.Display();
                        break;
                    case "treasure":
                        Treasures.Display();
                        break;
                    case "item":
                        Item.Display();
                        break;
                    case "mob":
                        Mob.Display();
                        break;
                    case "north":
                        Move("north");
                        break;
                    case "south":
                        Move("south");
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
            var item = Global.items.Find(x => x.Name.ToLower() == name.ToLower());
            if (item != null)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Description);
                Console.WriteLine(item.Cost);
                return;
            }
            var mob = Global.mobs.Find(x => x.Name.ToLower() == name.ToLower());
            if (mob != null)
            {
                Console.WriteLine(mob.Name);
                Console.WriteLine(mob.Description);
                Console.WriteLine(mob.Damage);
                Console.WriteLine(mob.AC);
                Console.WriteLine(mob.HP);
                return;
            }
            var p = Global.potion.Find(x => x.Name.ToLower() == name.ToLower());
            if (p != null)
            {
                Console.WriteLine(p.Name);
                Console.WriteLine(p.Description);
                Console.WriteLine(p.Cost);
                return;
            }
            var room = Global.rooms.Find(x => x.RoomName.ToLower() == name.ToLower());
            if (room != null)
            {
                Console.WriteLine(room.RoomID);
                Console.WriteLine(room.RoomName);
                Console.WriteLine(room.Description);
                Console.WriteLine(room.ExitNorth);
                Console.WriteLine(room.ExitSouth);
                return;
            }
            var t = Global.treasure.Find(x => x.Name.ToLower() == name.ToLower());
            if (t != null)
            {
                Console.WriteLine(t.Name);
                Console.WriteLine(t.Description);
                Console.WriteLine(t.Cost);
                return;
            }
            var w = Global.weapon.Find(x => x.Name.ToLower() == name.ToLower());
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
                    if (location < Global.rooms.Count)
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
