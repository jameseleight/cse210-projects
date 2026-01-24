using System;
using System.Runtime.CompilerServices;
// extension is that the random words will be selected based on the remaining unhidden words.

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        // Collect input data for scripture to memorize
        (string book, int chapter, int verse, int endVerse) = CollectReferenceData();
        (string text, int numHide) = CollectVerseText();
        // Construct data into Referece class
        Reference verseReference = new Reference(book, chapter, verse);
        if (endVerse != -1)
        {
            verseReference = new Reference(book, chapter, verse, endVerse);  // Reconstruct (replace) if there is an end verse
        }
        // Construct data into Scripture class
        Scripture memorizeScripture = new Scripture(verseReference, text);
        // Initialize the boolean flags for quit/continue.  Note that in this part of program IsCompletelyHidden() by definition will return false
        bool quitNow = false;
        // Start the steps to display the scripture refernece and text with some number of words hidden.  Words are hidden with the adjacent punctuation.
        while (quitNow == false && memorizeScripture.IsCompletelyHidden() == false)
        {
            Console.Clear();
            Console.WriteLine(memorizeScripture.GetDisplayText());
            Console.WriteLine();
            Console.Write($"Type 'quit' to finish or anything else (including Enter) to hide {numHide} words:");
            string continueReponse = Console.ReadLine();
            if (continueReponse == "quit")
            {
                quitNow = true;
            }
            else // Any response other than "quit" will continue
            {
                memorizeScripture.HideRandomWords(numHide);
            }
        }
        // After user types "quit" or all words have now been hidden.
        if (memorizeScripture.IsCompletelyHidden() == true)
        {
            DisplayAllDone(memorizeScripture);
        }
        else // Response is "quit".
        {
            DisplayQuit();
        }
        // Function definitions for Main
        static void DisplayWelcome()
        {
            // Display the program welcome message on the Console
            Console.WriteLine();
            Console.WriteLine("Welcome to the Scripture Memorizer Program!");
            Console.WriteLine();
        }
        static (string verseBook, int verseChapter, int verseStart, int verseEnd) CollectReferenceData()
        {
            // Collect the user input for the Book, Chapter, Verse(s)
            Console.Write("Enter the Scripture Reference Book: ");
            string verseBook = Console.ReadLine();
            Console.Write("Enter the Scripture Reference Chapter: ");
            int verseChapter = int.Parse(Console.ReadLine());
            Console.Write("Enter the Scripture Reference Starting Verse: ");
            int verseStart = int.Parse(Console.ReadLine());
            Console.Write("Enter the Scripture Reference Ending Verse (if no range hit 'Enter'): ");
            string readEndVerse = Console.ReadLine();
            int verseEnd = -1;
            // Check which version is entered by user for Reference constructor (one verse or verse range)
            if (readEndVerse != "")
            {
                verseEnd = int.Parse(readEndVerse);
            }
            // Return the parameters created in the function
            return (verseBook, verseChapter, verseStart, verseEnd);
        }
        static (string verseText, int verseNumHide) CollectVerseText()
        {
            // Collect user input for the text of the verse(s) to memorize
            Console.Write("Enter the Scripture Text: ");
            string verseText = Console.ReadLine();
            // Collect user input for how many words to hide with each step
            Console.Write("Enter how many words to Hide each step (integer > 0): ");
            int verseNumHide = int.Parse(Console.ReadLine());
            // Return the parameters created in the function
            return (verseText, verseNumHide);
        }
        static void DisplayQuit()
        {
            // Display the messgae when the user has quit early.
            Console.Clear();
            Console.WriteLine("You quit early! Do you have it memorized yet? Keep trying. Thanks for playing.");
        }
        static void DisplayAllDone(Scripture memorizeScripture)
        {
            // Display the scripture and message when all the wrrds are hidden.
            Console.Clear();
            Console.WriteLine(memorizeScripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("All words are hidden! Do you have it memorized yet? Thanks for playing.");
        }
    }
}