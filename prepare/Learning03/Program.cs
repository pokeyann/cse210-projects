using System;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction f1 = new Fraction();
        f1.SetBottom(4);
        Console.WriteLine(f1.GetBottom());
        Fraction f2 = new Fraction();
        f2.SetBottom(48);
        Console.WriteLine(f2.GetBottom());
        Fraction f3 = new Fraction();
        f3.SetBottom(88);
        Console.WriteLine(f3.GetBottom());


    }
}