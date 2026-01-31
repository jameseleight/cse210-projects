using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("James Leight", "Exponents");
        MathAssignment mathAssignment1 = new MathAssignment("James Leight", "Exponents", "11.1", "12-23");
        WritingAssignment writingAssignment1 = new WritingAssignment("James Leight", "History of the World", "What Mel Brooks Got Wrong");

        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());
        Console.WriteLine();
        
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}