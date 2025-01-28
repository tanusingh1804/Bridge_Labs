using System;

class TemperatureConverter
{
    public static double ConvertFahrenheitToCelsius(double fahrenheit) { return (fahrenheit - 32) * 5 / 9; }
    public static double ConvertCelsiusToFahrenheit(double celsius) { return (celsius * 9 / 5) + 32; }
    public static double ConvertPoundsToKg(double pounds) { return pounds * 0.453592; }
    public static double ConvertKgToPounds(double kg) { return kg * 2.20462; }
}

// Main for Problem 6
class Program6
{
    static void Main()
    {
        Console.WriteLine("Enter Fahrenheit:");
        double fahrenheit = double.Parse(Console.ReadLine());
        Console.WriteLine(fahrenheit + " °F = " + TemperatureConverter.ConvertFahrenheitToCelsius(fahrenheit) + " °C");

        Console.WriteLine("Enter weight in pounds:");
        double pounds = double.Parse(Console.ReadLine());
        Console.WriteLine(pounds + " lbs = " + TemperatureConverter.ConvertPoundsToKg(pounds) + " kg");
    }
}
