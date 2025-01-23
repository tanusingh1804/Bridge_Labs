using System;

 class Program
{
     static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            int sum1 = 0;
            int i = 1;

            while (i <= number)
            {
                sum1 += i;
                i++;
            }

            int sum2 = (number * (number + 1)) / 2;

            if (sum1 == sum2)
            {
                Console.WriteLine("Both computations are correct.");
            }
            else
            {
                Console.WriteLine("Computations do not match.");
            }
        }
        else
        {
            Console.WriteLine("The number is not a natural number.");
        }
    }
}