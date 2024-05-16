using System;

class Program
{
    static void Main(string[] args)
    {
  
        List<Shape> geo = new List<Shape>();

        Square s1 = new Square("Red", 3);
        geo.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        geo.Add(s2);

        Circle s3 = new Circle("Green", 6);
        geo.Add(s3);

        foreach (Shape s in geo)
        {
            string color = s.GetColor();
            
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}