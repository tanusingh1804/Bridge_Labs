using System;
using System.IO;
using Microsoft.Data.SqlClient; 
class CSVReportGenerator
{
   static void Main(string[] args)
   {
       string connectionString = "Server=your_server;Database=your_database;User Id=your_user;Password=your_password;";
       string query = "SELECT EmployeeID, Name, Department, Salary FROM Employees";
       string csvFilePath = "employee_report.csv";

       try
       {
           using (SqlConnection conn = new SqlConnection(connectionString))
           {
               conn.Open();
               using (SqlCommand cmd = new SqlCommand(query, conn))
               using (SqlDataReader reader = cmd.ExecuteReader())
               using (StreamWriter sw = new StreamWriter(csvFilePath))
               {
                   sw.WriteLine("Employee ID,Name,Department,Salary");

                   while (reader.Read())
                   {
                       sw.WriteLine($"{reader["EmployeeID"]},{reader["Name"]},{reader["Department"]},{reader["Salary"]}");
                   }
               }
           }

           Console.WriteLine("CSV Report Generated: employee_report.csv");
       }
       catch (Exception ex)
       {
           Console.WriteLine("Error: " + ex.Message);
       }
   }
}
