using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers:");

        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        int max = a;

        if (b > max)
            max = b;
        if (c > max)
            max = c;

        Console.WriteLine("The maximum number is: " + max);
    }
}
