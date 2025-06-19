using System;


public abstract class Exercise
{
    protected DateTime _date;
    protected int _duration;


    public DateTime GetDatetime()
    {
        return _date;
    }

    public void SetDateTime(DateTime date)
    {
        this._date = date;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        this._duration = duration;
    }

    public Exercise(DateTime date, int duration)
    {
        this._date = date;
        this._duration = duration;
    }

    public abstract double GetDistanceMiles();
    public abstract double GetSpeedMph();
    public abstract double GetPaceMinPerMile();
    public abstract string GetSummary();








}