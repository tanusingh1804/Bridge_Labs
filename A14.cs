using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a non-negative integer: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
        else
        {
            int factorial = 1;
            int i = 1;

            while (i <= number)
            {
                factorial *= i;
                i++;
            }

            Console.WriteLine("Factorial of " + number + " is: " + factorial);
        }
    }
}