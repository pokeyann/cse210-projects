using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercent = Console.ReadLine();

        int letterGrade = int.Parse(gradePercent);
        string letter = "";

        if (letterGrade >= 90)
        {
            //Console.WriteLine("Your letter grade is an A.");
            letter = "A";
        }
        else if (letterGrade >= 80)
        {
            //Console.WriteLine("Your letter grade is a B.");
            letter = "B";
        }
        else if (letterGrade >= 70)
        {
            //Console.WriteLine("Your letter grade is a C.");
            letter = "C";
        }
        else if (letterGrade >= 60)
        {
            //Console.WriteLine("Your letter grade is a D.");
            letter = "D";
        }
        else
        {
            //Console.WriteLine("Your letter grade is an F.");
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}.");

        if (letterGrade >= 70)
        {
            Console.WriteLine("Congratulations! You have passed.");
        }
        else
        {
            Console.WriteLine("You have not passed, keep trying.");
        }

    }
}