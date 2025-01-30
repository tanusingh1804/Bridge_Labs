using System;

class Program
{
    static void Main()
    {
        Console.Write("enter first date (yyyy-MM-dd)");
        string date1 = Console.ReadLine();
        Console.Write("enter second date (yyyy-MM-dd)");
        string date2 = Console.ReadLine();
        
        int y1 = int.Parse(date1.Substring(0, 4));
        int m1 = int.Parse(date1.Substring(5, 2));
        int d1 = int.Parse(date1.Substring(8, 2));

        int y2 = int.Parse(date2.Substring(0, 4));
        int m2 = int.Parse(date2.Substring(5, 2));
        int d2 = int.Parse(date2.Substring(8, 2));

        if (y1 < y2 || (y1 == y2 && m1 < m2) || (y1 == y2 && m1 == m2 && d1 < d2))
        {
            Console.WriteLine("first date come before second date");
        }
        else if (y1 > y2 || (y1 == y2 && m1 > m2) || (y1 == y2 && m1 == m2 && d1 > d2))
        {
            Console.WriteLine("first date comes after sec date");
        }
        else
        {
            Console.WriteLine("both dates are  same");
        }
    }
}
