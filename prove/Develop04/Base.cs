using System;

class Base
{
  private int _seconds;
  public void StartMessage()
  {
    Console.WriteLine("Welcome to the      Activity.");
    Console.WriteLine("This activity will help you      ");
    Console.WriteLine("How long in seconds, would you like your session? ");

    _seconds = int.Parse(Console.ReadLine());
  }

  public void EndMessage()
  {
    Console.WriteLine("Well Done!");
    Console.WriteLine($"You have completed       of the      ");
  }

  public void SpinnerAnimation()
  {
    Console.Write("Get ready... ");
  }

  public void CountdownAnimation()
  {
    Console.WriteLine("You may begin in: ");

  }
}