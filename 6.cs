using System;

class Substring
{
    static void Main()
    {
        Console.Write("Enter the main string ");
        string mainString = Console.ReadLine();
        Console.Write("enter the substring to count: ");
        string substring = Console.ReadLine();
        
        int count = 0;
        for (int i = 0; i <= mainString.Length - substring.Length; i++)
        {
            bool isMatch = true;
            for (int j = 0; j < substring.Length; j++)
            {
                if (mainString[i + j] != substring[j])
                {
                    isMatch = false;
                    break;
                }
            }
            if (isMatch)
                count++;
        }
        
        Console.WriteLine("the substring occurs " + count + " times.");
    }
}
