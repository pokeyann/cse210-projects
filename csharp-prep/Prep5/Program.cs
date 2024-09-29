using System;

class Program
{

    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();

        int number = PrompUserNumber();

        int square = SquareNumber(number);

        DisplayResult(name, square);


    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name? ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PrompUserNumber()
    {
        Console.WriteLine("What is your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    static int SquareNumber(int userNumber)
    {
        int sqNum = userNumber * userNumber;
        return sqNum;
    }

    static void DisplayResult(string userName, int userNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is: {userNumber}");
    }

}