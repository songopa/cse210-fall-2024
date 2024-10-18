public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    private string _fileName = "activitylog.csv";

    public Activity()
    {
    }

    private void SetDuration()
    {
        int seconds = 0;
        do
        {
            Console.Clear();
            Console.Write("\nHow long, in seconds, would you prefer your session to take? ");
            int.TryParse(Console.ReadLine(), out seconds);
        } while(seconds <= 0);
        
        _duration  = seconds;
    }

    public void DisplayStartingMesssage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to {_name} \n{_description}");
        SetDuration();

        Console.Clear();
        Console.Write($"Get ready...");
        ShowCountDown(3);
        Console.WriteLine();
    }

    public void DisplayEndingMesssage()
    {
        SaveLogToFile();
        Console.WriteLine("\nWell done!");
        ShowSpinner(2);

        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(3);

    }

    public void ShowSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        string[] animationCharacters = ["|", "/", "-", "\\"];
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(animationCharacters[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;
            if (i >= animationCharacters.Count())
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            if (seconds > 99)
            {
                Console.Write("\b\b\b   \b\b\b");
            }
            else if (seconds > 9)
            {
                Console.Write("\b\b  \b\b");
            }
            else
            {
                Console.Write("\b \b");
            }

            seconds--;
        }

    }

    public void SaveLogToFile()
    {

        using (StreamWriter log = new StreamWriter(_fileName, true))
        {
            string time = DateTime.Now.ToShortDateString();
            log.WriteLine($"{time},{_name},{_duration}");   
        }
    }
    public void DisplayLogFromFile()
    {
        if (!File.Exists(_fileName))
        {
            Console.WriteLine("No previous activities saved");
            return;
        }

        Console.Clear();
        Console.WriteLine("\nBelow is a log of previous activities:");
        Console.WriteLine("Date        Activity         Seconds");

        using (StreamReader reader = new StreamReader(_fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {   
                Console.WriteLine(line.Replace(",", " - "));
            }
        }

    }
}