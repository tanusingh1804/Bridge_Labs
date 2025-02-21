using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter numerator: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter denominator: ");
            int denom = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result: " + (num / denom));
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero!");
        }
        finally
        {
            Console.WriteLine("Operation completed");
        }
    }
}
