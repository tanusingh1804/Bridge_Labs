using System;

class Program
{
    static void Main()
    {
        Console.Write("enter a date (yyyy-MM-dd): ");
        string input = Console.ReadLine();
        
        int year = int.Parse(input.Substring(0, 4));
        int month = int.Parse(input.Substring(5, 2));
        int day = int.Parse(input.Substring(8, 2));
        
        int daysToAdd = 7, monthsToAdd = 1, yearsToAdd = 2, weeksToSubtract = 3;
        
        day += daysToAdd;
        month += monthsToAdd;
        year += yearsToAdd;

        if (month > 12)
        {
            month -= 12;
            year += 1;
        }

        day -= (weeksToSubtract * 7);
        
        Console.WriteLine("modified date:" + year + "-" + month + "-" + day);
    }
}
