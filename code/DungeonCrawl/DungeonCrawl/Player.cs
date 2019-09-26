using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DungeonCrawl
{
    public enum ClassType { warrior, ranger, wizard }
    public enum RaceType { human, dwarf, elf }

    public class Player
    {
        public Player(string name, string password, string className, string raceName)
        {
            PlayerName = name;
            Password = password;
            ClassName = className;
            RaceName = raceName;
        }

        public Player()
        {
            PlayerName = "";
            Password = "";
            ClassName = "";
            RaceName = "";
        }

        public string PlayerName { get; set; }
        public string Password { get; set; }
        public string ClassName { get; set; }
        public string RaceName { get; set; }

        public static void WriteFile(Player myPlayer)
        {
            try
            {
                StreamWriter outputFile;
                outputFile = File.AppendText($"../../../DungeonCrawl/Users/{myPlayer.PlayerName}.txt");

                outputFile.WriteLine(myPlayer.PlayerName);
                outputFile.WriteLine(myPlayer.Password);
                outputFile.WriteLine(myPlayer.ClassName);
                outputFile.WriteLine(myPlayer.RaceName);

                outputFile.Close();
            }
            catch(Exception)
            {
                Console.WriteLine($"Error reading file {myPlayer.PlayerName}!");
            }
        }

        public static void ReadFile()
        {
            string playerName;

            Console.WriteLine("Enter the name of a player you wish to use.");
            Console.Write("> ");
            playerName = Console.ReadLine();

            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText($"../../../DungeonCrawl/Users/{playerName}.txt");

                while (!inputFile.EndOfStream)
                {
                    string name = inputFile.ReadLine();
                    string password = inputFile.ReadLine();
                    string className = inputFile.ReadLine();
                    string raceName = inputFile.ReadLine();

                    Player myPlayer = new Player(name, password, className, raceName);
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file '{playerName}'");
            }
        }

        public static void PlayerInfo()
        {
            string name = "";
            string password = "";
            string className = "";
            string raceName = "";
            bool goodPassword = false;
            bool goodClass = false;
            bool goodRace = false;

            Console.WriteLine("Enter a player name you wish to use.");
            Console.Write("> ");
            name = Console.ReadLine();

            do
            {
                Console.WriteLine("Enter a password.");
                Console.WriteLine("Must contain 1 uppercase, 1 lowercase, and 1 special character (!,@,#,$,%,&,*,?)");
                Console.Write("> ");
                password = Console.ReadLine();

                if(Conversion.UpperCase(password) >= 1 && Conversion.LowerCase(password) >= 1 && Conversion.SpecialCase(password) >= 1)
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

                if (className == ClassType.warrior.ToString() || className == ClassType.ranger.ToString() || className == ClassType.wizard.ToString())
                {
                    goodClass = true;
                }
            }

            while (goodRace == false)
            {
                Console.WriteLine("Enter a race you wish to play.");
                Console.WriteLine("Human, Dwarf, Elf");
                Console.Write("> ");
                raceName = Conversion.ConvertToLower(Console.ReadLine());

                if (raceName == RaceType.human.ToString() || raceName == RaceType.dwarf.ToString() || raceName == RaceType.elf.ToString())
                {
                    goodRace = true;
                }
            }


            Player myPlayer = new Player(name, password, className, raceName);

            Player.WriteFile(myPlayer);
        }
    }
}


