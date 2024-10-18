public class BreathingActivity: Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = @"This activity will help you relax by walking you through breathing in and out slowly. 
        Clear your mind and focus on your breathing";
    }

    public void Run()
    {
        DisplayStartingMesssage();
        
        int i = 3;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write($"\nBreath in...");
            ShowCountDown(i);
            Console.Write($"\nNow breath out...");
            ShowCountDown(i);
            Console.WriteLine();
            if (i < 6)
            {
                i++;
            }
        }

        DisplayEndingMesssage();

    }
}