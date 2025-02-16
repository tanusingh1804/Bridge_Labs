using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string filePath = "binaryfile.bin";
        
        if (File.Exists(filePath))
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            using (StreamReader reader = new StreamReader(fs, Encoding.UTF8))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
