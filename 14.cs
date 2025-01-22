using System;

class DistanceConverter
{
    static void Main()
    {
        Console.WriteLine("Enter the distance in feet:");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());

        double distanceInYards = distanceInFeet / 3;
        double distanceInMiles = distanceInYards / 1760;

        Console.WriteLine("The distance is " + distanceInYards + " yards and " + distanceInMiles + " miles for " + distanceInFeet + " feet.");
    }
}
