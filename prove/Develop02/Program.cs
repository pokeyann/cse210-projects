using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal newJournal = new Journal();

        Console.WriteLine("Hello Develop02 World!");

        Console.WriteLine("Welcome to the Journal Program!");

        while (true)
        {
            Console.WriteLine("Please select from one of the following choices: ");

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load ");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    newJournal.JournalEntry();
                    break;

                case "2":
                    newJournal.Display();
                    break;

                case "3":
                    Journal.LoadFromFile();
                    break;

                case "4":
                    newJournal.SaveToFile();
                    break;

                case "5":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}

