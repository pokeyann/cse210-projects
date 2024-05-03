using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when done. ");

        List<int> numbers = new List<int>();

        int userInput = -1;
        do
        {
            numbers.Add(userInput);

            string userNumber = Console.ReadLine();
            userInput = int.Parse(userNumber);

        } while (userInput != 0);
    }
}