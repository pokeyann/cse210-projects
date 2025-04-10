using System;

public class Reception : BaseEvent
{
  private string _rsvpEmail;

  public Reception(string title, string description, DateTime date, Timespan time, Address address, string rsvpEmail) : BaseEvent(title, description, date, time, address)
  {
    _rsvpEmail = rsvpEmail;
  }

  public override string GetFullDetails()
  {
    return base.GetStandardDetails() 
      + $"\nType: Reception\n" 
      + $"RSVP Email: {_rsvpEmail}";
  }
}