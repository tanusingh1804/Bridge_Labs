using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 4, 3, -1, 5, -7 };
        
        foreach (int num in numbers)
        {
            if (num < 0)
            {
                Console.WriteLine("First negative number: " + num);
                return;
            }
        }

        Console.WriteLine("No negative numbers found.");
    }
}
