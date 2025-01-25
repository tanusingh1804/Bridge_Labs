using System;

class Program3
{
    public static void Main()
    {
        Console.Write("Enter a number for the multiplication table: ");
        int number = int.Parse(Console.ReadLine());

        int[] table = new int[10];
        for (int i = 0; i < 10; i++)
        {
            table[i] = number * (i + 1);
        }

        Console.WriteLine("Multiplication table for " + number + ":");
        for (int i = 0; i < table.Length; i++)
        {
            Console.WriteLine(number + " x " + (i + 1) + " = " + table[i]);
        }
    }
}
