using System;

public class Journal
{
  /*private List<Journal> entries;

  public WriteEntry()
  {
    entries = new List<Journal>();
  }*/
  List<Entry> entries = new List<Entry>();
  public void AddEntry(string prompt, string userEntry, DateTime date)
  {
    Entry newEntry = new Entry(prompt, userEntry, DateTime.Now);
    entries.Add(newEntry);
  }
  /*DateTime theCurrentTime = DateTime.Now;
  string dateText = theCurrentTime.ToShortDateString();

  PromptGenerator q = new PromptGenerator();
  q.PromptQuestion();

    for (int i = 0; i < entries.Count; i++)
    {
      Console.Write($"{i + 1}> ");
    }

    string userEntry = Console.ReadLine();

  entries.Add(userEntry);*/

  public void WriteEntryDisplay()
  {
    foreach (Entry entry in entries)
    {
      Console.WriteLine(entry);
    }
  }

  public void SaveToFile(string filename) //SaveToFile(List<string> entries) when I add this it messes up the Program.cs
  {
    //Console.WriteLine("Saving to file journal.txt.");
    /*string filename = "journal.txt";*/

    using (StreamWriter outputfile = new StreamWriter(filename))
      foreach (Entry entry in entries)
      {
        outputfile.WriteLine($"{entry.Date} {entry.Prompt}");
        outputfile.WriteLine($"{entry.UserEntry}\n");
      }
  }
  public void LoadFromFile(string filename)
  {
    //Console.WriteLine("Reading from file journal.txt");

    /* List<Write> entryFile = new List<Write>();*/

    //string filename = "journal.txt";

    string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
    {
      Console.WriteLine(line);
    }

    //return entryFile;
  }

  public void Quit()
  {
    Environment.Exit(0);

    return;
  }
}
