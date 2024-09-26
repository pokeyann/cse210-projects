using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guess;

        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (magicNumber != guess);
    }
}