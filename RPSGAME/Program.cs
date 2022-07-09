using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGAME
{
    class Program
    {
        static void Main(string[] args)
        {
            int NoOfGames = 0;
            int count_A_Victories = 0;
            int count_B_Victories = 0;

            Console.WriteLine("Welcome to Rock Paper Scissor game");

            while (NoOfGames < 100)
            {

                string[] choices = new string[3] { "ROCK", "PAPER", "SCISSOR" };
                Random rand = new Random();
                int random_choice = rand.Next(0, 3);
                Console.WriteLine("<< Game Number:" + (NoOfGames + 1) + " >>\n");
                Logger.writelog("<< Game Number:" + (NoOfGames + 1) + " >>\n");
                if (NoOfGames == 0)
                {
                    Console.WriteLine("Options to select are: 1: ROCK, 2: PAPER, 3: SCISSOR " +
                        "\n Player A will always bet on ROCK and \n" +
                        "Player B will select a new random choice in every game \n");
                }
                string Player_A = "ROCK"; //PLAYER A always bet on ROCK
                Console.WriteLine("Player A selection is: ROCK "); //PLAYER A selection output
                Console.WriteLine("Player B selection is: " + choices[random_choice]);

                if (Player_A == "ROCK" && choices[random_choice] == "SCISSOR")
                {
                    Console.WriteLine("Result: Player-A wins");
                    Logger.writelog("Result: Player-A wins");
                    count_A_Victories += 1;
                }
                else if (Player_A == "ROCK" && choices[random_choice] == "PAPER")
                {
                    Console.WriteLine("Result: Player-B wins");
                    Logger.writelog("Result: Player-B wins");
                    count_B_Victories += 1;
                }
                else if (Player_A == "ROCK" && choices[random_choice] == "ROCK")
                {
                    Console.WriteLine("Result: Same choice, Game Drawn");
                    Logger.writelog("Result: Same choice, Game Drawn");
                }

                NoOfGames++;
                Console.WriteLine("------------------------");
            }
            Console.WriteLine("Summary:");
            Console.WriteLine("Total Games Played " + (NoOfGames));
            Console.WriteLine("Player_A wins " + count_A_Victories + " games");
            Console.WriteLine("Player_B wins " + count_B_Victories + " games");
            Console.WriteLine("Games Drawn " + ((NoOfGames) - (count_A_Victories + count_B_Victories)) + " times");
            Logger.writelog("hi this is a message");
            Logger.writelog("Summary:");
            Logger.writelog("Total Games Played " + (NoOfGames));
            Logger.writelog("Player_A wins " + count_A_Victories + " games");
            Logger.writelog("Player_B wins " + count_B_Victories + " games");
            Logger.writelog("Games Drawn " + ((NoOfGames) - (count_A_Victories + count_B_Victories)) + " times");
        }
    }
}
