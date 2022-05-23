using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 42;
            
            Console.WriteLine("Guess the secret number!");
            string userGuessString = Console.ReadLine();
            int userGuess = int.Parse(userGuessString);

            if(secretNumber == userGuess) 
            {
                Console.WriteLine("Wow! That's Correct! Great Guess!");
            }
            else 
            {
                Console.WriteLine("Nope! Try again!");
            }
        }
    }
}
