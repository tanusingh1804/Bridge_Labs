using System;

class Student
{
    public static string UniversityName = "Delhi University";
    private static int totalStudents = 0;

    public readonly int RollNumber;
    public string Name { get; set; }
    public double Grade { get; set; }

    public Student(string name, double grade)
    {
        this.RollNumber = ++totalStudents; 
        this.Name = name;
        this.Grade = grade;
    }

    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total students enrolled: " + totalStudents);
    }

    public void DisplayDetails(object obj)
    {
        if (obj is Student student)
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine("Roll Number   : " + student.RollNumber);
            Console.WriteLine("Name          : " + student.Name);
            Console.WriteLine("Grade         : " + student.Grade);
            Console.WriteLine("University    : " + UniversityName);
        }
        else
        {
            Console.WriteLine("Invalid object. Cannot display student details.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of students  ");
        int numStudents = Convert.ToInt32(Console.ReadLine());

        Student[] students = new Student[numStudents]; 

        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine("\nEnter details for Student " + (i + 1) + ":");

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Grade: ");
            double grade = Convert.ToDouble(Console.ReadLine());

            students[i] = new Student(name, grade);
        }

        Console.WriteLine("\nAll Student Details:");
        for (int i = 0; i < numStudents; i++)
        {
            students[i].DisplayDetails(students[i]);
        }

        Student.DisplayTotalStudents();
    }
}
