using System;

class Program
{
    static double FahrenheitToCelsius(double f)
    {
        return (f - 32) * 5 / 9;
    }

    static double CelsiusToFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }

    static void Main()
    {
        Console.WriteLine("Enter temperature:");
        double temp = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Convert to (C/F)?");
        char choice = Console.ReadLine()[0];

        if (choice == 'C' || choice == 'c')
            Console.WriteLine("Converted: " + FahrenheitToCelsius(temp) + "°C");
        else if (choice == 'F' || choice == 'f')
            Console.WriteLine("Converted: " + CelsiusToFahrenheit(temp) + "°F");
        else
            Console.WriteLine("Invalid choice.");
    }
}
