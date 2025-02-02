using System;

class Program
{
    static void Main()
    {
        Manager manager = new Manager(1001, "IT", 75000);
        manager.SetSalary(85000);
        manager.DisplayManagerDetails();
    }
}

class Employee
{
    public int EmployeeID;
    protected string Department;
    private double Salary;

    public Employee(int employeeID, string department, double salary)
    {
        EmployeeID = employeeID;
        Department = department;
        Salary = salary;
    }

    public void SetSalary(double newSalary)
    {
        Salary = newSalary;
    }

    public double GetSalary()
    {
        return Salary;
    }
}

class Manager : Employee
{
    public Manager(int employeeID, string department, double salary) : base(employeeID, department, salary) { }

    public void DisplayManagerDetails()
    {
        Console.WriteLine("Manager ID: " + EmployeeID + ", Department: " + Department + ", Salary: " + GetSalary());
    }
}
