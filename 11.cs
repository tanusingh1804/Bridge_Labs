using System;

public interface Refuelable
{
    void Refuel();
}

public class Vehicle
{
    public int MaxSpeed { get; set; }
    public string Model { get; set; }

    public Vehicle(int maxSpeed, string model)
    {
        MaxSpeed = maxSpeed;
        Model = model;
    }
}

public class ElectricVehicle : Vehicle
{
    public ElectricVehicle(int maxSpeed, string model) : base(maxSpeed, model) { }

    public void Charge()
    {
        Console.WriteLine("Charging vehicle");
    }
}

public class PetrolVehicle : Vehicle, Refuelable
{
    public PetrolVehicle(int maxSpeed, string model) : base(maxSpeed, model) { }

    public void Refuel()
    {
        Console.WriteLine("Refueling vehicle");
    }
}

public class Program
{
    public static void Main()
    {
        PetrolVehicle petrolVehicle = new PetrolVehicle(120, "Honda");
        petrolVehicle.Refuel();
    }
}
