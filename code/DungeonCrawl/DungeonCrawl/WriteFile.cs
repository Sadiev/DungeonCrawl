using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DungeonCrawl
{
    public class WriteFile
    {
        public static void CreateFile(Player myPlayer)
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
