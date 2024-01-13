using System;
using System.IO.Pipes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string gradeFromUser = Console.ReadLine();

        int grade = int.Parse(gradeFromUser);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }

        else
        {
            Console.WriteLine("You did not pass.");
        }
    }
}
//A >= 90
//B >= 80
//C >= 70
//D >= 60
//F < 60