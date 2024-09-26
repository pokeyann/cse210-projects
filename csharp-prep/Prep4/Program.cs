using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNum = -1;

        Console.WriteLine("Enter a list of numbers, when done enter 0.");

        do
        {
            Console.Write("Enter number: ");
            userNum = int.Parse(Console.ReadLine());

            if (userNum != 0)
            {
                numbers.Add(userNum);
            }
        } while (userNum != 0);



        Console.WriteLine($"The sum is: {}");
    }
}