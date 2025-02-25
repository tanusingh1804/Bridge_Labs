using System;
using System.IO;

class CSVReader
{
   static void Main(string[] args)
   {
       string filePath = "students.csv"; 
       try
       {
           using (StreamReader sr = new StreamReader(filePath))
           {
               string line;
               while ((line = sr.ReadLine()) != null)
               {
                   string[] data = line.Split(','); 

                 
                   Console.WriteLine("ID: " + data[0] + ", Name: " + data[1] + ", Age: " + data[2] + ", Marks: " + data[3]);
               }
           }
       }
       catch (Exception ex)
       {
           Console.WriteLine("Error: " + ex.Message);
       }
   }
}

