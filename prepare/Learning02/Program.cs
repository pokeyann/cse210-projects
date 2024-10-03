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
        job1.DisplayJob();

        Job job2 = new Job();
        job2._companyName = "SJM";
        job2._jobTitle = "Girl Wonder";
        job2._startYear = 2006;
        job2._endYear = 2024;
        job2.DisplayJob();
    }
}