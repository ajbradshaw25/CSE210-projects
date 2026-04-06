using System;

public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public int GetMinutes() => _minutes;
    public string GetDate() => _date;

    // Virtual methods to be overridden by derived classes
    public abstract double GetDistance(); // In Miles
    public abstract double GetSpeed();    // In MPH
    public abstract double GetPace();     // In min per mile

    public string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_minutes} min): " +
               $"Distance {GetDistance():0.0} miles, " +
               $"Speed {GetSpeed():0.0} mph, " +
               $"Pace: {GetPace():0.0} min per mile";
    }
}