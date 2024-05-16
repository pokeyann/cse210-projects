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
        Console.WriteLine("Please select from one of the following choices: ");

        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load ");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.Write("What would you like to do? ");

        switch (Console.ReadLine())
        {
            case "1":
                newJournal.JournalEntry();

                break;

            case "2":
                Console.WriteLine("Display");
                break;

            case "3":
                Console.WriteLine("Load");
                break;

            case "4":
                Console.WriteLine("Save");
                break;

            case "5":
                //Console.WriteLine("Quit");
                Environment.Exit(0);
                break;
        }
    }
}

class Journal
{
    public void JournalEntry()
    {
        DateTime newDate = DateTime.Now;
        Console.WriteLine(newDate);
        string randomQuestion = GetRandomPrompt.Prompt();
        Console.WriteLine(randomQuestion);
        Console.Write("> ");
        Console.ReadLine();
        // date
    }

    public void Display()
    {
    }

    public void SaveToFile()
    {

    }

    static void LoadFromFile()
    {

    }

    public class Entry
    {
        // list of journalEntries 
    }

    public class GetRandomPrompt //.Next error code so cannot check yet
    {
        public static string Prompt()
        {
            //var prompts = new List<string>
            string[] promptQuestions =
            {
            "What is your favorite dinosaur and why? ",
            "What is the best advice you've ever recieved? ",
            "Who is your celebrity crush? ",
            "What is your least and most favorite chore? ",
            "What are you most proud of? ",
            "If you could change one thing, what would it be? ",
            "What are your political beliefs? "
            };
            Random randomPrompt = new Random();
            int index = randomPrompt.Next(promptQuestions.Length);

            return promptQuestions[index];
        }
    }
}