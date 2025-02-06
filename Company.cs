//using System;
//using System.Collections.Generic;

//class Company
//{
//    public string Name { get; }
//    public List<Department> Departments { get; } = new List<Department>();

//    public Company(string name)
//    {
//        Name = name;
//    }

//    public void AddDepartment(Department dept)
//    {
//        Departments.Add(dept);
//    }

//    public void RemoveDepartments()
//    {
//        Departments.Clear();
//    }

//    public void DeleteCompany()
//    {
//        Console.WriteLine($"Deleting company: {Name}");
//        RemoveDepartments();
//    }
//}

//class Department
//{
//    public string Name { get; }
//    public List<Employee> Employees { get; } = new List<Employee>();

//    public Department(string name)
//    {
//        Name = name;
//    }

//    public void AddEmployee(Employee emp)
//    {
//        Employees.Add(emp);
//    }

//    public void RemoveEmployees()
//    {
//        Employees.Clear();
//    }

//    public void ShowEmployees()
//    {
//        foreach (Employee emp in Employees)
//        {
//            Console.WriteLine($"Emp in {Name}: {emp.Name}");
//        }
//    }
//}

//class Employee
//{
//    public string Name { get; }

//    public Employee(string name)
//    {
//        Name = name;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter company name: ");
//        string companyName = Console.ReadLine();
//        Company company = new Company(companyName);

//        Console.Write("Enter number of departments: ");
//        if (!int.TryParse(Console.ReadLine(), out int deptCount) || deptCount <= 0)
//        {
//            Console.WriteLine("Invalid input!");
//            return;
//        }

//        for (int i = 0; i < deptCount; i++)
//        {
//            Console.Write($"\nEnter department {i + 1} name: ");
//            string deptName = Console.ReadLine();
//            Department department = new Department(deptName);

//            Console.Write($"Enter number of employees in {deptName}: ");
//            if (!int.TryParse(Console.ReadLine(), out int empCount) || empCount < 0)
//            {
//                Console.WriteLine("Invalid input!");
//                continue;
//            }

//            for (int j = 0; j < empCount; j++)
//            {
//                Console.Write($"Enter employee {j + 1} name: ");
//                string empName = Console.ReadLine();
//                department.AddEmployee(new Employee(empName));
//            }

//            company.AddDepartment(department);
//        }

//        Console.WriteLine("\nBefore company deletion:");
//        foreach (Department dept in company.Departments)
//        {
//            dept.ShowEmployees();
//        }

//        company.DeleteCompany();

//        Console.WriteLine("\nAfter company deletion:");
//        foreach (Department dept in company.Departments)
//        {
//            dept.ShowEmployees();
//        }
//    }
//}
