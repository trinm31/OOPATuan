
using System;
using OOP;

public class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(5,6, 7);
        Rectangle rectangle2 = new Rectangle();
        rectangle.Width = 5;
        rectangle.Height = 6;
        Console.WriteLine($"Area la {rectangle.GetArea()}");
        Console.WriteLine($"The Tich la {rectangle.GetTheTich()}");
    }
}