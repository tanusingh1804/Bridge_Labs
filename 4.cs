using System;

class Program
{
    static void GenerateFibonacci(int n)
    {
        int a = 0, b = 1, temp;

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            temp = a + b;
            a = b;
            b = temp;
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter number of terms:");
        int n = Convert.ToInt32(Console.ReadLine());

        GenerateFibonacci(n);
    }
}

