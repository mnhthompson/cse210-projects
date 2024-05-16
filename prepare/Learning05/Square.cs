public class Square : Shape
{
    private double _lengths;

    public Square(string color, double side) : base (color)
    {
        _lengths = side;
    }

    public override double GetArea()
    {
        return _lengths * _lengths;
    }
}