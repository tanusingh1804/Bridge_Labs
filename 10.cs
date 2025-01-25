using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        // Validate the input
        long number;
        while (!long.TryParse(input, out number) || number < 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
            input = Console.ReadLine();
        }

        // Convert number to an array of digits
        int[] digits = Array.ConvertAll(input.ToCharArray(), c => c - '0');
        int[] frequency = new int[10]; // Array to store the frequency of each digit

        // Calculate frequency
        foreach (int digit in digits)
        {
            frequency[digit]++;
        }

        // Display the frequency of each digit
        Console.WriteLine("\nDigit Frequencies:");
        for (int i = 0; i < frequency.Length; i++)
        {
            if (frequency[i] > 0)
                Console.WriteLine("Digit " + i + ": " + frequency[i]);
        }
    }
}
