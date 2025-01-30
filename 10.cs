using System;

class Specific
{
    static void Main()
    {
        Console.Write("Enter a string");
        string str = Console.ReadLine();
        Console.Write("enter the character to remove");
        char charToRemove = Console.ReadLine()[0];
        
        string result = "";
        
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != charToRemove)
                result += str[i];
        }
        
        Console.WriteLine("modified string" + result);
    }
}
