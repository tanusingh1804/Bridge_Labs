using System;

public class DateFormatter
{

    public string FormatDate(string inputDate)
    {
        try
        {
            DateTime date = DateTime.ParseExact(inputDate, "yyyy-MM-dd", null);
            return date.ToString("dd-MM-yyyy");
        }
        catch (FormatException)
        {
            throw new ArgumentException("Invalid date format. Use yyyy-MM-dd.");
        }
    }
}

