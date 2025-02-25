using System;
using System.IO;
using System.Collections.Generic;

class Student
{
   public int Id { get; set; }
   public string Name { get; set; }
   public int Age { get; set; }
   public double Marks { get; set; }

   public Student(int id, string name, int age, double marks)
   {
       Id = id;
       Name = name;
       Age = age;
       Marks = marks;
   }

   public override string ToString()
   {
       return $"ID: {Id}, Name: {Name}, Age: {Age}, Marks: {Marks}";
   }
}

class CSVToObject
{
   static void Main(string[] args)
   {
       string filePath = "students.csv";
       List<Student> students = new List<Student>();

       try
       {
           using (StreamReader sr = new StreamReader(filePath))
           {
               string line = sr.ReadLine();

               while ((line = sr.ReadLine()) != null)
               {
                   string[] data = line.Split(',');
                   int id = int.Parse(data[0]);
                   string name = data[1];
                   int age = int.Parse(data[2]);
                   double marks = double.Parse(data[3]);

                   students.Add(new Student(id, name, age, marks));
               }
           }

           Console.WriteLine("Student Records:");
           foreach (var student in students)
           {
               Console.WriteLine(student);
           }
       }
       catch (Exception ex)
       {
           Console.WriteLine("Error: " + ex.Message);
       }
   }
}
