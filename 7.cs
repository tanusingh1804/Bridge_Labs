using System;

public class Course
{
    public string CourseName { get; set; }
    public int Duration { get; set; }

    public Course(string courseName, int duration)
    {
        CourseName = courseName;
        Duration = duration;
    }
}

public class OnlineCourse : Course
{
    public string Platform { get; set; }
    public bool IsRecorded { get; set; }

    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
        : base(courseName, duration)
    {
        Platform = platform;
        IsRecorded = isRecorded;
    }
}

public class PaidOnlineCourse : OnlineCourse
{
    public double Fee { get; set; }
    public double Discount { get; set; }

    public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount)
        : base(courseName, duration, platform, isRecorded)
    {
        Fee = fee;
        Discount = discount;
    }
}

public class Program
{
    public static void Main()
    {
        PaidOnlineCourse paidCourse = new PaidOnlineCourse("C# Programming", 30, "Udemy", true, 100.0, 20.0);
        Console.WriteLine(paidCourse.CourseName);
    }
}
