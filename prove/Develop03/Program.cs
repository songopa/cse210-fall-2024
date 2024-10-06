using System;

class Program
{
    static void Main(string[] args)
    {   
        Scripture script = new Scripture();
        bool quit = false;

        while (!quit)
        {
            Console.Clear();
            Console.WriteLine($"\n{script.GetDisplayText()}");
            Console.Write("\nTo continue press Enter or type 'quit' to quit: ");
            string response = Console.ReadLine();
            if (script.IsCompletelyHidden() || response == "quit")
            {
                quit = true;
            } else
            {
                script.HideRandomWords(2);
            }
        }

        Console.WriteLine($"\nThanks for memorizing scripture, see you next time\n");
    }
}