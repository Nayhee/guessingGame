using System;
using System.Collections.Generic;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 42;
            
            int guessFunc()
            {
                Console.WriteLine("Guess the secret number!");
                string userGuessString = Console.ReadLine();
                int userGuess = int.Parse(userGuessString);
                return userGuess;   
            }

            int guess = guessFunc();
            int count = 1;
            while(count < 4)
            {
                if(secretNumber == guess) 
                {
                    Console.WriteLine("Wow! That's Correct! Great Guess!");
                    break;
                }
                else 
                {
                    Console.WriteLine("Nope! Try again!");
                    Console.WriteLine($"Your guess {count}");
                    count++;
                }
                guess = guessFunc();
            }
        }
    }
}
