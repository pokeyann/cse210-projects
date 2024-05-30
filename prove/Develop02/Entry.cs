using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
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