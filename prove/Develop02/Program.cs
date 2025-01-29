using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one from the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");

        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("1. Write");
                break;
            case 2:
                Console.WriteLine("2. Display");
                break;
            case 3:
                Console.WriteLine("3. Load");
                break;
            case 4:
                Console.WriteLine("4. Save");
                break;
            case 5:
                Console.WriteLine("5. Quit");
                break;
        }



    }
}