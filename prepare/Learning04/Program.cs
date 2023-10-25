using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment1 = new MathAssignment("Dominic Stefani", "Programming with Classes", 5, "Problems 1-9, 20-25");
        string summary = mathAssignment1.GetSummary();
        System.Console.WriteLine(summary);
        mathAssignment1.GetHomeworkList();

        System.Console.WriteLine();

        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "Writing and Reasoning Foundations", "The Causes of World War II");
        summary = writingAssignment1.GetSummary();
        System.Console.WriteLine(summary);
        writingAssignment1.GetWritingInformation();
    }
}