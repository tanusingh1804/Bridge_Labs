using System;

class BasicCalculator
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        double number2 = Convert.ToDouble(Console.ReadLine());

        double addition = number1 + number2;
        double subtraction = number1 - number2;
        double multiplication = number1 * number2;
        double division = number1 / number2;

        Console.WriteLine("The addition of " + number1 + " and " + number2 + " is " + addition);
        Console.WriteLine("The subtraction of " + number1 + " and " + number2 + " is " + subtraction);
        Console.WriteLine("The multiplication of " + number1 + " and " + number2 + " is " + multiplication);
        Console.WriteLine("The division of " + number1 + " and " + number2 + " is " + division);
    }
}
