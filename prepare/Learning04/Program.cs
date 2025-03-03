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

        WritingAssignment writingAssignment1 = new WritingAssignment("Suzy Marie", "Creative Writing", "All Writers Cry");
        {
            Console.WriteLine(writingAssignment1.GetSummary());
            Console.WriteLine(writingAssignment1.GetWritingInformation());
        }
    }
}