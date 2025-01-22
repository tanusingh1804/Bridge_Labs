using System;

class HandshakeCalculator
{
    static void Main()
    {
        Console.WriteLine("Enter the number of students:");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        Console.WriteLine("The maximum number of handshakes among " + numberOfStudents + " students is " + handshakes + ".");
    }
}
