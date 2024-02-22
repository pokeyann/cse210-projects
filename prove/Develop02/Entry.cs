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

    /*displayEntryFile(entry);*/

    /*List<string> newEntry = new List<string>();

    foreach (string n in newEntry)
    {
      Console.WriteLine(n);
    }*/

  }




}