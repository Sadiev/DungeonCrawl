﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * 9/12/2019
 * CSC 253
 * Bradley Legge
 * Dilshod Sadiev
 * This 
 */

namespace DungeonCrawl
{
    class Program
    {


        static List<string> items = new List<string>() { "Book", "Candle", "Tools", "Rope" };
        static List<string> mobs = new List<string>() { "wolf", "spider", "snake", "dog", "cat" };
        public static int location = 0;


        static string[] roomArray = new string[] { "Entrance", "Hallway", "Barracks", "Laboratory", "Temple" };
        static string[] weaponArray = new string[] { "Longsword", "Bow", "Dagger", "Warhammer" };
        static string[] potArray = new string[] { "Health potion", "Armor potion" };
        static string[] tresArray = new string[] { "Gold", "Weapon", "Trinket" };
        //static string[] help = new string[] { "room - to print rooms", "weapon - to print weapons", "potion - to print weapons", "treasure - to print weapons",
        //                                    "north - to move north", "south - to move south", "exit - to exit program" };
        //TODO put in list, help array

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Dungeon Crawl.");
            Console.WriteLine($"You are in the room {roomArray[location]}");

            bool exit = false;
            Array.Sort(weaponArray);

            while (!exit)
            {
                switch (Console.ReadLine())
                {
                    case "room":
                        Print(roomArray);
                        break;
                    case "weapon":
                        Print(weaponArray);
                        break;
                    case "potion":
                        Print(potArray);
                        break;
                    case "treasure":
                        Print(tresArray);
                        break;
                    case "exit":
                        exit = true;
                        break;
                    //case "help":
                    //    Print(help);
                    //    break;
                    case "north":
                        Move("north");
                        break;
                    case "south":
                        Move("south");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }

        }

        static void Print(string[] collection)
        {
            Console.WriteLine();
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public static void Move(string direction)
        {
            switch (direction)
            {
                case "north":
                    if (location < roomArray.Length)
                    {
                        location++;
                    }
                    Console.WriteLine($"Your location is {roomArray[location]}");
                    break;
                case "south":
                    if (location > 0)
                    {
                        location--;
                    }
                    Console.WriteLine($"Your location is {roomArray[location]}");
                    break;
                default:
                    Console.WriteLine("Not a valid location");
                    break;
            }

        }
    }
}
