using System;  // Include the System namespace for Console

// Define the superclass Device
public class Device
{
    // Attributes for the device
    public int DeviceId { get; set; }
    public string Status { get; set; }

    // Constructor for Device
    public Device(int deviceId, string status)
    {
        DeviceId = deviceId;
        Status = status;
    }

    // Method to display the status of the device
    public virtual void DisplayStatus()
    {
        Console.WriteLine("Device ID: " + DeviceId + ", Status: " + Status);
    }
}

// Define the subclass Thermostat that inherits from Device
public class Thermostat : Device
{
    // Additional attribute for Thermostat
    public double TemperatureSetting { get; set; }

    // Constructor for Thermostat that calls the base class constructor
    public Thermostat(int deviceId, string status, double temperatureSetting)
        : base(deviceId, status)
    {
        TemperatureSetting = temperatureSetting;
    }

    // Override DisplayStatus to include the TemperatureSetting
    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine("Temperature Setting: " + TemperatureSetting + "°C");
    }
}

// Main program to test the hierarchy
public class Program
{
    public static void Main(string[] args)
    {
        // Create a Device object
        Device myDevice = new Device(1, "Active");
        myDevice.DisplayStatus();

        // Create a Thermostat object
        Thermostat myThermostat = new Thermostat(2, "Active", 22.5);
        myThermostat.DisplayStatus();
    }
}
