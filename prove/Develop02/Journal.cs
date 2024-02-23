using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
  public void journalEntry()
  {
    List<string> entry = new List<string>();

    string input = Console.ReadLine();

    entry.Add(input);
    //need to add date and prompt to user input

    saveFile(entry);
    ReadFile();
  }

  public void saveFile(List<string> entry)
  {
    Console.WriteLine("testing save to file...");

    string filename = "journal.txt";

    using (StreamWriter outputFile = new StreamWriter(filename)) // add back , true     {
      foreach (string e in entry)
      {
        outputFile.WriteLine(e);
      }
  }


  public List<string> ReadFile()
  {
    Console.WriteLine("testing read from file...");

    List<string> entry = new List<string>();

    string filename = "journal.txt";

    string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
    {
      Console.WriteLine(line);
    }

    return entry;
  }

  public void Print()
  {
    Entry entryPrint = new Entry();
    Journal journalPrint = new Journal();

    entryPrint.displayEntry();
    //need to get date and prompt saving with user input journal entry

  }

}