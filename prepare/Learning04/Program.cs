using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("Samuel Bennett");
        assignment1.SetTopic("Multiplication");

        Console.WriteLine(assignment1.GetSummary());
    }
}