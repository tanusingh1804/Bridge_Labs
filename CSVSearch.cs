using System;
using System.IO;

class CSVSearch
{
   static void Main(string[] args)
   {
       string filePath = "employees.csv"; 
       Console.Write("Enter employee name to search: ");
       string searchName = Console.ReadLine();

       bool found = false;

       try
       {
           using (StreamReader sr = new StreamReader(filePath))
           {
               string line = sr.ReadLine(); 
               while ((line = sr.ReadLine()) != null)
               {
                   string[] data = line.Split(','); 
                   string name = data[1]; 

                   if (name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                   {
                       Console.WriteLine("Employee Found!");
                       Console.WriteLine("Department: " + data[2]);
                       Console.WriteLine("Salary: " + data[3]);
                       found = true;
                       break;
                   }
               }
           }

           if (!found)
           {
               Console.WriteLine("Employee not found.");
           }
       }
       catch (Exception ex)
       {
           Console.WriteLine("Error: " + ex.Message);
       }
   }
}
