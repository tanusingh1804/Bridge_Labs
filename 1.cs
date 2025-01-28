using System;

class FactorUtils
{
    public static int[] GetFactors(int number)
    {
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0) count++;
        }

        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index++] = i;
            }
        }

        return factors;
    }

    public static int GetSum(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    public static long GetProduct(int[] factors)
    {
        long product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    public static double GetSumOfSquares(int[] factors)
    {
        double sum = 0;
        foreach (int factor in factors)
        {
            sum += Math.Pow(factor, 2);
        }
        return sum;
    }
}

// Main for Problem 1
class Program1
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        int[] factors = FactorUtils.GetFactors(number);

        Console.WriteLine("Factors: " + string.Join(", ", factors));
        Console.WriteLine("Sum of Factors: " + FactorUtils.GetSum(factors));
        Console.WriteLine("Product of Factors: " + FactorUtils.GetProduct(factors));
        Console.WriteLine("Sum of Squares of Factors: " + FactorUtils.GetSumOfSquares(factors));
    }
}
