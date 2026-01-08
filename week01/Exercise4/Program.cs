using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        List<int> posNumbers = new List<int>();
        string answer = "";
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (answer != "0")
        {
            Console.Write("Enter number: ");
            answer = Console.ReadLine();
            if (answer != "0")
            {
                numbers.Add(int.Parse(answer));
            }
        }
        int sumNumbers = numbers.Sum();
        double aveNumbers = numbers.Average();
        int maxNumbers = numbers.Max();
        foreach (int num in numbers)
        {
            if (num > 0)
            {
                posNumbers.Add(num);
            }
        }
        int minposNumbers = posNumbers.Min();
        bool noPositive = posNumbers.Count == 0;
        List<int> sortNumbers = new List<int>(numbers);
        sortNumbers.Sort();
        Console.WriteLine($"The sum is: {sumNumbers}");
        Console.WriteLine($"The average is: {aveNumbers}");
        Console.WriteLine($"The largest number is: {maxNumbers}");
        if (noPositive)
        {
            Console.WriteLine("There are no positive numbers");
        }
        else
        {
            Console.WriteLine($"The smallest positive number is: {minposNumbers}");
        }
        Console.WriteLine("The sorted list is:");
        foreach (int num in sortNumbers)
        {
            Console.WriteLine(num);
        }
    }
}