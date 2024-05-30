using System;
using System.Collections.Generic;
using System.IO;
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
    Console.WriteLine("Save to filename: journal.txt. ");
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

  public static void LoadFromFile()
  {
    string filename = "journal.txt";
    string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
    {
      Console.WriteLine(line);
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