using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Rachel Denkins", "Circulatory System");
        Console.WriteLine($"{assignment.GetSummary()}\n");

        MathAssignment math = new MathAssignment("Sabrina Atkinson", "Algebra", "4", "10-12");
        Console.WriteLine($"{math.GetSummary()} \n{math.GetHomeworkList()} \n");

        WritingAssignment writing = new WritingAssignment("Jeannie Astra", "The Galaxy", "Are We Alone?");
        Console.WriteLine($"{writing.GetSummary()} \n{writing.GetWritingInformation()} \n");

    }
}