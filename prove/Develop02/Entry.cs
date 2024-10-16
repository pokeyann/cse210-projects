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

/*public class PromptGenerator
{
  public string PromptQuestion()
  {
    List<string> prompt = new List<string>
  {

    "What is your earliest memory? ",
    "Choose between Marvel or DC, and explain why. ",
    "Describe your experiences today? ",
    "Who is your favorite child? ",
    "What is your biggest regret? "
  };
    Random question = new Random();

    int index = question.Next(prompt.Count);

    return prompt[index];
  }

}*/
