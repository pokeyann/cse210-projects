using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userNumbers = -1;

        while (userNumbers != 0)
        {
            Console.Write("Enter number: ");
            userNumbers = int.Parse(Console.ReadLine());

            if (userNumbers != 0) //Needed to do this otherwise the average included the 0 in it's calculations.
            {
                numbers.Add(userNumbers);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        //int average = sum / numbers.Count; according to the sample need to use float so the math is correct
        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        int max = numbers.Max();

        Console.WriteLine($"The largest number is: {max}");


    }
}