using System;

// Base Class: Employee
public class Employee
{
    // Attributes
    public string Name;
    public int Id;
    public double Salary;

    // Constructor to initialize name, id, and salary
    public Employee(string name, int id, double salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    // Method to display employee details
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Salary: " + Salary);
    }
}

// Subclass: Manager (inherits from Employee)
public class Manager : Employee
{
    // Additional attribute for Manager
    public int TeamSize;

    // Constructor for Manager, reusing Employee's constructor
    public Manager(string name, int id, double salary, int teamSize) : base(name, id, salary)
    {
        TeamSize = teamSize;
    }

    // Overriding DisplayDetails to include TeamSize
    public override void DisplayDetails()
    {
        base.DisplayDetails(); // Display common employee details
        Console.WriteLine("Team Size: " + TeamSize);
    }
}

// Subclass: Developer (inherits from Employee)
public class Developer : Employee
{
    // Additional attribute for Developer
    public string ProgrammingLanguage;

    // Constructor for Developer, reusing Employee's constructor
    public Developer(string name, int id, double salary, string programmingLanguage) : base(name, id, salary)
    {
        ProgrammingLanguage = programmingLanguage;
    }

    // Overriding DisplayDetails to include ProgrammingLanguage
    public override void DisplayDetails()
    {
        base.DisplayDetails(); // Display common employee details
        Console.WriteLine("Programming Language: " + ProgrammingLanguage);
    }
}

// Subclass: Intern (inherits from Employee)
public class Intern : Employee
{
    // Additional attribute for Intern
    public string InternshipDuration;

    // Constructor for Intern, reusing Employee's constructor
    public Intern(string name, int id, double salary, string internshipDuration) : base(name, id, salary)
    {
        InternshipDuration = internshipDuration;
    }

    // Overriding DisplayDetails to include InternshipDuration
    public override void DisplayDetails()
    {
        base.DisplayDetails(); // Display common employee details
        Console.WriteLine("Internship Duration: " + InternshipDuration);
    }
}

// Main Program to demonstrate inheritance
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of different employee types
        Employee manager = new Manager("Alice", 101, 90000, 5);
        Employee developer = new Developer("Bob", 102, 70000, "C#");
        Employee intern = new Intern("Charlie", 103, 15000, "6 months");

        // Displaying details for each employee
        manager.DisplayDetails();
        Console.WriteLine(); // For better readability

        developer.DisplayDetails();
        Console.WriteLine();

        intern.DisplayDetails();
    }
}
