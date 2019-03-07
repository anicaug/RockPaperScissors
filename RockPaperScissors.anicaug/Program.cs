using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.anicaug
{
    class Program
    {
        static void Main(string[] args)
        {
            //YouTube learning. MARCH 2019.
            //CONCEPTS: while loops, switch cases, nesting

            string inputPlayer, inputCPU;
            int randomInt;
            
            bool playAgain = true;

            while (playAgain)
            {

                int ScorePlayer = 0;
                int ScoreCPU = 0;

                while (ScorePlayer < 3 && ScoreCPU < 3)
                {


                    Console.Write("Choose between ROCK, PAPER, and SCISSORS:       ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose ROCK.");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Draw!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("Player Wins!\n\n");
                                ScorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU Wins!\n\n");
                                ScoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPER.");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("Draw!\n\n");
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("Player Wins!\n\n");
                                ScorePlayer++;
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU Wins!\n\n");
                                ScoreCPU++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS.");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("Draw!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Player Wins!\n\n");
                                ScorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU Wins!\n\n");
                                ScoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Entry.");
                            break;
                    }
                }
                if (ScorePlayer == 3)
                {
                    Console.WriteLine("Player Won!");
                }
                else if (ScoreCPU == 3)
                {
                    Console.WriteLine("CPU Won!");
                }
              
            Console.WriteLine("Do you want to play again? (y/n)");
            string loop = Console.ReadLine();
            if (loop == "y")
            {
                 playAgain = true;
                 Console.Clear();
            }
            else if (loop == "n")
            {
                playAgain = false;
            }
            }
        }
    }
}
