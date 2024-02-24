using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
  public string _date;
  public string _prompt;
  public string _response;

  List<string> entry = new List<string>();
  public void journalEntry()
  {


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

    using (StreamWriter outputFile = new StreamWriter(filename, true))
      foreach (string e in entry)
      {
        outputFile.WriteLine(e);
        //outputFile.WriteLine($"{e.date}~~{e.prompt}~~{e.input}"); I think this is where this should happen, now to figure out how.
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
    /*Entry entryPrint = new Entry();*/
    Journal journalFile = new Journal();

    /*entryPrint.date();*/
    /*entryPrint.prompt();*/
    journalFile.ReadFile();

    //entryPrint.journal();
    //need to get date and prompt saving with user input journal entry

  }

}