using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

public class Listing:Activity{
private List<string> _prompts;
private List<string> _userList;
private string  _randomPrompt;

public Listing(string titleParam, string descParam, int durationParam)
        
        : base(titleParam, descParam, durationParam)
    {
        _prompts = new List<string>();
        _userList= new List<string>();
    }
    public void ListingActivity(){
        Console.WriteLine("Get ready");
        int animationDelay = 3;
        DisplayAnimation(animationDelay);
        Stopwatch activityTime = new();
        activityTime.Start();
        TimeSpan duration = TimeSpan.FromSeconds(_duration);
        _randomPrompt=GetRandomPrompts();
        Console.Write(_randomPrompt);
        DisplayAnimation(animationDelay);
        Console.WriteLine(" \b");
        while (true)
        {
            _userList.Add(Console.ReadLine());
            if (activityTime.Elapsed >= duration)
            {
                break;
            }
        }
        int numberEntrys= _userList.Count();
        Console.WriteLine($"You entered {numberEntrys} entrys.");
        DisplayAnimation(animationDelay);
    }

    public void populatePrompts(){
        _prompts.Add("Who are people thtat you apprreciate.");
        _prompts.Add("What are personal strenghts of yours?");
        _prompts.Add("Who  are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month");
        _prompts.Add("Who are some of your personal heros?");
    }

    private string GetRandomPrompts(){
        Random rand= new Random();
        int index=rand.Next(_prompts.Count);
        return _prompts[index];
    }

}