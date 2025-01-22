using System;

class DistanceConverter
{
    static void Main()
    {
        Console.WriteLine("Enter distance in kilometers:");
        double kilometers = Convert.ToDouble(Console.ReadLine());
        double miles = kilometers / 1.6;
        Console.WriteLine("The total miles is " + miles + " mile(s) for the given " + kilometers + " km.");
    }
}
