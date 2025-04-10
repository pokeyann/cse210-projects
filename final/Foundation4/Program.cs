using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2025, 5, 5), 30, 4),
            new Bicycle(new DateTime(2025, 5, 5), 30, 15),
            new Swimming(new DateTime(2025, 5, 5), 30, 20)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}