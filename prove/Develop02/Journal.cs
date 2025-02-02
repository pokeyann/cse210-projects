using System;

public class Journal
{
  List<Entry> entries = new List<Entry>();
  public void AddEntry(string prompt, string userEntry, DateTime date)
  {
    Entry newEntry = new Entry(prompt, userEntry, DateTime.Now);
    entries.Add(newEntry);
  }
  public void WriteEntryDisplay()
  {
    foreach (Entry entry in entries)
    {
      Console.WriteLine(entry);
    }
  }

  public void SaveToFile(string filename)
  {
    using (StreamWriter outputfile = new StreamWriter(filename))
      foreach (Entry entry in entries)
      {
        outputfile.WriteLine($"{entry.Date} {entry.Prompt}");
        outputfile.WriteLine($"{entry.UserEntry}\n");
      }
  }
  public void LoadFromFile(string filename)
  {
    string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
    {
      Console.WriteLine(line);
    }
  }

  public void Quit()
  {
    Environment.Exit(0);

    return;
  }
}
