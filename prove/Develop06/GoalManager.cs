public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _level = 1;
    double _pointCutoff = 100;

    public void Start()
    {
        int choice = 0;
        while (choice != 6)
        {
            LevelCheckUpgrade();
            Console.WriteLine($"\nYou are in level {_level} with {_score} points.");
            Console.Write(@"
Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Goal Accompishment
    6. Quit
Select choice number from above menu: ");

            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    CreateGoal();
                    break;
                case 2:
                    Console.Clear();
                    ListGoalDetails();
                    break;
                case 3:
                    Console.Clear();
                    SaveGoals();
                    break;
                case 4:
                    Console.Clear();
                    LoadGoals();
                    break;
                case 5:
                    Console.Clear();
                    RecordEvent();
                    break;
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points");

    }
    public void ListGoalNames()
    {
        Console.WriteLine("\nThe goals are:");
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetGoalName()}");
            index++;
        }
    }
    public void ListGoalDetails()
    {
        if (_goals.Count > 0)
        {
            foreach(Goal goal in _goals)
            {
                Console.WriteLine($"{goal.GetDetailsString()}");
            }
        } 
        else
        {
            Console.WriteLine($"It appears you have no goals yet, please create new goals.");
        }
    }
    public void CreateGoal()
    {
        int choice = 0;
        Console.WriteLine($"\nThe type of goals are:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal");
        while (choice != 1 && choice != 2 && choice != 3)
        {
            Console.Write("Which type of goal would you like to create? ");
            int.TryParse(Console.ReadLine(), out choice);
        }

        Console.Write("Whats's the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("Provide brief details of your goal: ");
        string description = Console.ReadLine();
        // Console.Write("How many points do you want to assign this goal? ");
        // int.TryParse(Console.ReadLine(), out int points);

        switch (choice)
        {
            case 1:
                SimpleGoal simpleGoal = new SimpleGoal(name, description);
                _goals.Add(simpleGoal);
                break;
            case 2:
                EternalGoal eternalGoal = new EternalGoal(name, description);
                _goals.Add(eternalGoal);
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished? ");
                int.TryParse(Console.ReadLine(), out int target);
                // Console.Write("What are bonus points for completing this goal? ");
                // int.TryParse(Console.ReadLine(), out int bonus);

                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, target);
                _goals.Add(checklistGoal);
                break;
        }


    }
    public void RecordEvent()
    {
        if (_goals.Count > 0)
        {
            ListGoalNames();
            Console.Write("Which goal did you accomplish? ");
            int.TryParse(Console.ReadLine(), out int index);

            Goal goal = _goals[index-1];
            int earned = goal.RecordEvent();
            _score = _score + earned;
            Console.WriteLine($"\nCongratulations! You have earned {earned} points!");
            ShowSmileEmoji(1);

            int levelBefore = _level;
            LevelCheckUpgrade();
            if (_level > levelBefore)
            {
                _score = _score + 15;
                Console.WriteLine($"\nBravoooo, you have entered a NEW LEVEL and received 15 bonus points");
                ShowSmileEmoji(5);
            }
            
            Console.WriteLine($"You now have {_score} points!");
        } 
        else
        {
            Console.WriteLine($"It appears you have no goals yet, please create new goals.");
        }
    }
    public void SaveGoals()
    {
        if (_goals.Count > 0)
        {
            Console.Write("What is the filename you want to save? ");
            string fileName = Console.ReadLine();

            using (StreamWriter newFile = new StreamWriter(fileName))
            {
                newFile.WriteLine(_score);
                foreach (Goal goal in _goals)
                {
                    newFile.WriteLine($"{goal.GetStringRepresentation()}");   
                }
            }
        } 
        else
        {
            Console.WriteLine($"It appears you have no goals yet, please create new goals.");
        }

    }
    public void LoadGoals()
    {
        Console.Write("Name of the file you want to load? ");
        string fileName = Console.ReadLine();
        if (!File.Exists(fileName))
        {
            Console.WriteLine("No such file name");
            return;
        }

        using (StreamReader reader = new StreamReader(fileName))
        {
            _score = int.Parse(reader.ReadLine());
            string line;
            while ((line = reader.ReadLine()) != null)
            {   
                string[] lineArray = line.Split(':');
                string goalType = lineArray[0].Trim();

                string[] goalDetails = lineArray[1].Split(',');
                string name = goalDetails[0].Trim();
                string description = goalDetails[1].Trim();
                // int.TryParse(goalDetails[2], out int points);

                switch (goalType)
                {
                    case "SimpleGoal":
                        SimpleGoal simpleGoal = new SimpleGoal(name, description);
                        if (goalDetails[2].Trim() == "True")
                        {
                            simpleGoal.SetComplete();
                        }
                        _goals.Add(simpleGoal);
                        break;
                    case "EternalGoal":
                        EternalGoal eternalGoal = new EternalGoal(name, description);
                        _goals.Add(eternalGoal);
                        break;
                    case "ChecklistGoal":
                        // int.TryParse(goalDetails[3], out int bonus);
                        int.TryParse(goalDetails[2], out int target);
                        int.TryParse(goalDetails[3], out int amountCompleted);

                        ChecklistGoal checklistGoal = new ChecklistGoal(name, description, target);
                        checklistGoal.SetAmountCompleted(amountCompleted);
                        _goals.Add(checklistGoal);
                        break;
                }
            }
        }

    }

    public void ShowSmileEmoji(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write($"\u263A  ");
            Thread.Sleep(500);
        }
        Console.WriteLine();
    }

    public void LevelCheckUpgrade()
    {
        while (_score > _pointCutoff)
        {
            for (int i=1; i<=_level; i++)
            {
                _pointCutoff *= 1.5;
            }
            _level++;
        }
    }
}