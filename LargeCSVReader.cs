using System;
using System.IO;

class LargeCSVReader
{
   static void Main(string[] args)
   {
       string filePath = "large_data.csv";
       int batchSize = 100;  
       int totalRecords = 0;

       try
       {
           using (StreamReader sr = new StreamReader(filePath))
           {
               string header = sr.ReadLine(); 
               string line;
               int batchCount = 0;

               while ((line = sr.ReadLine()) != null)
               {
                   batchCount++;
                   totalRecords++;

                   if (batchCount == batchSize)
                   {
                       Console.WriteLine($"Processed {totalRecords} records...");
                       batchCount = 0; 
                   }
               }
           }

           Console.WriteLine($"Total Records Processed: {totalRecords}");
       }
       catch (Exception ex)
       {
           Console.WriteLine("Error: " + ex.Message);
       }
   }
}
