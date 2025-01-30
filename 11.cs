using System;

class Anagram
{
    static void Main()
    {
        Console.Write("Enter first string");
        string str1 = Console.ReadLine();
        Console.Write("Enter second string");
        string str2 = Console.ReadLine();
        
        if (str1.Length != str2.Length)
        {
            Console.WriteLine("strings are not anagram");
            return;
        }

        char[] str1Array = str1.ToCharArray();
        char[] str2Array = str2.ToCharArray();
        
        for (int i = 0; i < str1.Length; i++)
        {
            bool found = false;
            for (int j = 0; j < str2.Length; j++)
            {
                if (str1Array[i] == str2Array[j])
                {
                    str2Array[j] = '\0'; 
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine(" strings are not anagram");
                return;
            }
        }

        Console.WriteLine("the strings are anagrams");
    }
}
