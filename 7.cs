using System;

public class EmployeeNode
{
    public int EmployeeID;
    public string Name;
    public string Position;
    public EmployeeNode Next;

    public EmployeeNode(int employeeID, string name, string position)
    {
        EmployeeID = employeeID;
        Name = name;
        Position = position;
        Next = null;
    }
}

public class EmployeeList
{
    private EmployeeNode head;

    // Add an employee at the end (circular list)
    public void AddEmployee(int employeeID, string name, string position)
    {
        EmployeeNode newEmployee = new EmployeeNode(employeeID, name, position);
        if (head == null)
        {
            head = newEmployee;
            newEmployee.Next = head; // Circular reference
        }
        else
        {
            EmployeeNode current = head;
            while (current.Next != head)
            {
                current = current.Next;
            }
            current.Next = newEmployee;
            newEmployee.Next = head; // Circular reference
        }
    }

    // Display all employees in a circular manner
    public void DisplayEmployees()
    {
        if (head == null) return;

        EmployeeNode current = head;
        do
        {
            Console.WriteLine($"Employee ID: {current.EmployeeID}, Name: {current.Name}, Position: {current.Position}");
            current = current.Next;
        } while (current != head);
    }

    // Remove employee by Employee ID
    public void RemoveEmployeeByID(int employeeID)
    {
        if (head == null) return;

        if (head.EmployeeID == employeeID)
        {
            if (head.Next == head)
            {
                head = null;
            }
            else
            {
                EmployeeNode temp = head;
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }
                head = head.Next;
                temp.Next = head;
            }
            Console.WriteLine("Employee with ID " + employeeID + " has been removed.");
            return;
        }

        EmployeeNode current = head;
        while (current.Next != head && current.Next.EmployeeID != employeeID)
        {
            current = current.Next;
        }

        if (current.Next == head)
        {
            Console.WriteLine("Employee with ID " + employeeID + " not found.");
        }
        else
        {
            current.Next = current.Next.Next;
            Console.WriteLine("Employee with ID " + employeeID + " has been removed.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        EmployeeList employeeList = new EmployeeList();
        employeeList.AddEmployee(1, "Alice", "Manager");
        employeeList.AddEmployee(2, "Bob", "Developer");
        employeeList.AddEmployee(3, "Charlie", "Designer");

        Console.WriteLine("Employee List:");
        employeeList.DisplayEmployees();

        employeeList.RemoveEmployeeByID(2);
        Console.WriteLine("\nUpdated Employee List:");
        employeeList.DisplayEmployees();
    }
}
