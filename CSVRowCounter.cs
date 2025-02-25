using System;
using System.IO;

class CSVRowCounter
{
   static void Main(string[] args)
   {
       string filePath = "employees.csv"; 

       try
       {
           int count = 0;
           using (StreamReader sr = new StreamReader(filePath))
           {
               string line = sr.ReadLine();  

               while ((line = sr.ReadLine()) != null)
               {
                   count++; 
               }
           }

           Console.WriteLine("Total Records (excluding header): " + count);
       }
       catch (Exception ex)
       {
           Console.WriteLine("Error: " + ex.Message);
       }
   }
}
