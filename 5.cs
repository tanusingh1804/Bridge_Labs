using System;

class UnitConverterAdvanced
{
    public static double ConvertYardsToFeet(double yards) { return yards * 3; }
    public static double ConvertFeetToYards(double feet) { return feet * 0.333333; }
    public static double ConvertMetersToInches(double meters) { return meters * 39.3701; }
    public static double ConvertInchesToMeters(double inches) { return inches * 0.0254; }
    public static double ConvertInchesToCm(double inches) { return inches * 2.54; }
}

// Main for Problem 5
class Program5
{
    static void Main()
    {
        Console.WriteLine("Enter yards:");
        double yards = double.Parse(Console.ReadLine());
        Console.WriteLine(yards + " yards = " + UnitConverterAdvanced.ConvertYardsToFeet(yards) + " feet");
    }
}
