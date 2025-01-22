using System;

class SampleProgram
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter fromCity: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter viaCity: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter toCity: ");
        string toCity = Console.ReadLine();

        Console.Write("Enter distance from fromCity to viaCity: ");
        double fromToVia = double.Parse(Console.ReadLine());

        Console.Write("Enter distance from viaCity to toCity: ");
        double viaToFinalCity = double.Parse(Console.ReadLine());

        Console.Write("Enter time taken: ");
        double timeTaken = double.Parse(Console.ReadLine());

        Console.WriteLine("The results of the trip are: " + name + ", " + fromCity + ", " + viaCity + ", " + toCity + ", " + fromToVia + ", " + viaToFinalCity + ", " + timeTaken);
    }
}
