using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        /*assignment1.SetStudentName("Samuel Bennett");
        assignment1.SetTopic("Multiplication");*/

        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathAssignment1 = new MathAssignment("Boba Ganoosh", "Imaginary Numbers", "6", "6-6");

        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());
    }
}