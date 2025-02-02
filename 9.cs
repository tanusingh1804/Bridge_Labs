using System;

class Program
{
    static void Main()
    {
        Vehicle v1 = new Vehicle("Alice", "Car");
        v1.DisplayVehicleDetails();

        Vehicle.UpdateRegistrationFee(1200);
        v1.DisplayVehicleDetails();
    }
}

class Vehicle
{
    public string OwnerName { get; set; }
    public string VehicleType { get; set; }
    private static double registrationFee = 1000;

    public Vehicle(string ownerName, string vehicleType)
    {
        OwnerName = ownerName;
        VehicleType = vehicleType;
    }

    public void DisplayVehicleDetails()
    {
        Console.WriteLine("Owner: " + OwnerName + ", Vehicle Type: " + VehicleType + ", Registration Fee: " + registrationFee);
    }

    public static void UpdateRegistrationFee(double newFee)
    {
        registrationFee = newFee;
    }
}
