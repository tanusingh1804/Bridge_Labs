using System;

class Program10
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        string[] results = new string[number];

        for (int i = 0; i < number; i++)
        {
            if ((i + 1) % 3 == 0 && (i + 1) % 5 == 0)
                results[i] = "FizzBuzz";
            else if ((i + 1) % 3 == 0)
                results[i] = "Fizz";
            else if ((i + 1) % 5 == 0)
                results[i] = "Buzz";
            else
                results[i] = (i + 1).ToString();
        }

        Console.WriteLine("\nFizzBuzz Results:");
        for (int i = 0; i < results.Length; i++)
        {
            Console.WriteLine($"Position {i + 1} = {results[i]}");
        }
    }
}