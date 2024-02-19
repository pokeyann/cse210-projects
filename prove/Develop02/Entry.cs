using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
  public void displayEntry()
  {
    string input = Console.ReadLine();

    List<string> entry = new List<string>();

    entry.Add(input);

    foreach (string e in entry)
    {
      Console.WriteLine(e);
    }

    SaveToFile(entry);

    List<string> newEntry = ReadFromFile();
    foreach (string n in newEntry)
    {
      Console.WriteLine(n);
    }

  }

  public static void SaveToFile(List<string> entry)
  {
    Console.WriteLine("testing save to file...");
    string filename = "journal.txt";

    using (StreamWriter outputFile = new StreamWriter(filename))
    {
      foreach (string e in entry)
      {
        outputFile.WriteLine(e);
      }
    }

  }

  public static List<string> ReadFromFile()
  {
    Console.WriteLine("testing read from file...");
    List<string> entry = new List<string>();

    string filename = "journal.txt";

    string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
    {
      Console.WriteLine(line);
    }

    // need to add .Add
    return entry;
  }
}