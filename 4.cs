using System;

class HandshakeCalculator
{
    public static int CalculateHandshakes(int numberOfStudents)
    {
        return (numberOfStudents * (numberOfStudents - 1)) / 2;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        int handshakes = CalculateHandshakes(numberOfStudents);

        Console.WriteLine("The maximum number of handshakes among " + numberOfStudents + " students is " + handshakes + ".");
    }
}


Create a program to find the maximum number of handshakes among N number of students.
Hint => 
Get integer input for numberOfStudents variable.
Use the combination = (n * (n - 1)) / 2 formula to calculate the maximum number of possible handshakes.
Display the number of possible handshakes.





An athlete runs in a triangular park with sides provided as input by the user in meters. If the athlete wa Convert.ToDouble(Console.ReadLine());

        int rounds = CalculateRounds(side1, side2, side3);

        Console.WriteLine("The athlete needs to complete " + rounds + " rounds to run 5 km.");
    }
}