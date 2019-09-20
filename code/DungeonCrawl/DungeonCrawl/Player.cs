using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DungeonCrawl
{
    public class Player
    {
        public string PlayerName { get; set; }
        public string Password { get; set; }
        public string Class { get; set; }
        public string Race { get; set; }

        public static void WriteFile(Player myPlayer)
        {
            StreamWriter outputFile;
            outputFile = File.AppendText($"{myPlayer.PlayerName}.txt");

            outputFile.WriteLine(myPlayer.PlayerName);
            outputFile.WriteLine(myPlayer.Password);
            outputFile.WriteLine(myPlayer.Class);
            outputFile.WriteLine(myPlayer.Race);

            outputFile.Close();
        }


    }
}


