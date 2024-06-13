using System;
using System.Diagnostics;

public class Counting:Activity{

    private int _counter=0;
    public Counting(string titleParam, string descParam, int durationParam)
    : base(titleParam, descParam, durationParam)
    {

    }

    public void CountingActivity(){
        Console.WriteLine("Get ready");
        int animationDelay = 3;
        DisplayAnimation(animationDelay);
        Stopwatch activityTime = new();
        activityTime.Start();
        TimeSpan duration = TimeSpan.FromSeconds(_duration);
        while (true)
        {
            Console.WriteLine(_counter);
            _counter+=1;
            Thread.Sleep(1000);
            if (activityTime.Elapsed >= duration)
            {
                break;
            }
        }
        DisplayEndMessage();
    }
}