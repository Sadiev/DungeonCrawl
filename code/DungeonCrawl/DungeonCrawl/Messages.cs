using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    public class Messages
    {
        public string PromptName
        {
            get
            {
                return "Enter your player name > ";
            }
        }

        public string PromptPassword
        {
            get
            {
                return "Enter your password > ";
            }
        }
        
        public string PromptClass
        {
            get
            {
                return "Enter a class you wish to play" +
                       "\nWarrior, Ranger, Wizard > ";
            }
        }

        public string PromptRace
        {
            get
            {
                return "Enter a race you wish to play" +
                       "\nHuman, Dwarf, Elf > ";
            }
        }

    }
}
