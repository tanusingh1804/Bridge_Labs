
using System;

class Handshake
{
    public static void Main()
    {
        // Prompt the user to enter the number of people
        Console.Write("Enter number of people: ");
        
        // Read user input and convert it to an integer
        int n = Convert.ToInt32(Console.ReadLine());
        
        // Call the method to calculate the number of handshakes and store the result in a variable
        int handshakes = calculateHandshakes(n);
        
        // Display the number of possible handshakes
        Console.WriteLine($"The number of possible handshakes are {handshakes}");
    }

    // Method to calculate the number of handshakes
    // It takes an integer n (number of people) as input and returns the total number of handshakes
    public static int calculateHandshakes(int n)
    {
        // Formula: (n * (n - 1)) / 2
        // This calculates the number of unique pairs of people
        return (n * (n - 1)) / 2;
    }
}

