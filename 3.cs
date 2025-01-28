using System;

class Handshake
{
    public static void Main()
    {
        // Prompt the user to enter the number of people
        Console.Write("Enter number of people: ");
        
        // Read user input and convert it to an integer
        int n = Convert.ToInt32(Console.ReadLine());
        
        // Calculate the number of handshakes and store the result in a variable
        int handshakes = (n * (n - 1)) / 2;
        
        // Display the number of possible handshakes
        Console.WriteLine($"The number of possible handshakes are {handshakes}");
    }
}