using System;

namespace GCGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool realInteger = false;
            bool correctGuess = false;
            Random rand = new Random();
            int randomNumber = rand.Next(20) + 1;
            int userNumberGuess = 0;

            Console.WriteLine("Welcome to the Number Guessing Game!");
            while (correctGuess == false)
            {
                Console.Write("Please enter a number between 1 and 20: ");

                string userInput = Console.ReadLine();
                realInteger = int.TryParse(userInput, out userNumberGuess);

                if (userNumberGuess > 20 || userNumberGuess < 1 || realInteger == false)
                {
                    Console.WriteLine("Please choose a whole number within the range.");
                    continue;
                }

                if (randomNumber > userNumberGuess)
                {
                    Console.WriteLine($"The number is greater than {userNumberGuess}");
                }
                else if (randomNumber < userNumberGuess)
                {
                    Console.WriteLine($"The number is less than {userNumberGuess}");
                }
                else
                {
                    Console.WriteLine($" You got it right!!! The number is {userNumberGuess} ");
                    correctGuess = true;
                }
            }
            Console.WriteLine("Thank you for playing!!");
           
        }
    }
}
