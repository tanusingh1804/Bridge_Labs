using System;

class Program
{
    static int Factorial(int n)
    {
        if (n == 0)
            return 1;
        return n * Factorial(n - 1);
    }

    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Factorial of " + num + " is " + Factorial(num));
    }
}
