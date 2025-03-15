using System;
using System.ComponentModel;

class SimpleGoal : BaseEternal
{
  private bool IsComplete;

  public SimpleGoal(string name, string description, int points) : base(name, description, points)
  {
    IsComplete = false;
  }

  public override void RecordEvent()
  {
    IsComplete = true;
    Console.WriteLine($"Goal {Name} ({Description}) completed! {Points} points.");
  }

  public override string GetStatus()
  {
    return $"{(IsComplete ? "[X]" : "[ ]")} {Name}";

  }
}