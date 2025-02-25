using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class JsonCsvConverter
{
   static void Main(string[] args)
   {
       string jsonFilePath = "students.json";
       string csvFilePath = "students.csv";
       string outputJsonPath = "students_output.json";

        
       ConvertJsonToCsv(jsonFilePath, csvFilePath);
       Console.WriteLine(" JSON converted to CSV: students.csv");

       ConvertCsvToJson(csvFilePath, outputJsonPath);
       Console.WriteLine(" CSV converted back to JSON: students_output.json");
   }

   static void ConvertJsonToCsv(string jsonFilePath, string csvFilePath)
   {
       string jsonData = File.ReadAllText(jsonFilePath);
       var students = JsonConvert.DeserializeObject<List<Student>>(jsonData);

       using (StreamWriter sw = new StreamWriter(csvFilePath))
       {
           sw.WriteLine("ID,Name,Age,Marks");
           foreach (var student in students)
           {
               sw.WriteLine($"{student.ID},{student.Name},{student.Age},{student.Marks}");
           }
       }
   }

   static void ConvertCsvToJson(string csvFilePath, string jsonFilePath)
   {
       var students = new List<Student>();
       string[] lines = File.ReadAllLines(csvFilePath);

       for (int i = 1; i < lines.Length; i++) 
       {
           string[] data = lines[i].Split(',');
           students.Add(new Student
           {
               ID = int.Parse(data[0]),
               Name = data[1],
               Age = int.Parse(data[2]),
               Marks = int.Parse(data[3])
           });
       }

       string jsonOutput = JsonConvert.SerializeObject(students, Formatting.Indented);
       File.WriteAllText(jsonFilePath, jsonOutput);
   }
}

class Student
{
   public int ID { get; set; }
   public string Name { get; set; }
   public int Age { get; set; }
   public int Marks { get; set; }
}
