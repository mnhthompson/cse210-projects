public class Rectangle : Shape
{
    private double _lengthr;
    private double _widthr;

    public Rectangle(string color, double length, double width) : base (color)
    {
        _lengthr = length;
        _widthr = width;
    }

    public override double GetArea()
    {
        return _lengthr * _widthr;
    }
}