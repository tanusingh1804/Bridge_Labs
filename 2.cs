using System;

class Program
{
    static void Main()
    {
        Circle circle1 = new Circle();
        Circle circle2 = new Circle(5.5);

        Console.WriteLine("Default Circle Radius: " + circle1.Radius);
        Console.WriteLine("Custom Circle Radius: " + circle2.Radius);
    }
}

class Circle
{
    public double Radius { get; set; }

    public Circle() : this(1.0) { }

    public Circle(double radius)
    {
        Radius = radius;
    }
}
