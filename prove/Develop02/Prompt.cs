using System;

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

    int randomIndex = prompt.Next(0, questions.Count - 1);
  }


}



