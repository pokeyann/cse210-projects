using System;

class Breathing : BaseMessage
{
  BaseMessage basemessage = new BaseMessage();
  public void BreathingActivity()
  {
    StartMessage("BreathingActivity", "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing");

    for (int i = 0; i < duration; i += 6)
    {
      Console.WriteLine("Breathe In... ");
      Thread.Sleep(1000);
      Console.WriteLine(basemessage.CountdownAnimation());

      Console.WriteLine("Breathe Out... ");
      Thread.Sleep(1000);
      Console.WriteLine(basemessage.CountdownAnimation());
    }

    EndMessage("Breathing Activity");

  }


}