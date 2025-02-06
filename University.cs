//using System;
//using System.Collections.Generic;

//class University
//{
//    public string Name { get; }
//    public List<Department> Departments { get; } = new List<Department>();

//    public University(string name)
//    {
//        Name = name;
//    }

//    public void AddDepartment(Department dept)
//    {
//        Departments.Add(dept);
//    }

//    public void RemoveDepartment(Department dept)
//    {
//        Departments.Remove(dept);
//    }

//    public void ShowDepartments()
//    {
//        Console.WriteLine($"Departments in {Name}:");
//        foreach (Department dept in Departments)
//        {
//            Console.WriteLine($"Department: {dept.Name}");
//        }
//    }

//    public void DeleteUniversity()
//    {
//        Departments.Clear();
//    }
//}

//class Department
//{
//    public string Name { get; }
//    public List<Faculty> Faculties { get; } = new List<Faculty>();

//    public Department(string name)
//    {
//        Name = name;
//    }

//    public void AddFaculty(Faculty faculty)
//    {
//        Faculties.Add(faculty);
//    }

//    public void ShowFaculties()
//    {
//        Console.WriteLine($"Faculties in {Name} Department:");
//        foreach (Faculty faculty in Faculties)
//        {
//            Console.WriteLine($"Faculty: {faculty.Name}");
//        }
//    }
//}

//class Faculty
//{
//    public string Name { get; }

//    public Faculty(string name)
//    {
//        Name = name;
//    }

//    public void ShowFacultyDetails()
//    {
//        Console.WriteLine($"Faculty: {Name}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        University university = new University("Tech U");
//        Department csDept = new Department("CS");
//        Department eeDept = new Department("EE");

//        Faculty f1 = new Faculty("Dr. J");
//        Faculty f2 = new Faculty("Dr. E");

//        csDept.AddFaculty(f1);
//        eeDept.AddFaculty(f2);

//        university.AddDepartment(csDept);
//        university.AddDepartment(eeDept);

//        university.ShowDepartments();
//        csDept.ShowFaculties();
//        eeDept.ShowFaculties();

//        university.DeleteUniversity();
//        university.ShowDepartments();

//        f1.ShowFacultyDetails();
//        f2.ShowFacultyDetails();
//    }
//}

