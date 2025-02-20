using System;
using System.IO;

class FileHandling
{
   
   public static void CopyFile(string sourcePath, string destinationPath)
   {
       try
       {
            
           if (!File.Exists(sourcePath))
           {
               Console.WriteLine("Source file does not exist.");
               return;
           }

           using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
           {
               using (FileStream destStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write))
               {
                   byte[] buffer = new byte[1024];
                   int bytesRead;

                   while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                   {
                       destStream.Write(buffer, 0, bytesRead);
                   }

                   Console.WriteLine("File copied successfully!");
               }
           }
       }
       catch (IOException ex)
       {
           Console.WriteLine("An error occurred: " + ex.Message);
       }
   }

   public static void Main(string[] args)
   {
       Console.Write("Enter source file path: ");
       string sourcePath = Console.ReadLine();

       Console.Write("Enter destination file path: ");
       string destinationPath = Console.ReadLine();

       CopyFile(sourcePath, destinationPath);
   }
}
