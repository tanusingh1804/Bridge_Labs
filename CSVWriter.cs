using System;
using System.IO;

class CSVWriter
{
   static void Main(string[] args)
   {
       string filePath = "employees.csv"; 

       try
       {
           using (StreamWriter sw = new StreamWriter(filePath))
           {
            
               sw.WriteLine("101,John,HR,50000");
               sw.WriteLine("102,Alice,IT,60000");
               sw.WriteLine("103,Bob,Finance,55000");
               sw.WriteLine("104,Emma,Marketing,52000");
               sw.WriteLine("105,David,Sales,58000");
           }

           Console.WriteLine("CSV file successfully created with employee details!");
       }
       catch (Exception ex)
       {
           Console.WriteLine("Error: " + ex.Message);
       }
   }
}
