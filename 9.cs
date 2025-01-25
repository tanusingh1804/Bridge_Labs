using System;

class Program9
{
    public static void Main()
    {
        Console.Write("Enter a positive number: ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Error: Not a positive number.");
            return;
        }

        string[] results = new string[number + 1];

        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                results[i] = "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                results[i] = "Fizz";using System;

class Program9
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, columns];
        int[] oneDArray = new int[rows * columns];
        int index = 0;

        Console.WriteLine("Enter elements of the matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Enter element at position ({i+1},{j+1}): ");
                matrix[i, j] = int.Parse(Console.ReadLine());
                oneDArray[index++] = matrix[i, j];
            }
        }

        Console.WriteLine("\n1D Array:");
        for (int i = 0; i < oneDArray.Length; i++)
        {
            Console.Write(oneDArray[i] + " ");
        }
    }
}
            }
            else if (i % 5 == 0)
            {
                results[i] = "Buzz";
            }
            else
            {
                results[i] = i.ToString();
            }
        }

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine("Position " + i + " = " + results[i]);
        }
    }
}
