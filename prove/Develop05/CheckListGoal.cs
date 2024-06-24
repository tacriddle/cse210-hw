class ChecklistGoal : Goal
{
    protected int _targetCount;
    protected int _currentCount;
    protected int _bonusScore;

    public ChecklistGoal(string name, int score, int targetCount, int bonusScore) : base(name, score)
    {
        this._targetCount = targetCount;
        this._bonusScore = bonusScore;
        _currentCount = 0;
    }

    public override void RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            Console.WriteLine($"Goal '{_name}' recorded! You earned {_score} points. Completed {_currentCount}/{_targetCount} times.");
            if (_currentCount == _targetCount)
            {
                Console.WriteLine($"Goal '{_name}' completed! You earned a bonus of {_bonusScore} points.");
            }
        }
        else
        {
            Console.WriteLine($"Goal '{_name}' is already completed.");
        }
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override void Display()
    {
        Console.WriteLine($"[{(_currentCount >= _targetCount ? "X" : " ")}] {_name} - {_score} points each, Bonus {_bonusScore} points. Completed {_currentCount}/{_targetCount} times.");
    }

    public int TargetCount
    {
        get { return _targetCount; }
    }

    public int CurrentCount
    {
        get { return _currentCount; }
    }

    public int BonusScore
    {
        get { return _bonusScore; }
    }
}