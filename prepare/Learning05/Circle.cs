public class Circle : Shape
{
    private double _radiusc;

    public Circle(string color, double radius) : base (color)
    {
        _radiusc = radius;
    }
    public override double GetArea()
    {
        return _radiusc * _radiusc * Math.PI;
    }
}