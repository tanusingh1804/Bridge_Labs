using System;
using System.Collections.Generic;

// Abstract Class
public abstract class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public double BaseSalary { get; set; }

    public abstract double CalculateSalary();
    
    public void DisplayDetails()
    {
        Console.WriteLine("Employee ID: " + EmployeeId + ", Name: " + Name + ", Salary: " + CalculateSalary());
    }
}

// Subclass FullTimeEmployee
public class FullTimeEmployee : Employee
{
    public override double CalculateSalary()
    {
        return BaseSalary;  // Fixed Salary for full-time
    }
}

// Subclass PartTimeEmployee
public class PartTimeEmployee : Employee
{
    public int WorkHours { get; set; }
    public double HourlyRate { get; set; }

    public override double CalculateSalary()
    {
        return WorkHours * HourlyRate;  // Salary based on hours worked
    }
}

// Interface
public interface IDepartment
{
    void AssignDepartment(string department);
    string GetDepartmentDetails();
}

public class EmployeeDepartment : IDepartment
{
    public string Department { get; private set; }

    public void AssignDepartment(string department)
    {
        Department = department;
    }

    public string GetDepartmentDetails()
    {
        return "Department: " + Department;
    }
}

// Main Program
public class Program
{
    public static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new FullTimeEmployee { EmployeeId = 1, Name = "John", BaseSalary = 5000 },
            new PartTimeEmployee { EmployeeId = 2, Name = "Alice", BaseSalary = 0, WorkHours = 20, HourlyRate = 15 }
        };

        foreach (var employee in employees)
        {
            employee.DisplayDetails();
        }
    }
}
