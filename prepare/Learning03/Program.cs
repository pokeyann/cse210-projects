using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(8);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(2, 3);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        /*f1.Display();
        f2.Display();
        f3.Display();

        Fraction f4 = new Fraction();
        f4.SetTopFraction(8);
        Console.WriteLine(f4.GetTopFraction());

        Fraction f5 = new Fraction();
        f5.SetBottomFraction(9);
        Console.WriteLine(f5.GetBottomFraction());*/
    }
}

