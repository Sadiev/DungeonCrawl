using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary
{
    public class Player: AliveObject
    {
        //TODO.  "Damage" needs to be deleted, just used for sprint 3.

        public enum ClassType { warrior, ranger, wizard }
        public enum RaceType { human, dwarf, elf }
        public string Password { get; set; }
        public string ClassName { get; set; }
        public string RaceName { get; set; }
        public Player(string name, string password, string className, string raceName, int hp, int ac, bool dead, string damage)
                    :base(name, hp, ac, dead, damage)
        {
            Password = password;
            ClassName = className;
            RaceName = raceName;
        }

        public static void CreatePlayer()
        {
            string name = "";
            string password = "";
            string className = "";
            string raceName = "";
            int hp = 0;
            int ac = 15;
            string damage = "";
            bool dead = false;
            bool goodPassword = false;
            bool goodClass = false;
            bool goodRace = false;
            bool exit = false;

            while (exit == false)
            {
                Console.WriteLine("Enter a player name you wish to use.");
                Console.Write("> ");
                name = Console.ReadLine();

                if (File.Exists($"../../../ClassLibrary/Users/{name}.txt"))
                {
                    Console.WriteLine("This character already exists!");
                }
                else
                {
                    exit = true;
                }
            }

            do
            {
                Console.WriteLine("Enter a password.");
                Console.WriteLine("Must contain 1 uppercase, 1 lowercase, and 1 special character (!,@,#,$,%,&,*,?)");
                Console.Write("> ");
                password = Console.ReadLine();

                if (Conversion.UpperCase(password) >= 1 && Conversion.LowerCase(password) >= 1 && Conversion.SpecialCase(password) >= 1)
                {
                    goodPassword = true;
                }
                else
                {
                    Console.WriteLine("Invalid Password!");
                }

            } while (goodPassword == false);

            while (goodClass == false)
            {
                Console.WriteLine("Enter a class you wish to play.");
                Console.WriteLine("Warrior, Ranger, Wizard");
                Console.Write("> ");
                className = Conversion.ConvertToLower(Console.ReadLine());

                if (className == ClassType.warrior.ToString())
                {
                    damage = "1d8";
                    goodClass = true;
                }
                else if (className == ClassType.ranger.ToString())
                {
                    damage = "1d8";
                    goodClass = true;
                }
                else if (className == ClassType.wizard.ToString())
                {
                    damage = "1d6";
                    goodClass = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input! Try again!");
                }

            }

            while (goodRace == false)
            {
                Console.WriteLine("Enter a race you wish to play.");
                Console.WriteLine("Human, Dwarf, Elf");
                Console.Write("> ");
                raceName = Conversion.ConvertToLower(Console.ReadLine());

                if (raceName == RaceType.human.ToString())
                {
                    hp = 16;
                    goodRace = true;
                }
                else if (raceName == RaceType.dwarf.ToString())
                {
                    hp = 18;
                    goodRace = true;
                }
                else if (raceName == RaceType.elf.ToString())
                {
                    hp = 14;
                    goodRace = true;
                }
            }


            Player myPlayer = new Player(name, password, className, raceName, hp, ac, dead, damage);

            Player.WriteFile(myPlayer);
        }

        public static void WriteFile(Player myPlayer)
        {
            try
            {
                StreamWriter outputFile;
                outputFile = File.AppendText($"../../../ClassLibrary/Users/{myPlayer.Name}.txt");

                outputFile.WriteLine(myPlayer.Name);
                outputFile.WriteLine(myPlayer.Password);
                outputFile.WriteLine(myPlayer.ClassName);
                outputFile.WriteLine(myPlayer.RaceName);
                outputFile.WriteLine(myPlayer.HP);
                outputFile.WriteLine(myPlayer.AC);
                outputFile.WriteLine(myPlayer.Dead);
                outputFile.WriteLine(myPlayer.Damage);

                outputFile.Close();
            }
            catch (Exception)
            {
                Console.WriteLine($"Error reading file {myPlayer.Name}!");
            }
        }

        public static void ReadFile()
        {
            string playerName;
            string psswrd;
            bool exit = false;

            Console.WriteLine("Enter the name of a player you wish to use.");
            Console.Write("> ");
            playerName = Console.ReadLine();

            Console.WriteLine("Enter password.");
            Console.Write("> ");
            psswrd = Console.ReadLine();

            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText($"../../../ClassLibrary/Users/{playerName}.txt");

                while (!inputFile.EndOfStream)
                {
                    string name = inputFile.ReadLine();
                    string password = inputFile.ReadLine();
                    string className = inputFile.ReadLine();
                    string raceName = inputFile.ReadLine();
                    int hp = int.Parse(inputFile.ReadLine());
                    int ac = int.Parse(inputFile.ReadLine());
                    bool dead = bool.Parse(inputFile.ReadLine());
                    string damage = inputFile.ReadLine();

                    while (exit == false)
                    {
                        if (psswrd != password)
                        {
                            Console.WriteLine("Password is incorrect! Try again!");
                            Console.Write("> ");
                            psswrd = Console.ReadLine();
                        }
                        else
                        {
                            exit = true;
                        }
                    }

                    Global.CurrentPlayer = new Player(name, password, className, raceName, hp, ac, dead, damage);
                }

                //Program.ColorPrint($"Welcome {Global.CurrentPlayer.PlayerName}.", ConsoleColor.Green);
                inputFile.Close();
            }
            catch (Exception)
            {
                Console.Write($"{playerName}, doesnt exist.");
                LoginInfo.AskLogin();
            }
        }

    }
}


