public class Schedule
{
    private int _startTime;   // Time in 24-hour format (e.g., 1300 for 1:00 PM)
    private int _turnOffTime; // Time in 24-hour format (e.g., 1800 for 6:00 PM)

    public Schedule(int start, int end)
    {
        _startTime = start;
        _turnOffTime = end;
    }

    // Method to check if the current time is within the scheduled time range
    public bool IsActive(int currentTime)
    {
        if (_startTime <= _turnOffTime)
        {
            // Simple case: start and end on the same day
            return currentTime >= _startTime && currentTime <= _turnOffTime;
        }
        else
        {
            // Overlapping case: end time is on the next day
            return currentTime >= _startTime || currentTime <= _turnOffTime;
        }
    }

    // Display the schedule details
    public void DisplaySchedule()
    {
        Console.WriteLine($"Schedule: Start at {_startTime}, Turn off at {_turnOffTime}");
    }
}
