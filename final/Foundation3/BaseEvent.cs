using System;
using System.Runtime.CompilerServices;

public class BaseEvent
{
  protected string EventTitle;
  protected string Description;
  protected DateTime Date;
  protected TimeSpan Time;
  protected Address Address;

public BaseEvent(string eventTitle, string description, DateTime date, TimeSpan time, Address address)
{
  EventTitle = eventTitle;
  Description = description;
  Date = date;
  Time = time;
  Address = address;
}

public string GetStandardDetails()
{
  /*
  return $"Title: {EventTitle}\n"
    + "Description: {Description}\n"
    + "Date: {Date.ToString()}\n"
    + "Time: {Time.ToString()}\n"
    + "Address: {Address.GetFullAddress()}";
    */

        return $"\nTitle: {EventTitle}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {Address.GetFullAddress()}";
}

public virtual string GetFullDetails()
{
  return GetStandardDetails();
}

public string GetShortDescription()
{
  /*
  return $"Type: {GetType().Name}\n"
    + "Title: {EventTitle}\n"
    + "Date: {Date.ToString()}";
    */
  
  return $"\nType: {GetType().Name}\nTitle: {EventTitle}\nDate: {Date.ToString()}";
}


}