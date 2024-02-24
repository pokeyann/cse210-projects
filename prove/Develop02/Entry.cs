using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.IO;

public class Entry
{
  DateTime _date;
  string _prompt;
  string _response;

  public Entry()
  {
    // Get a date
    // Generate a prompt
    // Get a response
  }

  public Entry(string prompt)
  {
    // Get a date
    // Present the prompt
    // Get a response
  }

  public Entry(DateTime date, string prompt, string response)
  {

  }

  public Entry(string fileLine)
  {
    // Parse a line from the text file that saves the entries
    List<string> data = fileLine.Split("%");
    _date = DateTime.Parse(data[0]);
    _prompt = data[1];
    _response = data[2];
  }

  public string GenerateFileLine()
  {
    return $"{_date}%{_prompt}%{_response}"; 
  }

  public void Print()
  {
    string lineBreak = new String('=', 80);
    Console.WriteLine($"{_date}\t{_prompt}\n\t{_response}{lineBreak}");
  }


  public void journalEntry()
  {
    DateTime date = DateTime.Now;
    Console.WriteLine(date);

    Prompt prompt = new Prompt();
    prompt.GetPrompt();

    Journal journal = new Journal();
    journal.journalEntry();

  }


}




