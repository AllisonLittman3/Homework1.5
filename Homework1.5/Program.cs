﻿using System;
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


            int i = Round(); //Player 1
            int j = Round(); //Computer
            while (j < 20 && i < 20) //While both Player 1 and Computer have less than 20, the game keeps playing
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
            if (i >= 20) //If Player 1 wins
            {
                Console.WriteLine("Player 1, roll the dice.");
                Console.Write("Press Enter to roll. ");
                Console.ReadLine();
                Console.WriteLine("You rolled and your score is " + i + ". Congratulations, you win!");
                Console.ReadLine();
            }
            else if (j >= 20) //If the Computer wins
                {
                Console.WriteLine("Computer, roll the dice.");

                Console.Write("Press Enter to roll. ");
                Console.ReadLine();
                Console.WriteLine("Oh darn, the computer rolled and won with a score of " + j + " this time.");
                Console.ReadLine();
                }
            Console.ReadLine();
        }
        static int RollDice() //This method rolls 1 6-sided dice
        {
            int rolledNumber = rnd.Next(1, 7);
            return rolledNumber;
}
        static int Round() //This method is 1 round of 2 rolled 6-sided dice
        {
            int RoundX = RollDice() + RollDice();
            return RoundX;
        }
        

        
       
            
            



        }

    }

