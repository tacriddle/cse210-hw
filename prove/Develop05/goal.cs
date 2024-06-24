using System;
using System.Collections.Generic;
using System.IO;

abstract class Goal
{
    public string _name { get; set; }
    public int _score { get; protected set; }

    public Goal(string name, int score)
    {
        _name = name;
        _score = score;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract void Display();
}

