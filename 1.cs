using System;

class Employee
{
    public string Name;
    public int Id;
    public double Salary;

    public Employee(string name, int id, double salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Employee Name " + Name);
        Console.WriteLine("Employee ID " + Id);
        Console.WriteLine("Salary " + Salary);
    }

    static void Main()
    {
        Employee emp = new Employee("John Doe", 101, 50000);
        emp.DisplayDetails();
    }
}
