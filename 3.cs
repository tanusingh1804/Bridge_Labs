using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        
        bool isPalindrome = true;
        int length = str.Length;
        
        for (int i = 0; i < length / 2; i++)
        {
            if (str[i] != str[length - i - 1])
            {
                isPalindrome = false;
                break;
            }
        }
        
        if (isPalindrome)
            Console.WriteLine("the string is a palindrome.");
        else
            Console.WriteLine("the string is not a palindrome.");
    }
}
