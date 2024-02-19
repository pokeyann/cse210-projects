using System;

public class Journal
{
  public void journalEntry()
  {
    DateTime date = DateTime.Now;
    Console.WriteLine(date);

    Prompt prompt = new Prompt();
    prompt.promptQuestions();

    Console.ReadLine();


  }
}