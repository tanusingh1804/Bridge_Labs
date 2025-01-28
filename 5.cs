using System;

class NumberCheck
{
    public static int CheckNumber(int number)
    {
        if (number > 0) return 1;
        if (number < 0) return -1;
        return 0;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = CheckNumber(number);

        if (result == 1) Console.WriteLine("The number is positive.");
        else if (result == -1) Console.WriteLine("The number is negative.");
        else Console.WriteLine("The number is zero.");
    }
}