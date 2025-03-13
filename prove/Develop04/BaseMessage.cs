using System;

public class BaseMessage
{
  protected int duration;
  public void StartMessage()
  {
    Console.WriteLine("Welcome to the       activity.");
    Console.WriteLine("This activity will help you     ");
    UserInputDuration();
    Console.WriteLine("Prepare to begin... ");
    Thread.Sleep(1000);
  }

  public void EndMessage()
  {
    Console.WriteLine("Well Done!");
    Console.WriteLine($"You have completed       of the      ");
  }

  public void UserInputDuration()
  {
    Console.WriteLine("How long in seconds, would you like your session? ");

    while (true)
    {
      int userInput = int.Parse(Console.ReadLine());
      if (userInput > 0)
      {
        break;
      }
    }
  }

  public void SpinnerAnimation()
  {
    //Console.WriteLine("Get ready... ");

    List<string> spinner = new List<string>();
    spinner.Add("|");
    spinner.Add("/");
    spinner.Add("-");
    spinner.Add("\\");
    spinner.Add("|");
    spinner.Add("/");
    spinner.Add("-");
    spinner.Add("\\");

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(10);

    int i = 0;

    while (DateTime.Now < endTime)
    {
      string s = spinner[i];
      Console.Write(s);
      Thread.Sleep(1000);
      Console.Write("\b \b");

      i++;

      if (i >= spinner.Count)
      {
        i = 0;
      }
    }

  }

  public int CountdownAnimation()
  {
    //Console.WriteLine("You may begin in: ");

    for (int i = 3; i > 0; i--)
    {
      Console.Write(i);
      Thread.Sleep(1000);
      Console.Write("\b \b");
    }

    return 0;
  }
}