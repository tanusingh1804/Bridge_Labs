//using System;
//using System.Collections.Generic;

//class School
//{
//    public string Name { get; }
//    public List<Student> Students { get; } = new List<Student>();

//    public School(string name)
//    {
//        Name = name;
//    }

//    public void AddStudent(Student student)
//    {
//        Students.Add(student);
//    }

//    public void ShowStudents()
//    {
//        foreach (Student student in Students)
//        {
//            Console.WriteLine($"Student: {student.Name}");
//        }
//    }
//}

//class Student
//{
//    public string Name { get; }
//    public List<Course> Courses { get; } = new List<Course>();

//    public Student(string name)
//    {
//        Name = name;
//    }

//    public void Enroll(Course course)
//    {
//        Courses.Add(course);
//        course.AddStudent(this);
//    }

//    public void ShowCourses()
//    {
//        foreach (Course course in Courses)
//        {
//            Console.WriteLine($"Course: {course.Name}");
//        }
//    }
//}

//class Course
//{
//    public string Name { get; }
//    public List<Student> Students { get; } = new List<Student>();

//    public Course(string name)
//    {
//        Name = name;
//    }

//    public void AddStudent(Student student)
//    {
//        Students.Add(student);
//    }

//    public void ShowStudents()
//    {
//        foreach (Student student in Students)
//        {
//            Console.WriteLine($"Student enrolled: {student.Name}");
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter school name: ");
//        string schoolName = Console.ReadLine();
//        School school = new School(schoolName);

//        Console.Write("Enter number of students: ");
//        if (!int.TryParse(Console.ReadLine(), out int studentCount) || studentCount <= 0)
//        {
//            Console.WriteLine("Invalid input!");
//            return;
//        }

//        for (int i = 0; i < studentCount; i++)
//        {
//            Console.Write($"\nEnter student {i + 1} name: ");
//            string studentName = Console.ReadLine();
//            Student student = new Student(studentName);

//            Console.Write($"Enter number of courses for {studentName}: ");
//            if (!int.TryParse(Console.ReadLine(), out int courseCount) || courseCount < 0)
//            {
//                Console.WriteLine("Invalid input!");
//                continue;
//            }

//            for (int j = 0; j < courseCount; j++)
//            {
//                Console.Write($"Enter course {j + 1} name: ");
//                string courseName = Console.ReadLine();
//                Course course = new Course(courseName);
//                student.Enroll(course);
//            }

//            school.AddStudent(student);
//        }

//        Console.WriteLine("\nSchool Students:");
//        school.ShowStudents();

//        Console.WriteLine("\nCourses and Enrolled Students:");
//        foreach (Student student in school.Students)
//        {
//            student.ShowCourses();
//        }
//    }
//}
