using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1._5
{
    class Program
    {
        private static Random rnd = new Random();
        
        static void Main(string[] args)
        {
          
            Console.WriteLine("Let's Play the Dice Game!");


            int i = Round();
            int j = Round();
            while (j < 20 && i < 20)
                {

                    Console.WriteLine("Player 1, roll the dice.");

                    Console.Write("Press Enter to roll. ");
                    Console.ReadLine();
                    Console.WriteLine("You rolled and your score is " + i);
                    Console.ReadLine();

                Console.WriteLine("Computer, roll the dice.");

                    Console.Write("Press Enter to roll. ");
                    Console.ReadLine();
                    Console.WriteLine("The computer rolled and its score is " + j);
                    Console.ReadLine();
                i = i + Round();
                j = j + Round();
            }
            if (i >= 20)
            {
                Console.WriteLine("Player 1, roll the dice.");
                Console.Write("Press Enter to roll. ");
                Console.ReadLine();
                Console.WriteLine("You rolled and your score is " + i + ". Congratulations, you win!");
                Console.ReadLine();
            }
            else if (j >= 20)
                {
                Console.WriteLine("Computer, roll the dice.");

                Console.Write("Press Enter to roll. ");
                Console.ReadLine();
                Console.WriteLine("Oh darn, the computer rolled and won with a score of " + j + " this time.");
                Console.ReadLine();
                }
            Console.ReadLine();
        }
        static int RollDice()
        {
            int rolledNumber = rnd.Next(1, 7);
            return rolledNumber;
}
        static int Round()
        {
            int RoundX = RollDice() + RollDice();
            return RoundX;
        }
        

        
       
            
            



        }

    }

