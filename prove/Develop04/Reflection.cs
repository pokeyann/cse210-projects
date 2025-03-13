using System;

class Reflection : BaseMessage
{
  public void ReflectionActivity()
  {
    StartMessage("Reflection Activity", "reflect on the times in our life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

    string reflectionPrompt = Prompt();
    Console.WriteLine(reflectionPrompt);
    Thread.Sleep(5000);

    for (int i = 0; i < duration; i += 5)
    {
      string reflectQuestion = Question();
      Console.WriteLine(reflectQuestion);
      SpinnerAnimation(10);
    }

    static string Prompt()
    {
      List<string> prompt = new List<string>
            {
             "Think of a time you stood up for someone else. ",
             "Think of a time when you thought you couldn't, but then you did. ",
             "Think of a time when you were the main character in the Good Samaritan. ",
             "Think of a time when you slayed. "
            };

      Random statement = new Random();

      int index = statement.Next(prompt.Count);

      return prompt[index];
    }

    static string Question()
    {
      List<string> question = new List<string>
            {
             "Why was this experience meaningful to you? ",
             "Have you ever done anything like this before? ",
             "How can you keep this experience in mind in the future?  ",
             "What did you learn about yourself from this experience? "
            };

      Random reflect = new Random();

      int index = reflect.Next(question.Count);

      return question[index];
    }

    EndMessage("Reflection Activity");
  }
}