using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
  public void journalEntry()
  {
    DateTime date = DateTime.Now;
    Console.WriteLine(date);

    Prompt prompt = new Prompt();
    prompt.promptQuestions();

    Entry entry = new Entry();
    entry.displayEntry();

  }




}