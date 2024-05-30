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
                    //Journal.LoadFromFile();
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

class Journal
{
    public List<Entry> entries = new List<Entry>();

    public void JournalEntry()
    {
        // DateTime newDate = DateTime.Now; //Do not want showing at prompt, only with entry saved 
        //Console.WriteLine(newDate);
        string randomQuestion = GetRandomPrompt.Prompt();
        Console.WriteLine(randomQuestion);
        Console.Write("> ");
        string response = Console.ReadLine();

        Entry newEntry = new Entry(randomQuestion, response, DateTime.Now.ToString("M/d/yyyy"));
        entries.Add(newEntry);

    }
    public void Display()
    {
        for (int i = 0; i < entries.Count; i++)
        {
            Console.WriteLine($"{i + 1} {entries[i]._date}: {entries[i]._prompt} - {entries[i]._response}");
        }
    }

    public void SaveToFile()
    {
        Console.WriteLine("What is the filename? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                outputFile.WriteLine($"{entry._date}: {entry._prompt} - {entry._response} ");
            }
        }
        Console.WriteLine($"Journal saved to {filename}.");
    }

    static void LoadFromFile()
    {

    }

    public class Entry
    {
        // list of journalEntries 
        // move date to entry and remove from journal entry, change to only show date not time if can figure out quickly.
        public string _prompt = "";
        public string _response = "";
        public string _date = "";

        public Entry(string prompt, string response, string date)
        {
            _prompt = prompt;
            _response = response;
            _date = date;
        }
    }

    public class GetRandomPrompt
    {
        public static string Prompt()
        {
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