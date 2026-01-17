using System;
using System.IO;
using System.IO.Enumeration;
using System.Text.RegularExpressions;
// Exceed requirement is to allow display of the Journal prompts.  It is included as a menu option.

class Program
{
    static void Main(string[] args)
    {
        Journal activeJournal = new Journal();
        // List<Entry> readFileList = new List<Entry>();
        PromptGenerator promptPrint = new PromptGenerator();
        string fileName = "";
        DisplayWelcome();
        string answer = "-1";
        while (answer != "6")
        {
            DisplayChoices();
            answer = PromptMenuChoice();
            if (answer == "1")
            {
                activeJournal.LoadFromFile();
            }
            else if (answer == "2")
            {
                activeJournal.AddEntry();
            }
            else if (answer == "3")
            {
                activeJournal.DisplayAll();
            }
            else if (answer == "4")
            {
                activeJournal.SaveToFile();
            }
            else if (answer == "5")
            {
                promptPrint.DisplayPrompts();
            }
            else if (answer == "6")
            {
                Console.WriteLine("Thank you for adding to your Journal.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Please select a valid choice (1-6).");
            }
        }

        static void DisplayWelcome()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine();
        }        

        static void DisplayChoices()
        {
            Console.WriteLine("Select an action from the following list:");
            Console.WriteLine("1) Load the Journal from a file.");
            Console.WriteLine("2) Add a Journal Entry.");
            Console.WriteLine("3) Display all Journal Entries.");
            Console.WriteLine("4) Write the Journal to a file.");
            Console.WriteLine("5) Display all Prompts.");
            Console.WriteLine("6) Quit the Journal.");
        }

        static string PromptMenuChoice()
        {
            Console.Write("Selection (1-6): ");
            string answer1 = Console.ReadLine();
            Console.WriteLine();
            return answer1;
        }        
        
    }
}