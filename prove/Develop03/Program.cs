using System;

class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("John", 1, 16);
        Scripture s1 = new Scripture(ref1, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        Console.WriteLine($"{s1.GetDisplayText()}");
    }
}