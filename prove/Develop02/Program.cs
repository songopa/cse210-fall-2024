using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator prompts = new PromptGenerator();

        foreach (string prompt in prompts._prompts)
        {
            Console.WriteLine($"{prompt}");
        }
    }
}