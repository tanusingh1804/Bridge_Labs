using System;

class SpringSeasonChecker
{
    public static bool IsSpringSeason(int month, int day)
    {
        if (month == 3 && day >= 20) return true;
        if (month > 3 && month < 6) return true;
        if (month == 6 && day <= 20) return true;
        return false;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter Month (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Day: ");
        int day = Convert.ToInt32(Console.ReadLine());

        bool isSpring = IsSpringSeason(month, day);

        if (isSpring) Console.WriteLine("It's a Spring Season.");
        else Console.WriteLine("Not a Spring Season.");
    }
}