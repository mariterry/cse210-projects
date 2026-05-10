using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        while (playAgain == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 11);

            int guess = 0;
            int guessCount = 0;

            while (guess != number)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
               
                guessCount++;         
                
                if (guess == number)
                {
                    Console.WriteLine("You guess it");
                }

                else if (guess < number)
                {
                    Console.WriteLine("Guess Higher");
                }

                else 
                {
                    Console.WriteLine("Guess Lower");
                }
            }    
            Console.WriteLine($"You made {guessCount} guesses.");

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();
        }

        Console.WriteLine("Thanks for playing!");
    }
}