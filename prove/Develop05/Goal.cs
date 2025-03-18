using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;

class GoalManager
{
  private List<BaseEternal> Goals;
  private int TotalScore;

  public GoalManager()
  {
    Goals = new List<BaseEternal>();
    TotalScore = 0;
  }

  public void AddGoal(BaseEternal goal)
  {
    Goals.Add(goal);
  }
  public void RecordGoal(string name)
  {
    foreach (var goal in Goals)
    {
      if (goal.GetName() == name)
      {
        goal.RecordEvent();
        if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
        {
          TotalScore += checklistGoal.GetBonusPoints();
        }
        TotalScore += goal.GetPoints();
        return;
      }
    }
  }

  public void ShowScore()
  {
    foreach (var goal in Goals)
    {
      goal.GetPoints();
    }
    Console.WriteLine($"Total Score: {TotalScore}");

    return;
  }

  public void ShowGoals()
  {
    foreach (var goal in Goals)
    {
      Console.WriteLine(goal.GetStatus());
    }
    return;
  }
  public void SaveToFile(string filename)
  {
    using (StreamWriter outputfile = new StreamWriter(filename))
    {
      foreach (var goal in Goals)
      {
        string goalDetails = FormatGoalDetails(goal);
        outputfile.WriteLine(goalDetails);
      }
    }
    Console.WriteLine($"Goals saved to {filename}"); /*test */
  }
  private string FormatGoalDetails(BaseEternal goal)
  {
    if (goal is SimpleGoal simpleGoal)
    {
      return $"Simple|{simpleGoal.GetName()}|{simpleGoal.GetDescription()}|{simpleGoal.GetPoints()}|{simpleGoal.GetStatus()}";
    }
    else if (goal is EternalGoal eternalGoal)
    {
      return $"Eternal|{eternalGoal.GetName()}|{eternalGoal.GetDescription()}|{eternalGoal.GetPoints()}|{eternalGoal.GetStatus()}";
    }
    else if (goal is ChecklistGoal checklistGoal)
    {
      return $"Checklist|{checklistGoal.GetName()}|{checklistGoal.GetDescription()}|{checklistGoal.GetPoints()}|{checklistGoal.GetTargetCount()}|{checklistGoal.GetBonusPoints()}|{checklistGoal.GetStatus()}";
    }
    return "";
  }
  public void LoadFromFile(string filename)
  {
    //string fileName = "goals.txt";
    string[] lines = System.IO.File.ReadAllLines(filename);
    Goals.Clear();

    foreach (string line in lines)
    {
      //Console.WriteLine($"Reading line: {line}");

      string[] parts = line.Split('|');

      /*if (parts.Length < 4)
      {
        Console.WriteLine($"Skipping malformed line: {line}");
        continue;
      }*/

      string type = parts[0];
      string name = parts[1];
      string description = parts[2];
      int points = int.Parse(parts[3]);

      /*if (!int.TryParse(parts[3], out int points))
      {
        Console.WriteLine($"Invalid points value in line: {line}");
        continue;
      }*/

      if (type == "Simple")
      {
        Goals.Add(new SimpleGoal(name, description, points));
      }
      else if (type == "Eternal")
      {
        Goals.Add(new EternalGoal(name, description, points));
      }
      else if (type == "Checklist")
      {
        //int currentCount = int.Parse(parts[4]);
        int targetCount = int.Parse(parts[4]);
        int bonusPoints = int.Parse(parts[5]);
        Goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
      }
      //Console.WriteLine(line);
    }
  }

}