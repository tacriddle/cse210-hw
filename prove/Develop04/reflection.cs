using System;
using System.Diagnostics;

public class Reflection:Activity{
    private List<string> _prompts;
    private List<string> _questions;
    public Reflection(string titleParam, string descParam, int durationParam)
        
        : base(titleParam, descParam, durationParam)
    {
        _prompts= new List<string>();
        _questions= new List<string>();;
    }

    public void PopulateLists(){
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think off a time when you did something truly selfless.");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times whne you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
    }


    private string GetRandomPrompts(){
        Random rand= new Random();
        int index=rand.Next(_prompts.Count);
        return _prompts[index];
    }
        private string GetRandomQuestion(){
        Random rand= new Random();
        int index=rand.Next(_questions.Count);
        return _questions[index];
    }
    public void ReflectionActivity(){
        Console.WriteLine("Get ready");
        int animationDelay = 3;
        DisplayAnimation(animationDelay);
        Console.WriteLine(GetRandomPrompts());
        DisplayAnimation(animationDelay);
        Stopwatch activityTime = new();
        activityTime.Start();
        TimeSpan duration = TimeSpan.FromSeconds(_duration);
        Console.WriteLine("Think of the following prompts: ");
        while (true)
        {
            Console.WriteLine(GetRandomQuestion());
            DisplayAnimation(animationDelay);
            if (activityTime.Elapsed >= duration)
            {
                break;
            }
        }
    }
}