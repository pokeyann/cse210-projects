using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int userNumber = -1;

        do
        {
            Console.WriteLine("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

        } while (userNumber != 0);

        /* add userNumber to list numbers*/


    }
}