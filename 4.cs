using System;

class Program4
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int count = 0;
        int temp = number;

        while (temp != 0)
        {
            temp /= 10;
            count++;
        }

        int[] digits = new int[count];
        for (int i = 0; i < count; i++)
        {
            digits[i] = number % 10;
            number /= 10;
        }

        Console.WriteLine("Reversed Number: ");
        for (int i = 0; i < count; i++)
        {
            Console.Write(digits[i]);
        }
    }
}
