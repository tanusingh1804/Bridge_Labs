//using System;
//using System.Collections.Generic;

//class Course
//{
//    public string CourseName { get; }
//    public Professor Prof { get; private set; }
//    public List<Student> Students { get; } = new List<Student>();

//    public Course(string courseName)
//    {
//        CourseName = courseName;
//    }

//    public void AssignProfessor(Professor professor)
//    {
//        Prof = professor;
//    }

//    public void EnrollStudent(Student student)
//    {
//        Students.Add(student);
//    }

//    public void ShowCourseDetails()
//    {
//        Console.WriteLine($"Course: {CourseName}");
//        Console.WriteLine($"Professor: {Prof.ProfessorName}");
//        Console.WriteLine("Enrolled Students:");
//        foreach (Student student in Students)
//        {
//            Console.WriteLine($"- {student.StudentName}");
//        }
//    }
//}

//class Student
//{
//    public string StudentName { get; }

//    public Student(string studentName)
//    {
//        StudentName = studentName;
//    }

//    public void EnrollInCourse(Course course)
//    {
//        course.EnrollStudent(this);
//    }
//}

//class Professor
//{
//    public string ProfessorName { get; }

//    public Professor(string professorName)
//    {
//        ProfessorName = professorName;
//    }

//    public void AssignCourse(Course course)
//    {
//        course.AssignProfessor(this);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter Professor's Name: ");
//        string professorName = Console.ReadLine();
//        Professor professor = new Professor(professorName);

//        Console.Write("Enter Course Name: ");
//        string courseName = Console.ReadLine();
//        Course course = new Course(courseName);

//        professor.AssignCourse(course);

//        Console.Write($"Enter number of students for {courseName}: ");
//        int studentCount = int.Parse(Console.ReadLine());

//        for (int i = 0; i < studentCount; i++)
//        {
//            Console.Write("Enter Student Name: ");
//            string studentName = Console.ReadLine();
//            Student student = new Student(studentName);
//            student.EnrollInCourse(course);
//        }

//        course.ShowCourseDetails();
//    }
//}
