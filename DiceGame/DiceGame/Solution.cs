using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int Player1=0;
            int Player2=0;
            int Score1=0;
            int Score2=0;
            bool Success=false;
            Console.WriteLine("                                 Who Takes 5 points ,that Player is winner !!");
            while(Success!=true)
            {
                Console.WriteLine("                                 --------------------------------------------");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("\nPress Enter to Roll a Dice Player 1 : ");
                var a=Console.ReadKey(intercept: true);
                if (a.Key == ConsoleKey.Enter)
                {
                    Player1 = rnd.Next(1, 7);
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("\nYou Rolled {0}", Player1);
                    Console.WriteLine("....");
                }
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("\nPress Enter to Roll a Dice Player 2 : ");
                var b=Console.ReadKey(intercept: true);
                if (b.Key == ConsoleKey.Enter)
                {
                    Player2 = rnd.Next(1, 7);
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("\nYou Rolled {0}", Player2);
                    Console.WriteLine("....");
                }
                System.Threading.Thread.Sleep(1000);
                if (Player1 > Player2)
                {
                    Score1 += 1;
                    Console.WriteLine("\nPlayer 1 is win this Round ! ");
                    Console.WriteLine("***********");
                    Console.WriteLine("\nScore Board is : Player1 - {0}  Player2 - {1}",Score1,Score2);
                }
                else if (Player2 > Player1)
                {
                    Score2 += 1;
                    Console.WriteLine("\nPlayer 2 is win this Round ! ");
                    Console.WriteLine("***********");
                    Console.WriteLine("\nScore Board is : Player1 - {0}  Player2 - {1}", Score1, Score2);
                }
                else if (Player1 == Player2)
                {
                    Console.WriteLine("\nMatch is Draw !!");
                    Console.WriteLine("\nScore Board is : Player1 - {0}  Player2 - {1}", Score1, Score2);
                }

                if (Score1 == 5)
                {
                    Console.WriteLine("\n\n           The Winner is : {0}",Player1);
                    Success = true;
                    break;
                }

                if (Score2 == 5)
                {
                    Console.WriteLine("\n\n           The Winner is : {0}", Player2);
                    Success= true;
                    break;
                }
            }
        }
    }
}
