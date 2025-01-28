using System;

class LeapYearUtils
{
    public static bool IsLeapYear(int year)
    {
        if (year < 1582) return false;
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}

// Main for Problem 3
class Program3
{
    static void Main()
    {
        Console.WriteLine("Enter a year:");
        int year = int.Parse(Console.ReadLine());

        if (LeapYearUtils.IsLeapYear(year))
            Console.WriteLine(year + " is a Leap Year.");
        else
            Console.WriteLine(year + " is NOT a Leap Year.");
    }
}

