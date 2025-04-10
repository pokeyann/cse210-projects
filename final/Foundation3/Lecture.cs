using System;
using System.Runtime.CompilerServices;
using System.ComponentModel;

public class Lecture : BaseEvent
{
  private string _speaker;
  private int _capacity;

  public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
  {
    _speaker = speaker;
    _capacity = capacity;
  }

  public override string GetFullDetails()
  {
    return base.GetStandardDetails() 
      + $"\nType: Lecture\n"
      + $"Speaker: {_speaker}\n" 
      + $"Capacity: {_capacity}";
  }
}