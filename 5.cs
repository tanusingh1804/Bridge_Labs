using System;

class Longest
{
    static void Main()
    {
        Console.Write("Enter a sentence");
        string sentence = Console.ReadLine();
        string longestWord = "";
        string currentWord = "";
        
        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] != ' ')
            {
                currentWord += sentence[i];
            }
            else
            {
                if (currentWord.Length > longestWord.Length)
                    longestWord = currentWord;
                currentWord = "";
            }
        }
        
        if (currentWord.Length > longestWord.Length)
            longestWord = currentWord;
        
        Console.WriteLine("the longest word is" + longestWord);
    }
}

