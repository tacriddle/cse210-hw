using System;
using System.Collections.Generic;
public class Prompts{
    private List<string> _prompts= new List<string>();
    public void popPrompts(){
        _prompts.Add("Who did you like talking too today?");
        _prompts.Add("Where do you want go for a vacation?");
        _prompts.Add("What do you want to do to make tommorow better?");
        _prompts.Add("What was your favorite part about today?");
    }
    public string randomPrompt(){
        Random rand= new Random();
        int index=rand.Next(_prompts.Count);
        return _prompts[index];
    }
    
}