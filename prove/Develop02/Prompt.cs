using System;
using System.ComponentModel;
using System.Net;
public class Prompt
{

  List<string> _questions = new List<string> {
      "What was the most surprising thing that happened today? ",
      "What am I most proud of? ",
      "What is my favorite animal and why? ",
      "One thing I want others to know is? ",
      "How do I feel about today? ",
      "Where is your favorite place? ",
      "Describe your happiest childhood memory. ",
      "Filibuster for 5 minutes about your biggest pet peeve. "
  };

  Random _random;

  public Prompt()
  {
    _random = new Random();
  }

  public string GetPrompt()
  {
    int questionsIndex = _random.Next(0, _questions.Count);
    Console.WriteLine(_questions[questionsIndex]);
    return _questions[questionsIndex];
  }
}
