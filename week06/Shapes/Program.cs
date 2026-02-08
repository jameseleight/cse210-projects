using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("blue", 3.56);
        Rectangle rectangle1 = new Rectangle("green", 4.5, 6.7);
        Circle circle1 = new Circle("red", 7.89);
        List<Shape> variousShapes = new List<Shape>();
        variousShapes.Add(square1);
        variousShapes.Add(rectangle1);
        variousShapes.Add(circle1);

        foreach (var item in variousShapes)
        {
        Console.WriteLine($"The area of the {item.GetColor()} shape is {item.GetArea().ToString("F2")}");
        Console.WriteLine();
        }
        // Console.WriteLine("Square");
        // Console.WriteLine(square1.GetColor());
        // Console.WriteLine(square1.GetArea().ToString("F2"));
        // Console.WriteLine();
        // Console.WriteLine("Rectangle");
        // Console.WriteLine(rectangle1.GetColor());
        // Console.WriteLine(rectangle1.GetArea().ToString("F2"));
        // Console.WriteLine();
        // Console.WriteLine("Circle");
        // Console.WriteLine(circle1.GetColor());
        // Console.WriteLine(circle1.GetArea().ToString("F2"));
        // Console.WriteLine();
    }
}