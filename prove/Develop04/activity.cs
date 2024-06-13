using System;
using System.Diagnostics;

public class Activity{
    protected string _title;
    protected string _desc;
    protected int _duration;

    protected Activity(string titleParam, string descParam, int durationParam){
        _title=titleParam;
        _desc=descParam;
        _duration=durationParam;
    }

    protected void DisplayAnimation(int animationDelay){
        
        Stopwatch stopwatch=new();
        stopwatch.Start();
        TimeSpan duration=TimeSpan.FromSeconds(animationDelay);
        
        while(true){
            Console.Write("/\b");
            Thread.Sleep(100);
            Console.Write("-\b");
            Thread.Sleep(100);
            Console.Write("\\\b");
            Thread.Sleep(100);
            Console.Write("|\b");
            Thread.Sleep(100);
            if (stopwatch.Elapsed >= duration)
            {
                break;
            }
        }
    }
        protected void PerformCountdown()
    {
        for (int i = 3; i > 0; i--)
        {
            Console.Write($"{i}\b");
            Thread.Sleep(1000);
        }
        Console.Write(" \b");
    }
    public void DisplayIntroMessage(){
        Console.WriteLine($"Welcome to the {_title} activity");
        Console.WriteLine($"You will be doing the following: {_desc}");    
    }
    protected void DisplayEndMessage(){
        Console.WriteLine("Well done!");
    }
}