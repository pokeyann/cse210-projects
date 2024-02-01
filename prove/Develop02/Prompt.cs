using System;
using System.ComponentModel;
using System.Net;
public class Prompt
{
  public void promptQuestions()
  {
    List<string> questions = new List<string>();

    questions.Add("What was the most surprising thing that happened today? ");
    questions.Add("What am I most proud of? ");
    questions.Add("What is my favorite animal and why? ");
    questions.Add("One thing I want others to know is? ");
    questions.Add("How do I feel about today? ");

    Random prompt = new Random();

    for (int i = 0; i <= 5; i++)
    {
      int questionsIndex = prompt.Next(0, questions.Count);
      questions.Add(questions[questionsIndex]);
    }

    foreach (string prmpt in questions)
    {
      Console.WriteLine(prmpt);
    }
  }
}



