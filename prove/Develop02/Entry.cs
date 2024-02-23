using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.IO;

public class Entry
{
  public void displayEntry()
  {

    List<string> entry = new List<string>();

    string input = Console.ReadLine();

    entry.Add(input);

    /*foreach (string e in entry)
    {
      Console.WriteLine(e);
    }*/

    saveFile(entry);
    ReadFile();
  }
  public void saveFile(List<string> entry)
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

  public static List<string> ReadFile()
  {
    Console.WriteLine("testing read from file...");

    List<string> entry = new List<string>();

    string filename = "journal.txt";

    string[] lines = System.IO.File.ReadAllLines(filename);

    /*foreach (string line in lines)
    {
      Console.WriteLine(line);
    }*/

    return entry;
  }
  /*displayEntryFile(entry);*/

  /*List<string> newEntry = new List<string>();

  foreach (string n in newEntry)
  {
    Console.WriteLine(n);
  }*/

}




