class NegativeGoal : Goal
{
    public NegativeGoal(string name, int score) : base(name, score) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Negative Goal '{_name}' recorded! You lost {_score} points.");
    }

    public override bool IsComplete()
    {
        return false; // Negative goals are never "complete"
    }

    public override void Display()
    {
        Console.WriteLine($"[ ] {_name} - Lose {_score} points if recorded.");
    }
}
