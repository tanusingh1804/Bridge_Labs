using System;
using System.Collections.Generic;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class CacheResultAttribute : Attribute { }

class ExpensiveOperations
{
    private static Dictionary<string, object> cache = new Dictionary<string, object>();

    [CacheResult]
    public int ComputeFactorial(int n)
    {
        string key = $"Factorial({n})";

        if (cache.ContainsKey(key))
        {
            Console.WriteLine($"Returning cached result for {n}!");
            return (int)cache[key];
        }

        Console.WriteLine($"Computing factorial for {n}...");
        int result = Factorial(n);
        cache[key] = result;
        return result;
    }

    private int Factorial(int n)
    {
        return (n <= 1) ? 1 : n * Factorial(n - 1);
    }
}

class Program12
{
    static void Main(string[] args)
    {
        ExpensiveOperations operations = new ExpensiveOperations();

        Console.WriteLine(operations.ComputeFactorial(5)); 
        Console.WriteLine(operations.ComputeFactorial(5)); 
        Console.WriteLine(operations.ComputeFactorial(6)); 
        Console.WriteLine(operations.ComputeFactorial(6)); 
    }
}
