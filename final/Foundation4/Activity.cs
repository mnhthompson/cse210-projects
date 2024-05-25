using System;

public class Activity
{
    protected string _date;
    protected int _minutes;
    protected string _name;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual double CalcDistance()
    {
        return 0;
    }

    public virtual double CalcSpeed()
    {
        return 0;
    }

    public virtual double CalcPace()
    {
        return 0;
    }

    public string Summary()
    {
        string summary = $"{_date} {_name} ({_minutes} min)- Distance {CalcDistance()} km, Speed: {CalcSpeed()} kph, Pace: {CalcPace()} min per km";
        return summary;
    }
}