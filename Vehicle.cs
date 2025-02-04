using System;
using System.Collections.Generic;

class Vehicle
{
   public static double RegistrationFee = 110.0;
   public readonly string RegistrationNumber;

   public string OwnerName { get; set; }
   public string VehicleType { get; set; }

   public Vehicle(string ownerName, string vehicleType, string registrationNumber)
   {
       this.OwnerName = ownerName;
       this.VehicleType = vehicleType;
       this.RegistrationNumber = registrationNumber;
   }

   public static void UpdateRegistrationFee(double newFee)
   {
       RegistrationFee = newFee;
       Console.WriteLine("Registration fee updated to: " + RegistrationFee);
   }

   public void DisplayRegistrationDetails(object obj)
   {
       if (obj is Vehicle vehicle)
       {
           Console.WriteLine("\nVehicle Registration Details:");
           Console.WriteLine("Owner Name       : " + vehicle.OwnerName);
           Console.WriteLine("Vehicle Type     : " + vehicle.VehicleType);
           Console.WriteLine("Registration No. : " + vehicle.RegistrationNumber);
           Console.WriteLine("Registration Fee : " + RegistrationFee);
       }
       else
       {
           Console.WriteLine("Invalid object. Cannot display registration details.");
       }
   }
}

class Program
{
   static void Main(string[] args)
   {
       Console.Write("Enter number of vehicles to register: ");
       int numVehicles = Convert.ToInt32(Console.ReadLine());

       List<Vehicle> vehicles = new List<Vehicle>();

       for (int i = 0; i < numVehicles; i++)
       {
           Console.WriteLine("\nEnter details for Vehicle " + (i + 1) + ":");

           Console.Write("Enter Owner Name: ");
           string ownerName = Console.ReadLine();

           Console.Write("Enter Vehicle Type: ");
           string vehicleType = Console.ReadLine();

           Console.Write("Enter Registration Number: ");
           string registrationNumber = Console.ReadLine();

           Vehicle vehicle = new Vehicle(ownerName, vehicleType, registrationNumber);
           vehicles.Add(vehicle);
       }

       Console.WriteLine("\nAll Vehicle Details:");
       foreach (var vehicle in vehicles)
       {
           vehicle.DisplayRegistrationDetails(vehicle);
       }

       Console.Write("\nUpdate registration fee? (yes/no): ");
       string choice = Console.ReadLine().ToLower();

       if (choice == "yes")
       {
           Console.Write("Enter new registration fee: ");
           if (double.TryParse(Console.ReadLine(), out double newFee))
           {
               Vehicle.UpdateRegistrationFee(newFee);

               Console.WriteLine("\nUpdated Vehicle Details:");
               foreach (var vehicle in vehicles)
               {
                   vehicle.DisplayRegistrationDetails(vehicle);
               }
           }
           else
           {
               Console.WriteLine("Invalid fee amount entered.");
           }
       }
   }
}
