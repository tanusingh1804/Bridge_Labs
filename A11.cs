using System;
 class Program
{
     static void Main(string[] args)
    {
        double total = 0;
        double number;

        while (true)
        {
            Console.WriteLine("Enter a number:");
            number = double.Parse(Console.ReadLine());

            if (number <= 0)
            {
                break;
            }

            total += number;
        }

        Console.WriteLine("The sum is: " + total);
    }
}