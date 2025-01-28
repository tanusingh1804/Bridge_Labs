using System;

class RandomNumbers
{
    public int[] Generate4DigitRandomArray(int size)
    {
        Random random = new Random();
        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(1000, 10000); // Generates a random 4-digit number
        }
        return numbers;
    }

    public double[] FindAverageMinMax(int[] numbers)
    {
        double sum = 0;
        int min = numbers[0];
        int max = numbers[0];

        foreach (int number in numbers)
        {
            sum += number;
            min = Math.Min(min, number);
            max = Math.Max(max, number);
        }

        double average = sum / numbers.Length;
        return new double[] { average, min, max };
    }
}

class Program12
{
    static void Main()
    {
        RandomNumbers randomNumbers = new RandomNumbers();
        
        Console.Write("Enter the number of random 4-digit values to generate: ");
        int size = int.Parse(Console.ReadLine());

        int[] numbers = randomNumbers.Generate4DigitRandomArray(size);

        Console.WriteLine("Generated Random Numbers:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        double[] results = randomNumbers.FindAverageMinMax(numbers);

        Console.WriteLine("Average: " + results[0]);
        Console.WriteLine("Minimum: " + results[1]);
        Console.WriteLine("Maximum: " + results[2]);
    }
}
