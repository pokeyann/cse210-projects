using System;
using System.ComponentModel;
using System.Net;
public class Prompt
{
  public void promptQuestions()
  {

    List<string> questions = new List<string>
    {
      "What was the most surprising thing that happened today? ",
      "What am I most proud of? ",
      "What is my favorite animal and why? ",
      "One thing I want others to know is? ",
      "How do I feel about today? ",
      "Where is your favorite place? ",
      "Describe your happiest childhood memory. ",
      "Filibuster for 5 minutes about your biggest pet peeve. "
    };

    Random prompt = new Random();

    List<string> randomQuestions = new List<string>(); /*Wasn't working before because I needed an empty list to store the random selected questions*/

    for (int i = 0; i < 1; i++) /*wasn't working because it wasn't about selecting from 5 (i<5), the i++ goes through the whole list, 
    need to set i<1 because only want one question at a time.*/
    {
      int questionsIndex = prompt.Next(0, questions.Count);
      randomQuestions.Add(questions[questionsIndex]);
    }

    foreach (string prmpt in randomQuestions) /*could this code go in the for loop?  Too scared to break, don't want to try. not enough time to investigate.*/
    {
      Console.WriteLine(prmpt);
    }
  }
}



