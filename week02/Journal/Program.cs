using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        {
            PromptGenerator prompt1 = new PromptGenerator();
            Console.WriteLine();
            prompt1.DisplayPrompts();

            Journal activejournal = new Journal();
            activejournal.AddEntry();
            activejournal.AddEntry();
            activejournal.AddEntry();



        }
    }
}