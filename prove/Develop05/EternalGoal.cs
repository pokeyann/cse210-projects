using System;
using System.ComponentModel;

class EternalGoal : BaseEternal
{
  private bool IsComplete;
  public EternalGoal(string name, string description, int points) : base(name, description, points)
  {
    IsComplete = false;
  }

  public override void RecordEvent()
  {
    Console.WriteLine($"Recorded {Name}. {Points} points.");
  }

  public override string GetStatus()
  {
    return $"{(IsComplete ? "[X]" : "[ ]")} {Name}";
  }
}