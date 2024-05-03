using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when done. ");

        List<int> numbers = new List<int>();

        int userNumber = -1;
        do
        {
            numbers.Add(userNumber);

            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

        } while (userNumber != 0);
    }
}