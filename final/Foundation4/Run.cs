using System;

public class Run : Activity
{
    private double _distance;

    public Run(string date, int minutes, double distance) : base(date, minutes)
    {
        _name = "Running";
        _distance = distance;
    }

    public override double CalcDistance()
    {
        return _distance;
    }

    public override double CalcSpeed()
    {
        double speed = (_distance / _minutes) * 60;
        return speed;
    }

    public override double CalcPace()
    {
        double pace = _minutes / _distance;
        return pace;
    }
}