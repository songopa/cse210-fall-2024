using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6,7);

        Console.WriteLine($"{f1.GetFractionString()}, {f2.GetFractionString()}, {f3.GetFractionString()}");

        f1.SetTop(3);
        f1.SetBottom(4);
        Console.WriteLine($"{f1.GetTop()}, {f1.GetBottom()}");
        Console.WriteLine($"{f1.GetFractionString()}");
        Console.WriteLine($"{f1.GetDecimalValue()}");

    }
}