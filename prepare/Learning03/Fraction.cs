using System;
using System.Reflection.Metadata.Ecma335;

public class Fraction
{
  private int _top;
  private int _bottom;

  public Fraction()
  {
    _top = 1;
    _bottom = 1;
  }

  public Fraction(int wholeNum)
  {
    _top = wholeNum;
    _bottom = 1;
  }

  public Fraction(int top, int bottom)
  {
    _top = top;
    _bottom = bottom;
  }

  public override string ToString()
  {
    return $"{_top}/{_bottom}";
  }


  /*
  SetTop(: int)top
  GetBottom()
  SetBottom()bottom: int*/

  public int GetTop()
  {
    return _top;
  }

  public void SetTop(int top)
  {
    _top = top;
  }

  public int GetBottom()
  {
    return _bottom;
  }

  public void SetBottom(int bottom)
  {
    _bottom = bottom;
  }

}