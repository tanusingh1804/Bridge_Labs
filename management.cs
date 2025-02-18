using System;
using System.Collections.Generic;

// Abstract class for course types
abstract class CourseType { }

class ExamCourse : CourseType { }
class AssignmentCourse : CourseType { }

// Generic Course class
class Course<T> where T : CourseType
{
    public string Title { get; set; }
    public List<T> Evaluations { get; set; } = new List<T>();
}

// Main execution
class Program
{
    static void Main()
    {
        Course<ExamCourse> mathCourse = new Course<ExamCourse> { Title = "Mathematics 101" };
        Course<AssignmentCourse> programmingCourse = new Course<AssignmentCourse> { Title = "C# Programming" };

        Console.WriteLine($"Course Created: {mathCourse.Title}");
        Console.WriteLine($"Course Created: {programmingCourse.Title}");
    }
}
