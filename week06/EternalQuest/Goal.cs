using System;


public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    protected bool _isComplete;

    public Goal(string name, string description, int points, bool isComplete)
    {
        this._name = name;
        this._description = description;
        this._points = points;
        this._isComplete = isComplete;
    }

    public Goal(string name, string description, int points) : this(name, description, points, false)
    {
        
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}