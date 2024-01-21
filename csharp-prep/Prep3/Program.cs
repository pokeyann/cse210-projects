using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        /*Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());*/
        Console.WriteLine("Guess the magic number game");

        int guess = -1;

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magicNumber);
    }
}