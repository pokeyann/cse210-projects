using System;
using System.Runtime.CompilerServices;

class ChecklistGoal : BaseEternal
{
  private int TargetCount;
  private int CurrentCount;
  private int BonusPoints;
  public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) : base(name, description, points)
  {
    TargetCount = targetCount;
    CurrentCount = 0;
    BonusPoints = bonusPoints;
  }

  public override void RecordEvent()
  {
    if (CurrentCount < TargetCount)
    {
      CurrentCount++;
      Console.WriteLine($"Recorded {Name} ({CurrentCount}/{TargetCount}. {Points} points.");

      if (CurrentCount == TargetCount)
      {
        Console.WriteLine($"Congratulations! {Name} completed! Bonus {BonusPoints} points.");
      }
    }
    else
    {
      Console.WriteLine($"Goal {Name} is already completed.");
    }
  }

  public override string GetStatus()
  {
    return $"{(CurrentCount >= TargetCount ? "[X]" : "[ ]")} {Name} ({CurrentCount}/{TargetCount})";
  }

  public bool IsComplete()
  {
    return CurrentCount >= TargetCount;
  }

  public int GetBonusPoints()
  {
    return BonusPoints;
  }

  public int GetTargetCount()
  {
    return TargetCount;
  }
}