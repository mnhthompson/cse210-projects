using System;

public class Bike : Activity
{
    private double _speed;

    public Bike(string date, int minutes, double speed) : base(date, minutes)
    {
        _name = "Stationary Bicycles";
        _speed = speed;
    }

    public override double CalcDistance()
    {
        double distance = _speed * _minutes / 60;
        return distance;
    }

    public override double CalcSpeed()
    {
        return _speed;
    }

    public override double CalcPace()
    {
        double pace = 60 / _speed;
        return pace;
    }
}