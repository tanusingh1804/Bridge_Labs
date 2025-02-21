using System;

class Program
{
    static double CalculateInterest(double amount, double rate, int years)
    {
        if (amount < 0 || rate < 0)
            throw new ArgumentException("Amount and rate must be positive");

        return amount * rate * years / 100;
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter years: ");
            int years = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Interest: " + CalculateInterest(amount, rate, years));
        }
        catch (ArgumentException e)
        {
            Console.WriteLine("Invalid input: " + e.Message);
        }
    }
}
