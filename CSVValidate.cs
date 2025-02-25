using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class CSVValidate
{
   static void Main(string[] args)
   {
       string filePath = "employees.csv";
       List<string[]> invalidRows = new List<string[]>();

       string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
       string phonePattern = @"^\d{10}$";

       try
       {
           using (StreamReader sr = new StreamReader(filePath))
           {
               string header = sr.ReadLine();
               string line;

               while ((line = sr.ReadLine()) != null)
               {
                   string[] data = line.Split(',');
                   string email = data[3];
                   string phone = data[4];

                   bool isEmailValid = Regex.IsMatch(email, emailPattern);
                   bool isPhoneValid = Regex.IsMatch(phone, phonePattern);

                   if (!isEmailValid || !isPhoneValid)
                   {
                       invalidRows.Add(data);
                   }
               }
           }

           if (invalidRows.Count > 0)
           {
               Console.WriteLine("Invalid Rows Found:");
               foreach (var row in invalidRows)
               {
                   Console.WriteLine(string.Join(", ", row) + " -> Invalid Data");
               }
           }
           else
           {
               Console.WriteLine("All records are valid.");
           }
       }
       catch (Exception ex)
       {
           Console.WriteLine("Error: " + ex.Message);
       }
   }
}

