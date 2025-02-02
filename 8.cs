using System;

class Program
{
    static void Main()
    {
        Student s1 = new Student();
        s1.RollNumber = 101;
        s1.SetCGPA(3.8);

        Console.WriteLine("Roll Number: " + s1.RollNumber);
        Console.WriteLine("CGPA: " + s1.GetCGPA());
    }
}

class Student
{
    public int RollNumber;
    protected string Name;
    private double CGPA;

    public void SetCGPA(double cgpa)
    {
        CGPA = cgpa;
    }

    public double GetCGPA()
    {
        return CGPA;
    }
}
