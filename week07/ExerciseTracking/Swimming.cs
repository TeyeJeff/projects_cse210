using System;

public class Swimming : Exercise
{
    protected int _laps;
    protected double _lengthYards = 50.0;
    protected double _yardsToMiles = 1.0 / 1760.0;

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        this._laps = laps;
    }

    public override double GetDistanceMiles() => _laps * _lengthYards * _yardsToMiles;
    public override double GetSpeedMph() => GetDistanceMiles() / (_duration / 60.0);

    public override double GetPaceMinPerMile() => _duration / GetDistanceMiles();

    public override string GetSummary()
    {
        return $"{_date:dd MMM yyyy} Swimming ({_duration} min)- Distance {GetDistanceMiles():F1} miles, Speed {GetSpeedMph():F1} mph, Pace: {GetPaceMinPerMile():F1} min per mile";
    }



}