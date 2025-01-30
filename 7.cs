using System;

class Toggle
{
    static void Main()
    {
        Console.Write("Enter a string");
        string str = Console.ReadLine();
        string result = "";
        
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] >= 'A' && str[i] <= 'Z')
                result += (char)(str[i] + 32); 
            else if (str[i] >= 'a' && str[i] <= 'z')
                result += (char)(str[i] - 32);             else
                result += str[i];  
        }
        
        Console.WriteLine("toggled case string " + result);
    }
}
