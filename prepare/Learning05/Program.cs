using System;

class Program
{
    static void Main(string[] args)
    {
        
        Assignment assignment1 = new Assignment("\nDavid Anampa", "Homework");
        Console.WriteLine(assignment1.GetSummary());

        WritingAssignment assignment3 = new WritingAssignment("\nDavid Anampa (History)", "History of the World", "The Mesopotamian Empire", "Willian J. Duiker");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());

        MathAssignment assignment2 = new MathAssignment("\nDavid Anampa (Math)", "Equations", "6", "7-10\n");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

    }
}