using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");


        Console.Write("What is the magic number? ");
        int number = int.Parse(Console.ReadLine());

        int guess = -1;

        while (number != guess)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (number < guess)
            {
                Console.WriteLine("lower");
            }

            else if (number > guess)
            {
                Console.WriteLine("higher");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}