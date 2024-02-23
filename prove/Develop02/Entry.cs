using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.IO;

public class Entry
{
  public void displayEntry()
  {

    DateTime date = DateTime.Now;
    Console.WriteLine(date);

    Prompt prompt = new Prompt();
    prompt.promptQuestions();

    Journal journal = new Journal();
    journal.journalEntry();

  }
}




