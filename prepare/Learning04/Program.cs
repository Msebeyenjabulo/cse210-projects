using System;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
class Program
{
    static void Main()
    {
        // Test the Assignment class
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary()); // Outputs: Samuel Bennett - Multiplication

        // Test the MathAssignment class
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary()); // Outputs: Roberto Rodriguez - Fractions
        Console.WriteLine(mathAssignment.GetHomeworkList()); // Outputs: Section 7.3 Problems 8-19

        // Test the WritingAssignment class
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary()); // Outputs: Mary Waters - European History
        Console.WriteLine(writingAssignment.GetWritingInformation()); // Outputs: The Causes of World War II by Mary Waters
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
