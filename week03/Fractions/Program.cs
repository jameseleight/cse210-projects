using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Fraction fract1 = new Fraction();
        Console.WriteLine(fract1.GetFractionString());
        Console.WriteLine(fract1.GetDecimalValue());

        Console.WriteLine();
        Fraction fract2 = new Fraction(6);
        Console.WriteLine(fract2.GetFractionString());
        Console.WriteLine(fract2.GetDecimalValue());

        Console.WriteLine();
        Fraction fract3 = new Fraction(6, 7);
        Console.WriteLine(fract3.GetFractionString());
        Console.WriteLine(fract3.GetDecimalValue());

        Console.WriteLine();
        Console.WriteLine(fract3.GetTop());
        Console.WriteLine(fract3.GetBottom());

        fract2.SetTop(8);
        fract2.SetBottom(9);
        Console.WriteLine();
        Console.WriteLine(fract2.GetTop());
        Console.WriteLine(fract2.GetBottom());

    }


}