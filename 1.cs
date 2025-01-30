using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Think of a number between 1 and 100. I will try to guess it.");
        int low = 1, high = 100, guess;
        
        while (true)
        {
            guess = (low + high) / 2;
            Console.WriteLine("Is your number " + guess + "? (Type: HIGH, LOW, or CORRECT)");
            
            string response = Console.ReadLine();
            string userResponse = "";
            
            // Converting input to uppercase manually
            for (int i = 0; i < response.Length; i++)
            {
                char c = response[i];
                if (c >= 'a' && c <= 'z')
                {
                    userResponse += (char)(c - 32);
                }
                else
                {
                    userResponse += c;
                }
            }

            if (userResponse == "CORRECT")
            {
                Console.WriteLine("Yay! I guessed it.");
                break;
            }
            else if (userResponse == "HIGH")
            {
                high = guess - 1;
            }
            else if (userResponse == "LOW")
            {
                low = guess + 1;
            }
            else
            {
                Console.WriteLine("Invalid response. Please type HIGH, LOW, or CORRECT.");
            }
        }
    }
}
