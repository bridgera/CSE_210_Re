using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Bridger", "CS");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Alan Brigg", "Triangl", "6", "19-22");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Rando Bro", "Big Brain Movies", "Interstellar | An underated masterpiece");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}