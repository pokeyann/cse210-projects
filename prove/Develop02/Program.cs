using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
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
                Console.WriteLine("Write");
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

public class Journal
{
    public void JournalEntry(string promptQuestions)
    {
        // prompt question
        // >
        // date
        // user input

    }

    public void Display()
    {

    }

    public void SaveToFile()
    {

    }

    public void LoadFromFile()
    {

    }


}

public class Entry
{
    // list of journalEntries 
}

public class Random //.Next error code so cannot check yet
{
    static string Prompt()
    {
        Random randomPrompt = new Random();
        //var prompts = new List<string>
        string[] promptQuestions =
        [
            "What is your favorite dinosaur and why? ",
            "What is the best advice you've ever recieved? ",
            "Who is your celebrity crush? ",
            "What is your least and most favorite chore? ",
            "What are you most proud of? ",
            "If you could change one thing, what would it be? ",
            "What are your political beliefs? "
        ];
        //int index = random.Next(prompts.Count);
        int index = randomPrompt.Next(promptQuestions.Length); //.Next is the syntax according to google searches??????
        //Console.WriteLine(prompts[index]);
        return promptQuestions[index];

        //https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-8.0
    }
}