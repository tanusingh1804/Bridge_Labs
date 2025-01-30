using System;

class Replace
{
    static void Main()
    {
        Console.Write("enter a sentence ");
        string sentence = Console.ReadLine();
        Console.Write("enter the word to replace");
        string oldWord = Console.ReadLine();
        Console.Write("enter the replacement word");
        string newWord = Console.ReadLine();
        
        string result = "";
        string currentWord = "";
        
        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] != ' ')
            {
                currentWord += sentence[i];
            }
            else
            {
                if (currentWord == oldWord)
                    result += newWord;
                else
                    result += currentWord;
                result += ' ';
                currentWord = "";
            }
        }

        if (currentWord == oldWord)
            result += newWord;
        else
            result += currentWord;
        
        Console.WriteLine("modified sentence" + result);
    }
}
