using System;

class NaturalNumberUtils
{
    public static int SumUsingRecursion(int n)
    {
        if (n == 1) return 1;
        return n + SumUsingRecursion(n - 1);
    }

    public static int SumUsingFormula(int n)
    {
        return n * (n + 1) / 2;
    }
}

// Main for Problem 2
class Program2
{
    static void Main()
    {
        Console.WriteLine("Enter a natural number:");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Not a natural number.");
            return;
        }

        int sumRecursion = NaturalNumberUtils.SumUsingRecursion(n);
        int sumFormula = NaturalNumberUtils.SumUsingFormula(n);

        Console.WriteLine("Sum using Recursion: " + sumRecursion);
        Console.WriteLine("Sum using Formula: " + sumFormula);
        Console.WriteLine(sumRecursion == sumFormula
            ? "Both results are correct."
            : "Results do not match.");
    }
}
