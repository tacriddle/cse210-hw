class Score
{
    public int _totalScore { get; private set; }
    private List<Goal> _goals;

    public Score()
    {
        _totalScore = 0;
        _goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordGoal(string goalName)
    {
        foreach (var goal in _goals)
        {
            if (goal._name == goalName)
            {
                goal.RecordEvent();
                if (goal is ChecklistGoal checklistGoal)
                {
                    if (checklistGoal.IsComplete())
                    {
                        _totalScore += checklistGoal._score * checklistGoal.TargetCount + checklistGoal.BonusScore;
                    }
                    else if (checklistGoal.CurrentCount < checklistGoal.TargetCount)
                    {
                        _totalScore += goal._score;
                    }
                }
                else if (goal is NegativeGoal)
                {
                    _totalScore -= goal._score;
                }
                else
                {
                    _totalScore += goal._score;
                }
            }
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in _goals)
        {
            goal.Display();
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {_totalScore}");
    }

    public void Save(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(_totalScore);
            foreach (var goal in _goals)
            {
                if (goal is SimpleGoal simpleGoal)
                {
                    writer.WriteLine($"SimpleGoal,{simpleGoal._name},{simpleGoal._score},{simpleGoal.IsComplete()}");
                }
                else if (goal is EternalGoal eternalGoal)
                {
                    writer.WriteLine($"EternalGoal,{eternalGoal._name},{eternalGoal._score}");
                }
                else if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine($"ChecklistGoal,{checklistGoal._name},{checklistGoal._score},{checklistGoal.TargetCount},{checklistGoal.BonusScore},{checklistGoal.CurrentCount}");
                }
                else if (goal is NegativeGoal negativeGoal)
                {
                    writer.WriteLine($"NegativeGoal,{negativeGoal._name},{negativeGoal._score}");
                }
            }
        }
    }

    public void Load(string filePath)
    {
        if (File.Exists(filePath))
        {
            _goals.Clear();
            using (StreamReader reader = new StreamReader(filePath))
            {
                _totalScore = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    if (parts[0] == "SimpleGoal")
                    {
                        var goal = new SimpleGoal(parts[1], int.Parse(parts[2]));
                        if (bool.Parse(parts[3]))
                        {
                            goal.RecordEvent();
                        }
                        _goals.Add(goal);
                    }
                    else if (parts[0] == "EternalGoal")
                    {
                        _goals.Add(new EternalGoal(parts[1], int.Parse(parts[2])));
                    }
                    else if (parts[0] == "ChecklistGoal")
                    {
                        var goal = new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]));
                        for (int i = 0; i < int.Parse(parts[5]); i++)
                        {
                            goal.RecordEvent();
                        }
                        _goals.Add(goal);
                    }
                    else if (parts[0] == "NegativeGoal")
                    {
                        _goals.Add(new NegativeGoal(parts[1], int.Parse(parts[2])));
                    }
                }
            }
        }
    }
}

