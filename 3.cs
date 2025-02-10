using System;
using System.Collections.Generic;

// Abstract Class
public abstract class Vehicle
{
    public string VehicleNumber { get; set; }
    public string Type { get; set; }
    public double RentalRate { get; set; }

    public abstract double CalculateRentalCost(int days);
}

// Concrete Classes
public class Car : Vehicle
{
    public override double CalculateRentalCost(int days)
    {
        return days * RentalRate;  // Rental rate per day
    }
}

public class Bike : Vehicle
{
    public override double CalculateRentalCost(int days)
    {
        return days * RentalRate;  // Rental rate per day
    }
}

// Interface
public interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

// Main Program
public class Program
{
    public static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car { VehicleNumber = "CAR123", Type = "Car", RentalRate = 50 },
            new Bike { VehicleNumber = "BIKE123", Type = "Bike", RentalRate = 20 }
        };

        foreach (var vehicle in vehicles)
        {
            double rentalCost = vehicle.CalculateRentalCost(5);  // Assume 5 days of rental
            Console.WriteLine("Vehicle: " + vehicle.Type + ", Rental Cost for 5 days: " + rentalCost);
        }
    }
}
