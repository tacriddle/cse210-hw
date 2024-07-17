using System;

public class Schedule
{
    public int StartTime { get; set; } // Time in 24-hour format (e.g., 1300 for 1:00 PM)
    public int TurnOffTime { get; set; } // Time in 24-hour format (e.g., 1800 for 6:00 PM)

    public Schedule() { }

    public Schedule(int start, int end)
    {
        StartTime = start;
        TurnOffTime = end;
    }

    // Method to check if the current time is within the scheduled time range
    public bool IsActive(int currentTime)
    {
        if (StartTime <= TurnOffTime)
        {
            // Simple case: start and end on the same day
            return currentTime >= StartTime && currentTime <= TurnOffTime;
        }
        else
        {
            // Overlapping case: end time is on the next day
            return currentTime >= StartTime || currentTime <= TurnOffTime;
        }
    }

    // Display the schedule details
    public void DisplaySchedule()
    {
        Console.WriteLine($"Schedule: Start at {StartTime}, Turn off at {TurnOffTime}");
    }
}

