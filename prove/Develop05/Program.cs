using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
       
        int choice = 0;
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;
        
        while (choice != 5)
        {
            Console.Write(@"
Menu Options:
    1. Start breathing activity
    2. Start reflecting activity
    3. Start listing activity
    4. View activity log
    5. Quit
Select choice number from above menu: "
            );
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    breathingCount++;
                    break;
                case 2:
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    reflectingCount++;
                    break;
                case 3:
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    listingCount++;
                    break;
                case 4:
                    Activity activity = new Activity();
                    activity.DisplayLogFromFile();
                    break;
            }
        }

        
        Console.WriteLine($"\nYou have performed a total of {breathingCount + reflectingCount + listingCount} activities. Including:");
        Console.WriteLine($" {breathingCount} Breathing activity \n {reflectingCount} Reflecting activity \n {listingCount} Listing activity \n");

        //exceeding requirements by 
        //keeping track of activity count and providing a summary on quit
        //saving log file and loading log file
        //ensuring user input duration is a positive integer
    }
}