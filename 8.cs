using System;
using System.Collections.Generic;

// Abstract Class
public abstract class Vehicle
{
    public string VehicleId { get; set; }
    public string DriverName { get; set; }
    public double RatePerKm { get; set; }

    public abstract double CalculateFare(double distance);
}

// Subclasses
public class Car : Vehicle
{
    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }
}

public class Bike : Vehicle
{
    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }
}

// Interface
public interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string newLocation);
}

// Main Program
public class Program
{
    public static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car { VehicleId = "CAR123", DriverName = "John", RatePerKm = 5 },
            new Bike { VehicleId = "BIKE123", DriverName = "Alice", RatePerKm = 3 }
        };

        foreach (var vehicle in vehicles)
        {
            double fare = vehicle.CalculateFare(10);  // Assume a 10 km ride
            Console.WriteLine("Vehicle: " + vehicle.DriverName + ", Fare: " + fare);
        }
    }
}
