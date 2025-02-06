using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction f1 = new Fraction();
        Console.WriteLine(f1);
        Fraction f2 = new Fraction(6);
        Console.WriteLine(f2);
        Fraction f3 = new Fraction(6, 7);
        Console.WriteLine(f3);

    }
}