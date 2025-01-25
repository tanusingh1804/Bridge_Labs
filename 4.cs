using System;

class Program4
{
    public static void Main()
    {
        double[] numbers = new double[10];
        double total = 0.0;
        int index = 0;

        Console.WriteLine("Enter up to 10 numbers (enter 0 or a negative number to stop):");
        while (true)
        {
            double num = double.Parse(Console.ReadLine());
            if (num <= 0 || index == 10)
            {
                break;
            }

            numbers[index++] = num;
        }

        Console.WriteLine("Numbers entered:");
        for (int i = 0; i < index; i++)
        {
            Console.Write(numbers[i] + " ");
            total += numbers[i];
        }

        Console.WriteLine("\nSum of numbers: " + total);
    }
}
