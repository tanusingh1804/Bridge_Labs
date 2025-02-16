using System;

class Program
{
    static void Main()
    {
        string[] sentences = { "Hello world", "Programming in C#", "Welcome to coding" };
        string wordToFind = "C#";

        foreach (string sentence in sentences)
        {
            if (sentence.Contains(wordToFind))
            {
                Console.WriteLine("Found in: " + sentence);
                return;
            }
        }

        Console.WriteLine("Word not found.");
    }
}
