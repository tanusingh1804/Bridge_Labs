using System;

class UnitConverter
{
    public static double ConvertKmToMiles(double km) { return km * 0.621371; }
    public static double ConvertMilesToKm(double miles) { return miles * 1.60934; }
    public static double ConvertMetersToFeet(double meters) { return meters * 3.28084; }
    public static double ConvertFeetToMeters(double feet) { return feet * 0.3048; }
}

// Main for Problem 4
class Program4
{
    static void Main()
    {
        Console.WriteLine("Enter kilometers:");
        double km = double.Parse(Console.ReadLine());
        Console.WriteLine(km + " km = " + UnitConverter.ConvertKmToMiles(km) + " miles");

        Console.WriteLine("Enter miles:");
        double miles = double.Parse(Console.ReadLine());
        Console.WriteLine(miles + " miles = " + UnitConverter.ConvertMilesToKm(miles) + " km");
    }
}
