using System;

public class Lecture : BaseEvent
{
  private string _speaker;
  private int _capacity;

  public Lecture(string title, string description, DateTime date, Timespan time, Address address, string speaker, int capacity) : BaseEvent(title, description, date, time, address)
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