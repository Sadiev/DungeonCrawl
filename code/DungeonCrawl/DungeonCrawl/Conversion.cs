using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    class Conversion
    {
        public static string ConvertToLower(string input)
        {
            string output;

            output = input.ToLower();

            return output;
        }

        public static int UpperCase(string input)
        {
            int upperCase = 0;

            foreach (char i in input)
            {
                if(char.IsUpper(i))
                {
                    upperCase++;
                }
            }
            return upperCase;
        }

        public static int LowerCase(string input)
        {
            int lowerCase = 0;

            foreach (char i in input)
            {
                if(char.IsLower(i))
                {
                    lowerCase++;
                }
            }

            return lowerCase;
        }

        public static int SpecialCase(string input)
        {
            int specialCase = 0;
            string[] str = { "!", "@", "#", "$", "%", "&", "*", "?" };

            foreach (char i in input)
            {
                if(str.Contains(i.ToString()))
                {
                    specialCase++;
                }
            }

            return specialCase;
        }
    }
}
