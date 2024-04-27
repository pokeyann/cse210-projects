using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);

        string letter = "";

        if (percent >= 90)
        {
            //Console.WriteLine("Your grade is an A.");
            letter = "A";
        }

        else if (percent >= 80)
        {
            //Console.WriteLine("Your grade is a B.");;
            letter = "B";
        }

        else if (percent >= 70)
        {
            //Console.WriteLine("Your grade is a C.");
            letter = "C";
        }

        else if (percent >= 60)
        {
            //Console.WriteLine("Your grade is a D.");
            letter = "D";
        }

        else
        {
            //Console.WriteLine("Your grade is an F.");
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}.");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations, you have passed!");
        }

        else
        {
            Console.WriteLine("I'm sorry you have not passed. Pleae try again.");
        }
    }
}