using System;

public class BaseMessage
{
  protected int duration;
  public void StartMessage(string name, string description)
  {
    Console.WriteLine($"Welcome to the {name}.");
    Console.WriteLine(); /*I feel it reads better with the added lines.*/
    Thread.Sleep(500);
    Console.WriteLine($"This activity will help you {description}.");
    Console.WriteLine();
    UserInputDuration();
    Console.WriteLine("Get ready... ");
    SpinnerAnimation(3);
    Thread.Sleep(500);
    Console.WriteLine("You may begin in: ");
    CountdownAnimation();
    Thread.Sleep(500);
    Console.WriteLine();
  }

  public void EndMessage(string name)
  {
    Thread.Sleep(1000);
    Console.WriteLine();
    Console.WriteLine("Well Done!");
    Console.WriteLine($"You have completed {duration} seconds of the {name}.");
    Thread.Sleep(1000);
    Console.WriteLine();
  }

  public void UserInputDuration()
  {
    Console.WriteLine("How long in seconds, would you like your session? ");

    while (true)
    {
      duration = int.Parse(Console.ReadLine());
      if (duration > 0)
      {
        break;
      }
    }
  }

  public void SpinnerAnimation(int seconds)
  {
    List<string> spinner = new List<string>();
    spinner.Add("|");
    spinner.Add("/");
    spinner.Add("-");
    spinner.Add("\\");
    spinner.Add("|");
    spinner.Add("/");
    spinner.Add("-");
    spinner.Add("\\");

    //DateTime startTime = DateTime.Now; changed due to Reflection Activity
    DateTime endTime = DateTime.Now.AddSeconds(seconds);

    int i = 0;

    while (DateTime.Now < endTime)
    {
      string s = spinner[i];
      Console.Write(s);
      Thread.Sleep(1000);
      Console.Write("\b \b");

      i = (i + 1) % spinner.Count;

      //i++;

      //if (i >= spinner.Count)
      //{
      // i = 0;
      //}
    }
    Console.WriteLine("");

  }

  public int CountdownAnimation()
  {
    for (int i = 3; i > 0; i--)
    {
      Console.Write(i);
      Thread.Sleep(1000);
      Console.Write("\b \b");
    }

    return 0;
  }
}