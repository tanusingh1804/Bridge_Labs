using System;
class ReverseString {
    static void Main(string[] args) {
        Console.WriteLine("Enter the string:");
        string s = Console.ReadLine();
        string s1 = "";

        for (int i = s.Length - 1; i >= 0; i--) {  // Fixing index range
            s1 += s[i];  // Appending characters correctly
        }

        Console.WriteLine("Reversed string is: " + s1);
    }
}
