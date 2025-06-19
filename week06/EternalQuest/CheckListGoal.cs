using System;

public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

     public CheckListGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        this._target = target;
        this._bonus = bonus;
        this._amountCompleted = amountCompleted;
    }

    public CheckListGoal(string name, string description, int points, int target, int bonus) : this(name, description, points, target, bonus, 0)
    {
    }

    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            if (_amountCompleted == _target)
            {
                return _points + _bonus;
            }
            return _points;
        }
        return 0;
    }

    public override string GetDetailsString()
    {
        return $"[{(_amountCompleted >= _target ? "X" : " ")}] {_name}: {_description} ({_points} points, {_amountCompleted}/{_target}, Bonus: {_bonus})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_target}|{_amountCompleted}|{_bonus}";
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }







}