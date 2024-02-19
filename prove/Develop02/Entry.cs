using System;
using System.Collections.Generic;

public class Entry
{
  public void displayEntry()
  {
    List<string> entry = new List<string>();

    string userEntry = Console.ReadLine();

    entry.Add(userEntry);

    foreach (string e in entry)
    {
      Console.WriteLine(e);
    }

  }
}