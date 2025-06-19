using System;

public class Cycling : Exercise
{
    protected double _speed;

    public double GetSpeed()
    {
        return _speed;
    }

    public void SetSpeed(double speed)
    {
        this._speed = speed;
    }

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        this._speed = speed;
    }

    public override double GetDistanceMiles() => _speed * (_duration / 60.0);
    public override double GetSpeedMph() => _speed;
    public override double GetPaceMinPerMile() => 60.0 / _speed;

    public override string GetSummary()
    {
        return $"{_date:dd MMM yyyy} Cycling ({_duration} min)- Distance {GetDistanceMiles():F1} miles, Speed {GetSpeedMph():F1} mph, Pace: {GetPaceMinPerMile():F1} min per mile";
    }


}