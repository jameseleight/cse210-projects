using System;

// exceed requirements:  I coded so that the prompts and questions are not repeated until all have been selected.
// exceed requirements:  I keep track of the total accumulated time for each activity.

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        BreathingActivity activity1 = new BreathingActivity();
        ListeningActivity activity2 = new ListeningActivity();
        ReflectingActivity activity3 = new ReflectingActivity();
        string answer = "-1";
        while (answer != "4")
        {
            DisplayChoices();
            answer = PromptMenuChoice();
            if (answer == "1")
            {
                activity1.Run();
            }
            else if (answer == "2")
            {
                activity2.Run();
            }
            else if (answer == "3")
            {
                activity3.Run();
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
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfullness Program!");
            Thread.Sleep(2000);
            Console.WriteLine();
        }        
        static void DisplayGoodbye()
        {
            Console.Clear();
            Console.WriteLine("Thank you for running the Mindfullness Program.");
            Console.WriteLine();
        }  
        static void DisplayChoices()
        {
            Console.Clear();
            Console.WriteLine("Select from the Menu:");
            Console.WriteLine("1) Start Breathing Activity");
            Console.WriteLine("2) Start Listening Activity");
            Console.WriteLine("3) Start Reflecting Activity");
            Console.WriteLine("4) Quit the Program");
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