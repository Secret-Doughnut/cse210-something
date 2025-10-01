using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Maron", "Speling");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Jake", "Fractions", "Section 3", "Problems: 30-72");
        Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine(assignment2.GetSummary());


        WritingAssignment assignment3 = new WritingAssignment("Maron", "spelling", "How proper speling can avoid causing problems");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}