using System;
using System.Dynamic;

public class Swimming : Activity
{
    private int _laps;
    private const double PoolLength = 50; // meters

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * PoolLength) / 1000; // km
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60;
    }

    public override double GetPace()
    {
        return Minutes / GetDistance();
    }
}