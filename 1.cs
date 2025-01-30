using System;

class Program
{
    static void Main()
    {
        DateTimeOffset utcNow = DateTimeOffset.UtcNow;

        DateTimeOffset gmtTime = utcNow;
        DateTimeOffset istTime = utcNow.ToOffset(TimeSpan.FromHours(5.5));
        DateTimeOffset pstTime = utcNow.ToOffset(TimeSpan.FromHours(-8));

        Console.WriteLine("current time in GMT" + gmtTime);
        Console.WriteLine("current time in IST" + istTime);
        Console.WriteLine("current time in PST" + pstTime);
    }
}

