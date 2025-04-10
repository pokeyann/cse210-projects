using System;

public class Outdoor : BaseEvent
{
  private string _weather;

  public Outdoor(string title, string description, DateTime date, Timespan time, Address address, string weather) : BaseEvent(title, description, date, time, address)
  {
    
  }
}