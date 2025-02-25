using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class CSVSort
{
   static void Main(string[] args)
   {
       string filePath = "employees.csv";
       List<string[]> employees = new List<string[]>();

       try
       {
           using (StreamReader sr = new StreamReader(filePath))
           {
               string header = sr.ReadLine();
               string line;

               while ((line = sr.ReadLine()) != null)
               {
                   employees.Add(line.Split(','));
               }
           }

           var sortedEmployees = employees.OrderByDescending(e => double.Parse(e[3])).ToList();

           Console.WriteLine("Top 5 Highest-Paid Employees:");
           Console.WriteLine("ID\tName\tDepartment\tSalary");

           for (int i = 0; i < Math.Min(5, sortedEmployees.Count); i++)
           {
               Console.WriteLine(sortedEmployees[i][0] + "\t" + sortedEmployees[i][1] + "\t" + sortedEmployees[i][2] + "\t" + sortedEmployees[i][3]);
           }
       }
       catch (Exception ex)
       {
           Console.WriteLine("Error: " + ex.Message);
       }
   }
}
