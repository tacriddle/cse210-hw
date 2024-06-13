using System;
using System.Diagnostics;
using System.Threading;

public class Breathing : Activity
{
    public Breathing(string titleParam, string descParam, int durationParam)
        : base(titleParam, descParam, durationParam)
    {
    }

    public void BreathingActivity()
    {
        Console.WriteLine("Get ready");
        int animationDelay = 5;
        DisplayAnimation(animationDelay);
        Stopwatch activityTime = new();
        activityTime.Start();
        TimeSpan duration = TimeSpan.FromSeconds(_duration);
        
        while (true)
        {
            Console.Write("Breath in...");
            PerformCountdown();
            Console.WriteLine();
            
            Console.Write("Now breath out...");
            PerformCountdown();
            Console.WriteLine();

            if (activityTime.Elapsed >= duration)
            {
                break;
            }
        }
    }


}

