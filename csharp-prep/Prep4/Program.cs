using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

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


        Console.WriteLine($"The sum is: {numbers.Sum()}");

        Console.WriteLine($"The average is: {numbers.Average()}");

        Console.WriteLine($"The largest number is: {numbers.Max()}");

        !!!!float average = ((float)userNum / numbers.Count);

        Console.WriteLine($"The average is: {average}");


    }


}

/*
Sample solutions uses foreach loops for the sum, avergae and largest number. 

int sum = 0;
foreach (number in numbers)
{
sum += number;
}

Console.WriteLine($"The sum is: {sum}");


The following is how I did it based on the documentation about average for list 
https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.average?view=net-5.0#system-linq-enumerable-average-1(system-collections-generic-ienumerable((-0))-system-func((-0-system-single)))
        double average = numbers.Average();

        Console.WriteLine($"The average is: {average}");
The sample solution shows the following:
float average = ((float)sum / numbers.Count);

Console.WriteLine($"The average is: {average}");
*/