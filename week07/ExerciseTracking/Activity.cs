using System;
using System.Security.Cryptography.X509Certificates;

public abstract class Activity
{
    private string _date;
    private int _minutes;
    

    public Activity (string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
     protected string Date => _date;
    protected int Minutes => _minutes;
     public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date} ({Minutes} min) - " +
               $"Distance {GetDistance():0.0}, " +
               $"Speed {GetSpeed():0.0}, " +
               $"Pace {GetPace():0.0}";
    }

}

