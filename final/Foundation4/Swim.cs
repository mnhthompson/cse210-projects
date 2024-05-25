using System;

public class Swim : Activity
{
    private double _laps;

    public Swim(string date, int minutes, int laps) : base(date, minutes)
    {
        _name = "Swimming";
        _laps = laps;
    }

    public override double CalcDistance()
    {
        double distance = _laps * 50 / 1000;
        return distance;
    }

    public override double CalcSpeed()
    {
        double speed = CalcDistance() / _minutes * 60;
        return speed;
    }

    public override double CalcPace()
    {
        double pace = _minutes / CalcDistance();
        return pace;
    }
}