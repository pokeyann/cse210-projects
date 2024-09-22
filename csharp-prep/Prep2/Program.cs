using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercent = Console.ReadLine();

        int letterGrade = int.Parse(gradePercent);

        if (letterGrade >= 90)
        {
            Console.WriteLine("Your letter grade is an A.");
        }
        else if (letterGrade >= 80)
        {
            Console.WriteLine("Your letter grade is a B.");
        }
        else if (letterGrade >= 70)
        {
            Console.WriteLine("Your letter grade is a C.");
        }
        else if (letterGrade >= 60)
        {
            Console.WriteLine("Your letter grade is a D.");
        }
        else
        {
            Console.WriteLine("Your letter grade is an F.");
        }

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