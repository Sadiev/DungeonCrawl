using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LoginInfo
    {
        public static void AskLogin()
        {
            Console.WriteLine("Do you wish to create a new player? (yes/no)");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "yes":
                    Player.CreatePlayer();
                    break;
                case "no":
                    Player.ReadFile();
                    break;
                default:
                    Console.WriteLine("Invalid input! Please enter yes or no!");
                    AskLogin();
                    break;
            }
        }
    }
}
