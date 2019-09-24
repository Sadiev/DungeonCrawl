using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DungeonCrawl
{
    public enum ClassType { Warrior, Ranger, Wizard }
    public enum RaceType { Human, Dwarf, Elf }

    public class Player
    {
        private string _playerName;
        private string _password;
        private string _className;
        private string _raceName;

        public Player(string name, string password, string className, string raceName)
        {
            PlayerName = name;
            Password = password;
            ClassName = className;
            RaceName = raceName;
        }

        public string PlayerName { get { return _playerName; } set { _playerName = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public string ClassName { get { return _className; } set { _className = value; } }
        public string RaceName { get { return _raceName; } set { _raceName = value; } }

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

        public static void PlayerInfo()
        {
            string name = "";
            string password = "";
            string className = "";
            string raceName = "";
            bool goodClass = false;
            bool goodRace = false;

            Console.WriteLine("Enter a player name you wish to use.");
            Console.Write("> ");
            name = Console.ReadLine();

            Console.WriteLine("Enter a password.");
            Console.Write("> ");
            password = Console.ReadLine();



            while (goodClass == false)
            {
                Console.WriteLine("Enter a class you wish to play.");
                Console.WriteLine("Warrior, Ranger, Wizard");
                Console.Write("> ");
                className = Console.ReadLine();

                if (className == ClassType.Warrior.ToString() || className == ClassType.Ranger.ToString() || className == ClassType.Wizard.ToString())
                {
                    goodClass = true;
                }
            }

            while (goodRace == false)
            {
                Console.WriteLine("Enter a race you wish to play.");
                Console.WriteLine("Human, Dwarf, Elf");
                Console.Write("> ");
                raceName = Console.ReadLine();

                if (raceName == RaceType.Human.ToString() || raceName == RaceType.Dwarf.ToString() || raceName == RaceType.Elf.ToString())
                {
                    goodRace = true;
                }
            }


            Player myPlayer = new Player(name, password, className, raceName);


            Player.WriteFile(myPlayer);
        }
    }
}


