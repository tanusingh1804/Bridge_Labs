using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        double first = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double second = double.Parse(Console.ReadLine());
        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();

        double result = 0.0;

        switch (op)
        {
            case "+":
                result = first + second;
                break;
            case "-":
                result = first - second;
                break;
            case "*":
                result = first * second;
                break;
            case "/":
                if (second != 0)
                {
                    result = first / second;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Invalid Operator.");
                return;
        }

        Console.WriteLine("Result: " + result);

        Console.ReadLine(); 
    }
}