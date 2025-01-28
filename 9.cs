using System;

class NumberUtils
{
    public static bool IsPositive(int number)
    {
        return number >= 0;
    }

    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public static int CompareNumbers(int num1, int num2)
    {
        if (num1 > num2) return 1;
        if (num1 < num2) return -1;
        return 0;
    }
}

class Program9
{
    static void Main()
    {
        int[] numbers = new int[5];

        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++)
        {
            if (NumberUtils.IsPositive(numbers[i]))
            {
                Console.WriteLine("Number " + numbers[i] + " is Positive and it is " + (NumberUtils.IsEven(numbers[i]) ? "Even" : "Odd"));
            }
            else
            {
                Console.WriteLine("Number " + numbers[i] + " is Negative");
            }
        }

        int comparison = NumberUtils.CompareNumbers(numbers[0], numbers[4]);
        if (comparison == 1)
            Console.WriteLine("The first element (" + numbers[0] + ") is greater than the last element (" + numbers[4] + ")");
        else if (comparison == -1)
            Console.WriteLine("The first element (" + numbers[0] + ") is less than the last element (" + numbers[4] + ")");
        else
            Console.WriteLine("The first element (" + numbers[0] + ") is equal to the last element (" + numbers[4] + ")");
    }
}
