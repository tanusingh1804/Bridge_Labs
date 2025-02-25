using System;
using System.IO;
using System.Collections.Generic;

class CSVDuplicateDetector
{
   static void Main()
   {
       string filePath = "students.csv";
       HashSet<int> uniqueIds = new HashSet<int>();
       List<string> duplicates = new List<string>();

       try
       {
           using (StreamReader sr = new StreamReader(filePath))
           {
               string header = sr.ReadLine();
               string line;

               while ((line = sr.ReadLine()) != null)
               {
                   string[] data = line.Split(',');
                   int id = int.Parse(data[0]);

                   if (!uniqueIds.Add(id))
                   {
                       duplicates.Add(line);
                   }
               }
           }

           if (duplicates.Count > 0)
           {
               Console.WriteLine("Duplicate Records Found:");
               foreach (var record in duplicates)
               {
                   Console.WriteLine(record);
               }
           }
           else
           {
               Console.WriteLine("No duplicate records found.
}
       }
       }
}