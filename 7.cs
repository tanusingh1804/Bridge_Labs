using System;

class NaturalNumberSum
{
    public static int CalculateSum(int n)
    {
        return (n * (n + 1)) / 2;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a positive number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = CalculateSum(n);

        Console.WriteLine("The sum of first " + n + " natural numbers is " + sum + ".");
    }
}