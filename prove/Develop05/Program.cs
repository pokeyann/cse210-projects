using System;
using System.IO;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        GoalManager manager = new GoalManager();

        while (true)
        {
            manager.ShowScore();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal ");
            Console.WriteLine("2. List Goals.");
            Console.WriteLine("3. Save Goals.");
            Console.WriteLine("4. Load Goals.");
            Console.WriteLine("5. Record Event.");
            Console.WriteLine("6. Exit");
            Console.WriteLine("Select a choice from the menu: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("The type of goals are: ");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.WriteLine("Which type of goal would you like to create? ");

                    int goalType = int.Parse(Console.ReadLine());

                    Console.WriteLine("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.WriteLine("How many points do you want associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());

                    switch (goalType)
                    {
                        case 1:
                            manager.AddGoal(new SimpleGoal(name, description, points));
                            break;
                        case 2:
                            manager.AddGoal(new EternalGoal(name, description, points));
                            break;
                        case 3:
                            Console.WriteLine("How many times must this goal be completed? ");
                            int targetCount = int.Parse(Console.ReadLine());
                            Console.WriteLine("What is the bonus for completing it? ");
                            int bonusPoints = int.Parse(Console.ReadLine());
                            manager.AddGoal(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
                            break;
                    }
                    break;
                case 2:
                    manager.ShowGoals();
                    break;
                case 3: /* Save*/
                    Console.WriteLine("What is the filename? ");
                    string saveFile = Console.ReadLine();
                    manager.SaveToFile(saveFile);
                    break;
                case 4: /* Load*/
                    Console.WriteLine("What is the filename? ");
                    string loadFile = Console.ReadLine();
                    manager.LoadFromFile(loadFile);
                    break;
                case 5:
                    Console.WriteLine("Enter goal name to record: ");
                    string goalName = Console.ReadLine();
                    manager.RecordGoal(goalName);
                    break;
                case 6:
                    return;

            }
        }
    }
}

