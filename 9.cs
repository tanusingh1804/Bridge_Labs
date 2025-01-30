using System;

class Frequent
{
    static void Main()
    {
        Console.Write("Enter a string");
        string input = Console.ReadLine();
        
        char mostFrequentChar = input[0];
        int maxCount = 1;
        
        for (int i = 0; i < input.Length; i++)
        {
            int count = 1;
            for (int j = i + 1; j < input.Length; j++)
            {
                if (input[i] == input[j])
                    count++;
            }
            if (count > maxCount)
            {
                maxCount = count;
                mostFrequentChar = input[i];
            }
        }
        
        Console.WriteLine("most Frequent Character" + mostFrequentChar);
    }
}

