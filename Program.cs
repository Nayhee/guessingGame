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
            Console.WriteLine($"secret number is {secretNumber}");

            int CaptureDifficulty()
            {
                Console.WriteLine("Select a difficulty");
                Console.WriteLine("1) Easy");
                Console.WriteLine("2) Medium");
                Console.WriteLine("3) Hard");
                Console.WriteLine("4) Cheater");
                string difficultySelection = Console.ReadLine();
                int difficultyInt = int.Parse(difficultySelection);
                return difficultyInt;
            }
            
            int DifficultySelection()
            {
                int difficultySelector = CaptureDifficulty();

                if(difficultySelector == 3)
                {
                    return 3;
                }
                else if(difficultySelector == 2)
                {
                    return 5;
                }
                else if(difficultySelector == 1)
                {
                    return 7;
                }
                else if(difficultySelector == 4)
                {
                    return -1;
                }
                else {
                    return 0;
                }
            };

            int GuessFunc()
            {
                Console.WriteLine("Guess the secret number!");
                string userGuessString = Console.ReadLine();
                int userGuess = int.Parse(userGuessString);
                return userGuess;   
            }

            int userDifficulty = DifficultySelection();
            int count = 0;
            int guess = GuessFunc();

            while(count != userDifficulty)
            {
                if(secretNumber == guess ) 
                {
                    Console.WriteLine($"Wow! That's Correct! Great Guess! The number was {guess}");
                    break;
                }
                else 
                {
                    count++;
                    
                    if(guess > secretNumber)
                    {
                        Console.WriteLine("Nope! Your guess was too high!");
                    }
                    else   
                    {
                        Console.WriteLine("Nope! Your guess was too low!");
                    }
                    if(userDifficulty != -1)
                    {
                        Console.WriteLine($"Guesses left: {userDifficulty - count + 1}");
                    }
                    guess = guessFunc();
                }
                if(count == userDifficulty && guess != secretNumber)
                {
                    Console.WriteLine("YOU WERE NEVER ABLE TO GUESS THE NUMBER. Sorry!!");
                }
                else if (count == userDifficulty && guess == secretNumber) 
                {
                    Console.WriteLine($"Wow! That's Correct! Great Guess! The number was {guess}");
                }

            }
        }
    }
}
