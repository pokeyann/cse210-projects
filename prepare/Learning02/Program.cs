using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Master of the Universe";

        Job job2 = new Job();
        job2._jobTitle = "Power of Grayskull";

        Console.WriteLine($"{job1._jobTitle}");

        Console.WriteLine($"{job2._jobTitle}");
    }

}