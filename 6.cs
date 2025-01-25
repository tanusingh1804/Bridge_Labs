using System;

class Program6
{
    public static void Main()
    {
        double[] heights = new double[11];
        double total = 0;

        Console.WriteLine("Enter the heights of 11 players:");
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write("Height of player " + (i + 1) + ": ");
            heights[i] = double.Parse(Console.ReadLine());
            total += heights[i];
        }

        double mean = total / heights.Length;
        Console.WriteLine("Mean height of the football team: " + mean);
    }
}
