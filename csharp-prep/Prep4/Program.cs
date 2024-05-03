using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when done. ");

        List<int> numbers = new List<int>();

        int userNumber = 0;

        do
        {
            Console.Write("Enter number: ");

            numbers.Add(userNumber);

            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

        } while (userNumber != 0);

        //int total = numbers.Sum();
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");


        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        //int max = numbers.Max();

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
    }
}