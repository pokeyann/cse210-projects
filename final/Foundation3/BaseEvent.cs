using System;
using System.Runtime.CompilerServices;

abstract class BaseEvent
{
  protected string EventTitle;
  protected string Description;
  protected DateTime Date;
  protected Timespan Time;
  protected Address Address;

public BaseEvent(string eventTitle, string description, DateTime date, Timespan time, Address address)
{
  EventTitle = eventTitle;
  Description = description;
  Date = date;
  Time = time;
  Address = address;
}

public string GetStandardDetails()
{
  return $"Title: {EventTitle}\n"
    + "Description: {Description}\n"
    + "Date: {Date.ToString()}\n"
    + "Time: {Time.ToString()}\n"
    + "Address: {Address.GetFullAddress()}";
}

public virtual string GetFullDetails()
{
  return GetStandardDetails();
}

public string GetShortDescription()
{
  return $"Type: {GetType().Name}\n"
    + "Title: {EventTitle}\n"
    + "Date: {Date.ToString()}";
}


}