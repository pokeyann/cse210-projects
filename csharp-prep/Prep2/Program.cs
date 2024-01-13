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

        if (grade >= 90)
        {
            Console.WriteLine("Your grade is A");
        }

        else if (grade >= 80)
        {
            Console.WriteLine("Your grade is B");
        }

        else if (grade >= 70)
        {
            Console.WriteLine("Your grade is C");
        }

        else if (grade >= 60)
        {
            Console.WriteLine("Your grade is D");
        }

        else
        {
            Console.WriteLine("Your grade is F");
        }

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