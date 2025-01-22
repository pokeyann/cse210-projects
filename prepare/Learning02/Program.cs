using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Master of the Universe";
        job1._company = "He-Man";
        job1._startYear = 1983;
        job1._endYear = 1985;

        Job job2 = new Job();
        job2._jobTitle = "Power of Grayskull";
        job2._company = "Mattel";
        job2._startYear = 2002;
        job2._endYear = 2004;

        job1.Display();
        job2.Display();
    }

}