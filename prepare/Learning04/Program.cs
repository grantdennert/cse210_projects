using System;

class Program
{
    static void Main(string[] args)
    {
        
        MathAssignment mathAssignment = new MathAssignment("Grant Dennert", "Engineering", "6.7", "6-7");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Grant Dennert", "Engineering", "Beans");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}