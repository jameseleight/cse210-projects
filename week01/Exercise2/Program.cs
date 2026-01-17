using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage (integer %)? ");
        string gradePercentInput = Console.ReadLine();
        int gradePercent = int.Parse(gradePercentInput);
        int gradeOnesDigit = gradePercent % 10;
        string letter;
        string plusMinus = "";
        if (gradePercent >= 90)
        {
            // Console.WriteLine("Your grade is A.");
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            // Console.WriteLine("Your grade is B.");
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            // Console.WriteLine("Your grade is C.");
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            // Console.WriteLine("Your grade is D.");
            letter = "D";
        }
        else
        {
            // Console.WriteLine("Your grade is D.");
            letter = "F";
        }
        if (letter != "F")
        {
            if (gradeOnesDigit >= 7 && letter != "A")
            {
                plusMinus = "+";
            }
            else if (gradeOnesDigit < 3 && gradePercent != 100)
            {
                plusMinus = "-";
            }
            else
            {
                plusMinus = "";
            }
        }
        Console.WriteLine($"Your grade is {letter}{plusMinus}.");
        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("You failed the class.  Try again and you will do better next term.");
        }
    }
}