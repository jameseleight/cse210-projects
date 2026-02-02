using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string answer = "-1";
        while (answer != "4")
        {
            DisplayChoices();
            answer = PromptMenuChoice();
            if (answer == "1")
            {
                //Load breathing activity, run breathing activity
            }
            else if (answer == "2")
            {
                // load listening activity, run listening activity
            }
            else if (answer == "3")
            {
                // load reflecting activity, run reflecting activity
            }
            else if (answer == "4")
            {
                DisplayGoodbye();
            }
            else
            {
                Console.WriteLine("Please select a valid choice (1-4).");
                Console.WriteLine();
            }
        }

        static void DisplayWelcome()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Mindfullness Program!");
            Console.WriteLine();
        }        
        static void DisplayGoodbye()
        {
            Console.WriteLine("Thank you for running the Mindfullness Program.");
            Console.WriteLine();
        }  
        static void DisplayChoices()
        {
            Console.WriteLine("Select an activity from the following list:");
            Console.WriteLine("1) Breathing Activity.");
            Console.WriteLine("2) Listening Activity.");
            Console.WriteLine("3) Reflecting Activity.");
            Console.WriteLine("4) Quit the Program.");
        }

        static string PromptMenuChoice()
        {
            Console.Write("Selection (1-4): ");
            string answer1 = Console.ReadLine();
            Console.WriteLine();
            return answer1;
        }   
    }
}