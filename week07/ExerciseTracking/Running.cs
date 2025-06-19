using System;

public class Running : Exercise
{
    protected double _distance;

    public double GetDistance()
    {
        return _distance;
    }

    public void SetDistance(double distance)
    {
        this._distance = distance;
    }

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        this._distance = distance;
    }

    public override double GetDistanceMiles() => _distance;
    public override double GetSpeedMph() => _distance / (_duration / 60.0);
    public override double GetPaceMinPerMile() => _duration / _distance;
    public override string GetSummary()
    {
        return $"{_date: dd MMM yyyy} Running({_duration} min)- Distance{GetDistance():F1} miles, Speed{GetSpeedMph():F1} mph, Pace:{GetPaceMinPerMile():F1} min per mile";
    }

    
}