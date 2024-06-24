class SimpleGoal : Goal
{
    protected bool _isComplete;

    public SimpleGoal(string name, int score) : base(name, score)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Goal '{_name}' completed! You earned {_score} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{_name}' is already completed.");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void Display()
    {
        Console.WriteLine($"[{(_isComplete ? "X" : " ")}] {_name} - {_score} points");
    }
}
