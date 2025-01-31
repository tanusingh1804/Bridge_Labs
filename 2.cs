using System;

class Circle
{
    public double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return 3.14 * Radius * Radius;
    }

    public double GetCircumference()
    {
        return 2 * 3.14 * Radius;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Radius " + Radius);
        Console.WriteLine("Area " + GetArea());
        Console.WriteLine("Circumference " + GetCircumference());
    }

    static void Main()
    {
        Circle circle = new Circle(5);
        circle.DisplayDetails();
    }
}
