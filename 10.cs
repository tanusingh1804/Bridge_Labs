using System;

class Program
{
    static void Main()
    {
        Student s1 = new Student(101, "John");
        s1.SetCGPA(3.8);
        Console.WriteLine("Roll Number: " + s1.RollNumber);
        Console.WriteLine("CGPA: " + s1.GetCGPA());

        PostgraduateStudent pgs = new PostgraduateStudent(102, "Alice", "Computer Science");
        pgs.DisplayDetails();
    }
}

class Student
{
    public int RollNumber;
    protected string Name;
    private double CGPA;

    public Student(int rollNumber, string name)
    {
        RollNumber = rollNumber;
        Name = name;
    }

    public void SetCGPA(double cgpa)
    {
        CGPA = cgpa;
    }

    public double GetCGPA()
    {
        return CGPA;
    }
}

class PostgraduateStudent : Student
{
    private string Specialization;

    public PostgraduateStudent(int rollNumber, string name, string specialization) : base(rollNumber, name)
    {
        Specialization = specialization;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Postgraduate Student: " + Name + ", Specialization: " + Specialization);
    }
}
