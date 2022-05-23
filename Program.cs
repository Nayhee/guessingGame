using System;
using System.Collections.Generic;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int secretNumber = r.Next(1,101);
            Console.WriteLine(secretNumber);

            
            int guessFunc()
            {
                Console.WriteLine("Guess the secret number!");
                string userGuessString = Console.ReadLine();
                int userGuess = int.Parse(userGuessString);
                return userGuess;   
            }

            int guess = guessFunc();
            int guessesLeft = 4;
            while(guessesLeft > 1)
            {
                if(secretNumber == guess) 
                {
                    Console.WriteLine("Wow! That's Correct! Great Guess!");
                    break;
                }
                else 
                {
                    guessesLeft--;
                    
                    if(guess > secretNumber)
                    {
                        Console.WriteLine("Nope! Your guess was too high!");
                    }
                    else   
                    {
                        Console.WriteLine("Nope! Your guess was too low!");
                    }
                    Console.WriteLine($"Guesses left: {guessesLeft}");

                }
                guess = guessFunc();
            }
        }
    }
}
