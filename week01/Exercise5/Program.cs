using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int numberSquare = SquareNumber(userNumber);
        DisplayResult(userName, numberSquare);

        static void DisplayWelcome()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string answer = Console.ReadLine();
            return answer;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string answer = Console.ReadLine(); int number = int.Parse(answer);
            return number;
        }

        static int SquareNumber(int number)
        {
            int nsquare = number * number;
            return nsquare;
        }

        static void DisplayResult(string name, int squarenum)
        {
            Console.WriteLine($"{name}, the square of your number is {squarenum}");
        }
    }
}