using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
  public string Prompt { get; set; }
  public string UserEntry { get; set; }
  public DateTime Date { get; set; }

  public Entry(string prompt, string userEntry, DateTime date)
  {
    Prompt = prompt;
    UserEntry = userEntry;
    Date = date;
  }

  public override string ToString()
  {
    return $"{Date} {Prompt}\n {UserEntry}\n";
  }
}
