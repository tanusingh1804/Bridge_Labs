using System;

 class Program
{
     static void Main(string[] args)
    {
        double total = 0;
        double number;

        Console.WriteLine("Enter numbers (enter 0 to stop):");

        do
        {
            number = double.Parse(Console.ReadLine());
            total += number;
        } while (number != 0);

        Console.WriteLine("The sum is: " + total);
    }
}