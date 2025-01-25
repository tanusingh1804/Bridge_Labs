using System;

class Program2
{
    static void Main()
    {
        string[] friends = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        Console.WriteLine("Enter the details for Amar, Akbar, and Anthony:");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("\n{0}:", friends[i]);

            // Taking age input
            while (true)
            {
                Console.Write("Enter age: ");
                if (int.TryParse(Console.ReadLine(), out ages[i]) && ages[i] > 0)
                    break;
                Console.WriteLine("Invalid age. Please enter a positive number.");
            }

            // Taking height input
            while (true)
            {
                Console.Write("Enter height (in cm): ");
                if (double.TryParse(Console.ReadLine(), out heights[i]) && heights[i] > 0)
                    break;
                Console.WriteLine("Invalid height. Please enter a positive number.");
            }
        }

        // Finding the youngest and tallest friend
        int youngestIndex = 0;
        int tallestIndex = 0;

        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < ages[youngestIndex])
                youngestIndex = i;

            if (heights[i] > heights[tallestIndex])
                tallestIndex = i;
        }

        Console.WriteLine("\nResults:");
        Console.WriteLine("The youngest friend is {0}.", friends[youngestIndex]);
        Console.WriteLine("The tallest friend is {0}.", friends[tallestIndex]);
    }
}
