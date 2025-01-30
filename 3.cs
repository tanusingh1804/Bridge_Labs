using System;

class Program
{
    static void Main()
    {
        DateTime now = DateTime.Now;

        string format1 = now.Day + "/" + now.Month + "/" + now.Year;
        string format2 = now.Year + "-" + now.Month + "-" + now.Day;
        
        string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
        string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        string format3 = weekDays[(int)now.DayOfWeek] + ", " + months[now.Month - 1] + " " + now.Day + ", " + now.Year;

        Console.WriteLine("format 1: " + format1);
        Console.WriteLine("format 2: " + format2);
        Console.WriteLine("format 3: " + format3);
    }
}
