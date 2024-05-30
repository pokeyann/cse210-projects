using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
  // list of journalEntries 
  // move date to entry and remove from journal entry, change to only show date not time if can figure out quickly.
  public string _prompt = "";
  public string _response = "";
  public string _date = "";

  public Entry(string prompt, string response, string date)
  {
    _prompt = prompt;
    _response = response;
    _date = date;
  }
}