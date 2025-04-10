using System;
using System.Runtime.CompilerServices;
using System.ComponentModel;

public class Outdoor : BaseEvent
{
  private string _weather;

  public Outdoor(string title, string description, DateTime date, TimeSpan time, Address address, string weather) : base(title, description, date, time, address)
  {
    _weather = weather;
  }

  public override string GetFullDetails()
  {
    return base.GetStandardDetails() 
      + $"\nType: Outdoor Gathering\n"
      + $"Weather Forecast: {_weather}";
  }
}