class EternalGoal : Goal
{
    public EternalGoal(string name, int score) : base(name, score) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Goal '{_name}' recorded! You earned {_score} points.");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void Display()
    {
        Console.WriteLine($"[ ] {_name} - {_score} points (Eternal)");
    }
}
