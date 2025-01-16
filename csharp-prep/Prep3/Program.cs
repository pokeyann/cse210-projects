using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Console.Write("What is the magic number? ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        if (number < guess)
        {
            Console.WriteLine("lower");
        }

        else
        {
            Console.WriteLine("higher");
        }

    }
}