using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO;
public class Fraction
{
  private int _top;
  private int _bottom;
  public Fraction()
  {
    _top = 1;
    _bottom = 1;
  }
  public Fraction(int top)
  {
    _top = top;
    _bottom = 1;
  }
  public Fraction(int top, int bottom)
  {
    _top = top;
    _bottom = bottom;
  }
  public void Display()
  {
    Console.WriteLine($"{_top}/{_bottom}");
  }

  public int GetTopFraction()
  {
    return _top;
  }

  public void SetTopFraction(int top)
  {
    _top = top;
  }
  public int GetBottomFraction()
  {
    return _bottom;
  }

  public void SetBottomFraction(int bottom)
  {
    _bottom = bottom;
  }

  public string GetFractionString()
  {
    string fractionString = $"{_top}/{_bottom}";
    return fractionString;
  }

  public double GetDecimalValue()
  {
    return (double)_top / (double)_bottom;
  }
}