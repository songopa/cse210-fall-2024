using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        RunningActivity a1 = new RunningActivity("26 Oct 2024", 37, 3);
        CyclingActivity a2 = new CyclingActivity ("29 Oct 2024", 34, 12);
        SwimmingActivity a3  = new SwimmingActivity("30 Oct 2024", 36, 30);

        activities.Add(a1);
        activities.Add(a2);
        activities.Add(a3);

        foreach (Activity activity in activities)
        {
            Console.WriteLine($"\n{activity.GetSummary()}");
        }
    }
}