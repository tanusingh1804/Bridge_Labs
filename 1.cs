using System;
class Vowels{
    static void Main(string[] args){
        Console.WriteLine("Enter the string:");
        string s = Console.ReadLine();
        int vowels = 0, consonants = 0;

        foreach(char ch in s){
            if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z')) { 
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                    {
                    vowels++;
                } else {
                    consonants++;
                }
            }
        }

        Console.WriteLine("Vowels: " + vowels);
        Console.WriteLine("Consonants: " + consonants);
    }
}


