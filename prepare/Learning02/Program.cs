using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._companyName = "GGM";
        job1._jobTitle = "Boy Wonder";
        job1._startYear = 2006;
        job1._endYear = 2024;
        //job1.DisplayJob();

        Job job2 = new Job();
        job2._companyName = "SJM";
        job2._jobTitle = "Girl Wonder";
        job2._startYear = 2006;
        job2._endYear = 2024;
        //job2.DisplayJob();

        Resume resume1 = new Resume();
        resume1._firstName = "Boba";
        resume1._lastName = "Ganoosh";
        resume1._jobList.Add(job1);
        resume1._jobList.Add(job2);

        //Console.WriteLine($"{resume1._jobList[0]._jobTitle}");

        resume1.DisplayResume();

    }
}