using System;

class Program
{
    static bool IsPalindrome(string str)
    {
        int left = 0, right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
                return false;
            left++;
            right--;
        }
        return true;
    }

    static void Main()
    {
        Console.WriteLine("Enter a word:");
        string word = Console.ReadLine();

        if (IsPalindrome(word))
            Console.WriteLine("It is a palindrome.");
        else
            Console.WriteLine("It is not a palindrome.");
    }
}

