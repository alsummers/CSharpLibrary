using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_OOP_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the game
            Console.WriteLine("Welcome hero. What is your name?");
            string playerName = Console.ReadLine();

            Console.WriteLine("What is your gamer name?");
            string gamerName = Console.ReadLine();
            bool typeSelect = true;
            do
            {
                Console.WriteLine("What is your type ? \n" +
                    "1. Barbarian \n" +
                    "2. Wizard \n" +
                    "3. Monk \n"
                    );

                int parseType = int.Parse(Console.ReadLine());
                switch (parseType)
                {
                    case 1:
                        Console.WriteLine("You have chosen to be a Barbarian.");
                        break;
                    case 2:
                        Console.WriteLine("You have chosen to be a Wizard");
                        break;
                    case 3:
                        Console.WriteLine("You have chosen to be a Monk");
                        break;
                    default:
                        Console.WriteLine("Please choose which type");
                        break;
                }
            }
            while (typeSelect);


                Console.ReadLine();

            //Player choices

            //Fight

            //Points

            //Death
            Player Allison = new Player("zedisdead", 12, 230, false, "player", "human");

            Creature Zed = new Creature("zed", 23, 344, false, "creature", "ratKing");
        }
    }
}
