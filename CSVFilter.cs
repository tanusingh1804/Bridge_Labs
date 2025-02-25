using System;
using System.IO;

class CSVFilter
{
   static void Main(string[] string)
   {
       string filePath = "students.csv"; 
       try
       {
           using (StreamReader sr = new StreamReader(filePath))
           {
               string line = sr.ReadLine(); 
               Console.WriteLine("Students with marks > 80:");

               while ((line = sr.ReadLine()) != null)
               {
                   string[] data = line.Split(','); 
                   int marks = int.Parse(data[3]);  

                   if (marks > 80)
                   {
                       Console.WriteLine("ID: " + data[0] + ", Name: " + data[1] + ", Age: " + data[2] + ", Marks: " + data[3]);
                   }
               }
           }
       }
       catch (Exception ex)
       {
           Console.WriteLine("Error: " + ex.Message);
       }
   }
}
