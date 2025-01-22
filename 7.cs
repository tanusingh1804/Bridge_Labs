using System;

class EarthVolume
{
    static void Main()
    {
        double radiusKm = 6378;
        double radiusMiles = radiusKm / 1.6;
        double volumeKm = (4.0 / 3) * Math.PI * Math.Pow(radiusKm, 3);
        double volumeMiles = (4.0 / 3) * Math.PI * Math.Pow(radiusMiles, 3);
        Console.WriteLine("The volume of Earth in cubic kilometers is " + volumeKm + " and in cubic miles is " + volumeMiles);
    }
}
