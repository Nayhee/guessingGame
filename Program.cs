using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //steps
            //1- Get users selection of difficulty level and set variable equal to the selection parsed. 
            //2- Generate random number.
            //3- Think: when do I want this to run? Only if they have guesses left, or if they select cheater (guess forevery).
            //    In those scenarios:
                    //4) get the users guess, tell them how many guesses they have left, 
                    //5) write something different to the user depending on whether their answer is right, too high or too low, and...
                    //6) if they guessed correctly, break. Otherwise decrement numberOfGuesses by 1 and continue the loop restarts. 

            Console.WriteLine("difficulty level? 1 -easy, 2 - medium, 3 -hard, 4 - unlimited");
            var difficulty = int.Parse(Console.ReadLine());
            int numberOfGuesses = new int[] { 8, 6, 4, 1}[difficulty - 1]; //using the index number-1 to grab the value there. 
                //a list of numbers that he uses bracket notation on to grab the value there since they are both in order and 
                // there is only a difference of 1 between the number the user selected and the index number of its associated value. 
                //1 other option: make an object like {1:8, 2:6, 3:4, 4:1} with the values as the number of guesses. 

            int secretNumber = new Random().Next(1, 101);
            
            while (difficulty == 4 || numberOfGuesses > 0)
            {
                string guessesLeft = difficulty == 4 ? "INFINITE!" : numberOfGuesses.ToString();
                Console.WriteLine("Guess the secret number!");
                Console.Write($"Your Guess ({guessesLeft} left): ");
                var input = int.Parse(Console.ReadLine());

                if (secretNumber == input)
                {
                    Console.WriteLine("correct!");
                    break;
                }
                else if (secretNumber > input)
                {
                    Console.WriteLine("Too low!");
                    if(difficulty!=4 && numberOfGuesses == 1)
                    {
                        Console.WriteLine($"The answer was {secretNumber}! Better Luck Next Time!");
                    }
                }
                else
                {
                    Console.WriteLine("too High!");
                    if(difficulty!=4 && numberOfGuesses == 1)
                    {
                        Console.WriteLine($"The answer was {secretNumber}");
                    }
                };
                numberOfGuesses--;
            }
           
        }
    }
}

















// using System;
// using System.Collections.Generic;

// namespace guessingGame
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int secretNumber = new Random().Next(1,101);
//             Console.WriteLine($"secret number is {secretNumber}");

//             int CaptureDifficulty()
//             {
//                 Console.WriteLine("Select a difficulty! 1 -easy, 2 -medium, 3 -hard, 4 -unlimited guesses");
//                 int difficultyInt = int.Parse(Console.ReadLine());
//                 return difficultyInt;
//             }
            
//             int DifficultySelection()
//             {
//                 int difficultySelector = CaptureDifficulty();

//                 if(difficultySelector == 3)
//                 {
//                     return 3;
//                 }
//                 else if(difficultySelector == 2)
//                 {
//                     return 5;
//                 }
//                 else if(difficultySelector == 1)
//                 {
//                     return 7;
//                 }
//                 else if(difficultySelector == 4)
//                 {
//                     return -1;
//                 }
//                 else {
//                     return 0;
//                 }
//             };

//             int GuessFunc()
//             {
//                 Console.WriteLine("Guess the secret number!");
//                 int userGuess = int.Parse(Console.ReadLine());
//                 return userGuess;   
//             }

//             int userDifficulty = DifficultySelection();
//             int count = 0;
//             int guess = GuessFunc();

//             while(count != userDifficulty)
//             {
//                 if(secretNumber == guess ) 
//                 {
//                     Console.WriteLine($"Wow! That's Correct! Great Guess! The number was {guess}");
//                     break;
//                 }
//                 else 
//                 {
//                     count++;
                    
//                     if(guess > secretNumber)
//                     {
//                         Console.WriteLine("Nope! Your guess was too high!");
//                     }
//                     else   
//                     {
//                         Console.WriteLine("Nope! Your guess was too low!");
//                     }
//                     if(userDifficulty != -1)
//                     {
//                         Console.WriteLine($"Guesses left: {userDifficulty - count + 1}");
//                     }
//                     guess = GuessFunc();
//                 }
//                 if(count == userDifficulty && guess != secretNumber)
//                 {
//                     Console.WriteLine("YOU WERE NEVER ABLE TO GUESS THE NUMBER. Sorry!!");
//                 }
//                 else if (count == userDifficulty && guess == secretNumber) 
//                 {
//                     Console.WriteLine($"Wow! That's Correct! Great Guess! The number was {guess}");
//                 }

//             }
//         }
//     }
// }
