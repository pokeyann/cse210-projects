using System;
using System.Runtime.CompilerServices;
using System.ComponentModel;

public class Reception : BaseEvent
{
  private string _rsvpEmail;

  public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail) : base(title, description, date, time, address)
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