using System;
using System.Runtime.CompilerServices;

abstract class BaseEternal
{
  protected string Name;
  protected string Description;
  protected int Points;

  public BaseEternal(string name, string description, int points)
  {
    Name = name;
    Description = description;
    Points = points;
  }

  public abstract void RecordEvent();
  public abstract string GetStatus();

  public string GetName() => Name;
  public string GetDescription() => Description;
  public int GetPoints() => Points;


}