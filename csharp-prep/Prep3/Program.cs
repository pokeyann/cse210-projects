using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        int magicNumber;
        int guess;


        //Console.Write("What is the magic number? ");
        //magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        magicNumber = randomGenerator.Next(1, 11);

        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }

            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("Higher");
            }
        } while (magicNumber != guess);
    }
}