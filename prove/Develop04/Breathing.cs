using System;

class Breathing
{
  BaseMessage basemessage = new BaseMessage();
  public void BreathingActivity()
  {
    //string breathingDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

    //Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

    Console.WriteLine("Breathe In... ");
    Thread.Sleep(1000);
    Console.WriteLine(basemessage.CountdownAnimation());

    Console.WriteLine("Breathe Out... ");
    Thread.Sleep(1000);
    Console.WriteLine(basemessage.CountdownAnimation());

  }


}