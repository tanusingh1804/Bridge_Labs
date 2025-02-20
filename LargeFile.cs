using System;
using System.IO;

class LargeFile
{
   public static void ReadErrorLines(string filePath)
   {
       try
       {
           using (StreamReader reader = new StreamReader(filePath))
           {
               string line;
               while ((line = reader.ReadLine()) != null)
               {
                   if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
                   {
                       Console.WriteLine(line);
                   }
               }
           }
       }
       catch (IOException ex)
       {
           Console.WriteLine("File read error: " + ex.Message);
       }
   }

   public static void Main(string[] args)
   {
       Console.Write("Enter the file path: ");
       string filePath = Console.ReadLine();

       if (File.Exists(filePath))
       {
           ReadErrorLines(filePath);
       }
       else
       {
           Console.WriteLine("File does not exist.");
       }
   }
}
