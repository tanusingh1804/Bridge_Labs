using System;

class Program
{
    static void Main()
    {
        CarRental rental = new CarRental("Mike", "Toyota", 5);
        Console.WriteLine("Total Cost: " + rental.CalculateTotalCost());
    }
}

class CarRental
{
    public string CustomerName { get; set; }
    public string CarModel { get; set; }
    public int RentalDays { get; set; }
    private const double DailyRate = 50.0;

    public CarRental(string customerName, string carModel, int rentalDays)
    {
        CustomerName = customerName;
        CarModel = carModel;
        RentalDays = rentalDays;
    }

    public double CalculateTotalCost()
    {
        return RentalDays * DailyRate;
    }
}
