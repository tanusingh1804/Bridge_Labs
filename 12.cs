using System;

class TrigonometricFunctions
{
    // Method to calculate sine, cosine, and tangent given an angle in degrees
    public static double[] CalculateTrigFunctions(double angleInDegrees)
    {
        // Convert angle to radians
        double angleInRadians = angleInDegrees * Math.PI / 180;

        // Calculate sine, cosine, and tangent
        double sine = Math.Sin(angleInRadians);
        double cosine = Math.Cos(angleInRadians);
        double tangent = Math.Tan(angleInRadians);

        return new double[] { sine, cosine, tangent };
    }

    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter an angle in degrees: ");
            double angle = Convert.ToDouble(Console.ReadLine());

            // Get trigonometric values
            double[] trigValues = CalculateTrigFunctions(angle);

            // Display results
            Console.WriteLine("Sine of " + angle + "°: " + trigValues[0]);
            Console.WriteLine("Cosine of " + angle + "°: " + trigValues[1]);
            Console.WriteLine("Tangent of " + angle + "°: " + trigValues[2]);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
