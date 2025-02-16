using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter text to save:");
        string input = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter("output.txt"))
        {
            writer.WriteLine(input);
        }

        Console.WriteLine("Text saved to file.");
    }
}
