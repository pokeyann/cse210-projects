using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Monkey Business";
        job1._jobTitle = "Dance Monkey";
        job1._startYear = 1997;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._company = "Beans";
        job2._jobTitle = "Bean Counter";
        job2._startYear = 2021;
        job2._endYear = 2026;

        Resume myResume = new Resume();

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume._name = "Boba Ganoosh";

        myResume.DisplayResume();

    }
}