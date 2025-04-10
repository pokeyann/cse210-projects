using System;

/* Base */
public abstract class Activity
{
  private DateTime _date;
  private int _minutes;

  public Activity(DateTime date, int minutes)
  {
    _date = date;
    _minutes = minutes;
  }

  public DateTime Date => _date;
  public int Minutes => _minutes;

  public abstract double GetDistance();
  public abstract double GetSpeed();
  public abstract double GetPace();

  public virtual string GetSummary()
  {
    return $"{_date.ToString("dd MM yyyy")} {GetType().Name} ({_minutes} min) -" +
           $"Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} minutes per mile";
  }
}