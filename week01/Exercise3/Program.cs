using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number (integer)? ");
        // string answerNumber = Console.ReadLine(); int number = int.Parse(answerNumber);
        // Console.WriteLine();
        // Console.Write("What is your guess? ");
        // string answerGuess = Console.ReadLine(); int answer = int.Parse(answerGuess);
        // if (answer > number)
        // {
        //     Console.WriteLine("Lower");
        // }
        // else if (answer == number)
        // {
        //     Console.WriteLine("You guessed it!");
        // }
        // else
        // {
        //     Console.WriteLine("Higher");
        // }
        // Console.Write("What is the magic number (integer)? ");
        // string answerNumber = Console.ReadLine(); int number = int.Parse(answerNumber);
        Random randomGenerator = new Random();
        string playAgain = "yes";
        while (playAgain == "yes")
        {
            int number = randomGenerator.Next(1, 101);
            Console.WriteLine();
            int answer;
            int numberGuesses = 1;
            do
            {
                Console.Write("What is your guess (integer from 1 to 100)? ");
                string answerGuess = Console.ReadLine(); answer = int.Parse(answerGuess);
                if (answer > number)
                {
                    Console.WriteLine("Lower");
                    numberGuesses++;
                }
                else if (answer == number)
                {
                    Console.WriteLine("You guessed it!");
                }
                else
                {
                    Console.WriteLine("Higher");
                    numberGuesses++;
                }
            } while (answer != number);
            Console.WriteLine($"You took {numberGuesses} guesses.");
            Console.WriteLine();
            Console.Write("Do you want to play again (yes or no)? ");
            playAgain = Console.ReadLine();
        }
    }
}