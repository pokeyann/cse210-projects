using System;

public class Bicycle : Activity
{
  private double _speed;

  public Bicycle(DateTime date, int minutes, double speed) : base(date, minutes)
  {
    _speed = speed;
  }

  public override double GetDistance() => (_speed * Minutes) / 60;

  public override double GetSpeed() => _speed;

  public override double GetPace() => 60 /_speed;
}