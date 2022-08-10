using System;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool participate; 

            Console.WriteLine("Hello! \nWould you like to play a Guessing Game?\nPlease use y/n");

            while (true)
            {
                string ans = Console.ReadLine();
                if (ans != null && (ans == "y" || ans == "yes"))
                {
                    participate = true;
                    break;
                }
                else if (ans != null && (ans == "n" || ans == "no"))
                {
                    participate = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Only y or n Allowed");
                }
            }

            if (participate)
            {
                Console.WriteLine("Great! Im thinking of a number 1 - 100");
                Console.WriteLine("What number am I thinking of?");
                bool nullCheck;
                var r = new Random();
                var favNumber = r.Next(1, 100);
                int userInput;
                nullCheck = int.TryParse(Console.ReadLine(), out userInput);
                
                while (!nullCheck)
                {
                    Console.WriteLine("Please enter your guess");
                    nullCheck = int.TryParse(Console.ReadLine(), out userInput);
                }

                while (userInput != favNumber)
                {
                    if (userInput > favNumber)
                    {
                        Console.WriteLine("Too High! Try again!");
                        nullCheck = int.TryParse(Console.ReadLine(), out userInput);
                        while (!nullCheck)
                        {
                            Console.WriteLine("Please enter your guess");
                            nullCheck = int.TryParse(Console.ReadLine(), out userInput);
                        }
                    }

                    else if (userInput < favNumber)
                    {
                        Console.WriteLine("Too Low! Try again!");
                        nullCheck = int.TryParse(Console.ReadLine(), out userInput);
                        while (!nullCheck)
                        {
                            Console.WriteLine("Please enter your guess");
                            nullCheck = int.TryParse(Console.ReadLine(), out userInput);
                        }
                    }

                    else
                    {
                        break;
                    }
                }

                Console.WriteLine("WOW GREAT JOB!! YOU GUESSED IT!");
            }
            else
            {
                Console.WriteLine("Aw Alright! See you next time!");
            }


        }
    }
}
