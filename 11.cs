using System;

class WindChillCalculator
{
    public static double CalculateWindChill(double temperature, double windSpeed)
    {
        return 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter temperature (Fahrenheit): ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter wind speed (mph): ");
        double windSpeed = Convert.ToDouble(Console.ReadLine());

        double windChill = CalculateWindChill(temperature, windSpeed);

        Console.WriteLine("The wind chill is: " + windChill);
    }
}